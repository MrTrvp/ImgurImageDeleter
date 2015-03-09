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
                new Image("rCMxwzr", "lo9h9nZuLVLKc6W")
            };
            
            // Pass the images array to the DeleteMultiple images.
            var deletionResult = Imgur.DeleteMultiple(images).Result;

            // Loop through all the deletion results and find
            // list the Id along with the status of the deletion.
            foreach (var result in deletionResult)
                Console.WriteLine("ImageId: {0}\r\nSuccess: {1}",
                                   result.TargetImage.Id,
                                   result.Success);

            // We're done here. User views console and sees results.
            Console.Write("Press any key to exit this application...");
            Console.Read();
        }
    }
}