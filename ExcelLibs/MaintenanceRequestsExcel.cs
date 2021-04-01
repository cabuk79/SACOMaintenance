using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SACOMaintenance.Common.ModelDB;

namespace ExcelLibs
{
    public class MaintenanceRequestsExcel
    {
        public void ExportListToExcel(ObservableCollection<MaintRequestInitiation> exportList)
       {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Maint Requests All");

                worksheet.Cell("A1").Value = "All Maintenance Requests";
                worksheet.Cell("A1").Style.Font.Bold = true;
                worksheet.Cell("A1").Style.Font.FontSize = 20;
                worksheet.Range("A1", "E1").Merge(true);

                worksheet.Cell("A2").Value = "Id";
                worksheet.Cell("A2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                worksheet.Cell("A2").Style.Font.Bold = true;

                worksheet.Cell("B2").Value = "Details";
                worksheet.Cell("B2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                worksheet.Cell("B2").Style.Font.Bold = true;

                worksheet.Cell("C2").Value = "Date Raised";
                worksheet.Cell("C2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                worksheet.Cell("C2").Style.Font.Bold = true;

                worksheet.Cell("D2").Value = "Equipment Name";
                worksheet.Cell("D2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                worksheet.Cell("D2").Style.Font.Bold = true;

                worksheet.Cell("E2").Value = "Status";
                worksheet.Cell("E2").Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                worksheet.Cell("E2").Style.Font.Bold = true;

                worksheet.Column(1).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                worksheet.Column(3).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                worksheet.Column(4).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);
                worksheet.Column(5).Style.Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                worksheet.Range("A2", "E2").SetAutoFilter();

                //loop through the collection and put the items in columns then increment to the next row
                var i = 3; //declare the row number to start

                //loop through the items in the list
                foreach(var item in exportList)
                {
                    worksheet.Cell("A" + i).Value = item.Id;
                    worksheet.Cell("B" + i).Value = item.RequestDetails;
                    worksheet.Cell("C" + i).Value = item.DateRaised;
                    worksheet.Cell("D" + i).Value = item.Equipment.Name;
                    worksheet.Cell("E" + i).Value = item.Status.StatusName;
                    i++;
                }

                worksheet.Columns("A", "E").AdjustToContents();

                workbook.SaveAs(@"C:\Excel Export Test\All Maint Requests.xlsx");
            }
        }

    }
}
