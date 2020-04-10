using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihanlnheritance
{
public class Student : Person
{
public string Studentld {get; set;}
public string Email {get; set;}
public Student(string name = "no name",int age =
0, string Studentld = "no id", string email= "no email")
{
Name = name;
Age = age;
Studentld = studentld;
Email = email;
}
}
}
