using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Yojana_chapter3   // Your main namespace
{
    namespace OuterNamespace
    {
        // Inner (Nested) Namespace
        namespace InnerNamespace
        {
            class Demo
            {
                public void Show()
                {
                    Console.WriteLine("Inside Nested Namespace");
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Creating object using full namespace
            OuterNamespace.InnerNamespace.Demo obj = new OuterNamespace.InnerNamespace.Demo();
            obj.Show();
        }
    }
}