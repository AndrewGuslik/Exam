namespace Exam
{
    partial class ProdCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Serie = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.Label();
            this.lbDpInf = new System.Windows.Forms.Label();
            this.Probl = new System.Windows.Forms.Label();
            this.lbSta = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.IoCl = new System.Windows.Forms.Label();
            this.PhCl = new System.Windows.Forms.Label();
            this.PhEmp = new System.Windows.Forms.Label();
            this.tbxPdInf = new System.Windows.Forms.TextBox();
            this.cmbxSta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Serie
            // 
            this.Serie.AutoSize = true;
            this.Serie.Location = new System.Drawing.Point(17, 17);
            this.Serie.Name = "Serie";
            this.Serie.Size = new System.Drawing.Size(84, 15);
            this.Serie.TabIndex = 0;
            this.Serie.Text = "Номер серии:";
            // 
            // Product
            // 
            this.Product.AutoSize = true;
            this.Product.Location = new System.Drawing.Point(17, 44);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(91, 15);
            this.Product.TabIndex = 1;
            this.Product.Text = "Оборудование:";
            // 
            // lbDpInf
            // 
            this.lbDpInf.AutoSize = true;
            this.lbDpInf.Location = new System.Drawing.Point(17, 95);
            this.lbDpInf.Name = "lbDpInf";
            this.lbDpInf.Size = new System.Drawing.Size(178, 15);
            this.lbDpInf.TabIndex = 3;
            this.lbDpInf.Text = "Дополнительная информация:";
            // 
            // Probl
            // 
            this.Probl.AutoSize = true;
            this.Probl.Location = new System.Drawing.Point(17, 68);
            this.Probl.Name = "Probl";
            this.Probl.Size = new System.Drawing.Size(68, 15);
            this.Probl.TabIndex = 2;
            this.Probl.Text = "Проблема:";
            // 
            // lbSta
            // 
            this.lbSta.AutoSize = true;
            this.lbSta.Location = new System.Drawing.Point(246, 160);
            this.lbSta.Name = "lbSta";
            this.lbSta.Size = new System.Drawing.Size(46, 15);
            this.lbSta.TabIndex = 4;
            this.lbSta.Text = "Статус:";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(330, 17);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(35, 15);
            this.Date.TabIndex = 5;
            this.Date.Text = "Дата:";
            // 
            // IoCl
            // 
            this.IoCl.AutoSize = true;
            this.IoCl.Location = new System.Drawing.Point(246, 79);
            this.IoCl.Name = "IoCl";
            this.IoCl.Size = new System.Drawing.Size(81, 15);
            this.IoCl.TabIndex = 6;
            this.IoCl.Text = "Имя клиента:";
            // 
            // PhCl
            // 
            this.PhCl.AutoSize = true;
            this.PhCl.Location = new System.Drawing.Point(246, 44);
            this.PhCl.Name = "PhCl";
            this.PhCl.Size = new System.Drawing.Size(95, 15);
            this.PhCl.TabIndex = 7;
            this.PhCl.Text = "Номер клиента:";
            // 
            // PhEmp
            // 
            this.PhEmp.AutoSize = true;
            this.PhEmp.Location = new System.Drawing.Point(246, 113);
            this.PhEmp.Name = "PhEmp";
            this.PhEmp.Size = new System.Drawing.Size(123, 15);
            this.PhEmp.TabIndex = 8;
            this.PhEmp.Text = "Номер исполнителя:";
            // 
            // tbxPdInf
            // 
            this.tbxPdInf.Location = new System.Drawing.Point(17, 113);
            this.tbxPdInf.Multiline = true;
            this.tbxPdInf.Name = "tbxPdInf";
            this.tbxPdInf.Size = new System.Drawing.Size(178, 71);
            this.tbxPdInf.TabIndex = 9;
            this.tbxPdInf.TextChanged += new System.EventHandler(this.tbxPdInf_TextChanged);
            // 
            // cmbxSta
            // 
            this.cmbxSta.FormattingEnabled = true;
            this.cmbxSta.Items.AddRange(new object[] {
            "в ожидании",
            "в работе",
            "выполнено"});
            this.cmbxSta.Location = new System.Drawing.Point(298, 157);
            this.cmbxSta.Name = "cmbxSta";
            this.cmbxSta.Size = new System.Drawing.Size(121, 23);
            this.cmbxSta.TabIndex = 10;
            this.cmbxSta.SelectedIndexChanged += new System.EventHandler(this.cmbxSta_SelectedIndexChanged);
            // 
            // ProdCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbxSta);
            this.Controls.Add(this.tbxPdInf);
            this.Controls.Add(this.PhEmp);
            this.Controls.Add(this.PhCl);
            this.Controls.Add(this.IoCl);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.lbSta);
            this.Controls.Add(this.lbDpInf);
            this.Controls.Add(this.Probl);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.Serie);
            this.Name = "ProdCard";
            this.Size = new System.Drawing.Size(497, 203);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Serie;
        private Label Product;
        private Label lbDpInf;
        private Label Probl;
        private Label lbSta;
        private Label Date;
        private Label IoCl;
        private Label PhCl;
        private Label PhEmp;
        private TextBox tbxPdInf;
        private ComboBox cmbxSta;
    }
}
