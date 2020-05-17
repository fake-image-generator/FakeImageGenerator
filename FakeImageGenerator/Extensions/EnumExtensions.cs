using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace FakeImageGenerator.Extensions
{
    internal static class EnumExtensions
    {
        internal static string GetDisplayName(this ImageExtension enumValue)
        {
            return enumValue
				.GetType()
				.GetMember(enumValue.ToString())
				.First()
				.GetCustomAttribute<DisplayAttribute>()
				.GetName();
        }
    }
}
