using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS.Entities
{
    /// <summary>
    /// 
    /// </summary>

    public class MsgParameter
    {
        /// <summary>
        /// 消息编号，保证唯一
        /// </summary>
        public string msgid { get; set; }
        /// <summary>
        /// 	接收消息的功能ID
        /// </summary>
        public string funcid { get; set; }
        /// <summary>
        /// 消息类型，文本消息默认为0
        /// </summary>
        public string msgtype { get; set; }
        /// <summary>
        /// 家长用户是接收消息，默认false
        /// </summary>
        public string parentsReceive { get; set; }
        /// <summary>
        /// 学生本人是否接收消息，默认false
        /// </summary>
        public string studentReceive { get; set; }
        /// <summary>
        /// 	用户所在组织机构ID
        /// </summary>
        public string orgid { get; set; }
        /// <summary>
        /// 	发送者ID
        /// </summary>
        public string senderid { get; set; }
        /// <summary>
        /// 	接收人ID，该字段与deptIds不能同时为空
        /// </summary>
        public string userids { get; set; }
        /// <summary>
        /// 	接收部门ID，该字段与userIds不能同时为空
        /// </summary>
        public string deptids { get; set; }
        /// <summary>
        /// 指定发送的用户角色，deptIds值不为空时有效
        /// </summary>
        public string userroles { get; set; }
        /// <summary>
        /// 	指定不接收此消息的用户，deptIds值不为空时有效
        /// </summary>
        public string exclude_userids { get; set; }
        /// <summary>
        /// 	是否对子部门下人员发送消息，deptIds值不为空时有效，默认false
        /// </summary>
        public string with_subdepts { get; set; }

        public object msg { get; set; }
    }
}
