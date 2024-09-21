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
        }

        private void CadastroLogradouroControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }
    }
}
