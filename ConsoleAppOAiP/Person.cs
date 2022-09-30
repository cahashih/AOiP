namespace BaseExam;

class Person
{


        
        


    private string Name;
    private string Surname;
    private System.DateTime DateOfBirth;


    public Person(string name, string surname, DateTime dateOfBirth)
    {
        this.Name = name;
        this.Surname = surname;
        this.DateOfBirth = dateOfBirth;
    }

    public Person()
    {
        this.Name = "Alex";
        this.Surname = "Avgust";
        this.DateOfBirth = new DateTime(2004, 04, 12);
    }


    public string Names
    {
        get { return Name; }
        set { Name = value; }
    }

    public string Surnames
    {
        get { return Surname; }
        set { Surname = value; }
    }

    public DateTime DateOfBirths
    {
        get { return DateOfBirth; }
        set { DateOfBirths = value; }
    }


    public int ChangingDateOfBirth
    {
        get { return DateOfBirth.Year; }
        set { DateOfBirth = new DateTime(value, DateOfBirth.Month, DateOfBirth.Day); }
    }

    public override string ToString()
    {
        return Name + "" + Surname + "" + DateOfBirths.Date.ToString();
    }

    public string ToShortString()
    {
        return Name + "" + Surname;
    }
}