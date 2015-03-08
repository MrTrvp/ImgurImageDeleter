using System;
using ImgurImageDeleter.Helpers;
using ImgurImageDeleter.Model;

namespace ImgurImageDeleter
{
    class Program
    {
        static void Main()
        {
            // Example images to be deleted.
            var images = new[]
            {
                new Image("rCMxwzr", "lo9h9nZuLVLKc6W"),
            };

            var deletionResult = Imgur.DeleteMultiple(images).Result;

            foreach (var result in deletionResult)
                Console.WriteLine("ImageId: {0}\r\nSuccess: {1}",
                                   result.TargetImage.Id,
                                   result.Success);

            Console.Write("Press any key to exit this application...");
            Console.Read();
        }
    }
}