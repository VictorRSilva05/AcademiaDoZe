using System.Globalization;
using System.Windows;

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

        private void ChangeLanguage(string cultureCode)
        {
            // en-US, es-ES, pt-BR
            // Definir a cultura
            CultureInfo culture = new CultureInfo(cultureCode);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            // Recargar a interface do usuário para refletir as mudanças
            var oldWindow = this;
            var newWindow = new MainWindow();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            oldWindow.Close();
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

        private void button_frequencia_Click(object sender, RoutedEventArgs e)
        {
            CadastrarFrequenciaWindow cadastrarFrequenciaWindow = new CadastrarFrequenciaWindow();

            cadastrarFrequenciaWindow.Show();
        }

        private void button_login_logoff_Click(object sender, RoutedEventArgs e)
        {
            LoginControl loginControl = new LoginControl();

            ContentControl_main.Content = loginControl;
        }

        private void button_espanhol_Click(object sender, RoutedEventArgs e)
        {
            ChangeLanguage("es-ES");
        }

        private void button_ingles_Click(object sender, RoutedEventArgs e)
        {
            ChangeLanguage("en-US");
        }

        private void button_portugues_Click(object sender, RoutedEventArgs e)
        {
            ChangeLanguage("pt-BR");
        }
    }
}