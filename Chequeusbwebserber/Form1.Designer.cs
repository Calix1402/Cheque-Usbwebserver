
namespace Chequeusbwebserber
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbanco = new System.Windows.Forms.TextBox();
            this.textusuario = new System.Windows.Forms.TextBox();
            this.textdinero = new System.Windows.Forms.TextBox();
            this.textfirma = new System.Windows.Forms.TextBox();
            this.textcheque = new System.Windows.Forms.TextBox();
            this.lstchequeInfo = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(117, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "cheque";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(117, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "banco";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(117, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(117, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "dinero";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(117, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "firma";
            // 
            // textbanco
            // 
            this.textbanco.BackColor = System.Drawing.Color.Aqua;
            this.textbanco.Location = new System.Drawing.Point(249, 134);
            this.textbanco.Name = "textbanco";
            this.textbanco.Size = new System.Drawing.Size(329, 26);
            this.textbanco.TabIndex = 5;
            // 
            // textusuario
            // 
            this.textusuario.BackColor = System.Drawing.Color.Aqua;
            this.textusuario.Location = new System.Drawing.Point(249, 257);
            this.textusuario.Name = "textusuario";
            this.textusuario.Size = new System.Drawing.Size(329, 26);
            this.textusuario.TabIndex = 6;
            // 
            // textdinero
            // 
            this.textdinero.BackColor = System.Drawing.Color.Aqua;
            this.textdinero.Location = new System.Drawing.Point(249, 375);
            this.textdinero.Name = "textdinero";
            this.textdinero.Size = new System.Drawing.Size(329, 26);
            this.textdinero.TabIndex = 7;
            // 
            // textfirma
            // 
            this.textfirma.BackColor = System.Drawing.Color.Aqua;
            this.textfirma.Location = new System.Drawing.Point(249, 482);
            this.textfirma.Name = "textfirma";
            this.textfirma.Size = new System.Drawing.Size(329, 26);
            this.textfirma.TabIndex = 8;
            // 
            // textcheque
            // 
            this.textcheque.BackColor = System.Drawing.Color.Aqua;
            this.textcheque.Location = new System.Drawing.Point(249, 43);
            this.textcheque.Name = "textcheque";
            this.textcheque.Size = new System.Drawing.Size(329, 26);
            this.textcheque.TabIndex = 9;
            // 
            // lstchequeInfo
            // 
            this.lstchequeInfo.BackColor = System.Drawing.Color.Aqua;
            this.lstchequeInfo.FormattingEnabled = true;
            this.lstchequeInfo.ItemHeight = 20;
            this.lstchequeInfo.Location = new System.Drawing.Point(677, 150);
            this.lstchequeInfo.Name = "lstchequeInfo";
            this.lstchequeInfo.Size = new System.Drawing.Size(588, 424);
            this.lstchequeInfo.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Aqua;
            this.btnAdd.Location = new System.Drawing.Point(862, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 68);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.Red;
            this.btncerrar.Location = new System.Drawing.Point(862, 577);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(132, 61);
            this.btncerrar.TabIndex = 12;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 705);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstchequeInfo);
            this.Controls.Add(this.textcheque);
            this.Controls.Add(this.textfirma);
            this.Controls.Add(this.textdinero);
            this.Controls.Add(this.textusuario);
            this.Controls.Add(this.textbanco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textbanco;
        private System.Windows.Forms.TextBox textusuario;
        private System.Windows.Forms.TextBox textdinero;
        private System.Windows.Forms.TextBox textfirma;
        private System.Windows.Forms.TextBox textcheque;
        private System.Windows.Forms.ListBox lstchequeInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btncerrar;
    }
}

