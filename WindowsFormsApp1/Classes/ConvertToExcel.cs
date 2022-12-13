using ClosedXML.Excel;
using System.Data;

namespace WindowsFormsApp1.Classes
{
    public class ConvertToExcel
    {

        public void ConvertDataTable (DataTable dataTable, string path)
        {
            var workBook = new XLWorkbook();
            var sheet = workBook.Worksheets.Add("login");
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {

                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                   // if (j == 0) sheet.Cell(i + 1, j+1).SetDataType(XLDataType.DateTime);
                    sheet.Cell(i + 1, j + 1).SetValue((dataTable.Rows[i])[j]); 
                }
               


            }


            workBook.SaveAs(path);
        }

    }
}
