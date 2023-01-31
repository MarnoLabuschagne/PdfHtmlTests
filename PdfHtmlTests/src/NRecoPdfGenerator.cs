using RazorEngineCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfHtmlTests.src
{
    class NRecoPdfGenerator
    {
        public static void helloWorld()
        {
            string filePath = "C:\\Users\\malabuschagne\\source\\repos\\PdfHtmlTests\\PdfHtmlTests\\docs\\hello.pdf";
            var htmlContent = String.Format("Hello World: {0}", DateTime.Now);
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            htmlToPdf.GeneratePdf(htmlContent, null, filePath);
            
            //Console.WriteLine(pdfBytes.ToString());
        }

        internal static void htmlTemplateToPdf(string fileName, string fileIn)
        {
            string fileOutPath = "C:\\Users\\malabuschagne\\source\\repos\\PdfHtmlTests\\PdfHtmlTests\\docs\\" + fileName;
            string fileInPath = "C:\\Users\\malabuschagne\\source\\repos\\PdfHtmlTests\\PdfHtmlTests\\bin\\Debug\\net6.0\\" + fileIn;
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            htmlToPdf.GeneratePdfFromFile(fileInPath, null, fileOutPath);
        }
    }
}
