using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character { Name = "Sam" }
        };

        // send CODE: 200, Character: knight.json
        // badrequest and notfound are also options
        [HttpGet]
        public ActionResult<Character> Get() {
            return Ok(characters);
        }
    }
}