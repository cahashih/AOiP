namespace BaseExam;

class Student
{
    private Person Person;
    private Education Education;
    private int NumGroup;
    private readonly List<Exam> exams = new List<Exam>();


    public Student(Person person, Education education, int group)
    {
        this.Person = person;
        this.Education = education;
        this.NumGroup = group;
    }

    public Student()
    {
        this.Person = new Person();
        this.Education = Education.Specialist;
        this.NumGroup = 320;
    }


    public Person Persons
    {
        get { return Person; }
        set { Person = value; }
    }

    public Education Educations
    {
        get { return Education; }
        set { Education = value; }
    }

    public int NumGroups
    {
        get { return NumGroup; }
        set { NumGroup = value; }
    }

    public Exam[] Exams
    {
        get { return exams.ToArray(); }

    }

    public double AvgEvaluation
    {
        get { return exams.Count > 0 ? exams.Average(p => p.Evaluation) : 0; }
    }

    public bool this[Education index]
    {
        get { return this.Education == index; }
    }

    public void AddExams(params Exam[] exams)
    {
        this.exams.AddRange(exams);
    }

    public override string ToString()
    {
        return string.Format("{0} {1} {2} {3}", Person, Education, NumGroup, string.Join(",", exams));
    }

    public string ToShortString()
    {
        return string.Format("{0} {1} {2} {3:0.00}", Person, Education, NumGroup, AvgEvaluation);
    }

}