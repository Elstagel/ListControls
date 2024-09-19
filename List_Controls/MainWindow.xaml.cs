using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace List_Controls
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			UpdateUI();
			

		}

		public void UpdateUI()
		{
			TextMain.Text = StringsUI.TextMain;
			TextSolarSystem.Text = StringsUI.TextSolarSystem;
			TextStruct.Text = StringsUI.TextStruct;
			TextSun.Text = StringsUI.TextSun;
			TextMercury.Text = StringsUI.TextMercury;
			TextVenus.Text = StringsUI.TextVenus;
			TextEarth.Text = StringsUI.TextEarth;
			TextMars.Text = StringsUI.TextMars;
			TextJupiter.Text = StringsUI.TextJupiter;
			TextSaturn.Text = StringsUI.TextSaturn;
			TextUranus.Text	= StringsUI.TextUranus;
			TextNeptune.Text = StringsUI.TextNeptune;
			TextNinePlanet.Text = StringsUI.TextNinePlanet;
			TextKontakt.Text = StringsUI.TextKontakt;

			TabSolarSystem.Header = StringsUI.TabSolarSystem;
			TabStruct.Header = StringsUI.TabSaturn;
			TabSun.Header = StringsUI.TabSun;
			TabMercury.Header = StringsUI.TabMercury;
			TabVenus.Header = StringsUI.TabVenus;
			TabEarth.Header = StringsUI.TabEarth;
			TabMars.Header = StringsUI.TabMars;
			TabJupiter.Header = StringsUI.TabJupiter;
			TabSaturn.Header = StringsUI.TabSaturn;
			TabUranus.Header = StringsUI.TabUran;
			TabNeptune.Header = StringsUI.TabNeptun;
			TabNinePlanet.Header = StringsUI.TabNinePlanet;
			TabKontakt.Header = StringsUI.TabKontakt;



		}

		private void SwitchLoc()
		{
			if (Thread.CurrentThread.CurrentUICulture.Name.Contains("en"))
				Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru");
			else
				if (Thread.CurrentThread.CurrentUICulture.Name.Contains("ru"))
				Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
		}

		private void SwitchLocUpdateButton_Click(object sender, RoutedEventArgs e)
		{
			SwitchLoc();
			UpdateUI();
		}

		private void SwitchLocNoUpdateButton_Click(object sender, RoutedEventArgs e)
		{
			SwitchLoc();
		}


		private void MenuItem_Click_1(object sender, RoutedEventArgs e)
		{
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru");
			UpdateUI();

		}

		private void MenuItem_Click_2(object sender, RoutedEventArgs e)
		{
			Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
			UpdateUI();

		}

		private void MenuItem_Click_3(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("В процессе перевода наберитесь терпения =)" +
				"Be patient during the translation process =)");

		}

	}
}