﻿///<summary>
///Copyright (c) 2015, 珠海派诺科技股份有限公司
///Product: PiEMS
///
///文件名称: JsonResutlModel.cs
///开发环境: Microsoft Visual Studio 2010
///描    述：
///
///当前版本: V1.0
///作    者: Wudq
///完成日期: 2016-03-18 0:50:51
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
    /// <summary>
    /// JSON结果对象
    /// </summary>
    public class JsonResutlModel<T>
    {
        public bool Status { get; set; }
        public int StatusInt { get; set; }
        public string ErrorDesc { get; set; }
        public T Info { get; set; }
    }
}
