using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAI
{
    internal class Encapsulation
    {
        //Access modifier
        //Encapsulation sınıfların özelliklerine erişimi getter setter metotlarıyla kısıtlayarak istenmeyen müdehaleleri önlemek için kullanılan bir yöntemdir.
         
        public string Name { get; } = "Encapsulation"; //Değeri sınıf içinden atanan property sadece okunabilirdir.

        public int Parameter { get; } //bir başka şekilde değeri değiştirilemeyen property tanımlama yöntemi.

        public int Discount { get; init; } //sadece bir kere değer atanabilen sonradan değiştirilemeyen tanımlama.

        private string _identityNumber;

        public string IdentityNumber //get-set metotları ile property'leri kısıtlayabiliriz.
        {
            get { return _identityNumber; }
            set 
            {
                if(value.Length == 11)
                {
                    _identityNumber = value;
                    return;
                }

                throw new Exception("Identity Number length must be 11 digits");
            }
        }

        public Encapsulation()
        {
            Parameter = 0;
        }


    }
}
