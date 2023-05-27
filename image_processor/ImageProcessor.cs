using System;
using System.IO;
using System.Drawing;

namespace image_processor
{
    class ImageProcessor
    {
        public static void Inverse(string[] filenames)
        {
            foreach (string filename in filenames)
            {
                // Load the image file
                Bitmap originalImage = new Bitmap(filename);

                // Create a new bitmap with the same dimensions as the original image
                Bitmap invertedImage = new Bitmap(originalImage.Width, originalImage.Height);

                // Iterate over each pixel in the image
                for (int y = 0; y < originalImage.Height; y++)
                {
                    for (int x = 0; x < originalImage.Width; x++)
                    {
                        // Get the color of the current pixel
                        Color pixelColor = originalImage.GetPixel(x, y);

                        // Calculate the inverted color by subtracting each color component from 255
                        Color invertedColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);

                        // Set the inverted color for the corresponding pixel in the new image
                        invertedImage.SetPixel(x, y, invertedColor);
                    }
                }

                // Save the inverted image to a file with "_inverted" appended to the original filename
                string invertedFilename = filename.Insert(filename.LastIndexOf('.'), "_inverted");
                invertedImage.Save(invertedFilename);
            }
        }
    }
}
