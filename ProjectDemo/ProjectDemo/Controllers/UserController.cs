using BusinessLayer3.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;

namespace ProjectDemo.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBl userBl;
        public UserController(IUserBl userBl)
        {
            this.userBl = userBl;
        }
        [HttpPost]
        public IActionResult AddUser(UserMl userModel)
        {
            var result = userBl.AddUser(userModel);
            if (result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("Something went wrong!!");
            }
        }
        [HttpPut("{user1}")]
        public IActionResult UpdateUser([FromBody]UserMl userModel,string user1)
        {
            var result=userBl.UpdateUser(userModel,user1);
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("Something went wrong!!");
            }
        }
        [HttpDelete]
        public IActionResult DeleteUser(UserMl userModel)
        {
            var result = userBl.DeleteUser(userModel);
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("Data to be deleted not found");
            }
        }
        [HttpGet]
        public IActionResult ReadUser()
        {
            var result=userBl.ReadUser();
            if(result != null)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest("Something went wrong !!");
            }
        }
    }
}
