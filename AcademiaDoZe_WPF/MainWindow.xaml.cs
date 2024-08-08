using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void button_logradouro_Click(object sender, RoutedEventArgs e)
        {
            CadastroLogradouroControl cadastroLogradouroControl = new CadastroLogradouroControl();

            ContentControl_main.Content = cadastroLogradouroControl;
        }

        private void button_aluno_Click(object sender, RoutedEventArgs e)
        {
            CadastroAlunoControl cadastroAlunoControl = new CadastroAlunoControl();

            ContentControl_main.Content = cadastroAlunoControl;
        }

        private void button_colaborador_Click(object sender, RoutedEventArgs e)
        {
            CadastroColaboradorControl cadastroColaboradorControl = new CadastroColaboradorControl();

            ContentControl_main.Content = cadastroColaboradorControl;
        }

        private void button_senha_Click(object sender, RoutedEventArgs e)
        {
            CadastrarSenhaWindow cadastrarSenhaWindow = new CadastrarSenhaWindow();

            cadastrarSenhaWindow.Show();
        }

        private void button_matricula_Click(object sender, RoutedEventArgs e)
        {
            CadastrarMatriculaControl cadastrarMatriculaControl = new CadastrarMatriculaControl();
            
            ContentControl_main.Content = cadastrarMatriculaControl;
        }

        private void button_avaliacao_Click(object sender, RoutedEventArgs e)
        {
            CadastrarAvaliacaoControl cadastrarAvaliacaoControl = new CadastrarAvaliacaoControl();

            ContentControl_main.Content = cadastrarAvaliacaoControl;
        }
    }
}