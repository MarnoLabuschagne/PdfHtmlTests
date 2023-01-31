using RazorEngineCore;
using System;
using System.Xml;
using UglyToad.PdfPig;
using UglyToad.PdfPig.DocumentLayoutAnalysis.TextExtractor;
using UglyToad.PdfPig.Util;

namespace PdfHtmlTests.src
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string[] docPath = {
                "C:\\Users\\malabuschagne\\source\\repos\\PdfHtmlTests\\PdfHtmlTests\\docs\\2column.pdf",
                "C:\\Users\\malabuschagne\\source\\repos\\PdfHtmlTests\\PdfHtmlTests\\docs\\basic.pdf"};

            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine(pdfPig.getAllText(docPath[1]));
                    pdfPig.printWords(docPath[0]);
                    break;
                case 11:
                    razorTemplate.helloTemplatePrint("11Marno");
                    break;
                case 12:
                    razorTemplate.printTemplate("12Marno", 4);
                    break;
                case 13:
                    razorTemplate.saveHelloTemplateToStream("13Marno");
                    break;
                case 14:
                    razorTemplate.saveHelloTemplate("helloTemplate.html");
                    break;
                case 15:
                    razorTemplate.loadHelloTemplate("15Marno", "helloTemplate.html");
                    break;
                case 16:
                    razorTemplate.saveLongTemplate("basicTestTemplate2.dll");
                    break;
                case 17:
                    razorTemplate.loadLongTemplate("basicTestTemplate2.dll", "17Marno", 5);
                    break;
                case 21:
                    NRecoPdfGenerator.helloWorld();
                    break;
                case 22:
                    var template = razorTemplate.getTemplate("basicTestTemplate2.dll");
                    NRecoPdfGenerator.htmlTemplateToPdf("helloTemplate.pdf", "helloTemplate.html");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}

