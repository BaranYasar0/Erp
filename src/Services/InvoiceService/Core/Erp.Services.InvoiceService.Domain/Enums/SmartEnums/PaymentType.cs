using Ardalis.SmartEnum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.Services.InvoiceService.Domain.Enums.SmartEnums
{
    public class PaymentType : SmartEnum<PaymentType>
    {
        public static readonly PaymentType Transfer = new PaymentType("Transfer", 1);
        public static readonly PaymentType Eft = new PaymentType("Eft", 2);
        public static readonly PaymentType Cash = new PaymentType("Cash", 3);
        public static readonly PaymentType CreditCart = new PaymentType("CreditCart", 4);
        public static readonly PaymentType BankCart = new PaymentType(nameof(BankCart), 5);
        public static readonly PaymentType Mobile = new PaymentType(nameof(Mobile), 6);


        public PaymentType(string name, int value) : base(name, value)
        {
        }
    }
}
