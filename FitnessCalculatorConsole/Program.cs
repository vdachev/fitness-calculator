using System;

namespace FitnessCalculatorConsole
{
	class Program
	{
		static void Main()
		{
			const int minAge = 0;
			const int maxAge = 123;
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

			Console.Write($"Enter age ({minAge} <= age <= {maxAge}): ");

			string s = Console.ReadLine();

			if (!int.TryParse(s, out int age))
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

			Console.Write($"Enter weight ({minWeight} <= weight <= {maxWeight}): ");

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

			Console.Write($"Enter height ({minHeight} <= height <= {maxHeight}): ");

			s = Console.ReadLine();

			if (!int.TryParse(s, out int height))
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

			double bmr = (10 * weight) + (6.25 * height) - (5 * age);

			// male
			if (sex)
			{
				bmr += 5;
			}
			// female
			else
			{
				bmr -= 161;
			}

			Console.WriteLine($"Basal metabolic rate (BMR) is {bmr} kcal/day.");

			#endregion

			// TODO: calculate TEE

			// TODO: calorie goal

			// TODO: diet
		}
	}
}
