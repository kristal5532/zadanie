/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 02.11.2021
 * Time: 14:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;


namespace Zadanie
{
	
	class Program
	{
		public static void Main(string[] args)
		{
			
			list<DateTime[]> date = new list<DateTime[]>();
			
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
				
							date.add (DateTime.Parse(Console.ReadLine()));
				
							for (int i = 0; i < date.Length; i++)
							Console.WriteLine(date[i]);
						}
			
					else if (otv.Equals("N")) //Вывод всех дат массива.
						{
							for (int i = 0; i < date.Length; i++)
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