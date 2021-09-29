
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace FormatoTexto
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

        private void TextoACambiarTextBox_TextChanged(object sender, TextChangedEventArgs e) => TextoCambiadoTextBox.Text = TextoACambiarTextBox.Text;
        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e) => TextoCambiadoTextBox.FontWeight = FontWeights.Bold;
        private void NegritaCheckBox_UnChecked(object sender, RoutedEventArgs e) => TextoCambiadoTextBox.FontWeight = FontWeights.Normal;
        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e) => TextoCambiadoTextBox.FontStyle = FontStyles.Italic;
        private void CursivaCheckBox_UnChecked(object sender, RoutedEventArgs e) => TextoCambiadoTextBox.FontStyle = FontStyles.Normal;
        private void AzulRadioButton_Checked(object sender, RoutedEventArgs e) => TextoCambiadoTextBox.Foreground = Brushes.Blue;
        private void VerdeRadioButton_Checked(object sender, RoutedEventArgs e) => TextoCambiadoTextBox.Foreground = Brushes.Green;
        private void RojoRadioButton_Checked(object sender, RoutedEventArgs e) => TextoCambiadoTextBox.Foreground = Brushes.Red;
    }
}
