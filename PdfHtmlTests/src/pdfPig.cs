using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UglyToad.PdfPig.DocumentLayoutAnalysis.TextExtractor;
using UglyToad.PdfPig;

namespace PdfHtmlTests.src
{
    class pdfPig
    {
        public static string getAllText(string filePath)
        {
            using (var document = PdfDocument.Open(filePath))
            {
                string text = "";
                foreach (var page in document.GetPages())
                {
                    text += ContentOrderTextExtractor.GetText(page, true);

                    text += "\n\n===============================\n\n";
                }
                return text;
            }
        }
        public static void printWords(string filePath)
        {
            using (var document = PdfDocument.Open(filePath))
            {
                foreach (var page in document.GetPages())
                {
                    var arr = page.GetWords().ToArray();
                    for (int i = 0; i < page.GetWords().ToArray().Length; i++)
                    {
                        Console.Write(" [" + arr[i] + "]");
                    }
                    Console.Write("\n");
                }
            }
        }
        /*public static string something(string filePath)
        {
            using (var document = PdfDocument.Open(filePath))
            {
                string text = "";
                foreach (var page in document.GetPages())
                {
                    var letters = page.Letters;

                    letters.
                }
                return text;
            }
        }*/
    }
}
