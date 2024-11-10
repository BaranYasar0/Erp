using Erp.Services.InvoiceService.Domain.Enums.SmartEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.Services.InvoiceService.Domain.Entities
{
    internal partial class Invoice:BaseEntity<Guid>
    {
        public int? BranchCode { get; set; }
        public long CitizenshipNumber { get; set; }
        public int CustomerId { get; set; }
        public Guid EInvoiceId { get; set; }
        public string Explanation { get; set; }
        public decimal StoppageRate { get; set; }
        public decimal StoppageAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal KdvAmount { get; set; }

        #region SmartEnums

        public CurrencyCode CurrencyCode { get; set; }
        public PaymentType PaymentType { get; set; }

        #endregion

        #region Relations
        public List<Document> Documents { get; set; }

        #endregion

    }
}
