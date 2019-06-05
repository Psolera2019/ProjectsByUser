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
    public class UserController : ControllerBase
    {
        private readonly UserProjectContext _context;

        public UserController(UserProjectContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public IEnumerable<Users> GetUsers()
        {
            return _context.Users;
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsers([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userFound = await _context.Users
              .FirstOrDefaultAsync(i => i.Id == id);

            if (userFound == null)
            {
                return NotFound();
            }

            return Ok(userFound);
        }
    }
}