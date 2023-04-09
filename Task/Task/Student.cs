
internal class Student
{
    public string Name;
    public string SurName;
    public string Group;
    public double Point;
    public bool IsGraduate;

    public Student(string name, string SurName, string group, double point, bool IsGraduate)
    {
        this.Name = name;
        this.SurName = SurName;
        this.Group = group;
        this.Point = point;
        this.IsGraduate = IsGraduate;
    }
    public void GetFullName()
    {
        Console.WriteLine($"{this.Name},{this.SurName}");
    }
    public void GetFullInfo()
    {
        Console.WriteLine($"{this.Name},{this.SurName},{this.Group},{this.Point},{this.IsGraduate}");
        if (IsGraduate == true)
        {
            Console.WriteLine("Mezun oldu");
        }
        else 
        {
            Console.WriteLine("Mezun ola bilmedi");
        }
    }
    public void NextExam() 
    {
        if (IsGraduate == false && Point > 80)
        {
            Console.WriteLine("Yeniden imtahana gire biler");
        }
        else 
        {
            Console.WriteLine("Yeniden imtahana gire bilmez");
        }
    
    }
    


    }

