using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    internal class OCP_OFF
    {
        public enum OrderType
        {
            Personal,
            Company,
            Foundation,
            Example
        }
      public class Invoice
        {
            public int InvoiceId { get; set; }

            public OrderType OrderType { get; set; }

            public void SetInvoice()
            {
                switch (OrderType)
                {
                    case OrderType.Personal:
                        Console.WriteLine("Personal Invoice");
                        break;
                    case OrderType.Company:
                        Console.WriteLine("Company Invoice");
                        break;
                    case OrderType.Foundation:
                        Console.WriteLine("Fondation Invoice");
                        break;
                    case OrderType.Example:
                        Console.WriteLine("Example Invoice");
                        break;
                }

            }
        }
    }
}
