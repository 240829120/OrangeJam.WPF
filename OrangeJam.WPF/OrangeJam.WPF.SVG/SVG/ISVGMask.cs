using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace OrangeJam.WPF.SVG
{
    /// <summary>
    /// 滤镜
    /// </summary>
    public interface ISVGMask
    {
        /// <summary>
        /// 值
        /// </summary>
        DrawingBrush Value { get; }
    }
}
