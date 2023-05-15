namespace TCP_server
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Sendbutton = new System.Windows.Forms.Button();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Msgbox = new System.Windows.Forms.TextBox();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listClientIP = new System.Windows.Forms.ListBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(2, 394);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(93, 44);
            this.textBox3.TabIndex = 31;
            this.textBox3.Text = "Message";
            // 
            // Sendbutton
            // 
            this.Sendbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Sendbutton.Location = new System.Drawing.Point(515, 400);
            this.Sendbutton.Name = "Sendbutton";
            this.Sendbutton.Size = new System.Drawing.Size(115, 35);
            this.Sendbutton.TabIndex = 30;
            this.Sendbutton.Text = " SEND";
            this.Sendbutton.UseVisualStyleBackColor = false;
            this.Sendbutton.Click += new System.EventHandler(this.Sendbutton_Click);
            // 
            // Startbutton
            // 
            this.Startbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Startbutton.Location = new System.Drawing.Point(515, 17);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(115, 37);
            this.Startbutton.TabIndex = 29;
            this.Startbutton.Text = "START";
            this.Startbutton.UseVisualStyleBackColor = false;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Msgbox
            // 
            this.Msgbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Msgbox.Location = new System.Drawing.Point(103, 400);
            this.Msgbox.Margin = new System.Windows.Forms.Padding(4);
            this.Msgbox.Multiline = true;
            this.Msgbox.Name = "Msgbox";
            this.Msgbox.Size = new System.Drawing.Size(405, 35);
            this.Msgbox.TabIndex = 28;
            // 
            // txtinfo
            // 
            this.txtinfo.Location = new System.Drawing.Point(103, 69);
            this.txtinfo.Multiline = true;
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtinfo.Size = new System.Drawing.Size(527, 302);
            this.txtinfo.TabIndex = 27;
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(103, 16);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Multiline = true;
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(405, 35);
            this.txtIP.TabIndex = 26;
            this.txtIP.Text = "127.0.0.1:9000";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(21, 16);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 44);
            this.textBox1.TabIndex = 25;
            this.textBox1.Text = "Server";
            // 
            // listClientIP
            // 
            this.listClientIP.FormattingEnabled = true;
            this.listClientIP.ItemHeight = 16;
            this.listClientIP.Location = new System.Drawing.Point(654, 79);
            this.listClientIP.Name = "listClientIP";
            this.listClientIP.Size = new System.Drawing.Size(158, 356);
            this.listClientIP.TabIndex = 32;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.Control;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(654, 17);
            this.textBox.Margin = new System.Windows.Forms.Padding(4);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(108, 44);
            this.textBox.TabIndex = 33;
            this.textBox.Text = "Client IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.listClientIP);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Sendbutton);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.Msgbox);
            this.Controls.Add(this.txtinfo);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "TCP/IP server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Sendbutton;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.TextBox Msgbox;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listClientIP;
        private System.Windows.Forms.TextBox textBox;
    }
}

