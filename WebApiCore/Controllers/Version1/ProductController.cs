using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCore.Controllers.Version1
{
    /// <summary>
    /// 产品管理视图接口
    /// </summary>
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName ="v1")]
    [ApiController]
    public class ProductController : ControllerBase
    {

    }
}
