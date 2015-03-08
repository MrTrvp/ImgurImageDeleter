using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ImgurImageDeleter.Model;

namespace ImgurImageDeleter.Helpers
{
    /// <summary>
    /// This class is used to be call the delete functions..
    /// </summary>
    public static class Imgur
    {
        // The client to be used to handle the delete results.
        private static readonly HttpClient Client;
  
        // The data to be send to the server when deleting an image.
        private static readonly Dictionary<string, string> ConfirmationPostData;

        /// <summary>
        /// Initializes the static readonly global variables.
        /// </summary>
        static Imgur()
        {
            Client = new HttpClient();
            ConfirmationPostData =
                new Dictionary<string, string> {{ "confirm", "true" }};
        }

        /// <summary>
        /// Deletes a single image form the given image parameter.
        /// </summary>
        /// <param name="image">The image to be deleted.</param>
        /// <returns></returns>
        public async static Task<DeletionResult> DeleteSingle(Image image)
        {
            // If the image is null, we throw an exception saying it is so.
            if (image == null)
                throw new ArgumentNullException("image");
            
            // We send a confirmation post data to the deletion url
            //requesting for the image to be deleted.
            var request = await Client.PostAsync(image.DeletionUrl, new FormUrlEncodedContent(ConfirmationPostData));
            
            // Read the response back from the server as a string.
            var response = await request.Content.ReadAsStringAsync();

            // Return a DeletionRequest stating the response contains
            // "has been deleted", notifing us that the image has been deleted.
            return new DeletionResult(image, response.Contains("has been deleted"));
        }

        /// <summary>
        /// Deletes multiple images from the given images parameter.
        /// </summary>
        /// <param name="images">The images to be deleted.</param>
        /// <returns></returns>
        public async static Task<DeletionResult[]> DeleteMultiple(Image[] images)
        {
            // We make a list of DeletionResult to store all the status of all the images being deleted.
            var results = new List<DeletionResult>();

            // Loop through the image array in the method parameter.
            foreach (var image in images)
                // Add the deletion result to the delete result list.
                results.Add(await DeleteSingle(image));

            // Result the results as an array.
            return results.ToArray();
        }
    }
}