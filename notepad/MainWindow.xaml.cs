using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace notepad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            double initialTop = 0d;
            double initialLeft = 0d;
            Loaded += (s, e) =>
            {
                initialTop = Top;
                initialLeft = Left;
            };

            LocationChanged += (s, ea) =>
            {
                var offset = myPopup.HorizontalOffset;
                myPopup.HorizontalOffset = offset + 1;
                myPopup.HorizontalOffset = offset;
            };
        }

        private void StackPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton== MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

    }
}
