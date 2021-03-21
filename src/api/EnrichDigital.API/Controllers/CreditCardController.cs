using EnrichDigital.API.Constants;
using EnrichDigital.API.Models;
using EnrichDigital.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnrichDigital.API.Controllers
{
    [System.Web.Http.Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CreditCardController : ControllerBase
    {
        private readonly ILogger<CreditCardController> _logger;

        private readonly ICreditCardService _creditCardService;
        public CreditCardController(ILogger<CreditCardController> logger, ICreditCardService creditCardService)
        {
            _logger = logger;
            _creditCardService = creditCardService;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { CardType.MoneyBack, CardType.Platinum, CardType.Titanium };
        }

        [HttpGet("GetDetailByType")]
        public CreditCard GetCardDetailsByType(string cardType)
        {
            return _creditCardService.GetCreditCardDetails(cardType);
        }

    }
}
