using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem04HTMLDispatcher
{
    class Problem04HTMLDispatcher
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");

            Console.WriteLine(div);
            Console.WriteLine();
            Console.WriteLine(div * 2);
            Console.WriteLine();
            Console.WriteLine(div * 3);


        }
    }
}
