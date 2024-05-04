namespace Registration.DataAccsess.Entities.Abstracts;

public abstract class Person : BaseEntity {

    // Fields

    public int Age { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }

}