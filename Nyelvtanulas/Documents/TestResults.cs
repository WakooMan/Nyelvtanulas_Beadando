using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyelvtanulas.Documents
{
    public class TestResults
    {
        private readonly List<TestResult> _results;
        private readonly string ConnectionString;
        public TestResults(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
            _results = new List<TestResult>();
            LoadFromDatabase();
        }

        private void LoadFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Results;", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    _results.Add(new TestResult(reader.GetDateTime(1), reader.GetInt32(2)));
                }
            }
        }

        public void Add(TestResult Result)
        {
            _results.Add(Result);
            AddToDatabase(Result);
        }
        
        private void AddToDatabase(TestResult Result)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Results(Id,Date,Percentage) VALUES (@ID,@Date,@Percentage);", connection);
                SqlParameter[] parameters = new SqlParameter[] { new SqlParameter("@ID",_results.Count),new SqlParameter("@Date",Result.Date), new SqlParameter("@Percentage",Result.Percentage)};
                parameters.ToList().ForEach(par => command.Parameters.Add(par));                
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<TestResult> Results => _results.AsEnumerable();
    }
}
