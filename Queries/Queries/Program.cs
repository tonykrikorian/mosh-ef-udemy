using System;
using System.Linq;
namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            var courses = context.Courses.Single(x=>x.Id == 2);
            foreach (var item in courses.Tags)
                Console.WriteLine(item.Name);
            Console.ReadKey();
        }
    }
}
