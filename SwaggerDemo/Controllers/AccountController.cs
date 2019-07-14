using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerDemo.Controllers
{

    /// <summary>
    /// 账户控制类
    /// </summary>
    [Route("api/Account")]
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Get(string id)
        {
            int.TryParse(id, out int _id);
            return Json(new AccountInfo()
            {
                Id = _id,
                Account = "TEST"
            });
        }
    }

    public class AccountInfo
    {
        public int Id { get; set; }
        public string Account { get; set; }
    }
}