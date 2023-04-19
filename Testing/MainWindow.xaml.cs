using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

namespace Testing
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

   

        #region Мин 3 || Макс 15  || - или && - и

        private void TBL_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // если длина<15 и длина>3 , тогда зеленое

            /*if(TBL.Text.Length > 3 && TBL.Text.Length < 15)
                TBL.Background = Brushes.Green;
            else
            {
                if (TBL.Text.Length > 15)
                    e.Handled = true;

                TBL.Background = Brushes.Red;
            }*/
            if (TBL.Text.Length > 14)
                e.Handled = true;

            if (TBL.Text.Length < 3)
                TBL.Background = Brushes.Red;
            else
                TBL.Background = Brushes.Green;
        }

        private void TBL_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TBL.Text.Length < 3)
                TBL.Background = Brushes.Red;
            else
                TBL.Background = Brushes.Green;
        }

        #endregion

        #region Валидация mail

        private void EmailTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            var trimmedEmail = EmailTB.Text.Trim();

            if (EmailTB.Text.EndsWith("."))
            {
                EmailTB.Background = Brushes.Red;
                return;
            }
                
            if (trimmedEmail.EndsWith("."))
            {
                EmailTB.Background = Brushes.Red;
                return;
            }

            try
            {
                var addr = new MailAddress(EmailTB.Text);
                EmailTB.Background = addr.Address == trimmedEmail ? Brushes.Green : Brushes.Red;
            }
            catch
            {
                EmailTB.Background = Brushes.Red;
            }

        }

        #endregion

        #region Ввод только положительных 1-9
        private void TB2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0) || e.Text == "0")
                e.Handled = true;
        }
        #endregion

        #region Только 6 цифр
        private void TB3_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0) || TB3.Text.Length > 5)
                e.Handled = true;
        }
        #endregion

        #region Только 4 цифры не отрицательное
        private void TB4_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (TB4.Text.Length != 0)
            {
                if (!Char.IsDigit(e.Text, 0) || TB4.Text.Length > 3)
                    e.Handled = true;
            }
            else
                if (!Char.IsDigit(e.Text, 0) || e.Text == "0")
                    e.Handled = true;

            if (TB4.Text.Length < 3)
                TB4.Background = Brushes.Red;
            else
                TB4.Background = Brushes.Green;
        }
        #endregion
        
    }
}
