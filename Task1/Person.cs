using System.Runtime.Intrinsics.Arm;

class Person{
     string FirstName;
     string LastName;
     int Age;

     public string GetFullName(string name,string surname){
        FirstName=name;
        LastName=surname;
        return $"My name is {FirstName} {LastName}";
    }
     public int GetBirthYear(int number){
         Age=2024-number;
         return Age;
    }
}