using System.Windows.Controls;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Interaction logic for CadastrarAvaliacaoControl.xaml
    /// </summary>
    public partial class CadastrarAvaliacaoControl : UserControl
    {
        public CadastrarAvaliacaoControl()
        {
            InitializeComponent();
            this.Loaded += CadastrarAvaliacaoControl_Loaded;
        }

        private void CadastrarAvaliacaoControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }

        private void textbox_antebraco_esq_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
