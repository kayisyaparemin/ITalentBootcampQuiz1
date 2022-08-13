using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Many_To_Many.Models
{
    public class Game
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
