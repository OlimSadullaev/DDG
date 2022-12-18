using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mock_interview.DTOs;
using Mock_interview.Mock_interviewServiceTools;

namespace Mock_interview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        
         
        
    }
}
