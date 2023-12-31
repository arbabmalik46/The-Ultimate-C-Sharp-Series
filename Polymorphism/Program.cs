using System;
using System.Collections.Generic;
using System.Linq;

#region Delegates


//namespace Polymorphism
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            PhotoProcessor processor = new PhotoProcessor();
//            var photoFilters = new PhotoFilters();
//            PhotoProcessor.ApplyingFilter filterhandler = photoFilters.ApplySaturation;
//            filterhandler += RemoveRedEye;
//            processor.Process("", filterhandler);
//        }

//        static void RemoveRedEye(Photo photo)
//        {
//            Console.WriteLine("Removed Red Eye");
//        }
//    }
//    public class PhotoProcessor
//    {
//        public delegate void ApplyingFilter(Photo photo);
//        public void Process(string _path, ApplyingFilter filter)
//        {
//            var photo = Photo.Load(_path);
//            filter(photo);

//        }
//    }

//    public class Photo
//    {
//        public static Photo Load(string _path)
//        {
//            return new Photo();
//        }
//    }
//    public class PhotoFilters
//    {
//        public void ApplyBrightness(Photo photo)
//        {
//            Console.WriteLine("Aplying Brightness");
//        }
//        public void ApplyContrast(Photo photo) { Console.WriteLine("Applying Contrast"); }

//        public void ApplyHue(Photo photo) { Console.WriteLine("Applying Hue"); }
//        public void ApplySaturation(Photo photo) { Console.WriteLine("Applying Saturation"); }
//    }

//}
#endregion

#region LambdaExpression
namespace LambdaExpression
{
    public class Books
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }
    public class BookRepository
    {
        public List<Books> GetBooks()
        {
            return new List<Books>
            {
                new Books(){ Title ="Learn C# with Mosh",Price=10},
                new Books(){ Title = "Learn JS with Tim Correy",Price = 20},
                new Books(){ Title = "Learn TypeScript with Zia Khan",Price= 34}
            };

        }
    }
    class Program
    {
        
        //static int Square(int number)
        //{
        //    return number * number;
        //}
        //static List<Books> isCheaperBook(List<Books> books)
        //{
        //    return books.Where(x => x.Price == 10);
        //}
        public static void Main(string[] args)
        {
            //Func<int, int> square = number => number * number;
            //Console.WriteLine(square(10));

            var books = new BookRepository().GetBooks() ;
            books.Find(x=>x.Price>10);
            Console.WriteLine(books.First(x=>x.Price > 20).Price);
        }
    }
}
#endregion