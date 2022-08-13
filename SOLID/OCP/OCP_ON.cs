using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class OCP_ON
    {
        /*
         * Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification.
         */
        public interface IInvoice
        {
            public int InvoiceId { get; set; }
            public void SetInvoice();
        }
        public class Invoice
        {
            private IInvoice invoice;
            public Invoice(IInvoice invoice)
            {
                this.invoice = invoice;
            }

            public void SetInvoice()
            {
                this.invoice.SetInvoice();
            }
        }
        public class PersonalInvoice : IInvoice
        {
            public int InvoiceId { get; set; }

            public void SetInvoice()
            {
                Console.WriteLine("Personal Invoice");
            }
        }
        public class CompanyInvoice : IInvoice
        {
            public int InvoiceId { get; set; }
            public void SetInvoice()
            {
                Console.WriteLine("Company Invoice");
            }
        }
        public class FoundationInvoice : IInvoice
        {
            public int InvoiceId { get; set; }
            public void SetInvoice()
            {
                Console.WriteLine("Fondation Invoice");
            }
        }
    }
}
