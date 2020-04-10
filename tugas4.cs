using system;
using system collections.Generic;
using system.Linq;
using system.Text;
using system.Threading.Tasks;

namespace Latihanlnheritance
{
public class person
{
public string Name { get; set;}
public int Age { get; set;}
public person(string name = "no name",int age =0)
{
Name = name;
Age = age;

}
public void GetNameAndAge()
{
console.WriteLine("The person has name: {0}")
and age: {1}", Name,Age);
}
}

}
