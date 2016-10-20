using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.Entities
{
    public class Picture
    {
        /// <summary>
        /// 图文消息的标题
        /// </summary>
        public string title { get; set; }
        /// <summary>
        /// 	图文消息的摘要
        /// </summary>
        public string summary { get; set; }
        /// <summary>
        /// 	图文消息的图片地址
        /// </summary>
        public string picUrl { get; set; }

        public class link
        {
            /// <summary>
            /// 	图文消息打开时的回调地址ID
            /// </summary>
            public string linkId { get; set; }
            /// <summary>
            /// 	图文消息打开后回调时的URL参数内容，平台会原样附加在回调URL中
            /// </summary>
            public string urlParams { get; set; }
        }
    }
}
