using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WzgjBLL;
using WzgjSystemAPI.Models;
using WzgjViewModel;

namespace WzgjSystemAPI.Controllers
{
    public class TransunController : BaseApiController
    {
        /// <summary>
        /// 查询非报废车辆明细
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Transun/QueryWellBus")]
        public HttpResponseMessage QueryWellBus()
        {
            try
            {
                var result = TransunManager.GetInstance().QueryWellBus();
                return ResReturn(State.Success, "查询非报废车辆明细成功", result);
            }
            catch (Exception ex)
            {
                return ResReturn(State.Error, "查询非报废车辆明细出错：" + ex.Message);
            }
        }

        /// <summary>
        /// 查询故障车辆明细
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage QueryFaultBus(string StartTime,string EndTime)
        {
            try
            {
                var result = TransunManager.GetInstance().QueryFaultBus(StartTime,EndTime);
                return ResReturn(State.Success, "查询故障车辆明细成功", result);
            }
            catch (Exception ex)
            {
                return ResReturn(State.Error, "查询故障车辆明细出错：" + ex.Message);
            }
        }

        /// <summary>
        /// 查询员工信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/Transun/QueryEmployee")]
        public HttpResponseMessage QueryEmployee()
        {
            try
            {
                var result = TransunManager.GetInstance().QueryEmployee();
                return ResReturn(State.Success, "查询员工信息成功", result);
            }
            catch (Exception ex)
            {
                return ResReturn(State.Error, "查询员工信息出错：" + ex.Message);
            }
        }
    }
}