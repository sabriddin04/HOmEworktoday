
var p1=new Person();

System.Console.WriteLine("Your name:");
string name=Console.ReadLine();
System.Console.WriteLine("Your surname:");
string surname=Console.ReadLine();
System.Console.WriteLine(p1.GetFullName(name,surname));
System.Console.WriteLine("Your age:");
System.Console.WriteLine("My birth year is:"+p1.GetBirthYear(Convert.ToInt32(Console.ReadLine())));