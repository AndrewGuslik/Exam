namespace Exam
{
    partial class Registration
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regCl = new System.Windows.Forms.Button();
            this.tBxIoRg = new System.Windows.Forms.TextBox();
            this.tBxPasRg = new System.Windows.Forms.TextBox();
            this.tBxPhRg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ваши Имя и Отчество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Ваш пароль";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ваш номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 22;
            this.label3.Text = "Введите все данные";
            // 
            // regCl
            // 
            this.regCl.Location = new System.Drawing.Point(32, 274);
            this.regCl.Name = "regCl";
            this.regCl.Size = new System.Drawing.Size(142, 23);
            this.regCl.TabIndex = 21;
            this.regCl.Text = "Зарегистрироваться как клиент";
            this.regCl.UseVisualStyleBackColor = true;
            this.regCl.Click += new System.EventHandler(this.regCl_Click_1);
            // 
            // tBxIoRg
            // 
            this.tBxIoRg.Location = new System.Drawing.Point(32, 129);
            this.tBxIoRg.Name = "tBxIoRg";
            this.tBxIoRg.Size = new System.Drawing.Size(154, 23);
            this.tBxIoRg.TabIndex = 20;
            // 
            // tBxPasRg
            // 
            this.tBxPasRg.Location = new System.Drawing.Point(32, 218);
            this.tBxPasRg.Name = "tBxPasRg";
            this.tBxPasRg.Size = new System.Drawing.Size(154, 23);
            this.tBxPasRg.TabIndex = 19;
            // 
            // tBxPhRg
            // 
            this.tBxPhRg.Location = new System.Drawing.Point(32, 171);
            this.tBxPhRg.Name = "tBxPhRg";
            this.tBxPhRg.Size = new System.Drawing.Size(154, 23);
            this.tBxPhRg.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Регистрация";
            // 
            // btnEnt
            // 
            this.btnEnt.Location = new System.Drawing.Point(32, 344);
            this.btnEnt.Name = "btnEnt";
            this.btnEnt.Size = new System.Drawing.Size(142, 23);
            this.btnEnt.TabIndex = 26;
            this.btnEnt.Text = "Войти";
            this.btnEnt.UseVisualStyleBackColor = true;
            this.btnEnt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 450);
            this.Controls.Add(this.btnEnt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regCl);
            this.Controls.Add(this.tBxIoRg);
            this.Controls.Add(this.tBxPasRg);
            this.Controls.Add(this.tBxPhRg);
            this.Controls.Add(this.label2);
            this.Name = "Registration";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label9;
        private Label label8;
        private Label label7;
        private Label label3;
        private Button regCl;
        private TextBox tBxIoRg;
        private TextBox tBxPasRg;
        private TextBox tBxPhRg;
        private Label label2;
        private Button btnEnt;
    }
}