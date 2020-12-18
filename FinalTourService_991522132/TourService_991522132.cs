using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FinalTourService_991522132
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TourService_991522132" in both code and config file together.
    public class TourService_991522132 : IAuthenticateUserService, IDBOperationService
    {
        ABCTourDB_991522132Entities current = new ABCTourDB_991522132Entities();
        public string InsertATour(User user)
        {
            current.Users.Add(user);
            current.SaveChanges();
            try
            {
                return ("Record inserted");
            }
            catch
            {
                return ("Data insertion Failed!");
            }
        }

        public string Login(User user)
        {
            List<User> users = current.Users.ToList();
            try
            {
                for(int i = 0; i <= users.Count; i++)
                {
                    if(user.UserName == users[i].UserName && user.Password == users[i].Password){
                        return ("Login success!");
                    }
                }
                return ("Login Failed");
            }
            catch
            {
                return ("Login Failed");
            }

        }

        public List<User> RetrieveTourInfo()
        {
            List<User> users = current.Users.ToList();
            return (users);
        }
    }
}
