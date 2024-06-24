namespace Ejercicio_I02___Atrapame_si_puedes
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbKilometros = new Label();
            lbLitros = new Label();
            txtKilometros = new TextBox();
            txtLitros = new TextBox();
            btnCalcular = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // lbKilometros
            // 
            lbKilometros.AutoSize = true;
            lbKilometros.Location = new Point(83, 23);
            lbKilometros.Name = "lbKilometros";
            lbKilometros.Size = new Size(81, 20);
            lbKilometros.TabIndex = 0;
            lbKilometros.Text = "Kilometros";
            // 
            // lbLitros
            // 
            lbLitros.AutoSize = true;
            lbLitros.Location = new Point(83, 112);
            lbLitros.Name = "lbLitros";
            lbLitros.Size = new Size(45, 20);
            lbLitros.TabIndex = 1;
            lbLitros.Text = "Litros";
            // 
            // txtKilometros
            // 
            txtKilometros.Location = new Point(83, 61);
            txtKilometros.Name = "txtKilometros";
            txtKilometros.Size = new Size(166, 27);
            txtKilometros.TabIndex = 2;
            // 
            // txtLitros
            // 
            txtLitros.Location = new Point(83, 154);
            txtLitros.Name = "txtLitros";
            txtLitros.Size = new Size(166, 27);
            txtLitros.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(83, 216);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(166, 29);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(315, 32);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(196, 188);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 273);
            Controls.Add(richTextBox1);
            Controls.Add(btnCalcular);
            Controls.Add(txtLitros);
            Controls.Add(txtKilometros);
            Controls.Add(lbLitros);
            Controls.Add(lbKilometros);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculador";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbKilometros;
        private Label lbLitros;
        private TextBox txtKilometros;
        private TextBox txtLitros;
        private Button btnCalcular;
        private RichTextBox richTextBox1;
    }
}
