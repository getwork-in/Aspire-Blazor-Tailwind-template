using Microsoft.JSInterop;

namespace BuildingBlocks.UIComponents;

public interface ILocalStorage
{
	ValueTask SetStringAsync(string name, string value);
	ValueTask<string?> GetStringAsync(string name);
	ValueTask RemoveAsync(string name);
}

public class LocalStorage(IJSRuntime _js) : ILocalStorage
{
	public ValueTask SetStringAsync(string name, string value) =>
		_js.InvokeVoidAsync("localStorage.setItem", name, value);

	public ValueTask<string?> GetStringAsync(string name) =>
		_js.InvokeAsync<string?>("localStorage.getItem", new object[] { name });

	public ValueTask RemoveAsync(string name) =>
		_js.InvokeVoidAsync("localStorage.removeItem", name);
}