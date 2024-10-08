﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPL1_login_test
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

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            if (nameTextBox.Text == "Admin" && passwordTextBox.Text == "Admin")
            {
                statusTextBlock.Text = "U wordt ingelogt.";
            }
            else
            {
                statusTextBlock.Text = "Foute accountnaam of passwoord.";
            }
        } 

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            statusTextBlock.Text = "";
            nameTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}