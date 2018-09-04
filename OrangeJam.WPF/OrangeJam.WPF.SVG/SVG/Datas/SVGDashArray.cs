using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrangeJam.WPF.SVG
{
    /// <summary>
    /// 虚线数组
    /// </summary>
    public class SVGDashArray : SVGData
    {
        /// <summary>
        /// 值
        /// </summary>
        public List<double> Value { get; set; } = new List<double>();
    }
}
