using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace OrangeJam.WPF.SVG
{
    /// <summary>
    /// 点集合
    /// </summary>
    public class SVGPointArray : SVGData
    {
        /// <summary>
        /// 值
        /// </summary>
        public List<Point> Value { get; set; } = new List<Point>();
    }
}
