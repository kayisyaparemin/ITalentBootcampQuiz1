using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    internal class LSP_ON
    {
     
        public interface IStandartAccess
        {
            public void AccesToLimitedTitles();
        }
        public interface IPremiumContentAccess
        {
            public void AccesToUnlimitedTitles();
            public void GiveAccesToFamilyMembers();
        }
        public abstract class UserMaster
        {
            public int FullName { get; set; }

            public string Email { get; set; }

            public string Password { get; set; }

        }

        public class StandartAccount : UserMaster,IStandartAccess
        {
    
            public  void AccesToLimitedTitles()
            {
                Console.WriteLine("Acces to limited titles");
            }
        }

        public class PremiumAccount : UserMaster,IStandartAccess,IPremiumContentAccess
        {
            public void AccesToLimitedTitles()
            {
                Console.WriteLine("Acces to limited titles");
            }
            public void GiveAccesToFamilyMembers()
            {
                Console.WriteLine("Standart Content Access permitted");
            }
            public  void AccesToUnlimitedTitles()
            {
                Console.WriteLine("Acces to unlimited titles");
            }
        }
    }
}

