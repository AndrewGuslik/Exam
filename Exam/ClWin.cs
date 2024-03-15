using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class ClWin : Form
    {
        string prod, problem, status;
        int idCl;
        int idProd;
        Database db = new Database();
        public ClWin()
        {
            InitializeComponent();
        }

        //public void checkProdCl(string nameCl, int idCl)
        //{
            
        //}

        private void btnSend_Click(object sender, EventArgs e)
        {
            prod = tbMyProd.Text;
            problem = tbProblem.Text;

            db.addProdCl(prod, problem, idCl);

            tbMyProd.Text = (db.getProd());
            tbProblem.Text = db.getProb();
            lbStatus.Text = db.getStatus();
        }

        public void showName(string nameCl, int idCl)
        {
            this.idCl= idCl;
            label1.Text = "Здравствуйте, " + "\n" + nameCl + "!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

       
    }
}
