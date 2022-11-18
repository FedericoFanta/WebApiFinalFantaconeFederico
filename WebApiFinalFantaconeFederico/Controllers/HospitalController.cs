using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using WebApiFinalFantaconeFederico.Data;
using WebApiFinalFantaconeFederico.Models;

namespace WebApiFinalFantaconeFederico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        public HospitalContext Context { get; set; }    //Generar propiedad con nuestra clase de DATA

        public HospitalController(HospitalContext context)   //Generar constructor Con nuesta clase de DATA
        {
            this.Context = context;
        }



        [HttpGet]
        public List<Hospital> Get()
        {
            //EF
            List<Hospital> hospitales = Context.hospitales.ToList(); 

            return hospitales; // retornamos la lista 
        }


        [HttpGet("{Num_Cama}")]
        public IEnumerable<Hospital> Get(int num_cama)
        {

           
            


                var hospital = (from h in Context.hospitales
                                where h.Num_Cama > num_cama
                                select h).ToList();

                return (IEnumerable<Hospital>)hospital;
            

            
        }



    }
}
