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
    public class DistanceController : ControllerBase
    {
        Functions f = new Functions();
        LogContext db;

        [ActivatorUtilitiesConstructor]
        public DistanceController()
        {
            db = new LogContext(Config.dockerConnectionString);
        }

        public DistanceController(LogContext MockDB)
        {
            db = MockDB;
        }

        [HttpGet]
        public IActionResult Get()
        {

            List<DistanceLog> response = new List<DistanceLog>();
            foreach (DistanceLog log in db.DistanceLogs)
            {
                response.Add(log);
            }
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Post([FromBody] DistanceModel input)
        {
            double response = f.Distance(input.x1, input.y1, input.x2, input.y2,db);
            return Ok(response);
        }
    }
}
