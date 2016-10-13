using System.Collections.Generic;

namespace ONS.Entities
{
    public class UserRole
    {
        public string deptId { get; set; }
        public string userRole { get; set; }
        public string userRoleRemark { get; set; }
        public string userId { get; set; }
        public string orgId { get; set; }

        /// <summary>
        /// 用token获取登录人信息时参数
        /// </summary>
        public string deptName { get; set; }
        /// <summary>
        /// 用token获取登录人信息时参数
        /// </summary>
        public string roleRemark { get; set; }
        /// <summary>
        /// 用token获取登录人信息时参数
        /// </summary>
        public string roleName { get; set; }
        /// <summary>
        /// 用token获取登录人信息时参数
        /// </summary>
        public string deptType { get; set; }

        public List<Userinfo> users { get; set; }
    }
}
