using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerDemo.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : Controller
    {

        /// <summary>
        /// 新增1
        /// </summary>
        /// <param name="user">用户对象1</param>
        /// <returns>response1</returns>
        [Route("Add")]
        [HttpPost]
        public IActionResult Add(UserInfo user)
        {
            return Ok("result");
        }

        /// <summary>
        /// 新增2
        /// </summary>
        /// <param name="user">用户对象2</param>
        /// <returns>response2</returns>
        [Route("Add2")]
        [HttpPost]
        public IActionResult Add2(UserInfo user)
        {
            return Ok("result2");
        }
    }

    public class UserInfo {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}