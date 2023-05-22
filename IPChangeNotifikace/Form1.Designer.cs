namespace IPChangeNotifikace
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
            this.components = new System.ComponentModel.Container();
            this.btnAktivace = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxTelefon = new System.Windows.Forms.TextBox();
            this.txtBoxIP = new System.Windows.Forms.TextBox();
            this.backWIPchecker = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menustripNapoveda = new System.Windows.Forms.MenuStrip();
            this.nápovědaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nápovědaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.labelCasKontroly = new System.Windows.Forms.Label();
            this.btnDeaktivace = new System.Windows.Forms.Button();
            this.menustripNapoveda.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAktivace
            // 
            this.btnAktivace.Location = new System.Drawing.Point(302, 71);
            this.btnAktivace.Name = "btnAktivace";
            this.btnAktivace.Size = new System.Drawing.Size(79, 99);
            this.btnAktivace.TabIndex = 0;
            this.btnAktivace.Text = "Aktivace";
            this.btnAktivace.UseVisualStyleBackColor = true;
            this.btnAktivace.Click += new System.EventHandler(this.btnAktivace_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vaše veřejná IP adresa je:";
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Location = new System.Drawing.Point(79, 71);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(211, 23);
            this.txtboxEmail.TabIndex = 3;
            this.txtboxEmail.Click += new System.EventHandler(this.txtboxEmail_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon:";
            // 
            // txtboxTelefon
            // 
            this.txtboxTelefon.Location = new System.Drawing.Point(79, 147);
            this.txtboxTelefon.Name = "txtboxTelefon";
            this.txtboxTelefon.Size = new System.Drawing.Size(211, 23);
            this.txtboxTelefon.TabIndex = 6;
            this.txtboxTelefon.Click += new System.EventHandler(this.txtboxTelefon_Click);
            // 
            // txtBoxIP
            // 
            this.txtBoxIP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxIP.Location = new System.Drawing.Point(190, 22);
            this.txtBoxIP.Name = "txtBoxIP";
            this.txtBoxIP.ReadOnly = true;
            this.txtBoxIP.Size = new System.Drawing.Size(134, 27);
            this.txtBoxIP.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "................................................................................." +
    "...........";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Heslo:";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(79, 106);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '*';
            this.txtBoxPassword.Size = new System.Drawing.Size(211, 23);
            this.txtBoxPassword.TabIndex = 10;
            this.txtBoxPassword.Click += new System.EventHandler(this.txtBoxPassword_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "................................................................................." +
    "...........";
            // 
            // menustripNapoveda
            // 
            this.menustripNapoveda.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nápovědaToolStripMenuItem});
            this.menustripNapoveda.Location = new System.Drawing.Point(0, 0);
            this.menustripNapoveda.Name = "menustripNapoveda";
            this.menustripNapoveda.Size = new System.Drawing.Size(505, 24);
            this.menustripNapoveda.TabIndex = 12;
            this.menustripNapoveda.Text = "Nápověda";
            // 
            // nápovědaToolStripMenuItem
            // 
            this.nápovědaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nápovědaToolStripMenuItem1});
            this.nápovědaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.nápovědaToolStripMenuItem.Name = "nápovědaToolStripMenuItem";
            this.nápovědaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.nápovědaToolStripMenuItem.Text = "Menu";
            // 
            // nápovědaToolStripMenuItem1
            // 
            this.nápovědaToolStripMenuItem1.Name = "nápovědaToolStripMenuItem1";
            this.nápovědaToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.nápovědaToolStripMenuItem1.Text = "Nápověda";
            this.nápovědaToolStripMenuItem1.Click += new System.EventHandler(this.nápovědaToolStripMenuItem1_Click);
            // 
            // timerCheck
            // 
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // labelCasKontroly
            // 
            this.labelCasKontroly.AutoSize = true;
            this.labelCasKontroly.Location = new System.Drawing.Point(330, 28);
            this.labelCasKontroly.Name = "labelCasKontroly";
            this.labelCasKontroly.Size = new System.Drawing.Size(106, 15);
            this.labelCasKontroly.TabIndex = 13;
            this.labelCasKontroly.Text = "Čas další kontroly: ";
            // 
            // btnDeaktivace
            // 
            this.btnDeaktivace.Location = new System.Drawing.Point(387, 71);
            this.btnDeaktivace.Name = "btnDeaktivace";
            this.btnDeaktivace.Size = new System.Drawing.Size(79, 99);
            this.btnDeaktivace.TabIndex = 14;
            this.btnDeaktivace.Text = "Deaktivace";
            this.btnDeaktivace.UseVisualStyleBackColor = true;
            this.btnDeaktivace.Click += new System.EventHandler(this.btnDeaktivace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 194);
            this.Controls.Add(this.btnDeaktivace);
            this.Controls.Add(this.labelCasKontroly);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxIP);
            this.Controls.Add(this.txtboxTelefon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAktivace);
            this.Controls.Add(this.menustripNapoveda);
            this.MainMenuStrip = this.menustripNapoveda;
            this.Name = "Form1";
            this.Text = "IP Change Notification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menustripNapoveda.ResumeLayout(false);
            this.menustripNapoveda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAktivace;
        private Label label1;
        private TextBox txtboxEmail;
        private Label label2;
        private Label label3;
        private TextBox txtboxTelefon;
        private TextBox txtBoxIP;
        private System.ComponentModel.BackgroundWorker backWIPchecker;
        private Label label4;
        private Label label5;
        private TextBox txtBoxPassword;
        private Label label6;
        private MenuStrip menustripNapoveda;
        private ToolStripMenuItem nápovědaToolStripMenuItem;
        private ToolStripMenuItem nápovědaToolStripMenuItem1;
        private System.Windows.Forms.Timer timerCheck;
        private Label labelCasKontroly;
        private Button btnDeaktivace;
    }
}