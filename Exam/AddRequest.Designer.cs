namespace Exam
{
    partial class AddRequest
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
            this.label10 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbProblem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMyProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(11, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "<-";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(50, 13);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(54, 23);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Назад";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(23, 292);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(270, 23);
            this.btnSend.TabIndex = 28;
            this.btnSend.Text = "Отправить заявку";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 15);
            this.label7.TabIndex = 27;
            this.label7.Text = "Заполните все данные";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Создание заявки на ремонт";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Тип неисправность и описание проблемы";
            // 
            // tbProblem
            // 
            this.tbProblem.Location = new System.Drawing.Point(23, 221);
            this.tbProblem.Multiline = true;
            this.tbProblem.Name = "tbProblem";
            this.tbProblem.Size = new System.Drawing.Size(324, 50);
            this.tbProblem.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Мое оборудование";
            // 
            // tbMyProd
            // 
            this.tbMyProd.Location = new System.Drawing.Point(23, 163);
            this.tbMyProd.Name = "tbMyProd";
            this.tbMyProd.Size = new System.Drawing.Size(242, 23);
            this.tbMyProd.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 21;
            // 
            // AddRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbProblem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMyProd);
            this.Controls.Add(this.label1);
            this.Name = "AddRequest";
            this.Text = "AddRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label10;
        private Button btnBack;
        private Button btnSend;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox tbProblem;
        private Label label3;
        private TextBox tbMyProd;
        private Label label1;
    }
}