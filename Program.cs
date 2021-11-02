using System;
using System.Collections.Generic;

namespace Zadanie
{
	
	class Program
	{
		public static void Main(string[] args)
		{			
			List<DateTime> date = new List<DateTime>();

			date.Add(new DateTime(2010, 10, 01));
			date.Add(new DateTime(2011, 10, 11));
			date.Add(new DateTime(2012, 05, 30));

			Console.WriteLine("Запуск программы (Y/N)");
			string v = Console.ReadLine();
			
			if (v.Equals("Y"))   //Запрос if для начала работы приложения.
				{
					Console.WriteLine("Добавить дату рождения (Y/N)");
					string otv = Console.ReadLine();
			
					if (otv.Equals("Y"))  //Запрос для загрузки новой даты.
						{
							Console.WriteLine("Введите дату");
				
							date.Add(DateTime.Parse(Console.ReadLine()));
				
							for (int i = 0; i < date.Count; i++)
							Console.WriteLine(date[i]);
						}
			
					else if (otv.Equals("N")) //Вывод всех дат массива.
						{
							for (int i = 0; i < date.Count; i++)
							Console.WriteLine(date[i]);
				
						}	
				}
			else if(v.Equals("N")) //Выход из консоли
				{
					Environment.Exit(0);
				
				}
			
			
			Console.ReadKey();
		}
		public void vivod()
		{
			//for (int i = 0; i < date.Length; i++)
			//	Console.WriteLine(date[i]);
		}
	}
}