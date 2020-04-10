using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihanlnheritance
{
class program
{
static void Main(string[] args)
{
     Person person = new Person ("Erika",19);
     person.GetNameAndAge();
     Console.WriteLine();
     Teacher teacher = new
Teacher("Kamarudin",35,"190302","Pemrograman");
    teacher.GetNameAndAge();
    Console.WriteLine();
    Student student = new Student("Erika",19,
    "19.11.2633",
    "erika.putri@students.amikom.ac.id");
       student.GetNameAndAge();

       Console.ReadKey();
}
}
}
