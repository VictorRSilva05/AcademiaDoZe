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
            this.KeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);
            this.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);
            textBoxCpf.PreviewTextInput += ClassFuncoes.TxtCPF_PreviewTextInput;
        }

        private void CadastrarSenhaWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }
    }
}
