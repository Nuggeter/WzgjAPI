using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WzgjSystemAPI.Models;

namespace WzgjSystemAPI.Controllers
{
    /// <summary>
    /// API基类
    /// </summary>
    public class BaseApiController : ApiController
    {
        /// <summary>
        /// 构造返回消息
        /// </summary>
        /// <param name="state">状态</param>
        /// <param name="msg">消息文本</param>
        /// <returns>构造完成的返回消息</returns>
        protected HttpResponseMessage ResReturn(State state, string msg)
        {
            return ResReturn(state, msg, null);
        }

        /// <summary>
        /// 构造返回消息
        /// </summary>
        /// <param name="state">状态</param>
        /// <param name="msg">消息文本</param>
        /// <param name="data">返回数据</param>
        /// <returns>构造完成的返回消息</returns>
        protected HttpResponseMessage ResReturn(State state, string msg, object data)
        {
            var res = new CommonResponse<object>(state, msg, data);
            return ResReturn(res);
        }

        /// <summary>
        /// 构造返回消息
        /// </summary>
        /// <param name="response"></param>
        /// <returns>构造完成的返回消息</returns>
        protected HttpResponseMessage ResReturn<T>(CommonResponse<T> response) where T : class
        {
            return new HttpResponseMessage
            {
                Content = new StringContent(JsonConvert.SerializeObject(response))
            };
        }
    }
}