using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEAI
{
    internal class Inheritance
    {
       
        public abstract class UserMaster
        {
            public int Id { get; set; }

            public string UserName { get; set; }

            public Guid Password { get; set; }

        }

        public  class User:UserMaster
        {
            void  CreatePost()
            {
                //....
            }
            void DeletePost()
            {
                //....
            }
            void LikePost()
            {
                //....
            }

            void Repost()
            {
                //....
            }
        }

        public class Admin : UserMaster
        {
            void RemoveUser()
            {
                //....
            }

            void BlockPost()
            {
                //....
            }
            
            void AddPage()
            {
                //....
            }
        }
    }
}
