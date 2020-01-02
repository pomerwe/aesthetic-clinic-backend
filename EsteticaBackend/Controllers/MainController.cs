using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EsteticaBackend.Db;
using EsteticaBackend.Models;
using EsteticaBackend.Services;

namespace EsteticaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly MainService mainService;

        public MainController(MainService mainService)
        {
            this.mainService = mainService;
        }

        [HttpGet("Clientes")]
        public ActionResult<List<Cliente>> GetClientes()
        {
            try
            {
                return Ok(mainService.GetClientes());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        } 

        [HttpPost("SalvarCliente")]
        public ActionResult<Cliente> SaveCliente([FromBody]Cliente cliente)
        {
            try
            {
                var c = mainService.SaveCliente(cliente);
                return Ok(c);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
