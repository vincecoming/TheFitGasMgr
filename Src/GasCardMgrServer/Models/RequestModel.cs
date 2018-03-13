﻿///<summary>
///Copyright (c) 2015, 珠海派诺科技股份有限公司
///Product: PiEMS
///
///文件名称: RequestModel.cs
///开发环境: Microsoft Visual Studio 2010
///描    述：
///
///当前版本: V1.0
///作    者: Wudq
///完成日期: 2016-03-20 9:05:58
///
///修改记录 
/// 作者   时间    版本      修改描述
///
///</summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
//     /// <summary>
//     /// 请求的数据包，请求的内容使用对象描述
//     /// </summary>
//     public class RequestModel<T>
//     {
//         public string UUID { get; set; }
//         public DateTime reqDt { get; set; }
//         public T Info { get; set; }
//     }


    /// <summary>
    /// 请求的数据包，数据内容使用字符串描述
    /// </summary>
    public class RequestModelString
    {
        public string UUID { get; set; }
        public DateTime reqDt { get; set; }
        public string Info { get; set; }
    }
}
