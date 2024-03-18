namespace Exam
{
    partial class Enter
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEnt = new System.Windows.Forms.Button();
            this.tBxPasEn = new System.Windows.Forms.TextBox();
            this.tBxPhEn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 36;
            this.label6.Text = "Ваш пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 15);
            this.label5.TabIndex = 35;
            this.label5.Text = "Ваш номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 15);
            this.label4.TabIndex = 34;
            this.label4.Text = "Введите все данные";
            // 
            // btnEnt
            // 
            this.btnEnt.Location = new System.Drawing.Point(63, 301);
            this.btnEnt.Name = "btnEnt";
            this.btnEnt.Size = new System.Drawing.Size(142, 23);
            this.btnEnt.TabIndex = 33;
            this.btnEnt.Text = "Войти";
            this.btnEnt.UseVisualStyleBackColor = true;
            this.btnEnt.Click += new System.EventHandler(this.btnEmp_Click);
            // 
            // tBxPasEn
            // 
            this.tBxPasEn.Location = new System.Drawing.Point(60, 235);
            this.tBxPasEn.Name = "tBxPasEn";
            this.tBxPasEn.Size = new System.Drawing.Size(193, 23);
            this.tBxPasEn.TabIndex = 32;
            // 
            // tBxPhEn
            // 
            this.tBxPhEn.Location = new System.Drawing.Point(60, 188);
            this.tBxPhEn.Name = "tBxPhEn";
            this.tBxPhEn.Size = new System.Drawing.Size(193, 23);
            this.tBxPhEn.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Вход";
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(60, 389);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(142, 23);
            this.btnReg.TabIndex = 37;
            this.btnReg.Text = "Зарегистрироваться";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // Enter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 450);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnt);
            this.Controls.Add(this.tBxPasEn);
            this.Controls.Add(this.tBxPhEn);
            this.Controls.Add(this.label1);
            this.Name = "Enter";
            this.Text = "Enter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnEnt;
        private TextBox tBxPasEn;
        private TextBox tBxPhEn;
        private Label label1;
        private Button btnReg;
    }
}