using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_One_To_One.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Capital Capital { get; set; }
        public int CapitalId { get; set; }
    }
}
