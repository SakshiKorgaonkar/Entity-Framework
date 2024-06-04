using ModelLayer;
using RepoLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoLayer.Interface
{
    public interface IUserRL
    {
        public UserEntity AddUser(UserMl model);

        public UserEntity UpdateUser(UserMl model,string model1);

        public UserEntity? DeleteUser(UserMl model);

        public List<UserEntity> ReadUser();
    }
}
