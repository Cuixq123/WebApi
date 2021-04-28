using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCore.Controllers.Version1
{
    /// <summary>
    /// 项目管理视图接口
    /// </summary>
    [Route("api/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        /// <summary>
        /// 获取项目的id
        /// </summary>
        /// <param name="id">主键参数</param>
        /// <returns></returns>
        [HttpGet]
        [Route("ProjectgetId")]
        public IActionResult ProjectgetId(int id)
        {
            return new JsonResult(new
            {
                Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                port = id,
                Version = "V1",
                Descript="测试成功"
            });
        }
    }
}
