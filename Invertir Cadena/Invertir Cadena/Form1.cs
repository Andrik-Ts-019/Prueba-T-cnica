namespace Invertir_Cadena
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Invert()
        {
            char[] outString = inputString.Text.ToCharArray();
            Array.Reverse(outString);

            string finalOutputString = new(outString);

            // Permite el salto de linea
            finalOutputString = finalOutputString.Replace("\n\r", "\r\n");

            outputString.Text = new string(finalOutputString);
        }

        private void Home_Closed(object sender, FormClosedEventArgs e)
        {
            splashScreenForm?.Close();
        }

        private void CheckInvertir_CheckedChanged(object sender, EventArgs e)
        {
            buttonInvert.Enabled = (checkInvert.Checked is false);
        }

        private void ButtonInvert_Click(object sender, EventArgs e)
        {
            buttonInvert.Enabled = (checkInvert.Checked is false);

            Invert();
        }

        private void InputString_TextChanged(object sender, EventArgs e)
        {
            if (checkInvert.Checked is false) return;

            Invert();
        }
    }
}