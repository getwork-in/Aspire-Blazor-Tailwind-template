namespace BlazorApp7.Client.Utils;

public static class Utils
{
	public static string CombineClasses(params string[] classes)
	{
		return string.Join(" ", classes.Where(c => !string.IsNullOrWhiteSpace(c)));
	}
}
