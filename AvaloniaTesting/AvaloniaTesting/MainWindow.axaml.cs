using Avalonia.Controls;
using Avalonia.Media;
using System;

namespace AvaloniaTesting
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			
			InitializeComponent();
		}

		private void TextBox_PointerPressed(object? sender, Avalonia.Input.PointerPressedEventArgs e)
		{
			Random _random = new Random();
			int _r = _random.Next(0, 10);
			switch (_r)
			{
				case 0:
					WelcomeTextBox.Background = Brushes.Yellow;
					break;
				case 1:
					WelcomeTextBox.Background = Brushes.Blue;
					break;
				case 2:
					WelcomeTextBox.Background = Brushes.Green;
					break;
				case 3:
					WelcomeTextBox.Background = Brushes.Gray;
					break;
				case 4:
					WelcomeTextBox.Background = Brushes.Cyan;
					break;
				case 5:
					WelcomeTextBox.Background = Brushes.SkyBlue;
					break;
				case 6:
					WelcomeTextBox.Background = Brushes.LightBlue;
					break;
				case 7:
					WelcomeTextBox.Background = Brushes.Aqua;
					break;
				case 8:
					WelcomeTextBox.Background = Brushes.Orange;
					break;
				case 9:
					WelcomeTextBox.Background = Brushes.Red;
					break;
				default:
					WelcomeTextBox.Background = Brushes.White;
					break;
			}
		}
	}
}