using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;

namespace WindowsFormsApplication1
{
    abstract class ExcelOperation
    {
        /// <summary>
        /// 将某个 <seealso cref="XmlDocument"/> 对象转为等价的 <seealso cref="DataSet"/> 表示
        /// </summary>
        public DataSet Convert(XmlDocument xml)
        {
            var xmlReader = new XmlNodeReader(xml);
            DataSet ds = new DataSet();
            ds.ReadXml(xmlReader);

            return ds;
        }
    }
}
