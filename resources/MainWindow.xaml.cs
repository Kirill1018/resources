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

namespace resources
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void editing_MouseEnter(object sender, MouseEventArgs e) { editing.Opacity = 1; }

        private void editing_MouseLeave(object sender, MouseEventArgs e) { editing.Opacity = 0.5; }

        private void text_block_of_name_MouseEnter(object sender, MouseEventArgs e) { editing.Opacity = 1; }

        private void text_block_of_name_MouseLeave(object sender, MouseEventArgs e) { editing.Opacity = 0.5; }

        private void name_MouseEnter(object sender, MouseEventArgs e) { editing.Opacity = 1; }

        private void name_MouseLeave(object sender, MouseEventArgs e) { editing.Opacity = 0.5; }

        private void text_block_of_amount_MouseEnter(object sender, MouseEventArgs e) { editing.Opacity = 1; }

        private void text_block_of_amount_MouseLeave(object sender, MouseEventArgs e) { editing.Opacity = 0.5; }

        private void amount_MouseEnter(object sender, MouseEventArgs e) { editing.Opacity = 1; }

        private void amount_MouseLeave(object sender, MouseEventArgs e) { editing.Opacity = 0.5; }

        private void text_block_of_meas_unit_MouseEnter(object sender, MouseEventArgs e) { editing.Opacity = 1; }

        private void text_block_of_meas_unit_MouseLeave(object sender, MouseEventArgs e) { editing.Opacity = 0.5; }

        private void meas_unit_MouseEnter(object sender, MouseEventArgs e) { editing.Opacity = 1; }

        private void meas_unit_MouseLeave(object sender, MouseEventArgs e) { editing.Opacity = 0.5; }

        private void gram_item_MouseEnter(object sender, MouseEventArgs e) { editing.Opacity = 1; }

        private void gram_item_MouseLeave(object sender, MouseEventArgs e) { editing.Opacity = 0.5; }

        private void millilit_item_MouseEnter(object sender, MouseEventArgs e) { editing.Opacity = 1; }

        private void millilit_item_MouseLeave(object sender, MouseEventArgs e) { editing.Opacity = 0.5; }

        private void thing_item_MouseEnter(object sender, MouseEventArgs e) { editing.Opacity = 1; }

        private void thing_item_MouseLeave(object sender, MouseEventArgs e) { editing.Opacity = 0.5; }

        private void addendum_MouseEnter(object sender, MouseEventArgs e) { editing.Opacity = 1; }

        private void addendum_MouseLeave(object sender, MouseEventArgs e) { editing.Opacity = 0.5; }
    }
}