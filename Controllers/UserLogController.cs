using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using aspnetcoreapp.Helpers;
using aspnetcoreapp.Models;
using aspnetcoreapp.Service;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace aspnetcoreapp.Controllers
{
    [Route("api")]
    [ApiController]
    public class UserLogController : CustomController
    {
        public UserLogController(ILogger<UserLogController> logger, ApplicationDbContext dbContext, IMapper mapper,
            IConfiguration configuration)
            : base(logger, dbContext, mapper, configuration)
        {
        }

       

        [HttpGet("user")]
        public async Task<ActionResult> GetUser([FromQuery] MinMaxDate form)
        {
            if (_authService.IsAuthenticate(UserLog.GroupId))
            {
                var list = await _dbContext.Set<UserLog>()
                    .Where(entity =>
                        entity.Timestamp <= form.MaxDate && entity.Timestamp >= form.MinDate &&
                        entity.Type != ApiType.ActivityLog)
                    .AsNoTracking()
                    .ToListAsync();
                var result = list.Select(entityLog => new UserLogResponse()
                    {
                        TargetId = entityLog.EntityId,
                        UserId = entityLog.UserId,
                        Metadata = entityLog.Metadata,
                        Description = entityLog.Description,
                        Type = entityLog.Type.GetDescription(),
                        Timestamp = entityLog.Timestamp.ToShortTimeString() + " " + entityLog.Timestamp.ToShortDateString(),
                    })
                    .ToList();
                return Ok(result);
            }
            else
            {
                return Unauthorized();
            }
        }


        [HttpPost("user/delete")]
        [HttpPost("user/edit")]
        [HttpPost("user/activity")]
        [HttpPost("user/add")]
        public async Task<ActionResult> PostUser([FromBody] UserLogRequest form)
        {
            if (!_authService.IsAuthenticate(UserLog.GroupId))
            {
                return Unauthorized();
            }

            var apiType = Utility.GetTypeFromUrl(Request.Path.Value);
            if (Request.Path.Value.Contains("user-role"))
            {
                apiType = ApiType.Role;
            }

            if (apiType == ApiType.Empty)
            {
                return NotFound();
            }
            else
            {
                var userLog = new UserLog()
                {
                    EntityId = form.target_id,
                    Metadata = form.meta_data,
                    UserId = form.user_id,
                    ProjectType = form.project_type,
                    Description = form.description,
                    Timestamp = DateTime.Now
                };
                return await Post<UserLog>(userLog, apiType);
            }
        }

    }
}