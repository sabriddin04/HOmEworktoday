var st1=new Student ();
System.Console.Write("NAME:");
st1.name=Console.ReadLine();
System.Console.Write("GRADELEVEL:");
st1.GradeLevel=Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine("ШКАЛА БАЛЛОВ ОТ 0 ДО 100 БАЛЛОВ!!!!!");
System.Console.Write("введите получений бал "+st1.name+" за Task1:");
st1.Get(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("введите получений бал "+st1.name+" за Task2:");
st1.Get(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("введите получений бал "+st1.name+" за Task3:");
st1.Get(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("введите получений бал "+st1.name+" за Task4:");
st1.Get(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("введите получений бал "+st1.name+" за Task5:");
st1.Get(Convert.ToInt32(Console.ReadLine()));


var st2=new Student ();
System.Console.Write("NAME:");
st2.name=Console.ReadLine();
System.Console.Write("GRADELEVEL:");
st2.GradeLevel=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ШКАЛА БАЛЛОВ ОТ 0 ДО 100 БАЛЛОВ!!!!!");
System.Console.Write("введите получений бал "+st2.name+" за Task1:");
st2.Get(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("введите получений бал "+st2.name+" за Task2:");
st2.Get(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("введите получений бал "+st2.name+" за Task3:");
st2.Get(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("введите получений бал "+st2.name+" за Task4:");
st2.Get(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("введите получений бал "+st2.name+" за Task5:");
st2.Get(Convert.ToInt32(Console.ReadLine()));

  

var st3=new Student ();
System.Console.Write("NAME:");
st3.name=Console.ReadLine();
System.Console.Write("GRADELEVEL:");
st3.GradeLevel=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ШКАЛА БАЛЛОВ ОТ 0 ДО 100 БАЛЛОВ!!!!!");
System.Console.Write("введите получений бал "+st3.name+" за Task1:");
st3.Get(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("введите получений бал "+st3.name+" за Task2:");
st3.Get(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("введите получений бал "+st3.name+" за Task3:");
st3.Get(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("введите получений бал "+st3.name+" за Task4:");
st3.Get(Convert.ToInt32(Console.ReadLine()));
System.Console.Write("введите получений бал "+st3.name+" за Task5:");
st3.Get(Convert.ToInt32(Console.ReadLine()));




var gruppa =new List<Student>();
gruppa.Add(st1);
gruppa.Add(st2);
gruppa.Add(st3);


foreach (var item in gruppa)
{
    if(item.GetAverage()>85){

        System.Console.WriteLine("ИМЯ: "+item.name);
        System.Console.WriteLine("класс: "+item.GradeLevel);
        System.Console.WriteLine("СРЕДНИЙ БАЛЛ: "+item.GetAverage());
    System.Console.WriteLine("МОЛОДЕЦ ПРОДОЛЖАЙ ТАК ");
}
else if(item.GetAverage()<70){
     System.Console.WriteLine("ИМЯ: "+item.name);
        System.Console.WriteLine("класс: "+item.GradeLevel);
        System.Console.WriteLine("СРЕДНИЙ БАЛЛ: "+item.GetAverage());
    System.Console.WriteLine("плохи дела");
}
else
{
     System.Console.WriteLine("ИМЯ: "+item.name);
        System.Console.WriteLine("класс: "+item.GradeLevel);
        System.Console.WriteLine("СРЕДНИЙ БАЛЛ: "+item.GetAverage());
System.Console.WriteLine("НОРМАЛЬНО ВСЕ");
}
}



