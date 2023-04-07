using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;                           
using OfficeOpenXml;
using NPOI;
using NPOI.SS.Formula.Functions;        

                                namespace Excel_Export
{
    internal class Program
    {
        public static void Main(string[] argv) { 
        
            ExcelPackage package = new ExcelPackage();
            var sheet = package.Workbook.Worksheets.Add("sheet");

            for (var i = 0; i < 10; ++i)
            {
                sheet.Cells[1, i+1].Value = 10;
            }
            

            package.SaveAs("C:\\Users\\joudia\\Desktop\\Data\\work.xlsx");
            System.Diagnostics.Process.Start("C:\\Users\\joudia\\Desktop\\Data\\work.xlsx");

        }
    }
}
