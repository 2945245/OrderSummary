using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrderSummary.Data;
using OrderSummary.Models;

namespace OrderSummary.Controllers
{
    public class SummaryController
    {
        [ApiController]
        [Route("[controller]")]
        public class SummaryController : ControllerBase
        {
            private ISummaryService summaryService;

            public SummaryController(ISummaryService summaryService)
            {
                this.summaryService = summaryService;
            }

            [HttpGet]
            public async Task<ActionResult<IList<Summary>>>
                GetTodos([FromQuery] string? items, [FromQuery] bool? isCompleted)
            {
                try
                {
                    IList<Summary> orderInfo = await summaryService.GetSummaryAsync();
                    if (items != null)
                    {
                        orderInfo = orderInfo.Where(summary => summary.Items == items).ToList();
                    }

                    if (isCompleted != null)
                    {
                        orderInfo = orderInfo.Where(orderInfo => orderInfo.IsCompleted == isCompleted).ToList();
                    }

                    return Ok(orderInfo);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return StatusCode(500, e.Message);
                }
            }
        }

    }