using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    internal class ISP_ON
    {
        public interface IMessage
        {
            public int From { get; set; }
            public int To { get; set; }
            public string MessageBody { get; set; }
        }
        public interface IMessageWithImage
        {
            public int ImageWith { get; set; }

            public int ImageHeight { get; set; }

            void AttachImage();
        }

        public interface IMessageWithMovie
        {
            public int MovieDuration { get; set; }

            void AttachMovie();
        }
    }
}
