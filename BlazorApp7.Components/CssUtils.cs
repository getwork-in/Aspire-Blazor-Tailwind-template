using System.Text;

namespace BlazorApp7.Components
{
	public static class CssUtils
	{
		public static class Tailwind
		{
		}

		public static string ClassNames(params string?[] classes)
		{
			var sb = new StringBuilder();
			foreach (var cls in classes)
			{
				if (string.IsNullOrEmpty(cls))
					continue;

				if (sb.Length is > 0)
					sb.Append(' ');
				sb.Append(cls);
			}
			return sb.ToString();
		}
	}
}
