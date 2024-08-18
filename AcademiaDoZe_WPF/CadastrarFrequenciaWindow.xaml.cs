using System.Windows;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Interaction logic for CadastrarFrequenciaWindow.xaml
    /// </summary>
    public partial class CadastrarFrequenciaWindow : Window
    {
        public CadastrarFrequenciaWindow()
        {
            InitializeComponent();
            this.Loaded += CadastrarFrequenciaWindow_Loaded;
        }

        private void CadastrarFrequenciaWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }
    }
}
