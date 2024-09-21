using System.Windows;
using System.Windows.Controls;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Interaction logic for CadastroAlunoControl.xaml
    /// </summary>
    public partial class CadastroAlunoControl : UserControl
    {
        public CadastroAlunoControl()
        {
            InitializeComponent();
            this.Loaded += UserControl_Loaded;
            this.KeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);
            this.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);
            textBoxCpf.PreviewTextInput += ClassFuncoes.TxtCPF_PreviewTextInput;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }
    }
}
