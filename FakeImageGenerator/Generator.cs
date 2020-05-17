using FakeImageGenerator.Extensions;
using System;
using System.IO;

namespace FakeImageGenerator
{
    public class Generator
    {
        private static readonly byte[] jpgImage = new byte[]
        {
            // JPEG IMAGE
            // FF D8 FF E0
            255, 216, 255, 224,

            0, 16, 74, 70, 73, 70, 0, 1, 1, 1, 0, 72, 0, 72, 0, 0, 255, 254, 0, 19, 67, 114, 101, 97, 116, 101, 100, 32,
            119, 105, 116, 104, 32, 71, 73, 77, 80, 255, 219, 0, 67, 0, 3, 2, 2, 3, 2, 2, 3, 3, 3, 3, 4, 3, 3, 4, 5, 8, 5, 5, 4, 4, 5, 10, 7,
            7, 6, 8, 12, 10, 12, 12, 11, 10, 11, 11, 13, 14, 18, 16, 13, 14, 17, 14, 11, 11, 16, 22, 16, 17, 19, 20, 21, 21, 21, 12, 15, 23,
            24, 22, 20, 24, 18, 20, 21, 20, 255, 219, 0, 67, 1, 3, 4, 4, 5, 4, 5, 9, 5, 5, 9, 20, 13, 11, 13, 20, 20, 20, 20, 20, 20, 20, 20,
            20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 20,
            20, 20, 20, 20, 20, 20, 20, 20, 20, 20, 255, 194, 0, 17, 8, 0, 1, 0, 1, 3, 1, 17, 0, 2, 17, 1, 3, 17, 1, 255, 196, 0, 20, 0, 1,
            0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 255, 196, 0, 20, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 218,
            0, 12, 3, 1, 0, 2, 16, 3, 16, 0, 0, 1, 84, 159, 255, 196, 0, 20, 16, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 218,
            0, 8, 1, 1, 0, 1, 5, 2, 127, 255, 196, 0, 20, 17, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 218, 0, 8, 1, 3, 1, 1,
            63, 1, 127, 255, 196, 0, 20, 17, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 218, 0, 8, 1, 2, 1, 1, 63, 1, 127, 255,
            196, 0, 20, 16, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 218, 0, 8, 1, 1, 0, 6, 63, 2, 127, 255, 196, 0, 20, 16,
            1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 218, 0, 8, 1, 1, 0, 1, 63, 33, 127, 255, 218, 0, 12, 3, 1, 0, 2, 0, 3,
            0, 0, 0, 16, 159, 255, 196, 0, 20, 17, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 218, 0, 8, 1, 3, 1, 1, 63, 16,
            127, 255, 196, 0, 20, 17, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 218, 0, 8, 1, 2, 1, 1, 63, 16, 127, 255, 196,
            0, 20, 16, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 255, 218, 0, 8, 1, 1, 0, 1, 63, 16, 127, 255, 217,
        };

        private static readonly byte[] pngImage = new byte[]
        {
            // PNG IMAGE
            // 89 50 4E 47 0D 0A 1A 0A
            137, 80, 78, 71, 13, 10, 26, 10,

            0, 0, 0, 13, 73, 72, 68, 82, 0, 0, 0, 1, // width
            0, 0, 0, 1, // height
            8, 6, 0, 0, 0, 31, 21, 196, 137, 0, 0, 0,
            1, 115, 82, 71, 66, 0, 174, 206, 28, 233, 0, 0, 0, 4, 103, 65, 77, 65, 0, 0, 177, 143, 11, 252, 97, 5, 0, 0, 0, 9, 112, 72, 89,
            115, 0, 0, 18, 116, 0, 0, 18, 116, 1, 222, 102, 31, 120, 0, 0, 0, 13, 73, 68, 65, 84, 24, 87, 99, 248, 255, 255, 255, 127, 0, 9,
            251, 3, 253, 5, 67, 69, 202, 0, 0, 0, 0, 73, 69, 78, 68, 174, 66, 96, 130
        };

        public byte[] Run(int sizeInBytes, string extension)
        {
            var bytes = Run(sizeInBytes, extension, out ImageExtension _);

            return bytes;
        }

        public void Run(int sizeInBytes, string extension, string outputPath)
        {
            if (!Directory.Exists(outputPath))
            {
                throw new ArgumentException($"Directory {outputPath} doesn't exist.");
            }

            var bytes = Run(sizeInBytes, extension, out ImageExtension parsedExtension);
            var path = Path.Combine(outputPath, "image" + parsedExtension.GetDisplayName());
            File.WriteAllBytes(path, bytes);
        }

        private byte[] Run(int sizeInBytes, string extension, out ImageExtension parsedExtension)
        {
            if (sizeInBytes < 1000)
            {
                throw new ArgumentException("Size must be greater than 1000 bytes (1 KB).");
            }

            var isExtensionValid = Enum.TryParse<ImageExtension>(extension, out parsedExtension);
            if (!isExtensionValid)
            {
                throw new ArgumentException($"Extension {extension} is invalid. Value must be 'Jpg' or 'Png'.");
            }

            var bytes = new byte[sizeInBytes];
            var imageBytes = parsedExtension switch
            {
                ImageExtension.Jpg => jpgImage,
                ImageExtension.Png => pngImage,
                _ => jpgImage,
            };
            imageBytes.CopyTo(bytes, 0);

            return bytes;
        }
    }
}
