using RazorEngineCore;
using System;
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

            int choice = 3;

            switch (choice)
            {
                case 1:
                    Console.WriteLine(pdfPig.getAllText(docPath[1]));
                    pdfPig.printWords(docPath[0]);
                    break;
                case 2:
                    razorTemplate.helloTemplatePrint("Marno");
                    break;
                case 3:
                    razorTemplate.printWeirdLongContent("Marno", 4);
                    break;
                default:
                    break;
            }


            


        }
    }
}

