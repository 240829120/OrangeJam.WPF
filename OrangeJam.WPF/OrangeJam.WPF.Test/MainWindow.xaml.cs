using OrangeJam.WPF.SVG;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

namespace OrangeJam.WPF.Test
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                List<string> list = new List<string>();

                string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

                foreach (string p in System.IO.Directory.GetFiles(path, "*.svg"))
                {
                    list.Add(System.IO.Path.GetFileName(p));
                }

                this.lb.ItemsSource = list;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string name = this.lb.SelectedValue == null ? null : this.lb.SelectedValue.ToString();

            if (string.IsNullOrWhiteSpace(name))
            {
                this.img.Source = null;
            }
            else
            {
                string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", name);

                SVG.SVG svg = SVGReader.Read(path);

                this.img.Source = new DrawingImage(svg.GetDrawing());
            }
        }
    }
}
