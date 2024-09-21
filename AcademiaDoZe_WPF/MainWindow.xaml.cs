using System.Globalization;
using System.Windows;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// This window, as the name implies is the main window for the application
    /// It also serves as a hub for the diferent options
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

        private void buttonConfig_Click(object sender, RoutedEventArgs e)
        {
            WindowConfig windowConfig = new();
            windowConfig.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            windowConfig.ShowDialog();
            // Recarregar a interface do usuário para refletir as mudanças
            var newWindow = new MainWindow();
            Application.Current.MainWindow = newWindow;
            newWindow.Show();
            Close();
        }

        public void button_home_Click(object sender, RoutedEventArgs e)
        {
            ContentControl_main.Content = null;
        }
    }
}