using System;
using System.Collections;
using System.Collections.Generic;

namespace Series1
{
	class Program
	{
		public static void Main(string[] args)
		{
			//Camel Case
			string firstName = "Arbab";
			//Pascal Case
			string LastName = "Munawar";
			//Hungarian Notation
			string strFullName = "Arbab Malik";
			//For Local variables: Camel Case
			int number1;
			//For Constants: Pascal Case
			const int MaxZoom = 5;
			//overflowing
			checked
			{
				byte number = 255;
				//number = number + 1;
			}
			//random class
			var random = new Random();
			//Console.WriteLine(random.Next(0,12));
			//DateTime
			var dateTime = new DateTime(2015,1,1);
			var now = DateTime.Now;
			var today = DateTime.Today;
			Console.WriteLine("DateTime: {0} \nNow: {1}\ntoday: {2} ",dateTime,now, today);

			#region String
			string name = "Arbab Malik";
			name.ToUpper();
			name.ToLower();
			name.Trim();
			name.IndexOf('a');
			name.LastIndexOf("Arbab");
			//substring
			name.Substring(1,5);
			name.Replace("Arbab","Ammar");
			//null check
			String.IsNullOrEmpty(name);
			String.IsNullOrWhiteSpace(name);
			//spliting
			name.Split('a');
			//Converting to string
			number1 = 234;
			number1.ToString();
			number1.ToString("C");
			number1.ToString("C0");

			#endregion


		}
	}
}