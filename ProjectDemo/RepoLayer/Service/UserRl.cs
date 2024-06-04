using ModelLayer;
using RepoLayer.Context;
using RepoLayer.Entity;
using RepoLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoLayer.Service
{
    public class UserRl: IUserRL
    {
        private readonly ProjectContext projectContext;

        public UserRl(ProjectContext projectContext)
        {
            this.projectContext = projectContext;
        }
        public UserEntity AddUser(UserMl user)
        {
            UserEntity userEntity = new UserEntity();
            userEntity.Name= user.Name;

            projectContext.Users.Add(userEntity);
            projectContext.SaveChanges();
            return userEntity;
        }
        public UserEntity? UpdateUser(UserMl user,string newUser)
        {
            UserEntity? userToUpdate=projectContext.Users.FirstOrDefault(u=>u.Name==user.Name);
            if (userToUpdate!=null)
            {
                userToUpdate.Name= newUser;
                projectContext.SaveChanges();
            }
            return userToUpdate;
        }
        public UserEntity? DeleteUser(UserMl user)
        {
            UserEntity? userToRemove=projectContext.Users.FirstOrDefault(u => u.Name == user.Name);
            if (userToRemove != null)
            {
                projectContext.Users.Remove(userToRemove);
                projectContext.SaveChanges();
            }
            return userToRemove;
        }
        public List<UserEntity> ReadUser()
        {
           return projectContext.Users.ToList();
        }
    }
}
