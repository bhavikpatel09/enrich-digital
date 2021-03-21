using EnrichDigital.API.Constants;
using EnrichDigital.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnrichDigital.API.Services
{
    public interface ICreditCardService
    {
        CreditCard GetCreditCardDetails(string cardType);
    }
}
