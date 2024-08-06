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

namespace AcademiaDoZe_WPF
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


        private void button_logradouro_Click(object sender, RoutedEventArgs e)
        {
            CadastroLogradouroControl cadastroLogradouroControl = new CadastroLogradouroControl();

            ContentControl_main.Content = cadastroLogradouroControl;
        }

        private void button_aluno_Click(object sender, RoutedEventArgs e)
        {
            CadastroAlunoControl cadastroAlunoControl = new CadastroAlunoControl();

            ContentControl_main.Content = cadastroAlunoControl;
        }
    }
}