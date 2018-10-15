using System;

namespace BookSwap
{
    public class User
    {
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string MemberGUID { get; set; }

        public User()
        {
        }

      public static string GenerateGUID(){

         Guid ID = Guid.NewGuid();
         return ID.ToString();
      }
    }
}
