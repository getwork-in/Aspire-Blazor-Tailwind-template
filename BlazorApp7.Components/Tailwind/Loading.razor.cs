using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorApp7.Components.Tailwind;

/// <summary>
/// Show Loading animation whilst waiting for a long operation to complete
/// </summary>
/// <remarks>
/// ![](https://raw.githubusercontent.com/ServiceStack/docs/master/docs/images/blazor/components/Loading.png)
/// </remarks>
public partial class Loading : UiComponentBase
{
	[Parameter] public string Message { get; set; } = "Loading...";
	[Inject] NavigationManager NavigationManager { get; set; } = default!;

	string prerenderedHtml { get; set; } = "";

	bool HasPrerenderedHtml => !string.IsNullOrEmpty(prerenderedHtml);

	[Parameter]
	public string ImageClass { get; set; } = "w-6 h-6";

	protected override async Task OnAfterRenderAsync(bool firstRender)
	{
		await base.OnAfterRenderAsync(firstRender);

		if (firstRender)
		{
			var html = await JS.InvokeAsync<string>("JS.prerenderedPage") ?? "";
			var currentPath = new Uri(NavigationManager.Uri).AbsolutePath;
			var prerenderedContentIsForPath = html.Contains($"data-prerender=\"{currentPath}\"", StringComparison.CurrentCulture);
			if (prerenderedContentIsForPath)
			{
				prerenderedHtml = html;
			}
		}
	}
}
