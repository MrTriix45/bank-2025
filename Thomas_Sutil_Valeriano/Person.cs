public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    // Construct Person
    public Person(string firstname, string lastname, DateTime birthdate)
    {
        FirstName = firstname;
        LastName = lastname;
        BirthDate = birthdate;
    }
}