using DummyJson.mvvm.Model;
using System.Text.Json;

namespace DummyJson.mvvm.Views;

public partial class ListPage : ContentPage
{
	HttpClient client;
	JsonSerializerOptions serializerOptions;
	string baseurl = "https://dummyjson.com/products";
	public ListPage()
	{
		InitializeComponent();
		client = new HttpClient();
		serializerOptions = new JsonSerializerOptions{ WriteIndented = true };
	}

	
}