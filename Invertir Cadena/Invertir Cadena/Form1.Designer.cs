namespace Invertir_Cadena
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Allows control of the SplashScreen form
        /// </summary>
        public SplashScreen splashScreenForm { get; set; } = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputString = new TextBox();
            outputString = new TextBox();
            buttonInvert = new Button();
            labelOString = new Label();
            labelIString = new Label();
            checkInvert = new CheckBox();
            SuspendLayout();
            // 
            // inputString
            // 
            inputString.AccessibleName = "INPUT STRING";
            inputString.Location = new Point(12, 36);
            inputString.Multiline = true;
            inputString.Name = "inputString";
            inputString.Size = new Size(465, 66);
            inputString.TabIndex = 0;
            inputString.TextChanged += InputString_TextChanged;
            // 
            // outputString
            // 
            outputString.AccessibleName = "OUTPUT STRING";
            outputString.BackColor = Color.White;
            outputString.Location = new Point(12, 208);
            outputString.Multiline = true;
            outputString.Name = "outputString";
            outputString.ReadOnly = true;
            outputString.Size = new Size(465, 66);
            outputString.TabIndex = 1;
            // 
            // buttonInvert
            // 
            buttonInvert.Location = new Point(201, 132);
            buttonInvert.Name = "buttonInvert";
            buttonInvert.Size = new Size(94, 39);
            buttonInvert.TabIndex = 2;
            buttonInvert.Text = "Invertir";
            buttonInvert.UseVisualStyleBackColor = true;
            buttonInvert.Click += ButtonInvert_Click;
            // 
            // labelOString
            // 
            labelOString.AutoSize = true;
            labelOString.Location = new Point(12, 190);
            labelOString.Name = "labelOString";
            labelOString.Size = new Size(88, 15);
            labelOString.TabIndex = 3;
            labelOString.Tag = "";
            labelOString.Text = "Texto invertido:";
            // 
            // labelIString
            // 
            labelIString.AutoSize = true;
            labelIString.Location = new Point(12, 18);
            labelIString.Name = "labelIString";
            labelIString.Size = new Size(157, 15);
            labelIString.TabIndex = 4;
            labelIString.Tag = "";
            labelIString.Text = "Introduzca el texto a invertir:";
            // 
            // checkInvert
            // 
            checkInvert.AutoSize = true;
            checkInvert.Location = new Point(314, 108);
            checkInvert.Name = "checkInvert";
            checkInvert.Size = new Size(163, 19);
            checkInvert.TabIndex = 5;
            checkInvert.Text = "Invertir automáticamente.";
            checkInvert.UseVisualStyleBackColor = true;
            checkInvert.CheckedChanged += CheckInvertir_CheckedChanged;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 304);
            Controls.Add(checkInvert);
            Controls.Add(labelIString);
            Controls.Add(labelOString);
            Controls.Add(buttonInvert);
            Controls.Add(outputString);
            Controls.Add(inputString);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Home";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invertir Cadena";
            FormClosed += Home_Closed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputString;
        private TextBox outputString;
        private Button buttonInvert;
        private Label labelOString;
        private Label labelIString;
        private CheckBox checkInvert;
    }
}