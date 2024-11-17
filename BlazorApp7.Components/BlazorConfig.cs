namespace BlazorApp7.Components;

public class BlazorConfig
{
	public static BlazorConfig Instance { get; private set; } = new BlazorConfig();
	public static void Set(BlazorConfig config)
	{
		Instance = config;
	}
	public bool IsDevelopment { get; init; }
	public bool IsWasm { get; init; }
	public bool DarkMode { get; internal set; }
	public bool UseLocalStorage { get; init; } = true;
	public string? ApiBaseUrl { get; init; }

	public bool ToggleDarkMode(bool? value = null)
	{
		return DarkMode = value ?? !DarkMode;
	}
}
