using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		Program program = new Program();

		program.Exercise1();
		program.Exercise2();
		program.Exercise3();
	}

	// Bài tập 1: Sử dụng ArrayList
	void Exercise1()
	{
		ArrayList numbers = new ArrayList();
		Console.WriteLine("Nhap so nguyen (nhap 'exit' de dung):");

		while (true)
		{
			string input = Console.ReadLine();
			if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
			{
				break;
			}

			if (int.TryParse(input, out int number))
			{
				numbers.Add(number);
			}
			else
			{
				Console.WriteLine("Vui long nhap so nguyen hop le.");
			}
		}

		numbers.Sort();
		Console.WriteLine("Danh sach so nguyen theo thu tu tang dan:");
		foreach (int number in numbers)
		{
			Console.WriteLine(number);
		}
	}

	// Bài tập 2: Sử dụng Hashtable
	void Exercise2()
	{
		Hashtable nameAgeTable = new Hashtable();
		Console.WriteLine("Nhap ten va tuoi (nhap 'exit' de dung):");

		while (true)
		{
			Console.Write("Ten: ");
			string name = Console.ReadLine();
			if (name.Equals("exit", StringComparison.OrdinalIgnoreCase))
			{
				break;
			}

			Console.Write("Tuoi: ");
			if (int.TryParse(Console.ReadLine(), out int age))
			{
				nameAgeTable[name] = age;
			}
			else
			{
				Console.WriteLine("Vui long nhap tuoi hop le.");
			}
		}

		Console.WriteLine("Danh sch ten va tuoi vua nhap la::");
		foreach (DictionaryEntry entry in nameAgeTable)
		{
			Console.WriteLine($"Ten: {entry.Key}, Tuoi: {entry.Value}");
		}
	}

	// Bài tập 3: Sử dụng Dictionary
	void Exercise3()
	{
		Dictionary<string, int> studentScores = new Dictionary<string, int>();
		Console.WriteLine("Nhap ten hoc sinh va diem (nhap 'exit' de dung):");

		while (true)
		{
			Console.Write("Ten hoc sinh la: ");
			string name = Console.ReadLine();
			if (name.Equals("exit", StringComparison.OrdinalIgnoreCase))
			{
				break;
			}

			Console.Write("Diem: ");
			if (int.TryParse(Console.ReadLine(), out int score))
			{
				studentScores[name] = score;
			}
			else
			{
				Console.WriteLine("Vui long nhap diem hop le.");
			}
		}

		Console.WriteLine("Danh sach hoc sinh va diem cua ho la::");
		foreach (var student in studentScores)
		{
			Console.WriteLine($"Ten: {student.Key}, Diem: {student.Value}");
		}
	}
}