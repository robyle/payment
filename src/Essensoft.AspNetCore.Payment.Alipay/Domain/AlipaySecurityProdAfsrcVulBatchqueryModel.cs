﻿using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdAfsrcVulBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdAfsrcVulBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}