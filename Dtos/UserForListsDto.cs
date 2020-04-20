using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dating.Dtos /*Dtos are using to return data without returning restricted data. ex: password hash and password salt

   in postman when we type api/users by using autorizd user details it will retuen user information with restricted data
   
     here we mention and declare the changes to those returning data*/
{
    public class UserForListsDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhotoUrl { get; set; }
    }
}
