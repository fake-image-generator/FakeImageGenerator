using System.ComponentModel.DataAnnotations;

namespace FakeImageGenerator
{
    public enum ImageExtension
    {
        [Display(Name = ".jpg")]
        Jpg,

        [Display(Name = ".png")]
        Png
    }
}
