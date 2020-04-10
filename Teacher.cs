using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihanlnheritance
{
public class Teacher : Person
{
public string Teacherld {get; set;}
public string Subject {get; set;}
public Teacher(string name= "no name",int age =
0,string teacherld = "no id", string subject = "no
subject")
{
    Name = name;
    Age = age;
    Teacherld = teacherld;
    Subject = subject;
}
}
}
