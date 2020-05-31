using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Microsoft.Office.Core;

namespace QuanLyNhanSu2
{
    class ClassBaocao
    {
        public void BaoCaoExcel(DataTable dt, string SheetName, string title)
        {
            //Tạo các đối tượng trong Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook book;
            Microsoft.Office.Interop.Excel.Worksheet sheet;

            //tạo mới 1 Exel WorkBook
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;

            book = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = book.Worksheets;
            sheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            sheet.Name = SheetName;
            //tạo phần đầu nếu muốn
            Microsoft.Office.Interop.Excel.Range head = sheet.get_Range("A1", "F1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Tahoma";
            head.Font.Size = "18";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            //Tạo tiêu đề cột
            Microsoft.Office.Interop.Excel.Range cl1 = sheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã nhân sự";
            cl1.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range cl2 = sheet.get_Range("B3", "B3");
            cl2.Value2 = "Họ tên nhân sự";
            cl2.ColumnWidth = 25.5;

            Microsoft.Office.Interop.Excel.Range cl3 = sheet.get_Range("C3", "C3");
            cl3.Value2 = "Số QĐ khen thưởng";
            cl3.ColumnWidth = 18.5;

            Microsoft.Office.Interop.Excel.Range cl4 = sheet.get_Range("D3", "D99");
            cl4.Value2 = "Ngày QĐ khen thưởng";
            cl4.NumberFormat = "m/d/yyyy";
            cl4.ColumnWidth = 29.5;

            Microsoft.Office.Interop.Excel.Range cl5 = sheet.get_Range("E3", "E3");
            cl5.Value2 = "Nội dung";
            cl5.ColumnWidth = 50.0;

            Microsoft.Office.Interop.Excel.Range cl6 = sheet.get_Range("F3", "F3");
            cl6.Value2 = "Hình thức";
            cl6.ColumnWidth = 45.5;

            Microsoft.Office.Interop.Excel.Range rowHead = sheet.get_Range("A3", "F3");
            rowHead.Font.Bold = true;
            //kẻ viền
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            //thiết lập màu nền
            rowHead.Interior.ColorIndex = 15;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //tạo mảng đối tượng để lưu trữ toàn bộ dữ liệu trong Database
            //vì dữ liệu đc gán vào các Cell trong Excel phải thông qua object thuần
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];
            //chuyển dữ liệu từ Database vào mảng đối tượng
            for (int r = 0; r < dt.Rows.Count; r++)
            {
                DataRow dr = dt.Rows[r];
                for (int c = 0; c < dt.Columns.Count; c++)
                {
                    arr[r, c] = dr[c];
                }
            }
            //thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dt.Rows.Count - 1;
            int columnEnd = dt.Columns.Count;
            //Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[rowStart, columnStart];
            //Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[rowEnd, columnEnd];
            //Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = sheet.get_Range(c1, c2);
            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;

            // Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Căn giữa cột STT
            Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[rowEnd, columnStart];
            Microsoft.Office.Interop.Excel.Range c4 = sheet.get_Range(c1, c3);
            sheet.get_Range(c3, c4).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

        }
    }
}
