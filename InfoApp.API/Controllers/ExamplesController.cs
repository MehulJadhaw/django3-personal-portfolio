using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfoApp.API.Data;
using InfoApp.API.Dtos;
using InfoApp.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace InfoApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamplesController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IAuthRepository _repo;
        public ExamplesController(DataContext context,IAuthRepository repo)
        {
            _context = context;
            _repo = repo; 


        }

        
      
        
        [HttpGet]
        public IActionResult GetExamples()
        {
            var examples = _context.Examples.ToList();

            return Ok(examples);
        }
        [HttpPost("shipment")]
      
        public async Task<IActionResult> ShipmentDetails([FromBody]UserforRegister userforRegister) 
        {
            var userToCreate = new Shipment
            {
                Shipment_type =   userforRegister.Shipment_type,
                Locality = userforRegister.Locality,
                Delivery_option = userforRegister.Delivery_option,
                Building_no = userforRegister.Building_no,
                Pickup_address = userforRegister.Pickup_address,
                L = userforRegister.L,
                B = userforRegister.B,
                H = userforRegister.H
               
               

            };
            var createdUser = await  _repo.ShipmentDetails(userToCreate);
           // userToCreate.SaveChanges()
           return StatusCode(200);

        }
    }
}
