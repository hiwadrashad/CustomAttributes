using System;
using System.Linq;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class CustomAttribtie : Attribute
{ 
   public string a { get; set; }
    public CustomAttribtie(string text)
    {
        a = text;
        Console.WriteLine(a);
    }
}

namespace CustomAttributes
{

    public class Program
    {
        [CustomAttribtie("test")]
        public static void Main(string[] args)
        {
            //<summary>
            // usage of reflection without use
            //<summary>
            var testSuites = from t in Assembly.GetExecutingAssembly().GetTypes()
                             where t.GetCustomAttributes().Any(a => a is CustomAttribtie)
                             select t;

            typeof(Program).GetCustomAttributes(false);
          
        }
    }
}
