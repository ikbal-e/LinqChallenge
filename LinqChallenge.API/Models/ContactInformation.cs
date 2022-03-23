namespace LinqChallenge.API.Models;

public class ContactInformation
{
    public int Id { get; set; }
    public int PersonId { get; set; }
    public string Name { get; set; }
    public InformationType InformationType { get; set; }
    public string InformationValue { get; set; }
}

public enum InformationType
{
    PhoneNumber,
    Address,
    Email
}