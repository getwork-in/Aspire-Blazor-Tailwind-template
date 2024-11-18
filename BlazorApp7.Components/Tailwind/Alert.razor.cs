using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp7.Components.Tailwind;

public enum AlertType
{
	Warning,
	Information,
	Error,
	Success,
}

/// <summary>
/// Show Alert Message
/// </summary>
/// <remarks>
/// ![](https://raw.githubusercontent.com/ServiceStack/docs/master/docs/images/blazor/components/Alert.png)
/// </remarks>
public partial class Alert : UiComponentBase
{
	[Parameter] public string HtmlMessage { get; set; } = "";
	[Parameter] public RenderFragment? ChildContent { get; set; }
	[Parameter] public AlertType Type { get; set; } = AlertType.Warning;

	/// <summary>
	/// Gets or sets a collection of additional attributes that will be added to the generated
	/// <c>a</c> element.
	/// </summary>
	[Parameter(CaptureUnmatchedValues = true)]
	public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }
}
