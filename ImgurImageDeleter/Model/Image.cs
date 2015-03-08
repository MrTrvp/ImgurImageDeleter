namespace ImgurImageDeleter.Model
{
    public class Image
    {
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
            DeletionUrl = "http://imgur.com/delete/" + deletionToken;
        }

        /// <summary>
        /// Constuctor for the Image object. Takes an image id, as well as a deletion token.
        /// </summary>
        /// <param name="imageId">Id of the image to be deleted.</param>
        /// <param name="deletionToken">Token to be used to delete the image.</param>
        public Image(string imageId, string deletionToken)
        {
            Id = imageId;
            DeletionUrl = "http://imgur.com/delete/" + deletionToken;
        }
    }
}