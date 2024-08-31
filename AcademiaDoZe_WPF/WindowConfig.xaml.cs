using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;

namespace AcademiaDoZe_WPF
{
    /// <summary>
    /// Interaction logic for WindowConfig.xaml
    /// </summary>
    public partial class WindowConfig : Window
    {
        public WindowConfig()
        {
            InitializeComponent();

            //seleciona no comboBox o idioma/cultura atual
            comboBoxIdioma.SelectedItem = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
            this.Loaded += WindowConfig_Loaded;
        }

        private void WindowConfig_Loaded(object sender, RoutedEventArgs e)
        {
            ClassFuncoes.AjustaResources(this);
        }

        private void buttonSalvar_Click(object sender, RoutedEventArgs e)
        {
            //abre o arquivo local como leitura/escrita e salva as alterações em AcademiaDoZe_WPF.dll.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", comboBoxIdioma.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            //atualiza a cultura corrente
            ClassFuncoes.AjustaIdiomaRegiao();
            Close();
            _ = MessageBox.Show("Idioma/região alterada com sucesso!");
        }
    }
}
