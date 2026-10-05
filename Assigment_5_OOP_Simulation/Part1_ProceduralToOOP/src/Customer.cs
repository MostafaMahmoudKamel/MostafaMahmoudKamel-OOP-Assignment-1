namespace Assigment_5_OOP_Simulation.Part1_ProceduralToOOP.src;

internal class Customer
{

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string City { get; private set; }
    public bool IsVip { get; private set; }

    public Customer(int id, string name, string email, string city, bool isVip)
    {
        Id = id;
        Name = name;
        Email = email;
        City = city;
        IsVip = isVip;
    }


    public override string ToString()
    {
        return $"id :{Id}   name: {Name}   email: {Email}   city: {City}   vip: {IsVip}";
    }

}
