﻿// ======================================================================
// 
//         Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//         All rights reserved
// 
//         filename :EChartsOptions.cs
//         description :
// 
//         created by 李文强 at  2016/09/17 19:16
//         Blog：http://www.cnblogs.com/codelove/
//         Home：http://xin-lai.com
// 
// ======================================================================

using Magicodes.ECharts.Axis;
using Magicodes.ECharts.Components.Legend;
using Magicodes.ECharts.Components.TimeLine;
using Magicodes.ECharts.Components.Title;
using Magicodes.ECharts.Components.ToolBox;
using Magicodes.ECharts.Components.ToolTip;

namespace Magicodes.ECharts
{
    /// <summary>
    ///     EChart相关配置
    /// </summary>
    public class EChartsOption
    {
        /// <summary>
        ///     标题组件
        /// </summary>
        public Title Title { get; set; }

        /// <summary>
        ///     是否启用拖拽重计算特性，默认关闭
        /// </summary>
        public bool Calculable { get; set; }

        /// <summary>
        ///     提示框组件
        /// </summary>
        public Tooltip Tooltip { get; set; }

        /// <summary>
        ///     工具箱 每个图表仅有一个
        /// </summary>
        public ToolBox Toolbox { get; set; }

        /// <summary>
        ///     timeline 组件，提供了在多个 ECharts option 间进行切换、播放等操作的功能。
        /// </summary>
        public TimeLine Timeline { get; set; }

        /// <summary>
        ///     图例组件
        /// </summary>
        public Legend Legend { get; set; }

        /// <summary>
        ///     直角坐标系 grid 中的 x 轴，单个 grid 组件最多只能放上下两个 x 轴。
        /// </summary>
        public XAxis[] XAxis { get; set; }

        /// <summary>
        ///     直角坐标系 grid 中的 y 轴，一般情况下单个 grid 组件最多只能放左右两个 y 轴，多于两个 y 轴需要通过配置 offset 属性防止同个位置多个 Y 轴的重叠。
        /// </summary>
        public YAxis[] YAxis { get; set; }

        /// <summary>
        ///     系列列表
        /// </summary>
        public Series.Series[] Series { get; set; }
    }
}