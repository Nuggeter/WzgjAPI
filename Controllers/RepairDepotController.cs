using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using WzgjBLL;
using WzgjSystemAPI.Models;
using WzgjViewModel;

namespace WzgjSystemAPI.Controllers
{
    public class RepairDepotController : BaseApiController
    {
        /// <summary>
        /// 返回登记，在制，审核状态的单据
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/RepairDepot/QueryRepairBill")]
        public HttpResponseMessage QueryRepairBill()
        {
            try
            {
                var result = RepairDepotManager.GetInstance().Query();
                return ResReturn(State.Success, "查询维修单据成功", result);
            }
            catch (Exception ex)
            {
                return ResReturn(State.Error, "查询维修单据出错：" + ex.Message);
            }
        }

        /// <summary>
        /// 同步维修单据
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/RepairDepot/InsertRepairBill")]
        public HttpResponseMessage InsertRepairBill(List<RepairBillModel> listModel)
        {
            try
            {
                if (listModel == null || listModel.Count == 0)
                    return ResReturn(State.Fail, "参数为空");
                var result = RepairDepotManager.GetInstance().Insert(listModel);
                return result ? ResReturn(State.Success, "维修单据同步成功") : ResReturn(State.Fail, "维修单据同步失败");
            }
            catch (Exception ex)
            {
                return ResReturn(State.Error, "维修单据同步出错：" + ex.Message);
            }
        }

        /// <summary>
        /// 同步领料明细
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/RepairDepot/InsertRepairMaterial")]
        public HttpResponseMessage InsertRepairMaterial(List<RepairMaterialModel> listModel)
        {
            try
            {
                if (listModel == null || listModel.Count == 0)
                    return ResReturn(State.Fail, "参数为空");
                var result = RepairDepotManager.GetInstance().Insert(listModel);
                return result ? ResReturn(State.Success, "领料明细同步成功") : ResReturn(State.Fail, "领料明细同步失败");
            }
            catch (Exception ex)
            {
                return ResReturn(State.Error, "领料明细同步出错：" + ex.Message);

            }
        }

        /// <summary>
        /// 同步项目明细
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/RepairDepot/InsertRepairService")]
        public HttpResponseMessage InsertRepairService(List<RepairServiceModel> listModel)
        {
            try
            {
                if (listModel == null || listModel.Count == 0)
                    return ResReturn(State.Fail, "参数为空");
                var result = RepairDepotManager.GetInstance().Insert(listModel);
                return result ? ResReturn(State.Success, "项目明细同步成功") : ResReturn(State.Fail, "项目明细同步失败");
            }
            catch (Exception ex)
            {
                return ResReturn(State.Error, "项目明细同步出错：" + ex.Message);

            }
        }
    }
}