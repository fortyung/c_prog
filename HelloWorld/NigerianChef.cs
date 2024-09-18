class NigerianChef : Chef // Inheritance subclass
{
    public void Makejollf()
    {
        Console.WriteLine("Making jollof");
    }

    public override void MakeSpecialDish() // Polymorphism
    {
        Console.WriteLine("Making puf!");
    }
}