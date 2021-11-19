using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coinverter.Client;
using Microsoft.AspNetCore.Mvc;
using Coinverter.BO;

namespace Coinverter.Controller
{
    [Route("api")]
    [ApiController]
    public class CurencyController : ControllerBase
    {

        private readonly CurrencyBo _currencyBo;

        public CurencyController(CurrencyBo currencyBo)
        {
            _currencyBo = currencyBo;
        }

        [HttpGet]
        [Route("currency/{from}/{to}")]
        public async Task<IActionResult> GetCurrency(string from, string to)
        {
            try
            {
                return Ok(await _currencyBo.GetCurrencyAsync(from, to));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
