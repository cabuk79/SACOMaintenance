using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.JSInterop;

namespace SACOMaintenance.Blazor.Server.Services
{
    public class FileDownloadService
    {

        private readonly IJSRuntime JSRuntime;

        public FileDownloadService(IJSRuntime jSRuntime)
        {
            JSRuntime = jSRuntime;
        }


        /// <summary>
        /// Download a PDF file form the server
        /// </summary>
        /// <param name="filePath">Enter the full path for the PDF file to download</param>
        /// <returns>Downloads the required PDF file</returns>
        public async Task DownloadPDF(string filePath)
        {
            var baseString = await GetPDF(filePath);

            await JSRuntime.InvokeVoidAsync("downloadPdfTool", "application/pdf", baseString, "test.pdf");
        }

        //TODO: check that the file exists first

        public async Task<string> GetPDF(string filePath)
        {
            var _filePath = filePath;

            using (var fileInput = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
            {
                MemoryStream memoryStream = new MemoryStream();
                await fileInput.CopyToAsync(memoryStream);

                var buffer = memoryStream.ToArray();
                var base64String = Convert.ToBase64String(buffer);
                return Convert.ToBase64String(buffer);
            }
        }
    }
}
