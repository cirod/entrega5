namespace AppComboBox
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblrojo = new System.Windows.Forms.Label();
            this.lblVerde = new System.Windows.Forms.Label();
            this.lblAzul = new System.Windows.Forms.Label();
            this.rbdrojo = new System.Windows.Forms.ComboBox();
            this.rbdVerde = new System.Windows.Forms.ComboBox();
            this.rbdAzul = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblrojo
            // 
            this.lblrojo.AutoSize = true;
            this.lblrojo.Location = new System.Drawing.Point(44, 40);
            this.lblrojo.Name = "lblrojo";
            this.lblrojo.Size = new System.Drawing.Size(29, 13);
            this.lblrojo.TabIndex = 0;
            this.lblrojo.Text = "Rojo";
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.Location = new System.Drawing.Point(44, 73);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(35, 13);
            this.lblVerde.TabIndex = 1;
            this.lblVerde.Text = "Verde";
            // 
            // lblAzul
            // 
            this.lblAzul.AutoSize = true;
            this.lblAzul.Location = new System.Drawing.Point(44, 101);
            this.lblAzul.Name = "lblAzul";
            this.lblAzul.Size = new System.Drawing.Size(35, 13);
            this.lblAzul.TabIndex = 2;
            this.lblAzul.Text = "label3";
            // 
            // rbdrojo
            // 
            this.rbdrojo.FormattingEnabled = true;
            this.rbdrojo.Location = new System.Drawing.Point(157, 40);
            this.rbdrojo.Name = "rbdrojo";
            this.rbdrojo.Size = new System.Drawing.Size(121, 21);
            this.rbdrojo.TabIndex = 3;
            // 
            // rbdVerde
            // 
            this.rbdVerde.FormattingEnabled = true;
            this.rbdVerde.Location = new System.Drawing.Point(157, 69);
            this.rbdVerde.Name = "rbdVerde";
            this.rbdVerde.Size = new System.Drawing.Size(121, 21);
            this.rbdVerde.TabIndex = 4;
            // 
            // rbdAzul
            // 
            this.rbdAzul.FormattingEnabled = true;
            this.rbdAzul.Location = new System.Drawing.Point(157, 93);
            this.rbdAzul.Name = "rbdAzul";
            this.rbdAzul.Size = new System.Drawing.Size(121, 21);
            this.rbdAzul.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cambiar Fondo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbdAzul);
            this.Controls.Add(this.rbdVerde);
            this.Controls.Add(this.rbdrojo);
            this.Controls.Add(this.lblAzul);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.lblrojo);
            this.Name = "Form1";
            this.Text = "Programa colorear fondo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrojo;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.Label lblAzul;
        private System.Windows.Forms.ComboBox rbdrojo;
        private System.Windows.Forms.ComboBox rbdVerde;
        private System.Windows.Forms.ComboBox rbdAzul;
        private System.Windows.Forms.Button button1;
    }
}

