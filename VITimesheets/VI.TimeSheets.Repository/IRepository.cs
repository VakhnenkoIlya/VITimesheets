using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VI.TimeSheets.Repository
{
   public interface IRepository
    {
        public Person GetById(int id);
        public List<Person> GetByName(string name);
        public List<Person> GetPagination(int skip, int take);
        public void AddPerson(Person person);
        public void UpdatePerson(Person person, string lastName, string email, string company);
        public void DeletePerson(int id);
        public List<Person> GetAll();
    }
}
