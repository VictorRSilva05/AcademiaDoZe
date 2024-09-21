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
            this.KeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);
            this.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(ClassFuncoes.Window_KeyDown);
            textBoxCpf.PreviewTextInput += ClassFuncoes.TxtCPF_PreviewTextInput;
        }

        private void CadastrarFrequenciaWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }
    }
}
