using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Collections.Concurrent;

namespace BlazorApp7.Components;

public abstract class UiComponentBase : ComponentBase
{
	[Inject] public IJSRuntime JS { get; set; } = default!;

	/// <summary>
	/// Optional user defined classes for this component
	/// </summary>
	[Parameter] public string? @class { get; set; }
	public string? Class => @class;

	protected virtual string CssClass(string? valid = null, string? invalid = null) =>
		CssUtils.ClassNames(@class);

	protected virtual string ClassNames(params string?[] classes) => CssUtils.ClassNames(classes);
	public static bool SanitizeAttribute(string name) => name == "@bind" || name.StartsWith("@bind:");
	public static IReadOnlyDictionary<string, object>? SanitizeAttributes(IReadOnlyDictionary<string, object>? attrs)
	{
		if (attrs == null) return null;
		var safeAttrs = new Dictionary<string, object>();
		foreach (var attr in attrs)
		{
			if (SanitizeAttribute(attr.Key))
				continue;
			safeAttrs[attr.Key] = attr.Value;
		}
		return safeAttrs;
	}

	static long renderIndex = 0;
	static ConcurrentDictionary<long, Func<IJSRuntime, Task>> RenderActions = new();
	protected virtual void QueueRenderAction(Func<IJSRuntime, Task> action) =>
		RenderActions[Interlocked.Increment(ref renderIndex)] = action;
	protected override async Task OnAfterRenderAsync(bool firstRender)
	{
		var orderedKeys = RenderActions.Keys.OrderBy(x => x).ToList();
		foreach (var key in orderedKeys)
		{
			if (RenderActions.TryRemove(key, out var action))
			{
				try
				{
					await action(JS);
				}
				catch (Exception e)
				{
					Console.Error.WriteLine("RenderAction in {0} failed: {1}", GetType().Name, e.Message);
				}
			}
		}
		await base.OnAfterRenderAsync(firstRender);
	}
}
