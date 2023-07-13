namespace Invertir_Cadena
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBoxTitleSS = new TextBox();
            textBoxProgramName = new TextBox();
            textBoxVersion = new TextBox();
            timerSS = new System.Windows.Forms.Timer(components);

            SuspendLayout();

            // 
            // textBoxTitleSS
            // 
            textBoxTitleSS.BackColor = SystemColors.Control;
            textBoxTitleSS.BorderStyle = BorderStyle.None;
            textBoxTitleSS.Font = new Font("Courier New", 20F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxTitleSS.Location = new Point(59, 39);
            textBoxTitleSS.Name = "textBoxTitleSS";
            textBoxTitleSS.ReadOnly = true;
            textBoxTitleSS.Size = new Size(313, 31);
            textBoxTitleSS.TabIndex = 1;
            textBoxTitleSS.Text = "Prueba Técnica";
            textBoxTitleSS.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxProgramName
            // 
            textBoxProgramName.BackColor = SystemColors.Control;
            textBoxProgramName.BorderStyle = BorderStyle.None;
            textBoxProgramName.Font = new Font("Courier New", 15F, FontStyle.Italic, GraphicsUnit.Point);
            textBoxProgramName.Location = new Point(71, 111);
            textBoxProgramName.Name = "textBoxProgramName";
            textBoxProgramName.Size = new Size(285, 23);
            textBoxProgramName.TabIndex = 2;
            textBoxProgramName.Text = "Invertidor de texto.";
            textBoxProgramName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxVersion
            // 
            textBoxVersion.BackColor = SystemColors.Control;
            textBoxVersion.BorderStyle = BorderStyle.None;
            textBoxVersion.Font = new Font("Century", 7F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxVersion.Location = new Point(327, 193);
            textBoxVersion.Name = "textBoxVersion";
            textBoxVersion.Size = new Size(88, 12);
            textBoxVersion.TabIndex = 3;
            textBoxVersion.Text = "Versión 1.0.0";
            textBoxVersion.TextAlign = HorizontalAlignment.Center;
            // 
            // timerSS
            // 
            timerSS.Enabled = true;
            timerSS.Interval = 2000;
            timerSS.Tick += TimerSS_Tick;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 217);
            ControlBox = false;
            Controls.Add(textBoxVersion);
            Controls.Add(textBoxProgramName);
            Controls.Add(textBoxTitleSS);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SplashScreen";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitleSS;
        private TextBox textBoxProgramName;
        private TextBox textBoxVersion;
        private System.Windows.Forms.Timer timerSS;
    }
}