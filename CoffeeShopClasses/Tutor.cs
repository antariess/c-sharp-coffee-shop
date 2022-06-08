using System;
namespace CoffeeShopClasses;

public class Tutor : Customer
{
    public int StudentSatisfaction { get; set; } = 6;

    public Tutor(string providedName) : base(providedName)
    {

    }

    public override int GenerateDiscount()
    {
        return StudentSatisfaction + 1;
    }
}

// property - student satisfaction
// generate discount = SS + 2;