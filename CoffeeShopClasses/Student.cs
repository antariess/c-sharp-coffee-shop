using System;
namespace CoffeeShopClasses
{
	public class Student : Customer
	{
		public int Attendance { get; set; } = 3;

		public Student (string providedName) : base(providedName)
        {

        }

		public override int GenerateDiscount()
        {
			return Attendance + 1;
        }
	}
}

