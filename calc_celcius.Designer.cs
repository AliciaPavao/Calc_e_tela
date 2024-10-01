namespace Calc_e_tela
{
    partial class calc_celcius
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
            textBox1 = new TextBox();
            btn_Calc = new Button();
            textBox2 = new TextBox();
            btn_limpar = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            textBox1.Location = new Point(303, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(440, 74);
            textBox1.TabIndex = 0;
            // 
            // btn_Calc
            // 
            btn_Calc.BackColor = Color.FromArgb(255, 128, 0);
            btn_Calc.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            btn_Calc.Location = new Point(361, 248);
            btn_Calc.Name = "btn_Calc";
            btn_Calc.Size = new Size(325, 98);
            btn_Calc.TabIndex = 1;
            btn_Calc.Text = "Calcular";
            btn_Calc.UseVisualStyleBackColor = false;
            btn_Calc.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 30F);
            textBox2.Location = new Point(183, 377);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(688, 74);
            textBox2.TabIndex = 2;
            // 
            // btn_limpar
            // 
            btn_limpar.BackColor = Color.FromArgb(255, 128, 0);
            btn_limpar.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            btn_limpar.Location = new Point(361, 493);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(325, 71);
            btn_limpar.TabIndex = 3;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = false;
            // 
            // calc_celcius
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(1059, 668);
            Controls.Add(btn_limpar);
            Controls.Add(textBox2);
            Controls.Add(btn_Calc);
            Controls.Add(textBox1);
            Name = "calc_celcius";
            Text = "calc_celcius";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btn_Calc;
        private TextBox textBox2;
        private Button btn_limpar;
    }
}