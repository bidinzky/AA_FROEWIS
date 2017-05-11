using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo
{
    class Program
    {
        static string file = "todo.txt";
        static void Main(string[] args)
        {
            if (!System.IO.File.Exists(file))
            {
                System.IO.File.Create(file);
            }
            List<string> txt = new List<string>();
            switch (args[0])
            {
                case "add":
                    txt = System.IO.File.ReadAllLines(file).ToList();
                    txt.Add(args[1]);
                    System.IO.File.WriteAllLines(file, txt.ToArray());
                    break;
                case "remove":
                    txt = System.IO.File.ReadAllLines(file).ToList();
                    txt.Remove(args[1]);
                    System.IO.File.WriteAllLines(file, txt.ToArray());
                    break;
            }
        }
    }
}
