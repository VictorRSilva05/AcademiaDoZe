using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Configuration;
using System.Globalization;

namespace AcademiaDoZe_WPF
{
    class ClassFuncoes
    {
        /// <summary>
        /// De forma recursiva, varre todos os componentes da tela informada, executando o método ApplyResources em cada um dos componentes localizados.
        /// O ApplyResources realiza a leitura do satellite assembly, ou seja, do arquivo de resource que foi ativo conforme o idioma escolhido pelo usuário,
        /// e com base no nome do campo ajusta todos os parâmetros contidos no resource para aquele campo, por exemplo Text, Content, Font, Size, etc.
        /// Deve possuir, em Properties, um arquivo de resources para cada idioma desejado, devendo ser alimentado na coluna nome o nome do campo e a propriedade que deseja ajustar.
        /// Por exemplo, em cadeias de caracteres labelLogin.Content, em outros textBoxSenha.PasswordChar, ou seja, todas as propriedades podem ser ajustadas conforme o idioma e região em uso.
        /// </summary>
        /// <param name="parent">Informar o container inicial, geralmente this para pegar todos os campos da tela, ou então, por exemplo, o nome de um panel ou usercontrol.</param>
        public static void AjustaIdiomaRegiao()
        {
            // pt-BR, en-US, es-ES
            // ? indica que o valor pode ser nulo
            string? auxIdiomaRegiao = ConfigurationManager.AppSettings.Get("IdiomaRegiao");
            // no ternário estamos tratando para isso não acontecer
            string idiomaRegiao = (auxIdiomaRegiao is not null) ? auxIdiomaRegiao : "";
            // Definir a cultura e ajusta o idioma/região
            // o operador ! (null-forgiving) afirma que o valor já foi tratado e não será nulo aqui
            CultureInfo culture = new(idiomaRegiao!);
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
        }
        public static void AjustaResources(DependencyObject parent)
        {
            if (parent == null) return;
            // Percorre cada filho direto do objeto pai
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(parent); i++)
            {
                // Obtém o filho no índice atual
                var child = VisualTreeHelper.GetChild(parent, i);
                if (child is FrameworkElement element)
                {
                    // Aplicar recursos ao componente
                    ComponentResourceManager resources = new(typeof(Properties.Idioma));
                    resources.ApplyResources(element, element.Name);
                }
                // Chama recursivamente para percorrer os filhos do filho atual
                AjustaResources(child);
            }
        }
    }
}
