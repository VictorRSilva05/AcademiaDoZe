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
        }

        private void CadastroColaboradorControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }
    }
}
