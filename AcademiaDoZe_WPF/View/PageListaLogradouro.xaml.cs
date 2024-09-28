using AcademiaDoZe_WPF.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AcademiaDoZe_WPF.View
{
    /// <summary>
    /// Interaction logic for PageListaLogradouro.xaml
    /// </summary>
    public partial class PageListaLogradouro : Page
    {
        // Atributos para conexão e persistência com o banco de dados
        private string ConnectionString { get; set; }
        private string ProviderName { get; set; }

        // declaração ViewModel
        private LogradouroViewModel ViewModelLogradouro;
        public PageListaLogradouro(string providerName, string connectionString)
        {
            InitializeComponent();
            ConnectionString = connectionString;
            ProviderName = providerName;

            try
            {
                // criação de objeto ViewModel
                ViewModelLogradouro = new LogradouroViewModel(ProviderName, ConnectionString);
                // carrega os dados
                ViewModelLogradouro.Load();
                // associa o objeto da ViewModel ao DataContext da janela
                // DataContext é uma propriedade que permite que elementos de interface gráfica sejam associados a objetos de dados
                DataContext = ViewModelLogradouro;
            }
            catch
            {
                MessageBox.Show("Erro ao carregar a lista de logradouros!");
            }
        }


        private void ButtonNovo_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new CadastroLogradouroControl());
        }

    }

}
    
