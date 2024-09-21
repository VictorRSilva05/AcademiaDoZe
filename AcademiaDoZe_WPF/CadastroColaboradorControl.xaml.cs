using System.Windows.Controls;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Interaction logic for CadastroColaboradorControl.xaml
    /// </summary>
    public partial class CadastroColaboradorControl : UserControl
    {
        public CadastroColaboradorControl()
        {
            InitializeComponent();
            this.Loaded += CadastroColaboradorControl_Loaded;
            this.KeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);
            this.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);
            textBoxCpf.PreviewTextInput += ClassFuncoes.TxtCPF_PreviewTextInput;
        }

        private void CadastroColaboradorControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }
    }
}
