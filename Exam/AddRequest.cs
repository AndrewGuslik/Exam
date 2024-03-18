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
    public partial class AddRequest : Form
    {
        string prod, problem, status;
        int idUs;
        int idProd;
        string nameUs, role;
        Database db = new Database();
        DateOnly date = DateOnly.FromDateTime(DateTime.Now);
        public AddRequest(string nameUs, int idUs, string role)
        {
            InitializeComponent();

            this.nameUs = nameUs;
            this.role = role;
            this.idUs = idUs;
        }
        private void btnSend_Click_1(object sender, EventArgs e)
        {
            prod = tbMyProd.Text;
            problem = tbProblem.Text;

            Random random = new Random();

            int series = random.Next(1000, 9999);

            if ((prod != "") && (problem != ""))
            {
                if (date != null)
                {
                    ////добавляем заявку
                    db.openConnection();
                    NpgsqlCommand addProd = new NpgsqlCommand($"INSERT INTO products(number_series, product, date, problem, dop_inf, status, clients_id) VALUES('{series}', '{prod}', '{date}', '{problem}', '', 'в ожидании', {idUs})", db.getConnection());
                    addProd.ExecuteNonQuery();
                    db.closeConnection();
                    /////получаем id заявки
                    db.openConnection();
                    NpgsqlCommand getId = new NpgsqlCommand($"SELECT id FROM products WHERE number_series = '{series}'", db.getConnection());
                    NpgsqlDataReader reader = getId.ExecuteReader();
                    if (reader.Read())
                    {
                        idProd = reader.GetInt32(0);
                        db.closeConnection();
                    }
                    /////заносим id заявки клиенту
                    //db.openConnection();
                    //NpgsqlCommand addIdPrToCl = new NpgsqlCommand($"UPDATE users SET prods_id = {idProd} WHERE id = {idUs}", db.getConnection());
                    //addIdPrToCl.ExecuteNonQuery();
                    //db.closeConnection();
                    MessageBox.Show("Заявка отправлена!");
                }
                else { MessageBox.Show("Ошибка в дате"); }
            }
            else { MessageBox.Show("Заполните все поля"); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu formMenu = new Menu(nameUs, idUs, role);
            formMenu.Show();
        }
    }
}
