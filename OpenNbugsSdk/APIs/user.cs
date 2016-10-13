using ONS.Entities;
using ONS.Utilities.HttpUtility;
using System.Collections.Generic;

namespace ONS.APIs
{
    public class user
    {
        /// <summary>
        /// 获取单个用户信息
        /// </summary>
        /// <param name="orgid"></param>
        /// <param name="userid"></param>
        /// <param name="oauth_token"></param>
        /// <param name="with_contacts"></param>
        /// <param name="with_orgext"></param>
        /// <param name="with_card"></param>
        /// <param name="with_roledetail"></param>
        /// <returns></returns>
        public Userinfo getUserInfo(string orgid, string userid, string oauth_token, bool with_contacts, bool with_orgext, bool with_card, bool with_roledetail)
        {
            Userinfo result = null;
            string url = Config.URL_OPENBUGS + "/user/get?orgid=" + orgid + "&userid=" + userid + "&oauth_token=" + oauth_token;
            var temp = Get.GetJson<RetResult<Userinfo>>(url);
            result = temp.r;
            return result;
        }

        /// <summary>
        /// 获取登陆用户信息
        /// </summary>
        /// <param name="oauth_toekn"></param>
        /// <returns></returns>
        public LoginUser getUserInfo(string oauth_toekn)
        {
            List<LoginUser> result = null;
            string url = Config.URL_OPENBUGS + "/loginuser/loadbytoken?oauth_token=" + oauth_toekn;
            var temp = Get.GetJson<RetResult<BaseUser<LoginUser>>>(url);
            result = temp.r.users;

            return result[0];
        }

        /// <summary>
        /// 获取多个用户信息
        /// </summary>
        /// <param name="orgid">用户所在组织机构ID</param>
        /// <param name="userids">部门ID，多个之间用逗号分隔</param>
        /// <param name="oauth_token"></param>
        /// <param name="with_contacts">	结果是否需要包含联系方式，默认：false</param>
        /// <param name="with_orgext">	结果是否需要包含机构定义的扩展信息，默认：false</param>
        /// <param name="with_card">	结果是否需要包含卡号信息，默认：false</param>
        /// <param name="with_roledetail">	结果是否需要包含角色详细信息，默认：false</param>
        /// <returns></returns>
        public List<Userinfo> getUserInfoList(string orgid, string userids, string oauth_token, bool with_contacts, bool with_orgext, bool with_card, bool with_roledetail)
        {
            List<Userinfo> result = null;
            string url = Config.URL_OPENBUGS + "user/list?orgid=" + orgid + "&userids=" + userids + "&oauth_token= " + Oauth.token[Config.guid] + "&with_orgext=" + with_orgext + "&with_card=" + with_card + "&with_roledetail=" + with_roledetail;
            var temp = Get.GetJson<RetResult<List<Userinfo>>>(url);
            return result;
        }

        /// <summary>
        /// 获取部门内的人员信息
        /// </summary>
        /// <param name="orgid">	用户所在组织机构ID</param>
        /// <param name="deptids">	部门ID，多个之间用逗号分隔</param>
        /// <param name="roles">	角色名称，如：学生、老师，多个之间用逗号分隔，需utf-8编码</param>
        /// <param name="oauth_token">应用授权获得的token</param>
        /// <param name="with_contacts">	结果是否需要包含联系方式，默认：false</param>
        /// <param name="with_orgext">	结果是否需要包含机构定义的扩展信息，默认：false</param>
        /// <param name="with_card">	结果是否需要包含卡号信息，默认：false</param>
        /// <param name="with_roledetail">	结果是否需要包含角色详细信息，默认：false</param>
        /// <returns></returns>
        public List<Userinfo> getOrgUser(string orgid, string deptids, string roles, string oauth_token, string with_contacts, string with_orgext, string with_card, string with_roledetail)
        {
            List<Userinfo> result = null;
            string url = Config.URL_OPENBUGS + "/orguser/list?orgid=" + orgid + "&deptids=" + deptids + "&oauth_token=" + Oauth.token[Config.guid] + "&with_contacts=" + with_contacts + "&with_orgext=" + with_orgext + "&with_card=" + with_card + "&with_roledetail=" + with_roledetail;
            var temp = Get.GetJson<RetResult<List<Userinfo>>>(url);
            result = temp.rs;
            return result;
        }

        /// <summary>
        /// 分页获取部门内的人员信息
        /// </summary>
        /// <param name="orgid">	用户所在组织机构ID</param>
        /// <param name="deptids">	部门ID，多个之间用逗号分隔</param>
        /// <param name="roles">	角色名称，如：学生、老师，多个之间用逗号分隔，需utf-8编码</param>
        /// <param name="page">	当前页面，大于0的整数</param>
        /// <param name="pagesize">	每页返回的记录数，默认为50</param>
        /// <param name="oauth_token">	应用授权获得的token</param>
        /// <param name="with_contacts">	结果是否需要包含联系方式，默认：false</param>
        /// <param name="with_orgext">	结果是否需要包含机构定义的扩展信息，默认：false</param>
        /// <param name="with_card">	结果是否需要包含卡号信息，默认：false</param>
        /// <param name="with_roledetail">	结果是否需要包含角色详细信息，默认：false</param>
        /// <returns></returns>
        public List<Userinfo> getOrgUserByPage(string orgid, string deptids, string roles, string page, string pagesize, string oauth_token, string with_contacts, string with_orgext, string with_card, string with_roledetail)
        {
            List<Userinfo> result = null;
            string url = Config.URL_OPENBUGS + "/orguser/page?orgid=" + orgid + "&deptids=" + deptids + "&roles=" + roles + "&page=" + page + "&pagesize=" + pagesize + "&oauth_token=" + Oauth.token[Config.guid] + "&with_contacts=" + with_contacts + "&with_orgext=" + with_orgext + "&with_card=" + with_card + "&with_roledetail=" + with_roledetail;
            var temp = Get.GetJson<RetResult<RetResult<List<Userinfo>>>>(url);//小虫返回体中r中套rs折中解法s
            result = temp.r.rs;
            return result;
        }

        /// <summary>
        /// 获取以部门为组织的人员信息
        /// </summary>
        /// <param name="orgid">用户所在组织机构ID</param>
        /// <param name="deptids">部门ID，多个之间用逗号分隔</param>
        /// <param name="roles">	角色名称，如：学生、老师，多个之间用逗号分隔，需utf-8编码</param>
        /// <param name="oauth_token">	应用授权获得的token</param>
        /// <param name="with_contacts">	结果是否需要包含联系方式，默认：false</param>
        /// <param name="with_orgext">	结果是否需要包含机构定义的扩展信息，默认：false</param>
        /// <param name="with_card">	结果是否需要包含卡号信息，默认：false</param>
        /// <param name="with_roledetail">	结果是否需要包含角色详细信息，默认：false</param>
        /// <returns></returns>
        public List<UserRole> getDeptidsUserinfo(string orgid, string deptids, string roles, string oauth_token, string with_contacts, string with_orgext, string with_card, string with_roledetail)
        {
            List<UserRole> result = null;
            string url = Config.URL_OPENBUGS + "/orguser/map?orgid=" + orgid + "&deptids=" + deptids + "&roles=" + roles + "&page=" + "&oauth_token=" + Oauth.token[Config.guid] + "&with_contacts=" + with_contacts + "&with_orgext=" + with_orgext + "&with_card=" + with_card + "&with_roledetail=" + with_roledetail;
            var temp = Get.GetJson<RetResult<List<UserRole>>>(url);
            result = temp.rs;
            return result;
        }


        public List<Userinfo> getUserinfobyOrg(string orgid, string usertype, string page, string pagesize, string oauth_token, string with_contacts, string with_orgext, string with_card, string with_roledetail)
        {
            List<Userinfo> result = null;
            string url = Config.URL_OPENBUGS + "/orguser/all?orgid=" + orgid + "&usertype=" + usertype + "&page=" + page + "&pagesize=" + pagesize + "&oauth_token=" + Oauth.token[Config.guid] + "&with_contacts=" + with_contacts + "&with_orgext=" + with_orgext + "&with_card=" + with_card + "&with_roledetail=" + with_roledetail;
            var temp = Get.GetJson<RetResult<RetResult<List<Userinfo>>>>(url);
            result = temp.r.rs;
            return result;
        }
    }
}
