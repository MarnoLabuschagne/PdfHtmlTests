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
                case 2:
                    razorTemplate.helloTemplatePrint("2Marno");
                    break;
                case 3:
                    razorTemplate.printTemplate("3Marno", 4);
                    break;
                case 4:
                    razorTemplate.saveHelloTemplateToStream("4Marno");
                    break;
                case 5:
                    razorTemplate.saveHelloTemplate("helloTemplate.dll");
                    break;
                case 6:
                    razorTemplate.loadHelloTemplate("6Marno", "helloTemplate.dll");
                    break;
                case 7:
                    razorTemplate.saveLongTemplate("basicTestTemplate2.dll");
                    break;
                case 8:
                    razorTemplate.loadLongTemplate("basicTestTemplate2.dll", "8Marno", 5);
                    break;
                default:
                    break;
            }


            


        }
    }
}

