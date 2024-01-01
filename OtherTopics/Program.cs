using OtherTopics;
using System;

namespace OtherTopics
{
	class Program
	{
		public static void Main(string[] args)
		{
            #region LINQ
            //var books = new BookRepository().GetBooks();
            #region LINQ Example
            ////LINQ Query Operators
            //var cheaperBooks = 
            //    from b in books
            //    where b.Price < 5
            //    orderby b.Price
            //    select b.Title;
            //// LINQ Extension Methods
            //var cheapBooks = books
            //    .Where(x=>x.Price<10)
            //    .OrderBy(x=>x.Price)
            //    .Select(p=>p.Title); //where is used for condition
            //foreach(var book in cheapBooks)
            //{
            //    Console.WriteLine(book);
            //}
            //foreach (var item in cheapBooks)
            //{
            //    Console.WriteLine("{0} is a cheap book and it's price is {1}", item.Title, item.Price);
            //}
            //var cheapBooks = new List<Books>();
            #region Conventional Way
            //foreach (var item in books) --This method is old and time consuming and it will take more memory too
            //{
            //	if(item.Price<10)
            //		cheapBooks.Add(item);
            //}
            //foreach (var item in cheapBooks)
            //{
            //             Console.WriteLine("{0} is a cheap book and it's price is {1}",item.Title,item.Price);
            //         }
            #endregion
            #endregion
            //var book = books.First(x => x.Title == "C# Advance Topics");
            //var summedPrice = books.Sum(x=>x.Price);
            ////var book = books.SingleOrDefault(p=>p.Title == "ASP.NET MVC++");
            //Console.WriteLine(summedPrice);
            #endregion

            #region Nullable
            Nullable<DateTime> dateTime = null;
            //DateTime? date = DateTime.Today ;
            //Console.WriteLine("GetValueOrDefault(): " + date.GetValueOrDefault());
            //Console.WriteLine("HasValue: "+date.HasValue);
            //Console.WriteLine("Value: "+date.Value);

            ////null coalescing operator c#
            //DateTime dateTime1 = date ?? DateTime.MaxValue;
            #endregion

            #region Dynamic
            //object obj = "Hash";
            //var method = obj.GetType().GetMethod("GetHashCode");
            //method.Invoke(null,null);

            //dynamic excelObject = "Arbab";
            //excelObject.Optimize();

            dynamic name = "Arbab";
            name = 123;
            Console.WriteLine(++name);
            #endregion
        }
    }
}