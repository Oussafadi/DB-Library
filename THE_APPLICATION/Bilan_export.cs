using lm =  DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;
using System.Windows.Forms;
using System.ComponentModel.Design.Serialization;
using System.Windows.Ink;
using System.Drawing;
using OfficeOpenXml.Style;
using Microsoft.Office.Interop.Excel;
using MODELES;

namespace THE_APPLICATION
{
    public partial class Bilan_annuel
    {
        private void export_button_Click(object sender, EventArgs e)
        {
            export_callback(dataGridView1);

        }
        private void export_callback(DataGridView grid) {

            // init
            ExcelPackage package = new ExcelPackage();
            ExcelWorkbook wb = package.Workbook;
            var sheet = wb.Worksheets.Add(elvSelected.code);
            string XLSX_FILE = Config.DATA_FOLDER + @"\" + filSelected.code + "_" + nvSelected + ".xlsx";

            int line = 2;
            int colomn_offset = 3;
            //-----

            // eleve info section
            ExcelRange info_area = sheet.Cells[line, colomn_offset, line, colomn_offset + 3];
            info_area.Merge = true;
            info_area.Value = elvSelected.ToString();
            info_area.Style.Fill.PatternType = ExcelFillStyle.Solid;
            info_area.Style.Fill.BackgroundColor.SetColor(Color.LightSeaGreen);

            line += 2;
            //-------------------

            // header section 
            for (var i=0; i<grid.Columns.Count; ++i) {
                sheet.Cells[line , i + colomn_offset].Value = grid.Columns[i].Name.ToUpper().Replace('_', ' ');
            }
            line += 2;
            //-------------------

            for (int row = 0; row<grid.Rows.Count; ++row ) {
                for (int col = 0; col < grid.Rows[row].Cells.Count; ++col)
                {
                    sheet.Cells[row+line, col+colomn_offset].Value = grid.Rows[row].Cells[col].Value;
                    if (col == grid.Rows[row].Cells.Count - 1) {
                        sheet.Cells[row + line, col + colomn_offset].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        sheet.Cells[row + line, col + colomn_offset].Style.Fill.BackgroundColor.SetColor(Color.LightSalmon);
                    }
                }
                line++;
            }
            line += 2;

            // looking for the moy
            Dictionary<string, object> rules = new Dictionary<string, object>()
            {
                ["code_eleve"] = elvSelected.code,
                ["code_filiere"] = filSelected.code,
                ["niveau"] = nvSelected.ToString()
            };
            //-------------------

            sheet.Cells[line, grid.ColumnCount - 2 + colomn_offset].Value = "Moyenne genaral";
            sheet.Cells[line, grid.ColumnCount - 1 + colomn_offset].Value =+ ((Moyenne)lm.Model.select<Moyenne>(rules)[0]).moyenne;

            sheet.Columns[1 , 20].AutoFit();
            package.SaveAs(XLSX_FILE);

            System.Diagnostics.Process.Start(XLSX_FILE);
        }
    }
}
