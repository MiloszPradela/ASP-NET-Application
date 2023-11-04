using Labolatorium3_App.Models;
using Labolatorium3.Models;
using System.Xml.Serialization;

namespace Labolatorium3.Models
{
    public interface IContactService
    {
        int Add(Contact contact);

        Contact FindById(int id);

        List<Contact> FindAll();

        void DeleteById(int id);

        void Update(Contact contact);


    }
}