using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using OrderSummary.Data;
using OrderSummary.Models;

namespace OrderSummary.Controllers
{
    [ApiController]
    [Microsoft.AspNetCore.Components.Route("[controller]")]
    public class InfoOrderController :ControllerBase
    {
        private IInfoService InfoService;

        public InfoOrderController(IInfoService infoService)
        {
            this.InfoService = infoService;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Summary>>> GetSummary()
        {
            try
            {
                IList<Summary> summary = await InfoService.GetSummaryAsync(true);
                return Ok(summary);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(200, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<InfoOrder>> AddInfoOrder([FromBody]InfoOrder infoOrder)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Task added = InfoService.AddInfoOrderAsync(infoOrder);
                return Created($"/{added.Id}", added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(200, e.Message);
            }
        }

        

        [HttpGet]
        public async Task<ActionResult<IList<Summary>>>

            GetSummary([FromQuery] int? quantity, [FromQuery] bool? isCompleted)
        {
            try
            {
                IList<Summary> getQuantity = await InfoService.GetSummaryAsync(isCompleted);
                return Accepted();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(200, e.Message);
            }
            
        }

       
    
        
        }
    
}