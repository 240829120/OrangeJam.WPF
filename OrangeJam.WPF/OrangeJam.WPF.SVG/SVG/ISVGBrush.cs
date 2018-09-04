using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace OrangeJam.WPF.SVG
{
    /// <summary>
    /// 画刷
    /// </summary>
    public interface ISVGBrush
    {
        /// <summary>
        /// 画刷
        /// </summary>
        Brush Value { get; }
    }
}
