using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SchoolExampleAPI.Model;
using SchoolExampleAPI.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolExampleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SchoolExampleController : ControllerBase
    {
        BaseController bc;
        public SchoolDbContext _context { get; set; }
        private readonly ILogger<SchoolExampleController> _logger;

        public SchoolExampleController(SchoolDbContext context, ILogger<SchoolExampleController> logger)
        {
            _logger = logger;
            _context = context;
        }

        [HttpPost("[action]")]
        public ResponseObject SaveUser(RequestObject request)
        {
            ResponseObject dataResponse;
            bc = new BaseController();
            var student = JsonConvert.DeserializeObject<User>(request.ObjectRequest);

            try
            {
                _context.Users.Add(student);
                _context.SaveChanges();
                dataResponse = bc.FormatResponse(student.Id);
            }
            catch (Exception ex)
            {
                dataResponse = bc.FormatException(ex);
            }
            return dataResponse;
        }

        [HttpPost("[action]")]
        public ResponseObject GetUsers()
        {
            ResponseObject dataResponse;
            bc = new BaseController();

            try
            {
                var users = _context.Users.Include(r => r.IdRolNavigation).ToList();
                var usersResult = new List<UserDto>();
                foreach (var user in users)
                {
                    usersResult.Add(new UserDto
                    {
                        Id = user.Id,
                        Name = user.Name,
                        LastName = user.LastName,
                        IdRol = user.IdRol,
                        RolName = user.IdRolNavigation.Name
                    });
                }
                dataResponse = bc.FormatResponse(usersResult);
            }
            catch (Exception ex)
            {
                dataResponse = bc.FormatException(ex);
            }
            return dataResponse;
        }

        [HttpPost("[action]")]
        public ResponseObject GetRols()
        {
            ResponseObject dataResponse;
            bc = new BaseController();

            try
            {
                var rols = _context.Rols.ToList();
                dataResponse = bc.FormatResponse(rols);
            }
            catch (Exception ex)
            {
                dataResponse = bc.FormatException(ex);
            }
            return dataResponse;
        }
    }
}