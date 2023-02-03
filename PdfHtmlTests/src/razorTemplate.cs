using RazorEngineCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UglyToad.PdfPig.Content;

namespace PdfHtmlTests.src
{
    class razorTemplate
    {
        public razorTemplate() { }

        public static string weirdLongContent()
        {
            string Content = @"
Hello @Model.Name
@foreach(var item in @Model.Items)
{
    <div>- @item</div>
}
<div data-name=""@Model.Name""></div>
<area>
    @{ RecursionTest(@Model.Recursions); }
</area>
@{
	void RecursionTest(int level){
		if (level <= 0)
		{
			return;
		}
			
		<div>LEVEL: @level</div>
		@{ RecursionTest(level - 1); }
	}
}";
            return Content;
        }
        public static IRazorEngineCompiledTemplate getCompiledTemplate(string file)
        {
            try
            {
                IRazorEngineCompiledTemplate loadedTemplate = RazorEngineCompiledTemplate.LoadFromFile(file);
                return loadedTemplate;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static void printTemplate(string name, int recursions)
        {
            IRazorEngine razorEngine = new RazorEngineCore.RazorEngine();
            IRazorEngineCompiledTemplate template = razorEngine.Compile(razorTemplate.weirdLongContent());
            string result = template.Run(new
            {
                Name = name,
                Items = new List<string>()
                        {
                            "item 1",
                            "item 2"
                        },
                Recursions = recursions
            });
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static void helloTemplatePrint(string name)
        {
            IRazorEngine razorEngine = new RazorEngine();
            IRazorEngineCompiledTemplate template = razorEngine.Compile("Hello @Model.Name");

            string result = template.Run(new
            {
                Name = name
            });

            Console.WriteLine(result);
        }

        public static void saveHelloTemplateToStream(string name)
        {
            IRazorEngine razorEngine = new RazorEngine();
            IRazorEngineCompiledTemplate template = razorEngine.Compile("Hello @Model.Name");

            MemoryStream memStrm = new MemoryStream();
            template.SaveToStream(memStrm);
            template.Run(new { Name = name });
            Console.WriteLine(memStrm.ToString());
        }

        public static void saveHelloTemplate(string file)
        {
            IRazorEngine razorEngine = new RazorEngine();
            IRazorEngineCompiledTemplate template = razorEngine.Compile("Hello @Model.Name");
            string result = template.Run(new { Name = "name" });
            
            //template.SaveToFile(file);
            File.WriteAllText(file, result);
            
        }

        public static void loadHelloTemplate(string name, string file)
        {
            try
            {
                IRazorEngineCompiledTemplate loadedTemplate = RazorEngineCompiledTemplate.LoadFromFile(file);
                string result = loadedTemplate.Run(new { Name = name });
                Console.WriteLine(result);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void saveLongTemplate(string file, string name, int recursions)
        {
            IRazorEngine razorEngine = new RazorEngineCore.RazorEngine();
            IRazorEngineCompiledTemplate template = razorEngine.Compile(weirdLongContent());

            string result = template.Run(new
            {
                Name = name,
                Items = new List<string>()
                        {
                            "item 1",
                            "item 2"
                        },
                Recursions = recursions
            });

            //template.SaveToFile(file);
            File.WriteAllText(file, result);
        }
        public static void loadLongTemplate(string file, string name, int recursions)
        {
            try
            {
                IRazorEngineCompiledTemplate loadedTemplate = RazorEngineCompiledTemplate.LoadFromFile(file);
                string result = loadedTemplate.Run(new { 
                    Name = name,
                    Items = new List<string>()
                        {
                            "item 1",
                            "item 2"
                        },
                    Recursions = recursions
                });

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void stringFromRazorPage(string file)
        {
            //File.WriteAllText("IAmHere.txt", "hello!");
            //var page = File.ReadAllText(file);
            IRazorEngine razorEngine = new RazorEngineCore.RazorEngine();
            IRazorEngineCompiledTemplate compilation = razorEngine.Compile(file);
            string result = compilation.Run(new { });
            Console.WriteLine(result);
            //Console.WriteLine($"{page}");
            //RazorEngineTemplateBase templ = new 
        }
    }
}
