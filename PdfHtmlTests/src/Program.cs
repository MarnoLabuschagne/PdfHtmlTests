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

            Console.WriteLine("1: Read all text from pdf\n" +
                "11: print hello from template\n" +
                "12: print template\n" +
                "13: save Hello template to stream\n" +
                "14: save Hello template as helloTemplate.html\n" +
                "15: load helloTemplate.html\n" +
                "16: save template as basicTestTemplate.html\n" +
                "17: load template basicTestTemplate.html\n" +
                //"18: get string from a razor page\n" +
                "21: save a Hello World pdf\n" +
                "22: convert 'Hello' html to pdf\n" +
                "23: convert longer template html to pfg\n"
                );

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
                    razorTemplate.saveLongTemplate("basicTestTemplate.html", "16Marno", 5);
                    break;
                case 17:
                    razorTemplate.loadLongTemplate("basicTestTemplate.html", "17Marno", 5);
                    break;
                case 18:
                    razorTemplate.stringFromRazorPage("C:\\Users\\malabuschagne\\source\\repos\\PdfHtmlTests\\PdfHtmlTests\\PagesX\\SharedX\\Index.cshtml");
                    break;
                case 21:
                    NRecoPdfGenerator.helloWorld();
                    break;
                case 22:
                    NRecoPdfGenerator.htmlTemplateToPdf("helloTemplate.pdf", "helloTemplate.html");
                    break;
                case 23:
                    NRecoPdfGenerator.htmlTemplateToPdf("basicTestTemplate2.pdf", "basicTestTemplate2.html");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}

