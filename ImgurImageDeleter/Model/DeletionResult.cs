namespace ImgurImageDeleter.Model
{
    public class DeletionResult
    {
        /// <summary>
        /// This image that got deleted (or not).
        /// </summary>
        public Image TargetImage { get; private set; }

        /// <summary>
        /// Boolean stating wheter the image got deletes or not.
        /// </summary>
        public bool Success { get; private set; }

        /// <summary>
        /// Constuctor for the object. Takes an image object, as well as a boolean.
        /// </summary>
        /// <param name="image">The image that got deleted (or not).</param>
        /// <param name="success">State of the deletion request.</param>
        public DeletionResult(Image image, bool success)
        {
            TargetImage = image;
            Success = success;
        }
    }
}