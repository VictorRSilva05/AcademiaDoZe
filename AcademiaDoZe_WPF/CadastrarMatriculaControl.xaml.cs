using System.Windows;
using System.Windows.Controls;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Interaction logic for CadastrarMatriculaControl.xaml
    /// </summary>
    public partial class CadastrarMatriculaControl : UserControl
    {
        public CadastrarMatriculaControl()
        {
            InitializeComponent();
            this.Loaded += CadastrarMatriculaControl_Loaded;
        }

        private void CadastrarMatriculaControl_Loaded(object sender, RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }

        private void checkbox_problemas_cardiacos_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
