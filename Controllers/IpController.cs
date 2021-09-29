using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPam.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IpController : ControllerBase
    {
        static List<string> ips = new List<string>()
        {    
        };


        [Route("add")]
        [HttpPost]
        public IActionResult AdicionarIP([FromBody] string ip)
        {
            ips.Add(ip);

            return Ok();
        }

        [Route("list")]
        [HttpGet]
        public IEnumerable<string> ListarIPs()
        {
            return ips;
        }


    }
}
