using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OG_ANGULAR_BUSINESS;
using OG_ANGULAR_ENTITIES;

namespace OG_ANGULAR_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[EnableCors("AllowOrigin")]
    public class PersonaController : ControllerBase
    {
        private BPersona _bus = new BPersona();
       
        // GET: api/Persona
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_bus.GetPersonas());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
            
        }

        // GET: api/Persona/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_bus.GetPersona(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
            
        }

        // POST: api/Persona
        [HttpPost]
        public IActionResult Post([FromBody] EPersona p)
        {
            try
            {
                return Ok(_bus.Ingresar(p));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // PUT: api/Persona/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EPersona p)
        {
            try
            {
                return Ok(_bus.Modificar(p));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(_bus.Elminar(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
        
    }
}
