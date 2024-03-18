namespace Exam
{
    partial class Menu
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
            this.lbHi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnaddReq = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbHi
            // 
            this.lbHi.AutoSize = true;
            this.lbHi.Location = new System.Drawing.Point(12, 18);
            this.lbHi.Name = "lbHi";
            this.lbHi.Size = new System.Drawing.Size(144, 15);
            this.lbHi.TabIndex = 0;
            this.lbHi.Text = "Здравствуйте, кто-то там";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnaddReq);
            this.panel1.Location = new System.Drawing.Point(-1, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 409);
            this.panel1.TabIndex = 1;
            // 
            // btnaddReq
            // 
            this.btnaddReq.Location = new System.Drawing.Point(13, 25);
            this.btnaddReq.Name = "btnaddReq";
            this.btnaddReq.Size = new System.Drawing.Size(162, 31);
            this.btnaddReq.TabIndex = 0;
            this.btnaddReq.Text = "Создать заявку";
            this.btnaddReq.UseVisualStyleBackColor = true;
            this.btnaddReq.Click += new System.EventHandler(this.btnaddReq_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(224, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(492, 314);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(224, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 23);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbHi);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbHi;
        private Panel panel1;
        private Button btnaddReq;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox textBox1;
    }
}