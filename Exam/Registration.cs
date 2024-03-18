using Npgsql;

namespace Exam
{
    public partial class Registration : Form
    {
        string phoneUs, name, passUs;
        string nameUs, checkRes, role;
        int idUs, idPrd;
        Database db = new Database();

        public Registration()
        {
            InitializeComponent();
        }

        private void regCl_Click_1(object sender, EventArgs e)
        {
            nameUs = tBxIoRg.Text;
            phoneUs = tBxPhRg.Text;
            passUs = tBxPasRg.Text;

            string res = checkCl(phoneUs);
            if (nameUs != null)
            {
                if (phoneUs.Length == 11)
                {
                    if (passUs.Length >= 5)
                    {
                        if (res == "Нету")
                        {
                            db.openConnection();
                            NpgsqlCommand addCl = new NpgsqlCommand($"INSERT INTO users (name_surname, phone, password, role) VALUES ('{nameUs}', '{phoneUs}', '{passUs}', 'Клиент')", db.getConnection());
                            addCl.ExecuteNonQuery();
                            MessageBox.Show("Вы успешно зарегистрированы.");
                            db.closeConnection();                           

                            db.openConnection();
                            NpgsqlCommand getId = new NpgsqlCommand($"SELECT id, role FROM users WHERE phone = '{phoneUs}'", db.getConnection());
                            NpgsqlDataReader reader = getId.ExecuteReader();
                            if (reader.Read())
                            {
                                idUs = reader.GetInt32(0);
                                role = reader.GetString(1); 
                            }

                            db.closeConnection();

                            this.Hide();                           
                            Menu formMenu = new Menu(nameUs, idUs, role);
                            formMenu.Show();
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

        public string checkCl(string phoneUs)
        {
            db.openConnection();

            NpgsqlCommand checkCl = new NpgsqlCommand($"SELECT name_surname FROM users WHERE phone = '{phoneUs}'", db.getConnection());

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
        private void button1_Click(object sender, EventArgs e)
        {
            Enter ent = new Enter();
            this.Hide();
            ent.Show();
        }
    }
}