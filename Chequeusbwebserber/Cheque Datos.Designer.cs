
namespace Chequeusbwebserber
{
    partial class Cheque10
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lstchequeInfo = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textFirm = new System.Windows.Forms.TextBox();
            this.textMoney = new System.Windows.Forms.TextBox();
            this.textBank = new System.Windows.Forms.TextBox();
            this.textCheck = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chequeid";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Banco";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Usuario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Dinero";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 427);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Firma";
            // 
            // lstchequeInfo
            // 
            this.lstchequeInfo.BackColor = System.Drawing.Color.Aqua;
            this.lstchequeInfo.FormattingEnabled = true;
            this.lstchequeInfo.ItemHeight = 20;
            this.lstchequeInfo.Location = new System.Drawing.Point(624, 143);
            this.lstchequeInfo.Name = "lstchequeInfo";
            this.lstchequeInfo.Size = new System.Drawing.Size(517, 364);
            this.lstchequeInfo.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.Location = new System.Drawing.Point(834, 64);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(161, 57);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // textUsername
            // 
            this.textUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textUsername.Location = new System.Drawing.Point(188, 232);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(283, 26);
            this.textUsername.TabIndex = 7;
            // 
            // textFirm
            // 
            this.textFirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textFirm.Location = new System.Drawing.Point(188, 421);
            this.textFirm.Name = "textFirm";
            this.textFirm.Size = new System.Drawing.Size(283, 26);
            this.textFirm.TabIndex = 8;
            // 
            // textMoney
            // 
            this.textMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textMoney.Location = new System.Drawing.Point(188, 320);
            this.textMoney.Name = "textMoney";
            this.textMoney.Size = new System.Drawing.Size(283, 26);
            this.textMoney.TabIndex = 9;
            // 
            // textBank
            // 
            this.textBank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBank.Location = new System.Drawing.Point(188, 137);
            this.textBank.Name = "textBank";
            this.textBank.Size = new System.Drawing.Size(283, 26);
            this.textBank.TabIndex = 10;
            // 
            // textCheck
            // 
            this.textCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textCheck.Location = new System.Drawing.Point(188, 39);
            this.textCheck.Name = "textCheck";
            this.textCheck.Size = new System.Drawing.Size(283, 26);
            this.textCheck.TabIndex = 11;
            // 
            // Cheque10
            // 
            this.ClientSize = new System.Drawing.Size(1172, 629);
            this.Controls.Add(this.textCheck);
            this.Controls.Add(this.textBank);
            this.Controls.Add(this.textMoney);
            this.Controls.Add(this.textFirm);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstchequeInfo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Name = "Cheque10";
            this.Text = "cheque10";
            this.Load += new System.EventHandler(this.Cheque10_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCheque;
        private System.Windows.Forms.TextBox textBanco;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textFirma;
        private System.Windows.Forms.TextBox textDinero;
        private System.Windows.Forms.ListBox lstCheckInfo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstchequeInfo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textFirm;
        private System.Windows.Forms.TextBox textMoney;
        private System.Windows.Forms.TextBox textBank;
        private System.Windows.Forms.TextBox textCheck;
    }
}