namespace Registration.Database.Entities.Abstracts;

public abstract class Person {

    // Fields

    public int Id { get; set; }
    public int Age { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }

}