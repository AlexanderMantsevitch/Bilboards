using ClosedXML.Excel;
using ExcelDataReader;
using System.Data;
using System.IO;

namespace WindowsFormsApp1.Classes
{
    public abstract class ConvertExcel
    {

        public static void DataTableInExcel (DataTable dataTable, string path)
        {
            var workBook = new XLWorkbook();
            var sheet = workBook.Worksheets.Add("login");

            for (int j = 0; j < dataTable.Columns.Count; j++)
            {
                // if (j == 0) sheet.Cell(i + 1, j+1).SetDataType(XLDataType.DateTime);
                sheet.Cell(1, j + 1).SetValue(dataTable.Columns[j].ColumnName);
            }


            for (int i = 0; i < dataTable.Rows.Count; i++)
            {

                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                   // if (j == 0) sheet.Cell(i + 1, j+1).SetDataType(XLDataType.DateTime);
                    sheet.Cell(i + 2, j + 1).SetValue((dataTable.Rows[i])[j]); 
                }
               


            }


            workBook.SaveAs(path);
        }

        public static DataTable ExcelInDataTable (string path)
        {
            DataTable dataTable = new DataTable();
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);

            DataSet table = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (x) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true

                }


            }) ;
            stream?.Close();
            dataTable = table.Tables[0];
            return dataTable;
        }

    }
}
