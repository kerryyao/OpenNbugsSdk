using ONS.Entities;
using ONS.Utilities.HttpUtility;
using System.Collections.Generic;

namespace ONS.APIs
{
    public class OrgServices
    {

        /// <summary>
        /// 获取单个机构（部门）信息
        /// </summary>
        /// <param name="orgid">用户所在组织机构ID</param>
        /// <param name="deptid">部门ID</param>
        /// <param name="oauth_token">	应用授权获得的token</param>
        /// <returns></returns>
        public Organize Orginfo(string orgid, string deptid, string oauth_token)
        {
            Organize result = null;
            string url = Config.URL_OPENBUGS + "/org/get?orgid=" + orgid + "&deptid=" + deptid + "&oauth_token=" + Oauth.token[Config.guid];
            var temp = Get.GetJson<RetResult<Organize>>(url);
            result = temp.r;
            return result;
        }

        /// <summary>
        /// 获取多个机构（部门）信息
        /// </summary>
        /// <param name="orgid">用户所在组织机构ID</param>
        /// <param name="deptid">	部门ID，多个之间用逗号分隔</param>
        /// <param name="oauth_token">	应用授权获得的token</param>
        /// <returns></returns>
        public List<Organize> OrginfoList(string orgid, string deptid, string oauth_token)
        {
            List<Organize> result = null;
            string url = Config.URL_OPENBUGS + "/org/list?orgid=" + orgid + "&deptids=" + deptid + "&oauth_token=" + Oauth.token[Config.guid];
            var temp = Get.GetJson<RetResult<List<Organize>>>(url);
            result = temp.rs;
            return result;
        }
        /// <summary>
        /// 获取机构内下级部门信息
        /// </summary>
        /// <param name="orgid">	用户所在组织机构ID</param>
        /// <param name="parentid">	父部门ID，返回该部门的下一级部门列表</param>
        /// <param name="oauth_token">	应用授权获得的token</param>
        /// <param name="types">	返回的下级部门类别，如：学校部门，年级、班级</param>
        /// <param name="withSelf">返回时是否同时返回本部门信息，默认：false</param>
        /// <returns></returns>
        public List<Organize> OrgSubmit(string orgid, string parentid, string oauth_token, string types, string withSelf)
        {
            List<Organize> result = null;
            string url = Config.URL_OPENBUGS + "/org/sublist?orgid=" + "" + orgid + "&parentid=" + parentid + "&oauth_token=" + Oauth.token[Config.guid] + "&types=" + types + "&withSelf=" + withSelf;
            var temp = Get.GetJson<RetResult<List<Organize>>>(url);
            result = temp.rs;
            return result;
        }

        /// <summary>
        /// 获取组织机构树
        /// </summary>
        /// <param name="orgid">	组织机构ID</param>
        /// <param name="oauth_toeken">	应用授权获得的token</param>
        /// <returns></returns>
        public Organize OrgTree(string orgid, string oauth_token)
        {
            Organize result = null;
            string url = Config.URL_OPENBUGS + "/org/tree?orgid=" + orgid + "&oauth_token=" + oauth_token;
            var temp = Get.GetJson<RetResult<Organize>>(url);
            result = temp.r;
            return result;
        }

        /// <summary>
        /// 未测试
        /// </summary>
        /// <param name="orgid"></param>
        /// <param name="usertype"></param>
        /// <param name="oauth_token"></param>
        /// <returns></returns>
        public List<object> orgext(string orgid, string usertype, string oauth_token)
        {
            List<object> result = null;
            string url = Config.URL_OPENBUGS + "/org/tree?orgid=" + orgid + "&oauth_token=" + oauth_token;
            var temp = Get.GetJson<RetResult<List<object>>>(url);
            result = temp.rs;
            return result;
        }

    }
}
