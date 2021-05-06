using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.DTO;
using ClosedXML.Report;
using ClosedXML.Excel;

namespace ExcelLibs
{
    public class MaintenanceRequestsGraphsExportToExcel
    {

       public void ExportRequestYearMonth(List<YearMonthModel> listYearMonths)
       {
            // var template = new XLTemplate(@"C:\Excel Export Test\Requests Year and Month.xlsx");


            XLWorkbook Workbook = new XLWorkbook(@"C:\Excel Export Test\Requests Year and Month.xlsx");
            IXLWorksheet worksheet = Workbook.Worksheet("Sheet1");



            //using (var workbook = XLWorkbook.OpenFromTemplate(@"C:\Excel Export Test\Requests Year and Month.xlsx"))
            //{
                //var worksheet = workbook.Worksheet(1);

                foreach (var item in listYearMonths)
                {
                    if (item.monthName == "January") { worksheet.Cell("D4").Value = item.monthCount; }
                    if (item.monthName == "Feburary") { worksheet.Cell("D5").Value = item.monthCount; }
                    if (item.monthName == "March") { worksheet.Cell("D6").Value = item.monthCount; }
                    if (item.monthName == "April") { worksheet.Cell("D7").Value = item.monthCount; }
                    if (item.monthName == "May") { worksheet.Cell("D8").Value = item.monthCount; }
                    if (item.monthName == "June") { worksheet.Cell("D9").Value = item.monthCount; }
                    if (item.monthName == "July") { worksheet.Cell("D10").Value = item.monthCount; }
                    if (item.monthName == "August") { worksheet.Cell("D11").Value = item.monthCount; }
                    if (item.monthName == "September") { worksheet.Cell("D12").Value = item.monthCount; }
                    if (item.monthName == "October") { worksheet.Cell("D13").Value = item.monthCount; }
                    if (item.monthName == "November") { worksheet.Cell("D14").Value = item.monthCount; }
                    if (item.monthName == "December") { worksheet.Cell("D15").Value = item.monthCount; }
                }

                Workbook.SaveAs(@"C:\Excel Export Test\Requests Year and Month New.xlsx");
            //}
        }

    }
}
