using System;
using System.Linq;
namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            var courses = context.Courses;
            foreach (var item in courses)
                Console.WriteLine(item.Name);
            Console.ReadKey();
        }
    }
}
