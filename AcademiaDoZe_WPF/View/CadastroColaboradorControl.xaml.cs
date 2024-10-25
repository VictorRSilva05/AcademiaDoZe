using AcademiaDoZe_WPF.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace AcademiaDoZe_WPF.View
{
    /// <summary>
    /// Interaction logic for CadastroColaboradorControl.xaml
    /// </summary>
    public partial class CadastroColaboradorControl : Window
    {
        public CadastroColaboradorControl()
        {
            InitializeComponent();
            this.Loaded += CadastroColaboradorControl_Loaded;
            this.KeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);
            this.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);
            textBoxId.Focus();
            this.KeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);
            this.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);

            DataContext = new ColaboradorCadastroViewModel();
        }

        private void CadastroColaboradorControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }

        private void Box_GotFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            var cor = System.Windows.Media.Brushes.LightCyan;
            if (sender is TextBox)
            {
                TextBox textBox = (TextBox)sender;
                textBox.Background = cor;
            }
            else if (sender is PasswordBox)
            {
                PasswordBox passwordBox = (PasswordBox)sender;
                passwordBox.Background = cor;
            }
        }
        private void Box_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            var cor = System.Windows.Media.Brushes.White;
            if (sender is TextBox)
            {
                TextBox textBox = (TextBox)sender;
                textBox.Background = cor;
            }
            else if (sender is PasswordBox)
            {
                PasswordBox passwordBox = (PasswordBox)sender;
                passwordBox.Background = cor;
            }
        }
    }
}
