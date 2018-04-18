﻿using System;
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
using System.Windows.Shapes;

namespace GuarderiaCADI
{
    /// <summary>
    /// Lógica de interacción para vntLogin.xaml
    /// </summary>
    public partial class vntLogin : Window
    {
        public vntLogin()
        {
            InitializeComponent();
        }

        private void Rectangulo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

      

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnContinuar_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            vntGuarderia G = new vntGuarderia();
            G.Show();
        }
    }
}
