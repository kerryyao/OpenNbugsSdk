using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONS
{
    public enum CommonJsonSendType
    {
        GET,
        POST
    }

    /// <summary>
    /// 公众号返回码code
    /// </summary>
    public enum ReturnCode
    {
        接口返回正常 = 0,
        业务异常_具体可见msg字段输出 = 1,
        开发者信息不存在 = 1001,
        开发者信息认证失败 = 1002,
        无效的code值 = 1003,
        不支持的授权方式 = 1004,
        无效的oauth_token = 1005,
        不支持应用授权的oauth_token = 1006,
        没有接口访问的权限 = 1007,
        不支持的response_type = 1008,
        urlid对应的地址为空 = 1009,
        微信端认证时缺少portalid或orgid参数 = 1010,
        单次提取数量不能超过1000个 = 1101,
        用户信息不存在 = 1012
    }
}
