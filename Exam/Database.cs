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

        public List<ProdCard> GetProdQuery(string query)
        {

            List<ProdCard> proCards = new List<ProdCard>();

            openConnection();

            NpgsqlCommand getProducts = new NpgsqlCommand($"SELECT id, number_series, " +
                $"product, problem, dop_inf, status, " +
                $"date FROM products WHERE product LIKE '{query}%'", connection);

            NpgsqlDataReader reader = getProducts.ExecuteReader();

            while (reader.Read())
            {
                ProdCard productCard = new ProdCard(reader.GetInt32(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3),
                    reader.GetString(4), reader.GetString(5),
                    reader.GetDateTime(6).ToString("dd.mm.yyyy"));
                proCards.Add(productCard);
            }

            closeConnection();

            return proCards;

        }
    }
}
