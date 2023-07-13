namespace ParidadNumerica
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void NumericInput_TextChanged(object sender, EventArgs e)
        {
            string resultMessage = NumericInput.Text;

            resultMessage = ValidateInput(resultMessage, out bool isNumeric, out double? number);

            if (isNumeric)
            {
                resultMessage = (number % 2 == 0) ? $"El número {number} es par."
                                                  : $"El número {number} es impar.";
            }

            ResultLabel.Text = resultMessage;
        }

        private static string ValidateInput(string resultMessage, out bool isNumeric, out double? number)
        {
            number = null;

            resultMessage = resultMessage.Trim();

            try
            {
                number = Convert.ToDouble(resultMessage);

                isNumeric = true;
            }
            catch (FormatException)
            {
                resultMessage = "Debe de ingresar un número.";

                isNumeric = false;
            }
            catch (OverflowException)
            {
                resultMessage = "Overflow!!! No hay suficiente memoria.";

                isNumeric = false;
            }

            //resultMessage ??= "Sin resultado.";

            resultMessage = resultMessage == string.Empty ? "Sin resultado." : resultMessage;

            return resultMessage;
        }

        private void Home_Closed(object sender, FormClosedEventArgs e)
        {
            splashScreenForm?.Close();
        }
    }
}