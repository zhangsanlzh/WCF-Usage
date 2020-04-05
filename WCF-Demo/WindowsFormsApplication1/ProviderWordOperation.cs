using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.XWPF.UserModel;
using System.Xml;
using System.Data;
using System.IO;
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    /// <summary>
    /// 专门用来处理 供方目录 Word文件
    /// </summary>
    class ProviderWordOperation :WordOperation
    {
        /// <summary>
        /// 获取指定 Word文件中某个 Table的 XML格式表示
        /// </summary>
        public XmlDocument GetTableXml(string wordFile, int index)
        {
            using (FileStream stream = File.OpenRead(wordFile))
            {
                XWPFDocument docx = new XWPFDocument(stream);
                var list = new List<XWPFTableCell>();

                var xml = new XmlDocument();
                var node = xml.CreateNode(XmlNodeType.XmlDeclaration, "", "");
                xml.AppendChild(node);

                var root = xml.CreateNode(XmlNodeType.Element, "Root", "");
                xml.AppendChild(root);

                var title = xml.CreateNode(XmlNodeType.Element, "Title", "");
                var year = xml.CreateNode(XmlNodeType.Element, "Year", "");
                var type = xml.CreateNode(XmlNodeType.Element, "Type", "");
                var text = xml.CreateNode(XmlNodeType.Element, "Text", "");
                root.AppendChild(title);
                title.AppendChild(year);
                title.AppendChild(type);
                title.AppendChild(text);

                var header = xml.CreateNode(XmlNodeType.Element, "Header", "");
                var totalOrder = xml.CreateNode(XmlNodeType.Element, "HTotalOrder", "");
                var secondOrder = xml.CreateNode(XmlNodeType.Element, "HSecondOrder", "");
                var date = xml.CreateNode(XmlNodeType.Element, "HDate", "");
                var companyName = xml.CreateNode(XmlNodeType.Element, "HCompanyName", "");
                var scope = xml.CreateNode(XmlNodeType.Element, "HScope", "");
                var whyUse = xml.CreateNode(XmlNodeType.Element, "HWhyUse", "");
                var linkMan = xml.CreateNode(XmlNodeType.Element, "HLinkMan", "");
                var phoneNum = xml.CreateNode(XmlNodeType.Element, "HPhoneNum", "");
                var address = xml.CreateNode(XmlNodeType.Element, "HAddress", "");
                header.AppendChild(totalOrder);
                header.AppendChild(secondOrder);
                header.AppendChild(date);
                header.AppendChild(companyName);
                header.AppendChild(scope);
                header.AppendChild(whyUse);
                header.AppendChild(linkMan);
                header.AppendChild(phoneNum);
                header.AppendChild(address);
                root.AppendChild(header);

                var body = xml.CreateNode(XmlNodeType.Element, "Body", "");
                root.AppendChild(body);

                var table = docx.Tables[index];
                #region
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    // 跳过非有效数据行
                    var row = table.Rows[i];
                    int result;
                    bool isData = true;
                    if (i >= 2)
                        isData = int.TryParse(row.GetCell(0).GetText(), out result);
                    if (!isData)
                        continue;

                    // 为有效数据行增加 Data节点
                    XmlNode data = null;
                    if (i >= 2 && i != table.Rows.Count - 1 && isData)
                    {
                        data = xml.CreateNode(XmlNodeType.Element, "Data", "");
                        body.AppendChild(data);
                    }

                    for (int j = 0; j < row.GetTableCells().Count; j++)
                    {
                        var cell = row.GetCell(j);
                        if (!list.Contains(cell))
                        {
                            list.Add(cell);

                            if (i == 0)
                            {
                                // 处理表名行
                                var titleText = cell.GetText().Split(' ');
                                year.InnerText = titleText[0];
                                type.InnerText = titleText[1];
                                text.InnerText = titleText[2];
                            }
                            else if (i == 1)
                            {
                                // 处理标题行
                                switch (j)
                                {
                                    case 0:
                                        totalOrder.InnerText = cell.GetText();
                                        break;
                                    case 1:
                                        secondOrder.InnerText = cell.GetText();
                                        break;
                                    case 2:
                                        date.InnerText = cell.GetText();
                                        break;
                                    case 3:
                                        companyName.InnerText = cell.GetText();
                                        break;
                                    case 4:
                                        scope.InnerText = cell.GetText();
                                        break;
                                    case 5:
                                        whyUse.InnerText = cell.GetText();
                                        break;
                                    case 6:
                                        linkMan.InnerText = cell.GetText();
                                        break;
                                    case 7:
                                        phoneNum.InnerText = cell.GetText();
                                        break;
                                    case 8:
                                        address.InnerText = cell.GetText();
                                        break;

                                    default:
                                        break;
                                }
                            }
                            else if (i >= 2 && i != table.Rows.Count - 1 && isData)
                            {
                                // 处理有效数据行
                                switch (j)
                                {
                                    case 0:
                                        var totalOrder1 = xml.CreateNode(XmlNodeType.Element, "TotalOrder", "");
                                        totalOrder1.InnerText = cell.GetText();
                                        data.AppendChild(totalOrder1);
                                        break;
                                    case 1:
                                        var secondOrder1 = xml.CreateNode(XmlNodeType.Element, "SecondOrder", "");
                                        secondOrder1.InnerText = cell.GetText();
                                        data.AppendChild(secondOrder1);
                                        break;
                                    case 2:
                                        var date1 = xml.CreateNode(XmlNodeType.Element, "Date", "");
                                        date1.InnerText = cell.GetText();
                                        data.AppendChild(date1);
                                        break;
                                    case 3:
                                        var companyName1 = xml.CreateNode(XmlNodeType.Element, "CompanyName", "");
                                        companyName1.InnerText = cell.GetText();
                                        data.AppendChild(companyName1);
                                        break;
                                    case 4:
                                        var scope1 = xml.CreateNode(XmlNodeType.Element, "Scope", "");
                                        scope1.InnerText = cell.GetText();
                                        data.AppendChild(scope1);
                                        break;
                                    case 5:
                                        var whyUse1 = xml.CreateNode(XmlNodeType.Element, "WhyUse", "");
                                        whyUse1.InnerText = cell.GetText();
                                        data.AppendChild(whyUse1);
                                        break;
                                    case 6:
                                        var linkMan1 = xml.CreateNode(XmlNodeType.Element, "LinkMan", "");
                                        linkMan1.InnerText = cell.GetText();
                                        data.AppendChild(linkMan1);
                                        break;
                                    case 7:
                                        var phoneNum1 = xml.CreateNode(XmlNodeType.Element, "PhoneNum", "");
                                        phoneNum1.InnerText = cell.GetText();
                                        data.AppendChild(phoneNum1);
                                        break;
                                    case 8:
                                        var address1 = xml.CreateNode(XmlNodeType.Element, "Address", "");
                                        address1.InnerText = cell.GetText();
                                        data.AppendChild(address1);
                                        break;

                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
                #endregion            

                return xml;
            }
        }

        /// <summary>
        /// 获取指定 Word文件中所有 Table的 XML格式表示
        /// </summary>
        private XmlDocument GetTableXml(string wordFile)
        {
            using (FileStream stream = File.OpenRead(wordFile))
            {
                XWPFDocument docx = new XWPFDocument(stream);
                var list = new List<XWPFTableCell>();

                var xml = new XmlDocument();
                var node = xml.CreateNode(XmlNodeType.XmlDeclaration, "", "");
                xml.AppendChild(node);

                var root = xml.CreateNode(XmlNodeType.Element, "Root", "");
                xml.AppendChild(root);

                var title = xml.CreateNode(XmlNodeType.Element, "Title", "");
                var year = xml.CreateNode(XmlNodeType.Element, "Year", "");
                var type = xml.CreateNode(XmlNodeType.Element, "Type", "");
                var text = xml.CreateNode(XmlNodeType.Element, "Text", "");
                root.AppendChild(title);
                title.AppendChild(year);
                title.AppendChild(type);
                title.AppendChild(text);

                var header = xml.CreateNode(XmlNodeType.Element, "Header", "");
                var totalOrder = xml.CreateNode(XmlNodeType.Element, "HTotalOrder", "");
                var secondOrder = xml.CreateNode(XmlNodeType.Element, "HSecondOrder", "");
                var date = xml.CreateNode(XmlNodeType.Element, "HDate", "");
                var companyName = xml.CreateNode(XmlNodeType.Element, "HCompanyName", "");
                var scope = xml.CreateNode(XmlNodeType.Element, "HScope", "");
                var whyUse = xml.CreateNode(XmlNodeType.Element, "HWhyUse", "");
                var linkMan = xml.CreateNode(XmlNodeType.Element, "HLinkMan", "");
                var phoneNum = xml.CreateNode(XmlNodeType.Element, "HPhoneNum", "");
                var address = xml.CreateNode(XmlNodeType.Element, "HAddress", "");
                header.AppendChild(totalOrder);
                header.AppendChild(secondOrder);
                header.AppendChild(date);
                header.AppendChild(companyName);
                header.AppendChild(scope);
                header.AppendChild(whyUse);
                header.AppendChild(linkMan);
                header.AppendChild(phoneNum);
                header.AppendChild(address);
                root.AppendChild(header);

                var body = xml.CreateNode(XmlNodeType.Element, "Body", "");
                root.AppendChild(body);

                foreach (var table in docx.Tables)
                {
                    #region
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        // 跳过非有效数据行
                        var row = table.Rows[i];
                        int result;
                        bool isData = true;
                        if (i >= 2)
                            isData = int.TryParse(row.GetCell(0).GetText(), out result);
                        if (!isData)
                            continue;

                        // 为有效数据行增加 Data节点
                        XmlNode data = null;
                        if (i >= 2 && i != table.Rows.Count - 1 && isData)
                        {
                            data = xml.CreateNode(XmlNodeType.Element, "Data", "");
                            body.AppendChild(data);
                        }

                        for (int j = 0; j < row.GetTableCells().Count; j++)
                        {
                            var cell = row.GetCell(j);
                            if (!list.Contains(cell))
                            {
                                list.Add(cell);

                                if (i == 0)
                                {
                                    // 处理表名行
                                    var titleText = cell.GetText().Split(' ');
                                    year.InnerText = titleText[0];
                                    type.InnerText = titleText[1];
                                    text.InnerText = titleText[2];
                                }
                                else if (i == 1)
                                {
                                    // 处理标题行
                                    switch (j)
                                    {
                                        case 0:
                                            totalOrder.InnerText = cell.GetText();
                                            break;
                                        case 1:
                                            secondOrder.InnerText = cell.GetText();
                                            break;
                                        case 2:
                                            date.InnerText = cell.GetText();
                                            break;
                                        case 3:
                                            companyName.InnerText = cell.GetText();
                                            break;
                                        case 4:
                                            scope.InnerText = cell.GetText();
                                            break;
                                        case 5:
                                            whyUse.InnerText = cell.GetText();
                                            break;
                                        case 6:
                                            linkMan.InnerText = cell.GetText();
                                            break;
                                        case 7:
                                            phoneNum.InnerText = cell.GetText();
                                            break;
                                        case 8:
                                            address.InnerText = cell.GetText();
                                            break;

                                        default:
                                            break;
                                    }
                                }
                                else if (i >= 2 && i != table.Rows.Count - 1 && isData)
                                {
                                    // 处理有效数据行
                                    switch (j)
                                    {
                                        case 0:
                                            var totalOrder1 = xml.CreateNode(XmlNodeType.Element, "TotalOrder", "");
                                            totalOrder1.InnerText = cell.GetText();
                                            data.AppendChild(totalOrder1);
                                            break;
                                        case 1:
                                            var secondOrder1 = xml.CreateNode(XmlNodeType.Element, "SecondOrder", "");
                                            secondOrder1.InnerText = cell.GetText();
                                            data.AppendChild(secondOrder1);
                                            break;
                                        case 2:
                                            var date1 = xml.CreateNode(XmlNodeType.Element, "Date", "");
                                            date1.InnerText = cell.GetText();
                                            data.AppendChild(date1);
                                            break;
                                        case 3:
                                            var companyName1 = xml.CreateNode(XmlNodeType.Element, "CompanyName", "");
                                            companyName1.InnerText = cell.GetText();
                                            data.AppendChild(companyName1);
                                            break;
                                        case 4:
                                            var scope1 = xml.CreateNode(XmlNodeType.Element, "Scope", "");
                                            scope1.InnerText = cell.GetText();
                                            data.AppendChild(scope1);
                                            break;
                                        case 5:
                                            var whyUse1 = xml.CreateNode(XmlNodeType.Element, "WhyUse", "");
                                            whyUse1.InnerText = cell.GetText();
                                            data.AppendChild(whyUse1);
                                            break;
                                        case 6:
                                            var linkMan1 = xml.CreateNode(XmlNodeType.Element, "LinkMan", "");
                                            linkMan1.InnerText = cell.GetText();
                                            data.AppendChild(linkMan1);
                                            break;
                                        case 7:
                                            var phoneNum1 = xml.CreateNode(XmlNodeType.Element, "PhoneNum", "");
                                            phoneNum1.InnerText = cell.GetText();
                                            data.AppendChild(phoneNum1);
                                            break;
                                        case 8:
                                            var address1 = xml.CreateNode(XmlNodeType.Element, "Address", "");
                                            address1.InnerText = cell.GetText();
                                            data.AppendChild(address1);
                                            break;

                                        default:
                                            break;
                                    }
                                }
                            }
                        }
                    }
                    #endregion            
                }

                return xml;
            }
        }

        public string GetYear(XmlDocument xml)
        {
            return xml.SelectSingleNode("//Year").InnerText;
        }

        public string GetType(XmlDocument xml)
        {
            return xml.SelectSingleNode("//Type").InnerText;
        }
        public string GetText(XmlDocument xml)
        {
            return xml.SelectSingleNode("//Text").InnerText;
        }

    }
}
