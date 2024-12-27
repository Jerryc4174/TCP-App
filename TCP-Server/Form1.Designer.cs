namespace TCP_Server
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lanNetworkLabel = new System.Windows.Forms.Label();
            this.localNetworkLabel = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ledPictureBox = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.sndmsgBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 156);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start Server";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lanNetworkLabel);
            this.groupBox1.Controls.Add(this.localNetworkLabel);
            this.groupBox1.Location = new System.Drawing.Point(28, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(262, 129);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Info";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Local:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "On your network:";
            // 
            // lanNetworkLabel
            // 
            this.lanNetworkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lanNetworkLabel.Location = new System.Drawing.Point(4, 88);
            this.lanNetworkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lanNetworkLabel.Name = "lanNetworkLabel";
            this.lanNetworkLabel.Size = new System.Drawing.Size(253, 19);
            this.lanNetworkLabel.TabIndex = 1;
            this.lanNetworkLabel.Text = "N/A";
            // 
            // localNetworkLabel
            // 
            this.localNetworkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localNetworkLabel.Location = new System.Drawing.Point(4, 41);
            this.localNetworkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.localNetworkLabel.Name = "localNetworkLabel";
            this.localNetworkLabel.Size = new System.Drawing.Size(253, 19);
            this.localNetworkLabel.TabIndex = 0;
            this.localNetworkLabel.Text = "N/A";
            // 
            // logTextBox
            // 
            this.logTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTextBox.Location = new System.Drawing.Point(311, 22);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(281, 323);
            this.logTextBox.TabIndex = 2;
            this.logTextBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ledPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(34, 232);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(256, 112);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED Demo";
            // 
            // ledPictureBox
            // 
            this.ledPictureBox.Image = global::TCP_Server.Properties.Resources.off_led;
            this.ledPictureBox.Location = new System.Drawing.Point(17, 27);
            this.ledPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ledPictureBox.Name = "ledPictureBox";
            this.ledPictureBox.Size = new System.Drawing.Size(68, 73);
            this.ledPictureBox.TabIndex = 0;
            this.ledPictureBox.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sndmsgBox
            // 
            this.sndmsgBox.Location = new System.Drawing.Point(178, 201);
            this.sndmsgBox.Name = "sndmsgBox";
            this.sndmsgBox.Size = new System.Drawing.Size(100, 20);
            this.sndmsgBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Send Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sndmsgBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "TCP Server";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ledPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox ledPictureBox;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.RichTextBox logTextBox;

        private System.Windows.Forms.Label localNetworkLabel;
        private System.Windows.Forms.Label lanNetworkLabel;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox sndmsgBox;
        private System.Windows.Forms.Label label3;
    }
}