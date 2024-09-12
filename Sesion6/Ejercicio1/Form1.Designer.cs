namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TbTitulo = new System.Windows.Forms.TextBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LbLibros = new System.Windows.Forms.ListBox();
            this.LbCopia = new System.Windows.Forms.ListBox();
            this.BtnCopiar = new System.Windows.Forms.Button();
            this.BtnMover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // TbTitulo
            // 
            this.TbTitulo.Location = new System.Drawing.Point(110, 39);
            this.TbTitulo.Name = "TbTitulo";
            this.TbTitulo.Size = new System.Drawing.Size(308, 20);
            this.TbTitulo.TabIndex = 1;
            this.TbTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbTitulo_KeyPress);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(424, 37);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Libros Agregados";
            // 
            // LbLibros
            // 
            this.LbLibros.FormattingEnabled = true;
            this.LbLibros.Location = new System.Drawing.Point(18, 93);
            this.LbLibros.Name = "LbLibros";
            this.LbLibros.Size = new System.Drawing.Size(465, 238);
            this.LbLibros.TabIndex = 4;
            this.LbLibros.Click += new System.EventHandler(this.LbLibros_Click);
            // 
            // LbCopia
            // 
            this.LbCopia.FormattingEnabled = true;
            this.LbCopia.Location = new System.Drawing.Point(489, 95);
            this.LbCopia.Name = "LbCopia";
            this.LbCopia.Size = new System.Drawing.Size(444, 238);
            this.LbCopia.TabIndex = 5;
            // 
            // BtnCopiar
            // 
            this.BtnCopiar.Location = new System.Drawing.Point(424, 66);
            this.BtnCopiar.Name = "BtnCopiar";
            this.BtnCopiar.Size = new System.Drawing.Size(75, 23);
            this.BtnCopiar.TabIndex = 6;
            this.BtnCopiar.Text = "Copiar";
            this.BtnCopiar.UseVisualStyleBackColor = true;
            this.BtnCopiar.Click += new System.EventHandler(this.BtnCopiar_Click);
            // 
            // BtnMover
            // 
            this.BtnMover.Enabled = false;
            this.BtnMover.Location = new System.Drawing.Point(505, 66);
            this.BtnMover.Name = "BtnMover";
            this.BtnMover.Size = new System.Drawing.Size(75, 23);
            this.BtnMover.TabIndex = 7;
            this.BtnMover.Text = "Mover";
            this.BtnMover.UseVisualStyleBackColor = true;
            this.BtnMover.Click += new System.EventHandler(this.BtnMover_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 352);
            this.Controls.Add(this.BtnMover);
            this.Controls.Add(this.BtnCopiar);
            this.Controls.Add(this.LbCopia);
            this.Controls.Add(this.LbLibros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.TbTitulo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbTitulo;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LbLibros;
        private System.Windows.Forms.ListBox LbCopia;
        private System.Windows.Forms.Button BtnCopiar;
        private System.Windows.Forms.Button BtnMover;
    }
}

