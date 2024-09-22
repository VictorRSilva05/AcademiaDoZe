using System.ComponentModel;
using System.Resources;
using System.Windows.Controls;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Interaction logic for CadastroLogradouroControl.xaml
    /// </summary>
    public partial class CadastroLogradouroControl : UserControl
    {
        public CadastroLogradouroControl()
        {
            InitializeComponent();

            this.Loaded += CadastroLogradouroControl_Loaded;
            this.KeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);
            this.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);
            textbox_id.Focus();
        }

        private void CadastroLogradouroControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
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
