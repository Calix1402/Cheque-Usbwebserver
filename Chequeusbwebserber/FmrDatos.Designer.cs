
namespace Chequeusbwebserber
{
    partial class FmrDatos
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
            this.Check = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.Banco = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.Label();
            this.Firma = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.AutoSize = true;
            this.Check.Location = new System.Drawing.Point(57, 45);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(81, 20);
            this.Check.TabIndex = 1;
            this.Check.Text = "Cheque id";
            this.Check.Click += new System.EventHandler(this.label1_Click);
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(57, 172);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(64, 20);
            this.Usuario.TabIndex = 2;
            this.Usuario.Text = "Usuario";
            // 
            // Banco
            // 
            this.Banco.AutoSize = true;
            this.Banco.Location = new System.Drawing.Point(57, 104);
            this.Banco.Name = "Banco";
            this.Banco.Size = new System.Drawing.Size(46, 20);
            this.Banco.TabIndex = 3;
            this.Banco.Text = "Bank";
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(57, 246);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(73, 20);
            this.Cantidad.TabIndex = 4;
            this.Cantidad.Text = "Cantidad";
            // 
            // Firma
            // 
            this.Firma.AutoSize = true;
            this.Firma.Location = new System.Drawing.Point(57, 306);
            this.Firma.Name = "Firma";
            this.Firma.Size = new System.Drawing.Size(49, 20);
            this.Firma.TabIndex = 5;
            this.Firma.Text = "Firma";
            // 
            // FmrDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Firma);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.Banco);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.Check);
            this.Name = "FmrDatos";
            this.Text = "FmrDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Check;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Banco;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.Label Firma;
    }
}