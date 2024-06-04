using BusinessLayer3.Interface;
using ModelLayer;
using RepoLayer.Entity;
using RepoLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer3.Service
{
    public class UserBl:IUserBl
    {
        private readonly IUserRL userRl;
        public UserBl (IUserRL userRl)
        {
            this.userRl = userRl;
        }
        public UserEntity AddUser(UserMl model)
        {
            return userRl.AddUser(model);
        }
        public UserEntity UpdateUser(UserMl model,string model1)
        {
            return userRl.UpdateUser(model,model1);
        }
        public UserEntity? DeleteUser(UserMl model)
        {
            return userRl.DeleteUser(model);
        }
        public List<UserEntity> ReadUser()
        {
            return userRl.ReadUser();
        }
    }
}
