using System;
using System.Windows;

namespace Primera_Interfaz
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

        // TAREAS A IMPLEMENTAR EN UN FUTURO PARA MEJORAR LA APP:

            // Añadir una fila más de operaciones (debajo de la primera).

            // Intentar mejorarla de manera que muestre también la operación (no solo el resultado).

            // Implementar que se puedan usar teclas del teclado numérico en lugar de solo los botones de la interfaz.

            // Añadir imagen de Aplicación.


        //Variables
        string operador = "";
        double num1 = 0;
        double num2 = 0;


        private void Borrar_Todo(object sender, RoutedEventArgs e)
        {

            MiTextBlock.Text = "0";
        }

        private void Borrar_1_Elemento(object sender, RoutedEventArgs e)
        {

            if (MiTextBlock.Text.Length == 1) MiTextBlock.Text = "0";  // Si tenemos 1 solo dígito, entonces al pulsar ⌫, el textblock valdrá 0. 
            else MiTextBlock.Text = MiTextBlock.Text.Substring(0, MiTextBlock.Text.Length - 1); // De lo contrario, eliminamos el último carácter.
        }

        private void Clickar_0(object sender, RoutedEventArgs e)
        {
            if (MiTextBlock.Text == "0") MiTextBlock.Text = "0";
            else MiTextBlock.Text += "0";
        }

        private void Clickar_1(object sender, RoutedEventArgs e)
        {

            if (MiTextBlock.Text == "0") MiTextBlock.Text = "";
            MiTextBlock.Text += "1";
        }

        private void Clickar_2(object sender, RoutedEventArgs e)
        {

            if (MiTextBlock.Text == "0") MiTextBlock.Text = "";
            MiTextBlock.Text += "2";
        }

        private void Clickar_3(object sender, RoutedEventArgs e)
        {

            if (MiTextBlock.Text == "0") MiTextBlock.Text = "";
            MiTextBlock.Text += "3";
        }

        private void Clickar_4(object sender, RoutedEventArgs e)
        {

            if (MiTextBlock.Text == "0") MiTextBlock.Text = "";
            MiTextBlock.Text += "4";
        }

        private void Clickar_5(object sender, RoutedEventArgs e)
        {

            if (MiTextBlock.Text == "0") MiTextBlock.Text = "";
            MiTextBlock.Text += "5";
        }

        private void Clickar_6(object sender, RoutedEventArgs e)
        {

            if (MiTextBlock.Text == "0") MiTextBlock.Text = "";
            MiTextBlock.Text += "6";
        }

        private void Clickar_7(object sender, RoutedEventArgs e)
        {

            if (MiTextBlock.Text == "0") MiTextBlock.Text = "";
            MiTextBlock.Text += "7";
        }

        private void Clickar_8(object sender, RoutedEventArgs e)
        {

            if (MiTextBlock.Text == "0") MiTextBlock.Text = "";
            MiTextBlock.Text += "8";
        }

        private void Clickar_9(object sender, RoutedEventArgs e)
        {

            if (MiTextBlock.Text == "0") MiTextBlock.Text = "";
            MiTextBlock.Text += "9";
        }

        private void Clickar_Coma(object sender, RoutedEventArgs e)
        {

            if (
                MiTextBlock.Text.Length > 0 &&  // Verifica que haya algo en el TextBlock
                !MiTextBlock.Text.EndsWith(",") &&  // No permitimos doble coma seguida
                char.IsDigit(MiTextBlock.Text[MiTextBlock.Text.Length - 1]) &&  // Solo agregamos coma si termina en un dígito
                !MiTextBlock.Text.Substring(MiTextBlock.Text.LastIndexOfAny(new char[] { '+', '-', 'x', '÷' }) + 1).Contains(",")) // Comprueba
                                                                                                                                   // que después de un operador (+, -, x, ÷),
                                                                                                                                   // el siguiente número no contenga una coma.

            {
                MiTextBlock.Text += ",";
            }
        }

        private void Clickar_Porcentaje(object sender, RoutedEventArgs e)
        {

            operador = "%";

            num1 = Convert.ToDouble(MiTextBlock.Text);

            MiTextBlock.Text = "0";
        }

        private void Clickar_Division(object sender, RoutedEventArgs e)
        {

            operador = "/";

            num1 = Convert.ToDouble(MiTextBlock.Text);

            MiTextBlock.Text = "0";
        }

        private void Clickar_Multiplicacion(object sender, RoutedEventArgs e)
        {

            operador = "*";

            num1 = Convert.ToDouble(MiTextBlock.Text);

            MiTextBlock.Text = "0";
        }

        private void Clickar_Suma(object sender, RoutedEventArgs e)
        {

            operador = "+";

            num1 = Convert.ToDouble(MiTextBlock.Text);

            MiTextBlock.Text = "0";
        }

        private void Clickar_Resta(object sender, RoutedEventArgs e)
        {

            operador = "-";

            num1 = Convert.ToDouble(MiTextBlock.Text);

            MiTextBlock.Text = "0";
        }

        private void Clickar_Resultado(object sender, RoutedEventArgs e)
        {

            num2 = Convert.ToDouble(MiTextBlock.Text); // Recuperar como double los valores almacenados en el TextBlock.

            switch (operador)
            {

                case "+":
                    MiTextBlock.Text = $"{num1 + num2}";
                    break;

                case "-":
                    MiTextBlock.Text = $"{num1 - num2}";
                    break;

                case "*":
                    MiTextBlock.Text = $"{num1 * num2}";
                    break;

                case "/":
                    MiTextBlock.Text = $"{num1 / num2}";
                    break;

                case "%":
                    MiTextBlock.Text = $"{(num1 * num2) / 100}";
                    break;

            }
        }
    }
}
