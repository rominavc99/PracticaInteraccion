using System;
using System.Collections.Generic;
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

namespace CalculadoraDeAreas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcularAreaRectangulo_Click(object sender, RoutedEventArgs e)
        {
            int RectanguloBase = int.Parse(BaseRectangulo.Text);
            int RectantuloAltura = int.Parse(AlturaRectangulo.Text);
            int RectanguloResultado = RectanguloBase * RectantuloAltura;
            ResultadoRectangulo.Text = RectanguloResultado.ToString();
        }

        private void CalcularAreaTriangulo_Click(object sender, RoutedEventArgs e)
        {
            int TrianguloBase = int.Parse(BaseTriangulo.Text);
            int TrianguloAltura = int.Parse(AlturaTriangulo.Text);
            double TrianguloResultado = (TrianguloBase * TrianguloAltura) / 2;
            ResultadoTriangulo.Text = TrianguloResultado.ToString();
        }

        private void CalcularAreaCirculo_Click(object sender, RoutedEventArgs e)
        {
            int CirculoRadio = int.Parse(RadioCirculo.Text);
            double CirculoResultado = Math.PI * (CirculoRadio * CirculoRadio);
            ResultadoCirculo.Text = CirculoResultado.ToString();
        }

        private void CalcularAreaTrapecio_Click(object sender, RoutedEventArgs e)
        {
            int TrapecioBaseMenor = int.Parse(BaseMenorTrapecio.Text);
            int TrapecioBaseMayor = int.Parse(BaseMayorTrapecio.Text);
            int TrapecioAltura = int.Parse(AlturaTrapecio.Text);
            double TrapecioResultado = TrapecioAltura * ((TrapecioBaseMenor + TrapecioBaseMayor) / 2);
            ResultadoTrapecio.Text = TrapecioResultado.ToString();
        }
    }
}
