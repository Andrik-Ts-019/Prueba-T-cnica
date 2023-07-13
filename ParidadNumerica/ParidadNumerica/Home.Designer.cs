namespace ParidadNumerica
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        /// <summary>
        /// Allows control of the SplashScreen form
        /// </summary>
        public SplashScreen splashScreenForm { get; set; } = null;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NumericInput = new TextBox();
            InstructionsLabel = new Label();
            ParityTittleLabel = new Label();
            ResultLabel = new Label();
            SuspendLayout();
            // 
            // NumericInput
            // 
            NumericInput.Location = new Point(12, 46);
            NumericInput.Name = "NumericInput";
            NumericInput.Size = new Size(244, 23);
            NumericInput.TabIndex = 0;
            NumericInput.TextChanged += NumericInput_TextChanged;
            // 
            // InstructionsLabel
            // 
            InstructionsLabel.AutoSize = true;
            InstructionsLabel.Location = new Point(12, 28);
            InstructionsLabel.Name = "InstructionsLabel";
            InstructionsLabel.Size = new Size(145, 15);
            InstructionsLabel.TabIndex = 1;
            InstructionsLabel.Text = "Ingrese cualquier número:";
            // 
            // ParityTittleLabel
            // 
            ParityTittleLabel.AutoSize = true;
            ParityTittleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ParityTittleLabel.Location = new Point(12, 93);
            ParityTittleLabel.Name = "ParityTittleLabel";
            ParityTittleLabel.Size = new Size(51, 15);
            ParityTittleLabel.TabIndex = 2;
            ParityTittleLabel.Text = "Paridad:";
            // 
            // ResultLabel
            // 
            ResultLabel.AutoSize = true;
            ResultLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            ResultLabel.Location = new Point(12, 108);
            ResultLabel.MaximumSize = new Size(244, 122);
            ResultLabel.MinimumSize = new Size(244, 23);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(244, 23);
            ResultLabel.TabIndex = 3;
            ResultLabel.Text = "Sin resultado.";
            ResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 253);
            Controls.Add(ResultLabel);
            Controls.Add(ParityTittleLabel);
            Controls.Add(InstructionsLabel);
            Controls.Add(NumericInput);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Home";
            ShowIcon = false;
            Text = "Paridad de Números";
            FormClosed += Home_Closed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NumericInput;
        private Label InstructionsLabel;
        private Label ParityTittleLabel;
        private Label ResultLabel;
    }
}