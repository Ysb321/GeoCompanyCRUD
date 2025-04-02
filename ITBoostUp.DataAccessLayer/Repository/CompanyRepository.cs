using ITBoostUp.BussinessLayer.IRepository;
using ITBoostUp.BussinessLayer.Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ITBoostUp.DataAccessLayer.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        public int Create(Company company)
        {
            string connstring = "Server=localhost;Database=Demo;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection conn = new SqlConnection(connstring); //Define Connection
            conn.Open();
            SqlCommand cmd = new SqlCommand("CreateCompany", conn);
            cmd.Parameters.AddWithValue("@CompanyName", company.Name);
            cmd.Parameters.AddWithValue("@CompnayAddress", company.Address);    
            cmd.CommandType = CommandType.StoredProcedure; //Specify Command Type
            var result = cmd.ExecuteNonQuery();
            conn.Close();
            return result;

        }

        public Company GetById(int id)
        {
            return new Company();
        }

        public List<Company> List(Company company)
        {
            return new List<Company>();
        }

        public int Update(Company company)
        {
            return 1;
        }
    }
}
