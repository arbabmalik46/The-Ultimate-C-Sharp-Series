using System;

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
    class Program
    {
        public static void Main(string[] args)
        {

        }
    }
}
#endregion