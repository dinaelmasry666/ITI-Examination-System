namespace Examination_System_UML;

public abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public abstract override string ToString();
}