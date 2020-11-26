using System;

namespace FitnessCalculatorConsole
{
	class Program
	{
		static void Main()
		{
			const double minAge = 0;
			const double maxAge = 123;
			const double minWeight = 0;
			const double maxWeight = 635;
			const double minHeight = 0;
			const double maxHeight = 272;

			#region Sex

			bool sex;

			Console.Write("Select sex ([m] for male, and [f] for female): ");

			ConsoleKeyInfo keyInfo = Console.ReadKey();

			Console.WriteLine();

			switch (keyInfo.Key)
			{
				// male
				case ConsoleKey.M:
					{
						sex = true;
						break;
					}
				// female
				case ConsoleKey.F:
					{
						sex = false;
						break;
					}
				default:
					{
						Console.Error.WriteLine("What kind of sorcery is this?");
						return;
					}
			}

			#endregion

			#region Age

			Console.Write($"Enter age ({minAge} <= age <= {maxAge}) in yrs: ");

			string s = Console.ReadLine();

			if (!double.TryParse(s, out double age))
			{
				Console.Error.WriteLine(@"I said ""age""!");
				return;
			}

			if (age < minAge)
			{
				Console.Error.WriteLine("Way too young, kid!");
				return;
			}

			if (age > maxAge)
			{
				Console.Error.WriteLine("That old?! Impossibru.");
				return;
			}

			#endregion

			#region Weight

			Console.Write($"Enter weight ({minWeight} <= weight <= {maxWeight}) in kg: ");

			s = Console.ReadLine();

			if (!double.TryParse(s, out double weight))
			{
				Console.Error.WriteLine("You should have entered weight, not the name of an elephant!");
				return;
			}

			if (weight < minWeight)
			{
				Console.Error.WriteLine("Y U LYING TO ME?!");
				return;
			}

			if (weight > maxWeight)
			{
				Console.Error.WriteLine("Well, congratulations then! You're the holder of a new Guinness World Record.");
				return;
			}

			#endregion

			#region Height

			Console.Write($"Enter height ({minHeight} <= height <= {maxHeight}) in cm: ");

			s = Console.ReadLine();

			if (!double.TryParse(s, out double height))
			{
				Console.Error.WriteLine("You should have entered weight, not the name of a giraffe!");
				return;
			}

			if (height < minHeight)
			{
				Console.Error.WriteLine("C'mon! No one is that short!");
				return;
			}

			if (height > maxHeight)
			{
				Console.Error.WriteLine("Hmmm... that tall? Really? No way.");
				return;
			}

			#endregion

			// TODO: enter lifestyle

			// TODO: enter weight goal

			// TODO: enter fitness goal

			#region BMI

			double bmi = weight / (((double)height / 100) * ((double)height / 100));

			Console.WriteLine($"Body mass index (BMI) is {bmi} kg/m².");

			#endregion

			#region BMR

			double bmr = sex
				? 66.5
					+ 13.75 * weight
					+ 5.003 * height
					- 6.755 * age
				: 655
					+ 9.563 * weight
					+ 1.850 * height
					- 4.676 * age;

			Console.WriteLine($"Basal metabolic rate (BMR) according to Harris–Benedict equations published in 1918 and 1919 {bmr} ㎉/day.");

			double bmr1984 = sex
				? 88.362
					+ 13.397 * weight
					+ 4.799 * height
					- 5.677 * age
				: 447.593
					+ 9.247 * weight
					+ 3.098 * height
					- 4.330 * age;

			Console.WriteLine($"Basal metabolic rate (BMR) according to Harris–Benedict equations revised by Roza and Shizgal in 1984 is {bmr1984} ㎉/day.");

			double bmr1990 =
				(sex ? 5 : -161)
				+ 10 * weight
				+ 6.25 * height
				- 5 * age;

			Console.WriteLine($"Basal metabolic rate (BMR) according to Harris–Benedict equations revised by Mifflin and St Jeor in 1990 is {bmr1990} ㎉/day.");

			#endregion

			// TODO: calculate TEE

			// TODO: calorie goal

			// TODO: diet
		}
	}
}
