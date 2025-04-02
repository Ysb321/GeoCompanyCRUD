using ITBoostUp.BussinessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITBoostUp.BussinessLayer.IRepository
{
    public interface ICompanyRepository
    {
        public int Create(Company company);
        public int Update(Company company);
        public List<Company> List(Company company);

        public Company GetById(int id);
    }
}
