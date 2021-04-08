using System;

class Faculty : Person
{
  public string Id{get; set;}
  public string Title {get; set;}
  public DateTime DateOfEmployment {get; set;}
  public string Employer {get; set;}
  public double YearlySalary {get; set;}  
  public bool Tenured {get; set;}  
  
  public string instructor {get; set;} 
  public double salary {get; set;} 

/* public override DateTime DateOfEmployment {
    get{return base.DateOfEmployment;}
    
    set{

      int Employment = DateTime.Today.Year - value.Year;
      Console.WriteLine("Employment="+Employ,Employment);
      if (Employment >= 5)
        base.DateOfEmployment = value;
      else
        Console.WriteLine("Employer cannot be under 18");     
      }
    
  }*/
   public Faculty() : base()
    {
        Title = "Instructor";
        Console.WriteLine(Title);
    }


    public Faculty(string firstname, string lastname) : base(firstname, lastname)
    {
        YearlySalary = salary;
        Title = "Instructor";
        Console.WriteLine(YearlySalary);
        Console.WriteLine(Title);
    }

   public bool GrandTenure()
      {int Experience = DateTime.Today.Year - DateOfEmployment.Year;
          if (Experience >= 5)
        {Tenured = true;
        Console.WriteLine("Tenured");
        }
          else{
        Tenured = false;
        }
        return Tenured;
      }

  public void Promote()
      {int Experience = DateTime.Today.Year - DateOfEmployment.Year;
        Console.WriteLine(Experience);
        Console.WriteLine(Title);
          if (Experience >= 2 && Title == "Instructor") 
          {
            Title = "Assistant Professor";
          Console.WriteLine("Faculty promoted to Assistant Professor rank!!");
          }
          
        if (Experience > 5 && Title == "Instructor") 
          {
            Title = "Associate Professor";
          Console.WriteLine("Faculty promoted to Associate Professor rank!!!");
          }
         
        if (Experience > 10 && Title == "Instructor") 
          {
            Title = "Professor";
          Console.WriteLine("Faculty promoted to Professor rank");
          }
}

  public override void Intro()
    {
      base.Intro();      
      Console.WriteLine("Faculty Member since " + DateOfEmployment.Year);
        Console.WriteLine("Title " + Title);
        Console.WriteLine("I work as " + Title + " at Tri-C since " + DateOfEmployment.Year);
    }
}