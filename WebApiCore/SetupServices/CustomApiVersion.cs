using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.SetupServices
{
    /// <summary>
    /// 多版本控制
    /// </summary>
    public class CustomApiVersion
    {
        public enum ApiVersions
        {
            /// <summary>
            /// v1版本
            /// </summary>
            v1 = 1,
            /// <summary>
            /// v2版本
            /// </summary>
            v2 = 2,
            /// <summary>
            /// v3版本
            /// </summary>
            v3 = 3
        }
    }
}
