﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTCPMessage.EntityPackage
{


    /// <summary>
    /// 淘宝券json详细结构
    /// </summary>
    public class TaobaoQuanDetailJsonResult
    {
        public string api { get; set; }
        public DataContainer data { get; set; }
        public IEnumerable<string> ret { get; set; }
        public string v { get; set; }

        public class DataContainer
        {
            public string error { get; set; }
            public string haveNextPage { get; set; }
            public IEnumerable<ModuleContainer> module { get; set; }
            public string needInterrupt { get; set; }
            public int totalCount { get; set; }
        }




        public class ModuleContainer
        {
            public string activityId { get; set; }
            public string couponId { get; set; }
            public string couponType { get; set; }
            public string currencyUnit { get; set; }
            public string defaultValidityCopywriter { get; set; }
            public string description { get; set; }
            public decimal? discount { get; set; }
            public DateTime? endTime { get; set; }
            public int intervalDays { get; set; }
            public int intervalHours { get; set; }
            public string poiShop { get; set; }
            public decimal sellerId { get; set; }
            public string shopNick { get; set; }
            public decimal? startFee { get; set; }
            public DateTime? startTime { get; set; }
            public int status { get; set; }
            public string transfer { get; set; }
            public string useIntervalMode { get; set; }
            public string uuid { get; set; }

            /// <summary>
            /// 是否是有效的优惠券
            /// </summary>
            /// <returns></returns>
            public bool IsValidQuan() {
                var result = false;
                if (this.status==1 &&this.endTime!=null&&this.endTime>=DateTime.Now)
                {
                    return true;
                }
                return result;
            }
        }
      


    }

}
