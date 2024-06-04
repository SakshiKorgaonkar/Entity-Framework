using ModelLayer;
using RepoLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer3.Interface
{
    public interface IUserBl
    {
        public UserEntity AddUser(UserMl user); 

        public UserEntity UpdateUser(UserMl user,string user1);  

        public UserEntity DeleteUser(UserMl user);

        public List<UserEntity> ReadUser();
    }
}
