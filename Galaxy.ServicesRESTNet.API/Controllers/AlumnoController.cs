using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Galaxy.ServicesRESTNet.EF.Context;
using Galaxy.ServicesRESTNet.EF.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Galaxy.ServicesRESTNet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnoController : ControllerBase
    {
        TrainingexamenContext _TrainingexamenContext;
        public AlumnoController(TrainingexamenContext trainingexamenContext)
        {
            _TrainingexamenContext = trainingexamenContext;
        }

        public ActionResult<List<Alumno>> GetAlumnos() {
            return _TrainingexamenContext.Alumnos.ToList();
        }

    }
}