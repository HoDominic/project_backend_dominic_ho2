using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{

    [ApiController]
    [Route("api")]
    public class NameController : ControllerBase
    {



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
    }
}

