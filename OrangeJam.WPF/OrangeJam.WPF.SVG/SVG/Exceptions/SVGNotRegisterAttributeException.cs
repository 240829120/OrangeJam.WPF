using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace OrangeJam.WPF.SVG
{
    /// <summary>
    /// 未注册的属性
    /// </summary>
    public class SVGNotRegisterAttributeException : Exception
    {
        public SVGNotRegisterAttributeException(XName name)
        {
            this.Name = name;
        }

        /// <summary>
        /// 属性名
        /// </summary>
        public XName Name { get; set; }
    }
}
