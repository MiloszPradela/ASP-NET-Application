using Labolatorium3.Models;
using Labolatorium3_App.Models;
using System.Reflection;

namespace Labolatorium3.Models
{
    public class MemoryContactService : IContactService
    {
        private Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>()
        {
            {1, new Contact() { Name = "adam" , Email="adam2@.pl" , Phone="660660660" , Priority = Priority.Normal } }
        };
        private int id = 2;

        private readonly IDateTimeProvider _timeProvider;

        public MemoryContactService(IDateTimeProvider timeProvider)
        {
            _timeProvider = timeProvider;
        }


        public int Add(Contact model)
        {
            model.Created = _timeProvider.GetDateTime();
            model.Id = id++;
            _contacts[model.Id] = model;
            return model.Id;
        }

        public void DeleteById(int id)
        {
            _contacts.Remove(id);
        }

        public List<Contact> FindAll()
        {
            return _contacts.Values.ToList();
        }

        public Contact FindById(int id)
        {
            return _contacts[id];
        }

        public void Update(Contact contact)
        {
            if (_contacts.ContainsKey(contact.Id))
            {
                _contacts[contact.Id] = contact;
            }
        }
    }
}