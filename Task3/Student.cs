class Student{
  public  string name ;

   public int GradeLevel;

    public List<int> Scores=new List<int>();
   public void Get(int grade){
    if(grade>100){
        System.Console.WriteLine("максималный балл 100.ВВедите корректное число!!!");
        }
     else {
        Scores.Add(grade);
        }
   }
   public  double GetAverage(){
    
    int summa=0,cnt=0;
        foreach (var elem in Scores){
            summa=summa+elem;
            cnt++;

        }
       return summa/cnt;
    }
    
}