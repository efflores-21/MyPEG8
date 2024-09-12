namespace Sesion5_Ejercicio_1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.tbNumero2 = new System.Windows.Forms.TextBox();
            this.btnMayor = new System.Windows.Forms.Button();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnMenor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbNumber1
            // 
            this.tbNumber1.Location = new System.Drawing.Point(262, 107);
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(117, 22);
            this.tbNumber1.TabIndex = 3;
            this.tbNumber1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbNumber1.TextChanged += new System.EventHandler(this.tbNumber1_TextChanged);
            // 
            // tbNumero2
            // 
            this.tbNumero2.Location = new System.Drawing.Point(262, 143);
            this.tbNumero2.Name = "tbNumero2";
            this.tbNumero2.Size = new System.Drawing.Size(117, 22);
            this.tbNumero2.TabIndex = 4;
            this.tbNumero2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbNumero2.TextChanged += new System.EventHandler(this.tbNumero2_TextChanged);
            // 
            // btnMayor
            // 
            this.btnMayor.Location = new System.Drawing.Point(246, 193);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(133, 26);
            this.btnMayor.TabIndex = 5;
            this.btnMayor.Text = "Evaluar Mayor";
            this.btnMayor.UseVisualStyleBackColor = true;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // lblAnswer
            // 
            this.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAnswer.Location = new System.Drawing.Point(186, 280);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(255, 47);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.Click += new System.EventHandler(this.lblAnswer_Click);
            // 
            // btnMenor
            // 
            this.btnMenor.Location = new System.Drawing.Point(246, 238);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(133, 26);
            this.btnMenor.TabIndex = 7;
            this.btnMenor.Text = "Evaluar Menor";
            this.btnMenor.UseVisualStyleBackColor = true;
            this.btnMenor.Click += new System.EventHandler(this.lblMenor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.btnMenor);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.btnMayor);
            this.Controls.Add(this.tbNumero2);
            this.Controls.Add(this.tbNumber1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesión 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNumber1;
        private System.Windows.Forms.TextBox tbNumero2;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnMenor;
    }
}

