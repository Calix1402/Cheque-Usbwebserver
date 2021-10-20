
namespace Chequeusbwebserber
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.tabform = new MetroFramework.Controls.MetroTabPage();
            this.btncancel = new MetroFramework.Controls.MetroButton();
            this.btnexit = new MetroFramework.Controls.MetroButton();
            this.btnsave = new MetroFramework.Controls.MetroButton();
            this.txtfirma = new MetroFramework.Controls.MetroTextBox();
            this.txtdinero = new MetroFramework.Controls.MetroTextBox();
            this.txtusuario = new MetroFramework.Controls.MetroTextBox();
            this.txtbanco = new MetroFramework.Controls.MetroTextBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCheque = new MetroFramework.Controls.MetroLabel();
            this.TabData = new MetroFramework.Controls.MetroTabPage();
            this.dgtCheques = new System.Windows.Forms.DataGridView();
            this.Action = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.tabs.SuspendLayout();
            this.tabform.SuspendLayout();
            this.TabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgtCheques)).BeginInit();
            this.Action.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabform);
            this.tabs.Controls.Add(this.TabData);
            this.tabs.Location = new System.Drawing.Point(61, 151);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(830, 378);
            this.tabs.TabIndex = 0;
            this.tabs.UseSelectable = true;
            // 
            // tabform
            // 
            this.tabform.Controls.Add(this.btncancel);
            this.tabform.Controls.Add(this.btnexit);
            this.tabform.Controls.Add(this.btnsave);
            this.tabform.Controls.Add(this.txtfirma);
            this.tabform.Controls.Add(this.txtdinero);
            this.tabform.Controls.Add(this.txtusuario);
            this.tabform.Controls.Add(this.txtbanco);
            this.tabform.Controls.Add(this.txtID);
            this.tabform.Controls.Add(this.metroLabel12);
            this.tabform.Controls.Add(this.metroLabel11);
            this.tabform.Controls.Add(this.metroLabel10);
            this.tabform.Controls.Add(this.metroLabel9);
            this.tabform.Controls.Add(this.metroLabelCheque);
            this.tabform.HorizontalScrollbarBarColor = true;
            this.tabform.HorizontalScrollbarHighlightOnWheel = false;
            this.tabform.HorizontalScrollbarSize = 10;
            this.tabform.Location = new System.Drawing.Point(4, 38);
            this.tabform.Name = "tabform";
            this.tabform.Size = new System.Drawing.Size(822, 336);
            this.tabform.TabIndex = 0;
            this.tabform.Text = "chequeform";
            this.tabform.VerticalScrollbarBarColor = true;
            this.tabform.VerticalScrollbarHighlightOnWheel = false;
            this.tabform.VerticalScrollbarSize = 10;
            this.tabform.Click += new System.EventHandler(this.tabform_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(584, 233);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 14;
            this.btncancel.Text = "Cancelar";
            this.btncancel.UseSelectable = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(584, 138);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "Salir";
            this.btnexit.UseSelectable = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(584, 49);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Guardar";
            this.btnsave.UseSelectable = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtfirma
            // 
            // 
            // 
            // 
            this.txtfirma.CustomButton.Image = null;
            this.txtfirma.CustomButton.Location = new System.Drawing.Point(311, 1);
            this.txtfirma.CustomButton.Name = "";
            this.txtfirma.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtfirma.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtfirma.CustomButton.TabIndex = 1;
            this.txtfirma.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtfirma.CustomButton.UseSelectable = true;
            this.txtfirma.CustomButton.Visible = false;
            this.txtfirma.Lines = new string[0];
            this.txtfirma.Location = new System.Drawing.Point(81, 284);
            this.txtfirma.MaxLength = 32767;
            this.txtfirma.Name = "txtfirma";
            this.txtfirma.PasswordChar = '\0';
            this.txtfirma.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtfirma.SelectedText = "";
            this.txtfirma.SelectionLength = 0;
            this.txtfirma.SelectionStart = 0;
            this.txtfirma.ShortcutsEnabled = true;
            this.txtfirma.Size = new System.Drawing.Size(333, 23);
            this.txtfirma.TabIndex = 11;
            this.txtfirma.UseSelectable = true;
            this.txtfirma.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtfirma.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtdinero
            // 
            // 
            // 
            // 
            this.txtdinero.CustomButton.Image = null;
            this.txtdinero.CustomButton.Location = new System.Drawing.Point(311, 1);
            this.txtdinero.CustomButton.Name = "";
            this.txtdinero.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtdinero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtdinero.CustomButton.TabIndex = 1;
            this.txtdinero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtdinero.CustomButton.UseSelectable = true;
            this.txtdinero.CustomButton.Visible = false;
            this.txtdinero.Lines = new string[0];
            this.txtdinero.Location = new System.Drawing.Point(81, 205);
            this.txtdinero.MaxLength = 32767;
            this.txtdinero.Name = "txtdinero";
            this.txtdinero.PasswordChar = '\0';
            this.txtdinero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtdinero.SelectedText = "";
            this.txtdinero.SelectionLength = 0;
            this.txtdinero.SelectionStart = 0;
            this.txtdinero.ShortcutsEnabled = true;
            this.txtdinero.Size = new System.Drawing.Size(333, 23);
            this.txtdinero.TabIndex = 10;
            this.txtdinero.UseSelectable = true;
            this.txtdinero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtdinero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtusuario
            // 
            // 
            // 
            // 
            this.txtusuario.CustomButton.Image = null;
            this.txtusuario.CustomButton.Location = new System.Drawing.Point(315, 1);
            this.txtusuario.CustomButton.Name = "";
            this.txtusuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtusuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtusuario.CustomButton.TabIndex = 1;
            this.txtusuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtusuario.CustomButton.UseSelectable = true;
            this.txtusuario.CustomButton.Visible = false;
            this.txtusuario.Lines = new string[0];
            this.txtusuario.Location = new System.Drawing.Point(81, 138);
            this.txtusuario.MaxLength = 32767;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '\0';
            this.txtusuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtusuario.SelectedText = "";
            this.txtusuario.SelectionLength = 0;
            this.txtusuario.SelectionStart = 0;
            this.txtusuario.ShortcutsEnabled = true;
            this.txtusuario.Size = new System.Drawing.Size(337, 23);
            this.txtusuario.TabIndex = 9;
            this.txtusuario.UseSelectable = true;
            this.txtusuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtusuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtusuario.Click += new System.EventHandler(this.metroTextBox8_Click);
            // 
            // txtbanco
            // 
            // 
            // 
            // 
            this.txtbanco.CustomButton.Image = null;
            this.txtbanco.CustomButton.Location = new System.Drawing.Point(315, 1);
            this.txtbanco.CustomButton.Name = "";
            this.txtbanco.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbanco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbanco.CustomButton.TabIndex = 1;
            this.txtbanco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbanco.CustomButton.UseSelectable = true;
            this.txtbanco.CustomButton.Visible = false;
            this.txtbanco.Lines = new string[0];
            this.txtbanco.Location = new System.Drawing.Point(81, 90);
            this.txtbanco.MaxLength = 32767;
            this.txtbanco.Name = "txtbanco";
            this.txtbanco.PasswordChar = '\0';
            this.txtbanco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbanco.SelectedText = "";
            this.txtbanco.SelectionLength = 0;
            this.txtbanco.SelectionStart = 0;
            this.txtbanco.ShortcutsEnabled = true;
            this.txtbanco.Size = new System.Drawing.Size(337, 23);
            this.txtbanco.TabIndex = 8;
            this.txtbanco.UseSelectable = true;
            this.txtbanco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbanco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtbanco.Click += new System.EventHandler(this.txtbanco_Click);
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(315, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(81, 27);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(337, 23);
            this.txtID.TabIndex = 7;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtID.Click += new System.EventHandler(this.metroTextBox6_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(210, 262);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(43, 19);
            this.metroLabel12.TabIndex = 6;
            this.metroLabel12.Text = "Firma";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(213, 183);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(48, 19);
            this.metroLabel11.TabIndex = 5;
            this.metroLabel11.Text = "Dinero";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(208, 53);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(45, 19);
            this.metroLabel10.TabIndex = 4;
            this.metroLabel10.Text = "Banco";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(208, 116);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(53, 19);
            this.metroLabel9.TabIndex = 3;
            this.metroLabel9.Text = "Usuario";
            // 
            // metroLabelCheque
            // 
            this.metroLabelCheque.AutoSize = true;
            this.metroLabelCheque.Location = new System.Drawing.Point(203, 7);
            this.metroLabelCheque.Name = "metroLabelCheque";
            this.metroLabelCheque.Size = new System.Drawing.Size(58, 19);
            this.metroLabelCheque.TabIndex = 2;
            this.metroLabelCheque.Text = "Cheque ";
            // 
            // TabData
            // 
            this.TabData.Controls.Add(this.dgtCheques);
            this.TabData.HorizontalScrollbarBarColor = true;
            this.TabData.HorizontalScrollbarHighlightOnWheel = false;
            this.TabData.HorizontalScrollbarSize = 10;
            this.TabData.Location = new System.Drawing.Point(4, 39);
            this.TabData.Name = "TabData";
            this.TabData.Size = new System.Drawing.Size(822, 335);
            this.TabData.TabIndex = 1;
            this.TabData.Text = "chequelist";
            this.TabData.VerticalScrollbarBarColor = true;
            this.TabData.VerticalScrollbarHighlightOnWheel = false;
            this.TabData.VerticalScrollbarSize = 10;
            // 
            // dgtCheques
            // 
            this.dgtCheques.AllowUserToAddRows = false;
            this.dgtCheques.AllowUserToDeleteRows = false;
            this.dgtCheques.AllowUserToResizeColumns = false;
            this.dgtCheques.AllowUserToResizeRows = false;
            this.dgtCheques.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgtCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtCheques.ContextMenuStrip = this.Action;
            this.dgtCheques.Location = new System.Drawing.Point(79, 36);
            this.dgtCheques.MultiSelect = false;
            this.dgtCheques.Name = "dgtCheques";
            this.dgtCheques.ReadOnly = true;
            this.dgtCheques.RowHeadersWidth = 62;
            this.dgtCheques.RowTemplate.Height = 28;
            this.dgtCheques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgtCheques.Size = new System.Drawing.Size(635, 261);
            this.dgtCheques.TabIndex = 2;
            this.dgtCheques.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtCheques_CellContentClick);
            // 
            // Action
            // 
            this.Action.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Action.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.Action.Name = "metroContextMenu1";
            this.Action.Size = new System.Drawing.Size(133, 68);
            this.Action.Text = "Action ";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(132, 32);
            this.editarToolStripMenuItem.Text = "Editar";
            this.editarToolStripMenuItem.Click += new System.EventHandler(this.editarToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(132, 32);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(79, 70);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(61, 19);
            this.metroLabel7.TabIndex = 1;
            this.metroLabel7.Text = "CHEQUE";
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroLink2
            // 
            this.metroLink2.Location = new System.Drawing.Point(146, 68);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(121, 21);
            this.metroLink2.TabIndex = 2;
            this.metroLink2.Text = "Nuevo Cheque";
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(1294, 706);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.tabs);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabs.ResumeLayout(false);
            this.tabform.ResumeLayout(false);
            this.tabform.PerformLayout();
            this.TabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgtCheques)).EndInit();
            this.Action.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabControl tabs;
        private MetroFramework.Controls.MetroTabPage tabform;
        private MetroFramework.Controls.MetroTextBox txtfirma;
        private MetroFramework.Controls.MetroTextBox txtdinero;
        private MetroFramework.Controls.MetroTextBox txtusuario;
        private MetroFramework.Controls.MetroTextBox txtbanco;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabelCheque;
        private MetroFramework.Controls.MetroTabPage TabData;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLink metroLink2;
        private System.Windows.Forms.DataGridView dgtCheques;
        private MetroFramework.Controls.MetroContextMenu Action;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btncancel;
        private MetroFramework.Controls.MetroButton btnexit;
        private MetroFramework.Controls.MetroButton btnsave;
        private MetroFramework.Controls.MetroTextBox txtID;
    }
}