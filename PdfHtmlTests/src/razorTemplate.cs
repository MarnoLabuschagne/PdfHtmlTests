using RazorEngineCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void printWeirdLongContent(string name, int recursions)
        {
            IRazorEngine razorEngine = new RazorEngine();
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
    }
}
