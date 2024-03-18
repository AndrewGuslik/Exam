using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.AxHost;

namespace Exam
{
    public partial class ProdCard : UserControl
    {
        Database db = new Database();
        string roleUs { get; set; }
        string serie { get; set; }
        string phoneCl { get; set; }
        string ioCl { get; set; }
        string phoneEmp { get; set; }
        string date { get; set; }
        string prod { get; set; }
        string problem { get; set; }
        string dop_inf { get; set; }
        string status { get; set; }
        public ProdCard(int idPrd, string serie, string prod, string problem,
                string dop_inf, string status,
                string date)
        {
            
            InitializeComponent();

            this.roleUs = roleUs;
            this.serie = serie;
            this.phoneCl = phoneCl;
            this.ioCl = ioCl;
            this.phoneEmp = phoneEmp;
            this.date = date;
            this.prod = prod;
            this.problem = problem;
            this.dop_inf = dop_inf;
            this.status = status;

            cmbxSta.Text = status;
            Serie.Text = "Серия: " + serie;
            PhCl.Text = "Номер клиента: " + phoneCl;
            IoCl.Text = "Имя клиента: " + ioCl;
            PhEmp.Text = "Номер исполнителя: " + phoneEmp;
            Date.Text = "Дата: " + date;
            Product.Text = "Оборудование: " + prod;
            Probl.Text = "Проблема: " + problem;
            tbxPdInf.Text = dop_inf;
        }

        private void tbxPdInf_TextChanged(object sender, EventArgs e)
        {
            db.openConnection();

            NpgsqlCommand updateDopInf = new NpgsqlCommand($"UPDATE products SET dop_inf = '{tbxPdInf.Text}' WHERE number_series = '{serie}'", db.getConnection());
            updateDopInf.ExecuteNonQuery();

            db.closeConnection();
        }

        private void cmbxSta_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.openConnection();

            NpgsqlCommand updateSt = new NpgsqlCommand($"UPDATE products SET status = '{cmbxSta.SelectedItem}' WHERE number_series = '{serie}'", db.getConnection());
            updateSt.ExecuteNonQuery();

            db.closeConnection();
        }
    }
}
