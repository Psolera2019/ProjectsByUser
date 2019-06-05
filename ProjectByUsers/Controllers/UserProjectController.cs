using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectByUsers.Data;
using ProjectByUsers.Models;
using Microsoft.AspNetCore.Cors;

namespace ProjectByUsers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("UserProjectPolicy")]
    public class UserProjectController : ControllerBase
    {
        private readonly UserProjectContext _context;

        public UserProjectController(UserProjectContext context)
        {
            _context = context;
        }

        // GET: api/UserProject/5
        [HttpGet("{id}")]
        public IEnumerable<UserByProject> GetProjectsByUser([FromRoute] int id)
        {

            var users_context = _context.Users;
            var project_context = _context.Project;
            var userproject_context = _context.UserProject;

            var ProjectsByUser = from usrproj in userproject_context
                            join usr in users_context on usrproj.UserId equals usr.Id
                            join proj in project_context on usrproj.ProjectId equals proj.Id
                            where usrproj.UserId == id
                select new { 
                        UserId = usrproj.UserId, 
                        FirstName = usr.FirstName,
                        LastName = usr.LastName,
                        ProjectId = usrproj.ProjectId,
                        StartDate = proj.StartDate,
                        EndDate = proj.EndDate,
                        AssignedDate = usrproj.AssignedDate,
                        IsActive = usrproj.IsActive
                         };

            var userbyprojectLList = new List<UserByProject>{};
            
            foreach (var obj in ProjectsByUser)
            {

                string days = "Started";

                if (obj.StartDate >= obj.AssignedDate) {
                    TimeSpan difference = obj.StartDate.Subtract(obj.AssignedDate);
                    days = difference.TotalDays.ToString();
                }
                

                userbyprojectLList.Add( new UserByProject { 
                    ProjectId = obj.ProjectId,
                    AssignedDate = obj.AssignedDate,
                    StartDate = obj.StartDate,
                    TimeToStart = days,
                    EndDate = obj.EndDate,
                    IsActive = (obj.IsActive)?"Active":"InActive"
                } );
            }
            
            return userbyprojectLList;

        }
    }
}