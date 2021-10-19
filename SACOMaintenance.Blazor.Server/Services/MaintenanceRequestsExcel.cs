using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SACOMaintenance.Common.ModelDB;
using ClosedXML.Report;
using System.Threading.Tasks;
using System.IO;
using Microsoft.JSInterop;


namespace SACOMaintenance.Blazor.Server.Services
{
    public class MaintenanceRequestsExcel
    {

        private readonly IJSRuntime JSRuntime;

        public MaintenanceRequestsExcel(IJSRuntime jSRuntime)
        {
            JSRuntime = jSRuntime;
        }

        public void ExportSingalReqest(MaintRequestInitiation maintReqSingle, ObservableCollection<MaintRequestInitiationRisk> maintReqRiskList)
        {
            var template = new XLTemplate(@"C:\Excel Export Test\TestRequest.xlsx");

            template.AddVariable(maintReqSingle);
            template.Generate();
            template.SaveAs(@"C:\Excel Export Test\New Report " + maintReqSingle.Id + ".xlsx");

            //open the excel file and loop through and set the risks
            using(var workbook = XLWorkbook.OpenFromTemplate(@"C:\Excel Export Test\New Report " + maintReqSingle.Id + ".xlsx"))
            {
                var worksheet = workbook.Worksheet(1);

                //loop through the risks and put into the correct position
                foreach(var item in maintReqSingle.Risks)
                {
                    var riskId = item.Id;

                    //loop through the risk link table to get the set level of risk
                    foreach(var itemRisk in maintReqRiskList)
                    {
                        if(itemRisk.RiskId == item.Id)
                        {
                            //switch(item.RiskName)
                            //{
                            //    case "Slips, trips and falls":
                            //        if (itemRisk.RiskLevel == "H") { worksheet.Cell("C18").Value = "X";  }
                            //        if (itemRisk.RiskLevel == "M") { worksheet.Cell("D18").Value = "X"; }
                            //        if (itemRisk.RiskLevel == "L") { worksheet.Cell("E18").Value = "X"; }
                            //        break;
                            //    case "Falls from height":
                            //        if (itemRisk.RiskLevel == "H") { worksheet.Cell("C19").Value = "X"; }
                            //        if (itemRisk.RiskLevel == "M") { worksheet.Cell("D19").Value = "X"; }
                            //        if (itemRisk.RiskLevel == "L") { worksheet.Cell("E19").Value = "X"; }
                            //        break;
                            //    case "Contact with moving machinery":
                            //        if (itemRisk.RiskLevel == "H") { worksheet.Cell("C20").Value = "X"; }
                            //        if (itemRisk.RiskLevel == "M") { worksheet.Cell("D20").Value = "X"; }
                            //        if (itemRisk.RiskLevel == "L") { worksheet.Cell("E20").Value = "X"; }
                            //        break;
                            //    case "Electrical":
                            //        if (itemRisk.RiskLevel == "H") { worksheet.Cell("C21").Value = "X"; }
                            //        if (itemRisk.RiskLevel == "M") { worksheet.Cell("D21").Value = "X"; }
                            //        if (itemRisk.RiskLevel == "L") { worksheet.Cell("E21").Value = "X"; }
                            //        break;
                            //}
                        }
                    }
                }

                workbook.SaveAs(@"C:\Excel Export Test\New Report " + maintReqSingle.Id + "trtrtr.xlsx");
            }
        }
    
         

        public async Task ExportListToExcel(ObservableCollection<MaintRequestInitiation> exportList)
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

                //Download the excel file to the users download default lcoation
                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    var fileName = "Maintenance Request Export " + DateTime.Now.ToString("dd-MM-yyyy") + " .xlsx"; //TODO: see if this format can be changed in the app settings?
                    await JSRuntime.InvokeAsync<object>("saveAsFile", fileName, Convert.ToBase64String(content));
                } 
            }
        }

        public async Task<string> GetPDF()
        {
            var filePath = @"C:\Excel Export Test\test.pdf";

            //await JSRuntime.InvokeVoidAsync("downloadPdfTool", @"C:\Excel Export Test\test.pdf", ""); //, @"C:\Excel Export Test\test.pdf");
            using (var fileInput = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                MemoryStream memoryStream = new MemoryStream();
                await fileInput.CopyToAsync(memoryStream);

                var buffer = memoryStream.ToArray();
                var base64String = Convert.ToBase64String(buffer);
                return Convert.ToBase64String(buffer);
            }

            //await JSRuntime.InvokeVoidAsync("downloadPdfTool", "application/pdf", base64String, ); //, @"C:\Excel Export Test\test.pdf");
        }

        public async Task DownloadPDF()
        {
            var baseString = await GetPDF();

            await JSRuntime.InvokeVoidAsync("downloadPdfTool", "application/pdf", baseString, "test.pdf");
        }
    }  
}
