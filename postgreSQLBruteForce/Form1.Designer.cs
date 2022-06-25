namespace postgreSQLBruteForce
{
    partial class mainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.SERVERIPTXTB = new System.Windows.Forms.TextBox();
            this.TRYBTTN = new System.Windows.Forms.Button();
            this.PASSWORDBTTN = new System.Windows.Forms.Button();
            this.USERNAMEBTTN = new System.Windows.Forms.Button();
            this.PASSWORDLISTBX = new System.Windows.Forms.ListBox();
            this.USERNAMLISTBX = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SERVERIPTXTB
            // 
            this.SERVERIPTXTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SERVERIPTXTB.ForeColor = System.Drawing.Color.Gray;
            this.SERVERIPTXTB.Location = new System.Drawing.Point(127, 28);
            this.SERVERIPTXTB.Name = "SERVERIPTXTB";
            this.SERVERIPTXTB.Size = new System.Drawing.Size(165, 20);
            this.SERVERIPTXTB.TabIndex = 7;
            this.SERVERIPTXTB.Text = "Server IP";
            this.SERVERIPTXTB.MouseEnter += new System.EventHandler(this.SERVERIPTXTB_MouseEnter);
            this.SERVERIPTXTB.MouseLeave += new System.EventHandler(this.SERVERIPTXTB_MouseLeave);
            // 
            // TRYBTTN
            // 
            this.TRYBTTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TRYBTTN.Location = new System.Drawing.Point(127, 160);
            this.TRYBTTN.Name = "TRYBTTN";
            this.TRYBTTN.Size = new System.Drawing.Size(165, 23);
            this.TRYBTTN.TabIndex = 5;
            this.TRYBTTN.Text = "Start";
            this.TRYBTTN.UseVisualStyleBackColor = true;
            this.TRYBTTN.Click += new System.EventHandler(this.TRYBTTN_Click);
            // 
            // PASSWORDBTTN
            // 
            this.PASSWORDBTTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PASSWORDBTTN.Location = new System.Drawing.Point(127, 97);
            this.PASSWORDBTTN.Name = "PASSWORDBTTN";
            this.PASSWORDBTTN.Size = new System.Drawing.Size(164, 23);
            this.PASSWORDBTTN.TabIndex = 1;
            this.PASSWORDBTTN.Text = "Choose wordlist for password";
            this.PASSWORDBTTN.UseVisualStyleBackColor = true;
            this.PASSWORDBTTN.Click += new System.EventHandler(this.PASSWORDBTTN_Click);
            // 
            // USERNAMEBTTN
            // 
            this.USERNAMEBTTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.USERNAMEBTTN.Location = new System.Drawing.Point(127, 68);
            this.USERNAMEBTTN.Name = "USERNAMEBTTN";
            this.USERNAMEBTTN.Size = new System.Drawing.Size(164, 23);
            this.USERNAMEBTTN.TabIndex = 0;
            this.USERNAMEBTTN.Text = "Choose  wordlist for username";
            this.USERNAMEBTTN.UseVisualStyleBackColor = true;
            this.USERNAMEBTTN.Click += new System.EventHandler(this.USERNAMEBTTN_Click);
            // 
            // PASSWORDLISTBX
            // 
            this.PASSWORDLISTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PASSWORDLISTBX.FormattingEnabled = true;
            this.PASSWORDLISTBX.Location = new System.Drawing.Point(216, 26);
            this.PASSWORDLISTBX.Name = "PASSWORDLISTBX";
            this.PASSWORDLISTBX.Size = new System.Drawing.Size(194, 160);
            this.PASSWORDLISTBX.TabIndex = 1;
            // 
            // USERNAMLISTBX
            // 
            this.USERNAMLISTBX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.USERNAMLISTBX.FormattingEnabled = true;
            this.USERNAMLISTBX.Location = new System.Drawing.Point(12, 26);
            this.USERNAMLISTBX.Name = "USERNAMLISTBX";
            this.USERNAMLISTBX.Size = new System.Drawing.Size(194, 160);
            this.USERNAMLISTBX.TabIndex = 0;
            this.USERNAMLISTBX.Tag = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SERVERIPTXTB);
            this.groupBox1.Controls.Add(this.USERNAMEBTTN);
            this.groupBox1.Controls.Add(this.PASSWORDBTTN);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 142);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP address entry and transactions";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.USERNAMLISTBX);
            this.groupBox3.Controls.Add(this.PASSWORDLISTBX);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(0, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(422, 207);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wordlists";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(422, 410);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TRYBTTN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hermes | Brute Force App for PostgreSQL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PASSWORDBTTN;
        private System.Windows.Forms.Button USERNAMEBTTN;
        private System.Windows.Forms.ListBox PASSWORDLISTBX;
        private System.Windows.Forms.ListBox USERNAMLISTBX;
        private System.Windows.Forms.Button TRYBTTN;
        private System.Windows.Forms.TextBox SERVERIPTXTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

