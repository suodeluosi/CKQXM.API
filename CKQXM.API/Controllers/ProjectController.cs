using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CKQXM.API.DAL;
namespace CKQXM.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private LDAL _LDAL;
        public ProjectController(LDAL LDAL)
        {
            _LDAL = LDAL;
        }
        [HttpGet]
        [Route("api/Login")]

        public int Login(string name, string pwd)
        {
            return _LDAL.Login(name, pwd);
        }
    }
}
