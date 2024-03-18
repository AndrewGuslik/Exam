using Microsoft.VisualBasic.Logging;
using Npgsql;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Menu : Form
    {
        Database db = new Database();
        string roleUs, phoneUs;
        string nameUs, role;
        int idUs;
        public string query;

        private void btnaddReq_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRequest adRq = new AddRequest(nameUs, idUs, role);
            adRq.Show();
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {            
            string txt = textBox1.Text;
            if (txt == "Введите для поиска")
            {
                textBox1.Clear();
            }          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = textBox1.Text;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(db.GetProdQuery(query).ToArray());
        }

        public Menu(string nameUs, int idUs, string role)
        {
            InitializeComponent();

            lbHi.Text = "Здравствуйте, " + nameUs + "!";

            this.nameUs = nameUs;
            this.role = role;
            this.idUs = idUs;

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(shPrCard().ToArray());
        }


        private List<ProdCard> shPrCard()
        {
            List<ProdCard> prods = new List<ProdCard>();           

            db.openConnection();

            NpgsqlCommand getReq = new NpgsqlCommand($"SELECT id, number_series, " +
                $"product, problem, dop_inf, status, " +
                $"date FROM products WHERE clients_id = '{idUs}'", db.getConnection());
            NpgsqlDataReader reader = getReq.ExecuteReader();

            while (reader.Read())
            {
                ProdCard addReq = new ProdCard(reader.GetInt32(0), reader.GetString(1), 
                    reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(5),
                    reader.GetDateTime(6).ToString("dd.mm.yyyy"));
                prods.Add(addReq);
            }

            db.closeConnection();
            
            return prods;
        }
    }
}
