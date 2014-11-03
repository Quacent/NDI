using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Threading.Tasks;

/// <summary>
/// 程序的启动窗口
/// </summary>
namespace UI
{
	public class StartWindow : Window
	{
		private static BackgroundWorker backgroundWorker = new BackgroundWorker ();

		public StartWindow ()
		{
			Title = "StartWindow";

			WindowStartupLocation = WindowStartupLocation.CenterScreen;
			WindowStyle = WindowStyle.ToolWindow;
			ShowInTaskbar = false;
			SizeToContent = SizeToContent.WidthAndHeight;
			ResizeMode = ResizeMode.NoResize;

			ImageBrush imgBrush = new ImageBrush ();
			BitmapImage bitmap = new BitmapImage (new Uri (@"C:\Users\Sharry\Documents\projects\NDI\Resources\Images\startWindow.jpg"));
			imgBrush.ImageSource = bitmap;
			Background = imgBrush;

			//canvas
			Canvas canvas = new Canvas ();
			canvas.Height = bitmap.Height;
			canvas.Width = bitmap.Width;

			//progressbar
			ProgressBar progressBar = new ProgressBar ();
			progressBar.Width = bitmap.Width;
			progressBar.Height = 20;
			progressBar.IsIndeterminate = true;Console.WriteLine (ActualHeight);
			Canvas.SetTop (progressBar, bitmap.Height - progressBar.Height);
			Canvas.SetLeft (progressBar, 0.0);
			canvas.Children.Add (progressBar);
			//text
			TextBox textBox = new TextBox ();
			textBox.Background = Brushes.Transparent;
			textBox.BorderBrush = Brushes.Transparent;
			textBox.BorderThickness = new Thickness (1.0);
			textBox.Height = 200;
			textBox.Width = 250;

			backgroundWorker.WorkerReportsProgress = true;

			Canvas.SetTop (textBox, bitmap.Height - progressBar.Height - textBox.Height - 5);
			Canvas.SetLeft (textBox, 5);
			canvas.Children.Add (textBox);

			Content = canvas;
		}

		/// <summary>
		/// 调用数据库
		/// </summary>
		/// <param name="sender">Sender.</param>
		private static void AccessDataBase(object sender)
		{
			TextBox txtbox = sender as TextBox;
			for (int i = 0; i < 100000; i++) {
				txtbox.Text = "This is good";
				backgroundWorker.ReportProgress (1);
			}
		}
	}
}
