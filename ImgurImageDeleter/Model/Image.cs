namespace ImgurImageDeleter.Model
{
    public class Image
    {
        /// <summary>
        /// Url used to upload an image to.
        /// </summary>
        public const string DeletionUrl = "http://imgur.com/delete/";
        
        /// <summary>
        /// The current id of the image.
        /// </summary>
        public string Id { get; private set; }

        /// <summary>
        /// The current deletion url of the image.
        /// </summary>
        public string DeletionUrl { get; private set; }

        /// <summary>
        /// Constuctor for the Image object. Takes only a deletion token.
        /// </summary>
        /// <param name="deletionToken">Token to be used to delete the image.</param>
        public Image(string deletionToken)
        {
            Id = string.Empty;
            DeletionUrl = string.Concat(DeletionUrl, deletionToken);
        }

        /// <summary>
        /// Constuctor for the Image object. Takes an image id, as well as a deletion token.
        /// </summary>
        /// <param name="imageId">Id of the image to be deleted.</param>
        /// <param name="deletionToken">Token to be used to delete the image.</param>
        public Image(string imageId, string deletionToken)
        {
            Id = imageId;
            DeletionUrl = string.Concat(DeletionUrl, deletionToken);
        }
    }
}
