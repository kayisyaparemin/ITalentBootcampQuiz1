using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    internal class LSP_OFF
    {
        public abstract class UserMaster
        {
            public int FullName { get; set; }

            public string Email { get; set; }

            public string Password { get; set; }

            public virtual void AccesToLimitedTitles()
            {
                Console.WriteLine("Acces to limited titles");
            }

            public virtual void AccesToUnlimitedTitles()
            {
                Console.WriteLine("Acces to unlimited titles");
            }

            public virtual void GiveAccesToFamilyMembers()
            {
                Console.WriteLine("Acces granted to family members");
            }
        }
 
        public class StandartAccount : UserMaster
        {
            public override void AccesToLimitedTitles()
            {
                base.AccesToLimitedTitles();
            }
        }

        public class PremiumAccount : UserMaster
        {
            public override void AccesToLimitedTitles()
            {
                base.AccesToLimitedTitles();
            }

            public override void AccesToUnlimitedTitles()
            {
                base.AccesToUnlimitedTitles();
            }

            public override void GiveAccesToFamilyMembers()
            {
                base.GiveAccesToFamilyMembers();
            }
        }
    }
}
