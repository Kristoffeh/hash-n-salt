namespace hasher
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
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txthash = new System.Windows.Forms.TextBox();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnhash = new System.Windows.Forms.Button();
            this.btnpassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(12, 63);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(315, 20);
            this.txtpassword.TabIndex = 0;
            // 
            // txthash
            // 
            this.txthash.Location = new System.Drawing.Point(12, 147);
            this.txthash.Multiline = true;
            this.txthash.Name = "txthash";
            this.txthash.Size = new System.Drawing.Size(400, 57);
            this.txthash.TabIndex = 1;
            // 
            // txtlog
            // 
            this.txtlog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtlog.ForeColor = System.Drawing.Color.DarkGray;
            this.txtlog.Location = new System.Drawing.Point(442, 40);
            this.txtlog.Multiline = true;
            this.txtlog.Name = "txtlog";
            this.txtlog.ReadOnly = true;
            this.txtlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtlog.Size = new System.Drawing.Size(346, 332);
            this.txtlog.TabIndex = 2;
            this.txtlog.Text = "CHAT LOG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password to hash";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hash to password";
            // 
            // btnhash
            // 
            this.btnhash.Location = new System.Drawing.Point(333, 63);
            this.btnhash.Name = "btnhash";
            this.btnhash.Size = new System.Drawing.Size(79, 20);
            this.btnhash.TabIndex = 5;
            this.btnhash.Text = "Get hash";
            this.btnhash.UseVisualStyleBackColor = true;
            this.btnhash.Click += new System.EventHandler(this.btnhash_Click);
            // 
            // btnpassword
            // 
            this.btnpassword.Location = new System.Drawing.Point(308, 210);
            this.btnpassword.Name = "btnpassword";
            this.btnpassword.Size = new System.Drawing.Size(104, 20);
            this.btnpassword.TabIndex = 6;
            this.btnpassword.Text = "Get password";
            this.btnpassword.UseVisualStyleBackColor = true;
            this.btnpassword.Click += new System.EventHandler(this.btnpassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 384);
            this.Controls.Add(this.btnpassword);
            this.Controls.Add(this.btnhash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.txthash);
            this.Controls.Add(this.txtpassword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txthash;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnhash;
        private System.Windows.Forms.Button btnpassword;
    }
}

