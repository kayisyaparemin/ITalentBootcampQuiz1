using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    internal class ISP_OFF
    {
        //Sorun:Her gönderilen mesaj video veya resim içermediği halde bu interface implement edildiğinde bu özelliklere sahip olacaktır. Fakat bu gereksizdir.
        public interface IMessage
        {
            public string From { get; set; }
            public string To { get; set; }
            public string MessageBody { get; set; }

            void AttachImage();

            public int ImageWith { get; set; }

            public int ImageHeight { get; set; }

            void AttachMovie();

            public int MovieDuration { get; set; }
        }
    }
}
