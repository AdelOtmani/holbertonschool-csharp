using System;
using System.IO;
using System.Drawing;
using System.Threading.Tasks;

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

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);
                    Color invertedColor = Color.FromArgb(
                        255 - pixelColor.R,
                        255 - pixelColor.G,
                        255 - pixelColor.B
                    );
                    invertedImage.SetPixel(x, y, invertedColor);
                }
            }

            // Get the original file extension
            string extension = Path.GetExtension(filename);

            // Create the new filename
            string invertedFilename = $"{Path.GetFileNameWithoutExtension(filename)}_inverse{extension}";

            // Save the inverted image to the application's root directory
            string savePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, invertedFilename);
            invertedImage.Save(savePath);

            // Dispose of the image objects to free up memory
            originalImage.Dispose();
            invertedImage.Dispose();
        }
    }
}
