using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Author : Entity
    {
        private int _id;
        public int Id => _id;

        private string _name;
        public string Name => _name;

        private string _about;
        public string About => _about;

        private string _image;
        public string Image => _image;

        private string _email;
        public string Email => _email;

        private string _password;
        public string Password => _password;

        private bool _status;
        public bool Status => _status;
        public AuthorBiography Biography { get; set; }

        private Author()
        {

        }
        public Author(int id, string name, string about, string image, string email, string password, bool status)
        {
            _id = id;
            _name = name;
            _about = about;
            _image = image;
            _email = email;
            _password = password;
            _status = status;
        }

        public bool IsSame(Author other)
        {
            return (this._id == other._id &&
                    this._name == other._name &&
                    this._about == other._about &&
                    this._image  == other._image &&
                    this._email == other._email &&
                    this._password == other._password &&
                    this._status == other._status);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj) && IsSame((Author)obj);
        }
    }
}
