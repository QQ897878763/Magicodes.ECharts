﻿// ======================================================================
// 
//         Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//         All rights reserved
// 
//         filename :NumberValue.cs
//         description :
// 
//         created by 李文强 at  2016/09/17 19:16
//         Blog：http://www.cnblogs.com/codelove/
//         Home：http://xin-lai.com
// 
// ======================================================================

using Magicodes.ECharts.JsonConverter;
using Newtonsoft.Json;

namespace Magicodes.ECharts.ValueTypes
{
    /// <summary>
    ///     数值
    /// </summary>
    [JsonConverter(typeof(ValueConverter<int>))]
    public class NumberValue : ILeftValue, ITopValue, IRightValue, IBottomValue, IValue<int>
    {
        public int Value { get; set; }
    }
}