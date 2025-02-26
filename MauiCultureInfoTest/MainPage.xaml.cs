using System.Globalization;

namespace MauiCultureInfoTest;

/// <summary>
/// A test page for troubleshooting iOS specific language culture issues.
/// </summary>
public partial class MainPage : ContentPage
{
	/// <summary>
	/// Exposes the installed UI culture for the app.
	/// </summary>
	public CultureInfo InstalledUICulture => CultureInfo.InstalledUICulture;

	/// <summary>
	/// Exposes the current UI culture for the app.
	/// </summary>
	public CultureInfo CurrentUICulture => CultureInfo.CurrentUICulture;

	/// <summary>
	/// Exposes the current culture for the app.
	/// </summary>
	public CultureInfo CurrentCulture => CultureInfo.CurrentCulture;

	/// <summary>
	/// Returns the date time when the culture information was last checked.
	/// </summary>
	public DateTime LastChecked => DateTime.Now;

	/// <summary>
	/// A test currency amount.
	/// </summary>
	public double CurrencyTest { get; set;} = 123.45;

	/// <summary>
	/// Initializes a new instance of the <see cref="MainPage"/> class.
	/// </summary>

	public MainPage()
	{
		InitializeComponent();
	}

	/// <summary>
	/// Handles the refresh button click event.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	void OnRefresh(object sender, EventArgs e)
	{
		CultureInfo.InstalledUICulture.ClearCachedData();
		CultureInfo.CurrentUICulture.ClearCachedData();
		CultureInfo.CurrentCulture.ClearCachedData();
		OnPropertyChanged(nameof(InstalledUICulture));
		OnPropertyChanged(nameof(CurrentUICulture));
		OnPropertyChanged(nameof(CurrentCulture));
		OnPropertyChanged(nameof(LastChecked));
	}
}
