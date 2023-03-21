using System;
namespace Inheritance
{
	public class Reptile: Animal
	{
		public Reptile()
		{
            Breed = "Lizard";
            Age =10;
            LegCount = 4;
            Type = "Reptile";
        }

		public bool IsColdBlooded { get; set; }
		public bool IsScaly { get; set; }
		public string Habitat { get; set; }
		public bool CanGrowTail { get; set; }

	}
}

