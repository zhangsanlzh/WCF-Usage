using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.XWPF.UserModel;
using System.Xml;
using System.Data;
using System.IO;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// 定义处理 Word 文件的公有操作
    /// </summary>
    abstract class WordOperation
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
