using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam
{
    public partial class Enter : Form
    {
        string phone, pass;
        string nameCl;
        string role = "Клиент";
        int idCl, idPrd;      

        Database db = new Database();

        public Enter()
        {
            InitializeComponent();
        }

        private void btnEmp_Click(object sender, EventArgs e)
        {
            phone = tBxPhEn.Text;
            pass = tBxPasEn.Text;

            if (phone.Length == 11)
            {
                if (pass.Length >= 5)
                {
                    db.openConnection();

                    NpgsqlCommand checkCl = new NpgsqlCommand($"SELECT name_surname, id FROM clients WHERE phone = '{phone}' AND password = '{pass}'", db.getConnection());

                    NpgsqlDataReader reader = checkCl.ExecuteReader();

                    if (reader.Read())
                    {
                        nameCl = reader.GetString(0);
                        idCl = reader.GetInt32(1);

                        this.Hide();
                        Menu formMenu = new Menu(nameCl, idCl, role, phone);
                        formMenu.Show();
                    }
                    else { MessageBox.Show("Такого пользователя нет"); }

                    db.closeConnection();
                }
                else { MessageBox.Show("Введите пароль больше 5 символов"); }
            }
            else { MessageBox.Show("Введите номер равный 11 символов"); }
        }

        private void btnEnEmp_Click(object sender, EventArgs e)
        {
            EmpEnter emen = new EmpEnter();
            this.Hide();
            emen.Show();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            this.Hide();
            reg.Show();
        }
    }
}
