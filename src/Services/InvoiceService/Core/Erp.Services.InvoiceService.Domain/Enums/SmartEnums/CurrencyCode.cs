using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.Services.InvoiceService.Domain.Enums.SmartEnums
{
    public class CurrencyCode : SmartEnum<CurrencyCode>
    {

        public static readonly CurrencyCode Try = new CurrencyCode("TRY", 1);
        public static readonly CurrencyCode Usd = new CurrencyCode("USD", 2);
        public static readonly CurrencyCode Eur = new CurrencyCode("EUR", 3);
        public static readonly CurrencyCode Xau = new CurrencyCode("XAU", 4);

        public CurrencyCode(string name, int value) : base(name, value)
        {
        }
    }
}
