using System;
using System.Text;
using System.Windows;

namespace WpfAppNote
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string phone = txtPhone.Text;
            MessageBox.Show($"姓名: {name}\n電話: {phone}");
        }

        private void BtnGenerate_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtN.Text, out int n))
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        sb.Append($"{i}*{j}={i * j}\t");
                    }
                    sb.AppendLine();
                }
                tbResult.Text = sb.ToString();
            }
        }
    }
}

