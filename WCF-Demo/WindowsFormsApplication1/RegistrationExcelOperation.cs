using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;
using System.IO;
using System.Xml;


namespace WindowsFormsApplication1
{
    class RegistrationExcelOperation:ExcelOperation
    {
        public XmlDocument GetExcelXml(string file)
        {
            var xml = new XmlDocument();

            using (var fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                IWorkbook workbook = null;
                ISheet sheet = null;

                if (file.IndexOf(".xlsx") > 0)
                {
                    workbook = new XSSFWorkbook(fs);
                }
                else if (file.IndexOf(".xls") > 0)
                {
                    workbook = new HSSFWorkbook(fs);
                }
                else
                {
                    MessageBox.Show("EXCEL文件格式错误");
                    return null;
                }

                sheet = workbook.GetSheetAt(0);

                var node = xml.CreateNode(XmlNodeType.XmlDeclaration, "", "");
                xml.AppendChild(node);

                var root = xml.CreateNode(XmlNodeType.Element, "Root", "");
                xml.AppendChild(root);

                var header = xml.CreateNode(XmlNodeType.Element, "Header", "");
                root.AppendChild(header);

                var body = xml.CreateNode(XmlNodeType.Element, "Body", "");
                root.AppendChild(body);

                var date = xml.CreateNode(XmlNodeType.Element, "HDate", "");
                var contractID = xml.CreateNode(XmlNodeType.Element, "HContractID", "");
                var companyName = xml.CreateNode(XmlNodeType.Element, "HCompanyName", "");
                var goodsName = xml.CreateNode(XmlNodeType.Element, "HGoodsName", "");
                var specifications = xml.CreateNode(XmlNodeType.Element, "HSpecifications", "");
                var singlePrice = xml.CreateNode(XmlNodeType.Element, "HSinglePrice", "");
                var priceUnit = xml.CreateNode(XmlNodeType.Element, "HPriceUnit", "");
                var buyCount = xml.CreateNode(XmlNodeType.Element, "HBuyCount", "");
                var buyCountUnit = xml.CreateNode(XmlNodeType.Element, "HBuyCountUnit", "");
                var totalPrice = xml.CreateNode(XmlNodeType.Element, "HTotalPrice", "");
                var totalPriceUnit = xml.CreateNode(XmlNodeType.Element, "HTotalPriceUnit", "");
                var buyType = xml.CreateNode(XmlNodeType.Element, "HBuyType", "");
                var importanceLevel = xml.CreateNode(XmlNodeType.Element, "HImportanceLevel", "");
                var auditor = xml.CreateNode(XmlNodeType.Element, "HAuditor", "");
                var reason = xml.CreateNode(XmlNodeType.Element, "HReason", "");
                var description = xml.CreateNode(XmlNodeType.Element, "HDescription", "");
                header.AppendChild(date);
                header.AppendChild(contractID);
                header.AppendChild(companyName);
                header.AppendChild(goodsName);
                header.AppendChild(specifications);
                header.AppendChild(singlePrice);
                header.AppendChild(priceUnit);
                header.AppendChild(buyCount);
                header.AppendChild(buyCountUnit);
                header.AppendChild(totalPrice);
                header.AppendChild(totalPriceUnit);
                header.AppendChild(buyType);
                header.AppendChild(importanceLevel);
                header.AppendChild(auditor);
                header.AppendChild(reason);
                header.AppendChild(description);

                var rows = sheet.GetEnumerator();
                while (rows.MoveNext())
                {
                    XmlNode data = null;
                    XmlNode date1 = null;
                    XmlNode contractID1 = null;
                    XmlNode companyName1 = null;
                    XmlNode goodsName1 = null;
                    XmlNode specifications1 = null;
                    XmlNode singlePrice1 = null;
                    XmlNode priceUnit1 = null;
                    XmlNode buyCount1 = null;
                    XmlNode buyCountUnit1 = null;
                    XmlNode totalPrice1 = null;
                    XmlNode totalPriceUnit1 = null;
                    XmlNode buyType1 = null;
                    XmlNode importanceLevel1 = null;
                    XmlNode auditor1 = null;
                    XmlNode reason1 = null;
                    XmlNode description1 = null;

                    if (((IRow)rows.Current).RowNum > 0)
                    {
                        data = xml.CreateNode(XmlNodeType.Element, "Data", "");
                        body.AppendChild(data);

                        date1 = xml.CreateNode(XmlNodeType.Element, "Date", "");
                        contractID1 = xml.CreateNode(XmlNodeType.Element, "ContractID", "");
                        companyName1 = xml.CreateNode(XmlNodeType.Element, "CompanyName", "");
                        goodsName1 = xml.CreateNode(XmlNodeType.Element, "GoodsName", "");
                        specifications1 = xml.CreateNode(XmlNodeType.Element, "Specifications", "");
                        singlePrice1 = xml.CreateNode(XmlNodeType.Element, "SinglePrice", "");
                        priceUnit1 = xml.CreateNode(XmlNodeType.Element, "PriceUnit", "");
                        buyCount1 = xml.CreateNode(XmlNodeType.Element, "BuyCount", "");
                        buyCountUnit1 = xml.CreateNode(XmlNodeType.Element, "BuyCountUnit", "");
                        totalPrice1 = xml.CreateNode(XmlNodeType.Element, "TotalPrice", "");
                        totalPriceUnit1 = xml.CreateNode(XmlNodeType.Element, "TotalPriceUnit", "");
                        buyType1 = xml.CreateNode(XmlNodeType.Element, "BuyType", "");
                        importanceLevel1 = xml.CreateNode(XmlNodeType.Element, "ImportanceLevel", "");
                        auditor1 = xml.CreateNode(XmlNodeType.Element, "Auditor", "");
                        reason1 = xml.CreateNode(XmlNodeType.Element, "Reason", "");
                        description1 = xml.CreateNode(XmlNodeType.Element, "Description", "");
                        data.AppendChild(date1);
                        data.AppendChild(contractID1);
                        data.AppendChild(companyName1);
                        data.AppendChild(goodsName1);
                        data.AppendChild(specifications1);
                        data.AppendChild(singlePrice1);
                        data.AppendChild(priceUnit1);
                        data.AppendChild(buyCount1);
                        data.AppendChild(buyCountUnit1);
                        data.AppendChild(totalPrice1);
                        data.AppendChild(totalPriceUnit1);
                        data.AppendChild(buyType1);
                        data.AppendChild(importanceLevel1);
                        data.AppendChild(auditor1);
                        data.AppendChild(reason1);
                        data.AppendChild(description1);
                    }

                    var row = (IRow)rows.Current;
                    foreach (var cell in row.Cells)
                    {
                        if (row.RowNum == 0)
                        {
                            switch (cell.ColumnIndex)
                            {
                                case 0:
                                    date.InnerText = cell.StringCellValue;
                                    break;
                                case 1:
                                    companyName.InnerText = cell.StringCellValue;
                                    break;
                                case 2:
                                    goodsName.InnerText = cell.StringCellValue;
                                    break;
                                case 3:
                                    specifications.InnerText = cell.StringCellValue;
                                    break;
                                case 4:
                                    singlePrice.InnerText = cell.StringCellValue;
                                    break;
                                case 5:
                                    buyCount.InnerText = cell.StringCellValue;
                                    break;
                                case 6:
                                    buyCountUnit.InnerText = cell.StringCellValue;
                                    break;
                                case 7:
                                    totalPrice.InnerText = cell.StringCellValue;
                                    break;
                                case 8:
                                    reason.InnerText = cell.StringCellValue;
                                    break;

                                default:
                                    break;
                            }
                        }
                        else
                        {
                            if (row.RowNum > 0)
                            {
                                switch (cell.ColumnIndex)
                                {
                                    case 0:
                                        if (cell.CellType == CellType.Numeric)
                                        {
                                            date1.InnerText = cell.NumericCellValue.ToString();
                                        }
                                        else if (cell.CellType == CellType.String)
                                        {
                                            date1.InnerText = cell.StringCellValue;
                                        }
                                        break;
                                    case 1:
                                        if (cell.CellType == CellType.Numeric)
                                        {
                                            companyName1.InnerText = cell.NumericCellValue.ToString();
                                        }
                                        else if (cell.CellType == CellType.String)
                                        {
                                            companyName1.InnerText = cell.StringCellValue;
                                        }
                                        break;
                                    case 2:
                                        if (cell.CellType == CellType.Numeric)
                                        {
                                            goodsName1.InnerText = cell.NumericCellValue.ToString();
                                        }
                                        else if (cell.CellType == CellType.String)
                                        {
                                            goodsName1.InnerText = cell.StringCellValue;
                                        }
                                        break;
                                    case 3:
                                        if (cell.CellType == CellType.Numeric)
                                        {
                                            specifications1.InnerText = cell.NumericCellValue.ToString();
                                        }
                                        else if (cell.CellType == CellType.String)
                                        {
                                            specifications1.InnerText = cell.StringCellValue;
                                        }
                                        break;
                                    case 4:
                                        if (cell.CellType == CellType.Numeric)
                                        {
                                            singlePrice1.InnerText = cell.NumericCellValue.ToString();
                                        }
                                        else if (cell.CellType == CellType.String)
                                        {
                                            singlePrice1.InnerText = cell.StringCellValue;
                                        }
                                        break;
                                    case 5:
                                        if (cell.CellType == CellType.Numeric)
                                        {
                                            buyCount1.InnerText = cell.NumericCellValue.ToString();
                                        }
                                        else if (cell.CellType == CellType.String)
                                        {
                                            buyCount1.InnerText = cell.StringCellValue;
                                        }
                                        break;
                                    case 6:
                                        if (cell.CellType == CellType.Numeric)
                                        {
                                            buyCountUnit1.InnerText = cell.NumericCellValue.ToString();
                                        }
                                        else if (cell.CellType == CellType.String)
                                        {
                                            buyCountUnit1.InnerText = cell.StringCellValue;
                                        }
                                        break;
                                    case 7:
                                        if (cell.CellType == CellType.Numeric)
                                        {
                                            totalPrice1.InnerText = cell.NumericCellValue.ToString();
                                        }
                                        else if (cell.CellType == CellType.String)
                                        {
                                            totalPrice1.InnerText = cell.StringCellValue;
                                        }
                                        break;
                                    case 8:
                                        if (cell.CellType == CellType.Numeric)
                                        {
                                            reason1.InnerText = cell.NumericCellValue.ToString();
                                        }
                                        else if (cell.CellType == CellType.String)
                                        {
                                            reason1.InnerText = cell.StringCellValue;
                                        }
                                        break;

                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            return xml;
        }

    }
}
