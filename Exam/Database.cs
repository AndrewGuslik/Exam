using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exam
{
    internal class Database
    {
        string prod, problem, status;
        int idCl, idProd;

        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=11111; Database=Exam");
        DateOnly date = DateOnly.FromDateTime(DateTime.Now);

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public NpgsqlConnection getConnection()
        {
            return connection;
        }

        public void addProdCl(string prod, string problem, int idCl)
        {
            this.idCl = idCl;

            Random random = new Random();

            int series = random.Next(1000, 9999);

            if ((prod != "") && (problem != ""))
            {
                if (date != null)
                {
                    ////добавляем заявку
                    openConnection();
                    NpgsqlCommand addProd = new NpgsqlCommand($"INSERT INTO products(number_series, product, date, problem, status, clients_id) VALUES('{series}', '{prod}', '{date}', '{problem}', 'в ожидании', {idCl})", getConnection());
                    addProd.ExecuteNonQuery();
                    closeConnection();
                    /////получаем id заявки
                    openConnection();
                    NpgsqlCommand getId = new NpgsqlCommand($"SELECT id FROM products WHERE number_series = '{series}'", getConnection());
                    NpgsqlDataReader reader = getId.ExecuteReader();
                    if (reader.Read())
                    {
                        idProd = reader.GetInt32(0);
                        this.idProd = idProd;
                        closeConnection();
                    }
                    /////заносим id заявки клиенту
                    openConnection();
                    NpgsqlCommand addIdPrToCl = new NpgsqlCommand($"UPDATE clients SET prods_id = {idProd} WHERE id = {idCl}", getConnection());
                    addIdPrToCl.ExecuteNonQuery();
                    closeConnection();

                    checkProdCl();
                }
                else { MessageBox.Show("Ошибка в дате"); }
            }
            else { MessageBox.Show("Заполните все поля"); }
        }

        public string checkProdCl()
        {
            openConnection();

            NpgsqlCommand checkProd = new NpgsqlCommand($"SELECT product, problem, status FROM products WHERE clients_id = {idCl}", getConnection());
            NpgsqlDataReader readProd = checkProd.ExecuteReader();
            if (readProd.Read())
            {
                prod = readProd.GetString(0);
                problem = readProd.GetString(1);
                status = readProd.GetString(2);

                this.prod = prod;
                this.problem = problem;
                this.status = status;

            }
            else { MessageBox.Show("Бебра"); }

            closeConnection();
        }

        public void getProd()
        {
            string prodCl = prod;
        }

        public void getProb(string problem)
        {
            this.problem = problem;
        }

        public void getStatus(string status)
        {
            this.status = status;
        }
    }
}
