using FontAwesome.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Listener_ClientApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}


		private void Border_MouseDown(object sender, MouseButtonEventArgs e)
		{
			Point mousePos = e.GetPosition(this);

			if (e.ChangedButton == MouseButton.Left &&
				(mousePos.X >= 0 && mousePos.X < Grid_TopPanel.ActualWidth &&
				mousePos.Y >= 0 && mousePos.Y < Grid_TopPanel.ActualHeight))
				this.DragMove();
		}


		private void GoForwardBackward_Click(object sender, RoutedEventArgs e)
		{
			if (sender is not Button button) return;

			string? tag = button.Tag as string;
			if (string.IsNullOrEmpty(tag)) return;

			switch (tag)
			{
				case "Forward":
					if (MainFrame.CanGoForward)
						MainFrame.GoForward();
					break;

				case "Backward":
					if (MainFrame.CanGoBack)
						MainFrame.GoBack();
					break;
			}
		}


		private void WindowPanelButtons_Click(object sender, RoutedEventArgs e)
		{
			if (sender is not Button button) return;

			string? tag = button.Tag as string;
			if (string.IsNullOrEmpty(tag)) return;

			switch (tag)
			{
				case "Minimize":
					WindowState = WindowState.Minimized;
					break;
				case "Maximize":
					var style = (Style)Application.Current.Resources["WindowPanelButtonIcon"];

					Action<WindowState> DefineState = (state) =>
					{
						WindowState = state;
						ImageAwesome ico = new()
						{
							Icon = FontAwesomeIcon.WindowRestore,
							Style = style
						};

						Btn_WindowMaximize.Content = ico;
					};

					if (WindowState == WindowState.Normal)
						DefineState(WindowState.Maximized);
					else
						DefineState(WindowState.Normal);

					break;
				case "Close":
					this.Close();
					break;
			}
		}
	}
}
