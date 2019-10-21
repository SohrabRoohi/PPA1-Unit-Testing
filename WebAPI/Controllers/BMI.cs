using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using Microsoft.Extensions.DependencyInjection;
=======
>>>>>>> d64fa71a04e68f34f8e417d7c71963941734956f
using Model;
using PPA1;
using WebAPI.Model;

namespace WebAPI.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class BMIController : ControllerBase
    {
        Functions f = new Functions();
        LogContext db;

<<<<<<< HEAD
        [ActivatorUtilitiesConstructor]
=======
>>>>>>> d64fa71a04e68f34f8e417d7c71963941734956f
        public BMIController()
        {
            db = new LogContext(Config.dockerConnectionString);
        }

        public BMIController(LogContext MockDB)
        {
            db = MockDB;
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<BMILog> response = new List<BMILog>();
            foreach(BMILog log in db.BMILogs)
            {
                response.Add(log);
            }
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Post([FromBody] BMIModel input)
        {
            string response = f.BMI(input.heightInFeet, input.heightInInches, input.weight, db);
            if (response.Equals("Impossible")) return BadRequest(response);
            return Ok(response);
        }
    }
}
