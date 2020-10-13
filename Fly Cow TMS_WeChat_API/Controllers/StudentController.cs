using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL;
using Model;

namespace Fly_Cow_TMS_WeChat_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        AddressBLL bll = new AddressBLL();
        //显示
        [HttpGet]
        [Route("GetList")]
        public List<Address> GetList()
        {
            return bll.GetList();
        }

    }
}
