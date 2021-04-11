using System;
using System.Collections.Generic;
using BookAPI.JWT;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class NameController : ControllerBase
    {
        private readonly IJwtAuthenticationManager jwtAuthenticationManager;
        public NameController(IJwtAuthenticationManager jwtAuthenticationManager)
        {
            this.jwtAuthenticationManager = jwtAuthenticationManager;
        }


        // GET: api/Name
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Name/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }


        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] UserCred userCred)
        {
            var token = jwtAuthenticationManager.Authenticate(userCred.Username, userCred.Password);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }
    }
}

