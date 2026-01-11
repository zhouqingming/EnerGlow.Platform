using EnerGlow.Core.Shared.Extensions;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnerGlow.Core.Shared.Helper
{
    /// <summary>
    /// Excel文件操作类,不依赖MS的Office COM组件
    /// </summary>
    public class ExcelHelper
    {

        /// <summary>
        /// 导出excel文件内存流
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">需要导出的列表数据</param>
        /// <param name="sheetName">工作簿名称</param>
        /// <param name="isDesToColName">是否使用实体的描述说明作列名</param>
        ///  <param name="headTitle">表头标题</param>
        /// <returns></returns>
        public static MemoryStream ExportToStream<T>(List<T> data, bool isDesToColName = false,
            string headTitle = null, string sheetName = "sheet1") where T : new()
        {
            if (data == null || data.Count <= 0)
                return null;
            Dictionary<string, string> columnNames = null;
            if (isDesToColName)
                columnNames = PropertiesDesToDict(typeof(T));
            return ExportToStream(data, columnNames, headTitle, sheetName);
        }

        /// <summary>
        /// 导出excel文件内存流
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">需要导出的列表数据</param>
        /// <param name="sheetName">工作簿名称</param>
        /// <param name="columnNames">需要自定义的字段和表头值对应关系</param>
        /// <param name="headTitle">表头标题</param>
        /// <returns></returns>
        public static MemoryStream ExportToStream<T>(List<T> data, Dictionary<string, string> columnNames = null,
            string headTitle = null, string sheetName = "sheet1") where T : new()
        {
            if (data == null || data.Count <= 0)
                return null;
            using (var package = new ExcelPackage())
            {
                GenerateWorkbook(package, data, columnNames, headTitle, sheetName);
                return new MemoryStream(package.GetAsByteArray());
            }
        }

        /// <summary>
        /// 导出excel文件内存流
        /// </summary>
        /// <param name="data">需要导出的表结构数据</param>
        /// <param name="headTitle">表头标题</param>
        /// <param name="sheetName">工作簿名称</param>
        /// <returns></returns>
        public static MemoryStream ExportToStream(DataTable data, string headTitle = null, string sheetName = "sheet1")
        {
            if (data == null || data.Rows.Count <= 0)
                return null;
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(sheetName);
                DefaultBodyStyle(worksheet);
                int tableStartRowNum = string.IsNullOrWhiteSpace(headTitle) ? 1 : 2;
                if (tableStartRowNum == 2)
                {
                    worksheet.Cells[1, 1].Value = headTitle;
                    worksheet.Cells[1, 1, 1, data.Columns.Count].Merge = true;
                    DefaultTitleStyle(worksheet, 1, 1);
                }
                for (int i = 0; i < data.Columns.Count; i++)
                {
                    worksheet.Cells[tableStartRowNum, i + 1].Value = data.Columns[i].ColumnName;
                    DefaultColHeadStyle(worksheet, tableStartRowNum, i + 1);
                }

                for (int i = 0; i < data.Rows.Count; i++)
                {
                    for (int j = 0; j < data.Columns.Count; j++)
                    {
                        if (Decimal.TryParse(data.Rows[i][j] + "", out decimal obj))
                            worksheet.Cells[i + tableStartRowNum + 1, j + 1].Value = obj;
                        else
                            worksheet.Cells[i + tableStartRowNum + 1, j + 1].Value = data.Rows[i][j];
                        DefaultBodyStyle(worksheet, i + tableStartRowNum + 1, j + 1);
                    }
                }
                for (int i = 0; i < worksheet.Dimension.End.Row; i++)
                    worksheet.Row(i + 1).Height = 24;
                return new MemoryStream(package.GetAsByteArray());
            }
            //if (data == null || data.Rows.Count <= 0)
            //    return null;
            //using (var package = new ExcelPackage())
            //{
            //    var worksheet = package.Workbook.Worksheets.Add(sheetName);
            //    DefaultBodyStyle(worksheet);
            //    int tableStartRowNum = 1;
            //    if (string.IsNullOrWhiteSpace(headTitle))
            //        worksheet.Cells.LoadFromDataTable(data, true);
            //    else
            //    {
            //        tableStartRowNum = 2;
            //        worksheet.Cells["A2"].LoadFromDataTable(data, true);
            //        worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column].Merge = true;
            //        worksheet.Cells[1, 1].Value = headTitle;
            //        DefaultTitleStyle(worksheet, 1, 1);
            //    }
            //    for (int i = 0; i < worksheet.Dimension.End.Column; i++)
            //        DefaultColHeadStyle(worksheet, tableStartRowNum, i + 1);
            //    for (int i = 0; i < worksheet.Dimension.End.Row; i++)
            //        worksheet.Row(i + 1).Height = 24;
            //    return new MemoryStream(package.GetAsByteArray());
            //}
        }

        /// <summary>
        /// 导出默认的excel文件内存流，即空的excel文件内存流
        /// </summary>
        /// <param name="sheetName"></param>
        /// <param name="headTitle"></param>
        /// <returns></returns>
        public static MemoryStream ExportDefaultStream(string sheetName = "sheet1", string headTitle = null)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(sheetName);
                if (!string.IsNullOrWhiteSpace(headTitle))
                    worksheet.Cells[1, 1].Value = headTitle;
                return new MemoryStream(package.GetAsByteArray());
            }
        }

        /// <summary>
        /// 导出excel文件到本地
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data">需要导出的列表数据</param>
        /// <param name="filePath">文件路径</param>
        /// <param name="sheetName">工作簿名称</param>
        /// <param name="isDesToColName">是否使用实体的描述说明作列名</param>
        ///  <param name="headTitle">表头标题</param>
        /// <returns></returns>
        public static void ExportToDisk<T>(List<T> data, string filePath, bool isDesToColName = false,
            string headTitle = null, string sheetName = "sheet1") where T : new()
        {
            if (data == null || data.Count <= 0)
                return;
            Dictionary<string, string> columnNames = null;
            if (isDesToColName)
                columnNames = PropertiesDesToDict(typeof(T));
            FileInfo file = new FileInfo(filePath);
            using (var package = new ExcelPackage(file))
            {
                GenerateWorkbook(package, data, columnNames, headTitle, sheetName);
                package.Save();
            }
        }

        /// <summary>
        /// 导出excel文件到本地
        /// </summary>
        /// <param name="data">需要导出的表结构数据</param>
        /// <param name="filePath">文件路径</param>
        /// <param name="headTitle">表头标题</param>
        /// <param name="sheetName">工作簿名称</param>
        public static void ExportToDisk(DataTable data, string filePath, string headTitle = null, string sheetName = "sheet1")
        {
            if (data == null || data.Rows.Count <= 0)
                return;
            FileInfo file = new FileInfo(filePath);
            using (var package = new ExcelPackage(file))
            {
                var worksheet = package.Workbook.Worksheets.Add(sheetName);
                DefaultBodyStyle(worksheet);
                int tableStartRowNum = 1;
                if (string.IsNullOrWhiteSpace(headTitle))
                    worksheet.Cells.LoadFromDataTable(data, true);
                else
                {
                    tableStartRowNum = 2;
                    worksheet.Cells["A2"].LoadFromDataTable(data, true);
                    worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column].Merge = true;
                    worksheet.Cells[1, 1].Value = headTitle;
                    DefaultTitleStyle(worksheet, 1, 1);
                }
                for (int i = 0; i < worksheet.Dimension.End.Column; i++)
                    DefaultColHeadStyle(worksheet, tableStartRowNum, i + 1);
                for (int i = 0; i < worksheet.Dimension.End.Row; i++)
                    worksheet.Row(i + 1).Height = 24;
                package.Save();
            }
        }

        /// <summary>
        /// 从Excel中加载数据（泛型）
        /// </summary>
        /// <typeparam name="T">每行数据的类型</typeparam>
        /// <param name="filePath">文件路径</param>
        /// <param name="isDesToColName">是否使用实体的描述说明作列名</param>
        /// <param name="sheetName">要加载的工作簿名称,默认为第一个</param>
        /// <returns></returns>
        public static IEnumerable<T> LoadFromExcel<T>(string filePath, bool isDesToColName = false, string sheetName = null) where T : new()
        {
            var file = new FileInfo(filePath);
            var list = new List<T>();
            Dictionary<string, int> dictHeader = new Dictionary<string, int>();
            using (ExcelPackage package = new ExcelPackage(file))
            {
                var worksheet = string.IsNullOrWhiteSpace(sheetName) ? package.Workbook.Worksheets[0] : package.Workbook.Worksheets[sheetName];
                int colStart = worksheet.Dimension.Start.Column;
                int colEnd = worksheet.Dimension.End.Column;
                int rowStart = worksheet.Dimension.Start.Row;
                int rowEnd = worksheet.Dimension.End.Row;
                for (int i = colStart; i <= colEnd; i++)
                    dictHeader[worksheet.Cells[rowStart, i].Value.ToString()] = i;
                var properties = typeof(T).GetProperties();
                for (int row = rowStart + 1; row <= rowEnd; row++)
                {
                    T model = new T();
                    foreach (var propertyInfo in properties)
                    {
                        var col = isDesToColName ? dictHeader[propertyInfo.GetDescriptionName()] : dictHeader[propertyInfo.Name];
                        ExcelRange cell = worksheet.Cells[row, col];
                        if (cell.Value == null)
                            continue;
                        propertyInfo.SetValue(model, Convert.ChangeType(cell.Value, propertyInfo.PropertyType), null);
                    }
                    list.Add(model);
                }
                return list;
            }
        }

        /// <summary>
        /// 从Excel内存流中加载数据（泛型）
        /// </summary>
        /// <typeparam name="T">每行数据的类型</typeparam>
        /// <param name="memoryStream">Excel内存流</param>
        /// <param name="isDesToColName">是否使用实体的描述说明作列名</param>
        /// <param name="sheetName">要加载的工作簿名称,默认为第一个</param>
        /// <returns></returns>
        public static IEnumerable<T> LoadFromExcelStream<T>(MemoryStream memoryStream, bool isDesToColName = false, string sheetName = null) where T : new()
        {
            var list = new List<T>();
            Dictionary<string, int> dictHeader = new Dictionary<string, int>();
            using (ExcelPackage package = new ExcelPackage(memoryStream))
            {
                var worksheet = string.IsNullOrWhiteSpace(sheetName) ? package.Workbook.Worksheets[0] : package.Workbook.Worksheets[sheetName];
                int colStart = worksheet.Dimension.Start.Column;
                int colEnd = worksheet.Dimension.End.Column;
                int rowStart = worksheet.Dimension.Start.Row;
                int rowEnd = worksheet.Dimension.End.Row;
                for (int i = colStart; i <= colEnd; i++)
                {
                    if (worksheet.Cells[rowStart, i]?.Value != null && !string.IsNullOrWhiteSpace(worksheet.Cells[rowStart, i].Value.ToString()))
                        dictHeader[worksheet.Cells[rowStart, i].Value.ToString()] = i;
                }
                var properties = typeof(T).GetProperties();
                for (int row = rowStart + 1; row <= rowEnd; row++)
                {
                    T model = new T();
                    foreach (var propertyInfo in properties)
                    {
                        var col = isDesToColName ? dictHeader[propertyInfo.GetDescriptionName()] : dictHeader[propertyInfo.Name];
                        ExcelRange cell = worksheet.Cells[row, col];
                        if (cell.Value == null)
                            continue;
                        propertyInfo.SetValue(model, Convert.ChangeType(cell.Value, propertyInfo.PropertyType), null);
                    }
                    list.Add(model);
                }
                return list;
            }
        }

        /// <summary>
        /// 从Excel内存流中加载数据
        /// </summary>
        /// <param name="memoryStream">Excel内存流</param>
        /// <param name="sheetName">要加载的工作簿名称,默认为第一个</param>
        /// <returns></returns>
        public static DataTable LoadFromExcelStream(MemoryStream memoryStream, string sheetName = null)
        {
            using (ExcelPackage package = new ExcelPackage(memoryStream))
            {
                var worksheet = string.IsNullOrWhiteSpace(sheetName) ? package.Workbook.Worksheets[0] : package.Workbook.Worksheets[sheetName];
                int rows = worksheet.Dimension.End.Row;
                int cols = worksheet.Dimension.End.Column;
                DataTable dt = new DataTable(worksheet.Name);
                DataRow dr = null;
                for (int i = 1; i <= rows; i++)
                {
                    if (i > 1)
                        dr = dt.Rows.Add();
                    for (int j = 1; j <= cols; j++)
                    {
                        if (i == 1)
                            dt.Columns.Add(worksheet.Cells[i, j].Value.ToString());
                        else
                            dr[j - 1] = worksheet.Cells[i, j].Value;
                    }
                }
                return dt;
            }
        }

        #region Helper

        /// <summary>
        /// 生成workbook,默认样式
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="package"></param>
        /// <param name="data"></param>
        /// <param name="columnNames"></param>
        /// <param name="headTitle"></param>
        /// <param name="sheetName"></param>
        private static void GenerateWorkbook<T>(ExcelPackage package, List<T> data, Dictionary<string, string> columnNames, string headTitle, string sheetName)
        {
            var worksheet = package.Workbook.Worksheets.Add(sheetName);
            DefaultBodyStyle(worksheet);
            int tableStartRowNum = 1;
            if (string.IsNullOrWhiteSpace(headTitle))
                worksheet.Cells.LoadFromCollection(data, true);
            else
            {
                tableStartRowNum = 2;
                worksheet.Cells["A2"].LoadFromCollection(data, true);
                worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column].Merge = true;
                worksheet.Cells[1, 1].Value = headTitle;
                DefaultTitleStyle(worksheet, 1, 1);
            }
            for (int i = 0; i < worksheet.Dimension.End.Column; i++)
            {
                DefaultColHeadStyle(worksheet, tableStartRowNum, i + 1);
                var name = worksheet.Cells[tableStartRowNum, i + 1].Value?.ToString();
                if (columnNames != null && !string.IsNullOrWhiteSpace(name) && columnNames.ContainsKey(name))
                    worksheet.Cells[tableStartRowNum, i + 1].Value = columnNames[name];
            }
            for (int i = 0; i < worksheet.Dimension.End.Row; i++)
                worksheet.Row(i + 1).Height = 24;
        }

        /// <summary>
        /// 实体属性转字典
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static Dictionary<string, string> PropertiesDesToDict(Type type)
        {
            var columnNames = new Dictionary<string, string>();
            var properties = type.GetProperties();
            foreach (var propertyInfo in properties)
            {
                var desName = propertyInfo.GetDescriptionName();
                columnNames.Add(propertyInfo.Name, string.IsNullOrWhiteSpace(desName) ? propertyInfo.Name : desName);
            }
            return columnNames;
        }

        /// <summary>
        /// 默认的body样式
        /// </summary>
        /// <param name="worksheet"></param>
        private static void DefaultBodyStyle(ExcelWorksheet worksheet)
        {
            worksheet.Cells.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            worksheet.Cells.Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            worksheet.Cells.Style.Border.Left.Style = ExcelBorderStyle.Thin;
            worksheet.Cells.Style.Border.Right.Style = ExcelBorderStyle.Thin;
            worksheet.Cells.Style.Border.Top.Style = ExcelBorderStyle.Thin;
            worksheet.Cells.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            worksheet.Cells.Style.Font.Name = "宋体";
            worksheet.Cells.Style.Font.Size = 10;
            worksheet.Cells.Style.WrapText = true;
            //worksheet.DefaultRowHeight = 24;
        }

        /// <summary>
        /// 默认的body样式
        /// </summary>
        /// <param name="worksheet"></param>
        private static void DefaultBodyStyle(ExcelWorksheet worksheet, int rowIndex, int columnIndex)
        {
            worksheet.Cells[rowIndex, columnIndex].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            worksheet.Cells[rowIndex, columnIndex].Style.VerticalAlignment = ExcelVerticalAlignment.Center;
            worksheet.Cells[rowIndex, columnIndex].Style.Border.Left.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[rowIndex, columnIndex].Style.Border.Right.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[rowIndex, columnIndex].Style.Border.Top.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[rowIndex, columnIndex].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
            worksheet.Cells[rowIndex, columnIndex].Style.Font.Name = "宋体";
            worksheet.Cells[rowIndex, columnIndex].Style.Font.Size = 10;
            worksheet.Cells.Style.WrapText = true;
            //worksheet.DefaultRowHeight = 24;
        }

        /// <summary>
        /// 默认标题样式
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="rowIndex"></param>
        /// <param name="columnIndex"></param>
        private static void DefaultTitleStyle(ExcelWorksheet worksheet, int rowIndex, int columnIndex)
        {
            worksheet.Cells[rowIndex, columnIndex].Style.Font.Size = 16;
            worksheet.Cells[rowIndex, columnIndex].Style.Font.Bold = true;
        }

        /// <summary>
        /// 默认列头样式
        /// </summary>
        /// <param name="worksheet"></param>
        /// <param name="rowIndex"></param>
        /// <param name="columnIndex"></param>
        private static void DefaultColHeadStyle(ExcelWorksheet worksheet, int rowIndex, int columnIndex)
        {
            worksheet.Cells[rowIndex, columnIndex].Style.Font.Size = 12;
            worksheet.Cells[rowIndex, columnIndex].Style.Font.Bold = true;
            worksheet.Column(columnIndex).Width = 25;
        }

        #endregion
    }
}
