using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{

			Breed = "Hawk";
			Age = 5;
			LegCount = 2;
			Type = "Bird";


		}
		public bool CanFly { get; set; }
		public string Color { get; set; }
		public bool DoMigrate { get; set; }
		public double BeakLength { get; set; }
	}
}

