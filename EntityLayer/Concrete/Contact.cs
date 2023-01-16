using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact : Entity
    {
        private int _id;
        public int Id => _id;

        private string _user_name;
        public string UserName => _user_name;

        private string _email;
        public string Email => _email;

        private string _subject;
        public string Subject => _subject;

        private string _message;
        public string Message => _message;

        private DateTime _date;    
        public DateTime Date => _date;  

        private bool _status;
        public bool Status => _status;

        private Contact()
        {

        }
        public Contact(int id, string userName, string email, string subject, string message, DateTime date, bool status)
        {
            this._id= id;
            this._user_name= userName;
            this._email= email;
            this._subject= subject;
            this._message= message;
            this._date = date;
            this._status= status;
        }

        public bool IsSame(Contact other)
        {
            return (this._id == other._id &&
                    this._user_name == other._user_name &&
                    this._email == other._email &&
                    this._subject == other._subject &&
                    this._message == other._message &&
                    this._date == other._date &&
                    this._status == other._status); 
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj) && IsSame((Contact)obj);
        }

    }
}
