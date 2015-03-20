# ImgurImageDeleter
This little library deletes your images from Imgur with a provided delete token. 

You can use it to delete a single image

```csharp
var image = new Image("jQDLrW7kz9VoQiO");
var result = Imgur.DeleteSingle(image);
```

or multiple images:

```csharp
var images = new [] {
  	new Image("HB0m1zanRGMQLlc"),
	new Image("Ev6FkcxEGXK4BKc"),
	new Image("zuyNkMu8IBW5qox"),
};

var results = Imgur.DeleteMultiple(images);
```
