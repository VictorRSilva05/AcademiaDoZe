using System.Windows;
using System.Windows.Controls;

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
            this.KeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);
            this.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);
            textBoxCpf.PreviewTextInput += ClassFuncoes.TxtCPF_PreviewTextInput;
            textbox_id_senha.Focus();
        }

        private void CadastrarSenhaWindow_Loaded(object sender, RoutedEventArgs e)
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
