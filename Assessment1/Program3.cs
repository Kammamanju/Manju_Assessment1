using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment1
{
    public class Car
    {
        string Model = "R15";
        int year = 2006;
        public static string Create(string path)
        {
            File.Create("C:/sample");
            return null;
        }
        public static void Write(string path)
        { 
            File.AppendAllText(path, Environment.NewLine + "R152006");
        }
    }
    internal class Program3
    {
        static void Main() {
            Car ob = new Car();
        }
    }
}
