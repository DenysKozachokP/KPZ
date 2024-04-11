using ClassLibraryTask05_06;
namespace task05
{
    class Program
    {
        static void Main(string[] args)
        {
            var paragraph = new LightElementNode("pre", "block", "normal", new List<string> { "paragraph" },new List<LightNode> { new LightTextNode("Lorem ipsum is a placeholder text commonly used \n in the design and printing industries. It's meant to mimic the flow of real text without \n  being readable, making it useful for demonstrating the layout of ") });
            var div = new LightElementNode("div", "block", "normal", new List<string> { "div_block" },new List<LightNode> { new LightTextNode("Lorem ipsum is a placeholder text commonly used \n in the design and printing industries. It's meant to mimic the flow of real text without \n  being readable, making it useful for demonstrating the layout of ") });
            var p = new LightElementNode("p", "block", "normal", new List<string> { "P_lorenm" },new List<LightNode> { new LightTextNode("Lorem ipsum is a placeholder text commonly used \n in the design and printing industries. It's meant to mimic the flow of real text without \n being readable, making it useful for demonstrating the layout of ") });

            Console.WriteLine($"{paragraph.OuterHtml}\n\n\n\n");
            Console.WriteLine($"{div.OuterHtml}\n\n\n\n");
            Console.WriteLine($"{p.OuterHtml}\n\n\n\n");
        }
    }

}