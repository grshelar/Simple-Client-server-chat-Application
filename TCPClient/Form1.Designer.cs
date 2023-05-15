namespace TCPClient
{
    partial class form1
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.Connectbutton = new System.Windows.Forms.Button();
            this.Messagebox = new System.Windows.Forms.TextBox();
            this.textinfo = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(9, 399);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(93, 44);
            this.textBox3.TabIndex = 24;
            this.textBox3.Text = "Message";
            // 
            // Sendbutton
            // 
            this.Sendbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Sendbutton.Location = new System.Drawing.Point(522, 405);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(115, 35);
            this.Sendbutton.TabIndex = 23;
            this.Sendbutton.Text = " SEND";
            this.Sendbutton.UseVisualStyleBackColor = false;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // Connectbutton
            // 
            this.Connectbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Connectbutton.Location = new System.Drawing.Point(522, 22);
            this.Connectbutton.Name = "Connectbutton";
            this.Connectbutton.Size = new System.Drawing.Size(115, 37);
            this.Connectbutton.TabIndex = 22;
            this.Connectbutton.Text = "CONNECT";
            this.Connectbutton.UseVisualStyleBackColor = false;
            this.Connectbutton.Click += new System.EventHandler(this.Connectbutton_Click);
            // 
            // Messagebox
            // 
            this.Messagebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Messagebox.Location = new System.Drawing.Point(110, 405);
            this.Messagebox.Margin = new System.Windows.Forms.Padding(4);
            this.Messagebox.Multiline = true;
            this.Messagebox.Name = "Messagebox";
            this.Messagebox.Size = new System.Drawing.Size(405, 35);
            this.Messagebox.TabIndex = 21;
            // 
            // textinfo
            // 
            this.textinfo.Location = new System.Drawing.Point(110, 74);
            this.textinfo.Multiline = true;
            this.textinfo.Name = "textinfo";
            this.textinfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textinfo.Size = new System.Drawing.Size(527, 302);
            this.textinfo.TabIndex = 20;
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(110, 21);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Multiline = true;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(405, 35);
            this.txtIP.TabIndex = 19;
            this.txtIP.Text = "127.0.0.1:9000";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(28, 21);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 44);
            this.textBox1.TabIndex = 18;
            this.textBox1.Text = "Server";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Sendbutton);
            this.Controls.Add(this.Connectbutton);
            this.Controls.Add(this.Messagebox);
            this.Controls.Add(this.textinfo);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.textBox1);
            this.Name = "form1";
            this.Text = "TCP client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Sendbutton;
        private System.Windows.Forms.Button Connectbutton;
        private System.Windows.Forms.TextBox Messagebox;
        private System.Windows.Forms.TextBox textinfo;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox textBox1;
    }
}

