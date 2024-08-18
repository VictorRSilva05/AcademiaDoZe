using System.Windows;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Interaction logic for CadastrarSenhaWindow.xaml
    /// </summary>
    public partial class CadastrarSenhaWindow : Window
    {
        public CadastrarSenhaWindow()
        {
            InitializeComponent();
            this.Loaded += CadastrarSenhaWindow_Loaded;
        }

        private void CadastrarSenhaWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }
    }
}
