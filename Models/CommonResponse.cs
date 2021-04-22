using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WzgjSystemAPI.Models
{
    /// <summary>
    /// 接口返回数据格式
    /// </summary>
    public class CommonResponse<T> where T : class
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public CommonResponse()
        {
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="state">处理状态</param>
        /// <param name="msg">处理消息</param>
        /// <param name="t">返回数据</param>
        public CommonResponse(State state, string msg, T t)
        {
            State = state;
            Msg = msg;
            Data = t;
        }
        /// <summary>
        /// 处理状态
        /// </summary>
        public State State { get; set; }
        /// <summary>
        /// 处理消息
        /// </summary>
        public string Msg { get; set; }
        /// <summary>
        /// 返回数据
        /// </summary>
        public T Data { get; set; }
    }

    /// <summary>
    /// 处理状态
    /// </summary>
    public enum State
    {
        /// <summary>
        /// 出错
        /// </summary>
        Error = -999,
        /// <summary>
        /// 失败
        /// </summary>
        Fail = -1,
        /// <summary>
        /// 成功
        /// </summary>
        Success = 1
    }
}