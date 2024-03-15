using Npgsql;

namespace Exam
{
    public partial class Form1 : Form
    {
        string phone, name, pass;
        string nameCl, checkRes;
        int idCl, idPrd;
        Database db = new Database();
        ClWin clwin = new ClWin();
        

        public Form1()
        {
            InitializeComponent();          
        }

        private void entrCl_Click(object sender, EventArgs e)
        {
            phone = tBxPhEn.Text;
            pass = tBxPasEn.Text;

            if (phone.Length == 11)
            {
                if (pass.Length >= 5)
                {
                    db.openConnection();

                    NpgsqlCommand checkCl = new NpgsqlCommand($"SELECT name_surname, id, prods_id FROM clients WHERE phone = '{phone}' AND password = '{pass}'", db.getConnection());

                    NpgsqlDataReader reader = checkCl.ExecuteReader();

                    if (reader.Read())
                    {
                        nameCl = reader.GetString(0);
                        idCl = reader.GetInt32(1);
                        idPrd = reader.GetInt32(2);
                        //if (idPrd == 0)
                        //{
                            this.Hide();
                            clwin.showName(nameCl, idCl);
                            clwin.Show();
                        //}
                        //else
                        //{
                        //    this.Hide();
                        //    clwin.checkProdCl(nameCl, idCl);
                        //}
                    }
                    else { MessageBox.Show("Такого пользователя нет"); }

                    db.closeConnection();
                }
                else { MessageBox.Show("Введите пароль больше 5 символов"); }
            }
            else { MessageBox.Show("Введите номер равный 11 символов"); }

        }

        private void regCl_Click(object sender, EventArgs e)
        {
            nameCl = tBxIoRg.Text;
            phone = tBxPhRg.Text;
            pass = tBxPasRg.Text;

            string res = checkCl(phone);
            if (nameCl != null)
            {
                if (phone.Length == 11)
                {
                    if (pass.Length >= 5)
                    {
                        if (res == "Нету")
                        {
                            db.openConnection();
                            NpgsqlCommand addCl = new NpgsqlCommand($"INSERT INTO clients (name_surname, phone, password) VALUES ('{nameCl}', '{phone}', '{pass}')", db.getConnection());
                            addCl.ExecuteNonQuery();
                            db.closeConnection();

                            this.Hide();
                            clwin.showName(nameCl, idCl);
                            clwin.Show();
                        }
                        else if (res == "Есть")
                        {
                            db.closeConnection();
                            MessageBox.Show("Такой пользователь уже зарегистрирован");
                        }
                    }
                    else { MessageBox.Show("Введите пароль больше 5 символов"); }
                }
                else { MessageBox.Show("Введите номер равный 11 символов"); }
            }
            else { MessageBox.Show("Введите ваше имя"); }
        }

        public string checkCl(string phone)
        {
            db.openConnection();

            NpgsqlCommand checkCl = new NpgsqlCommand($"SELECT name_surname FROM clients WHERE phone = '{phone}'", db.getConnection());

            NpgsqlDataReader reader = checkCl.ExecuteReader();

            if (reader.Read())
            {
                db.closeConnection();
                return checkRes = "Есть";
            }
            else
            {
                db.closeConnection();
                return checkRes = "Нету";
            }
        }
    }
}