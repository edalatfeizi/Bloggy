using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category : Entity
    {
        private int _id;
        public int Id => _id;

        private string _name;
        public string Name => _name;

        private string _description;
        public string Description => _description;

        private bool _status;
        public bool Status => _status;

        public ICollection<Post> Posts { get; set; }
        private Category()
        {

        }

        public Category(int id, string name, string description, bool status) : this()
        {
            _id = id;
            _name = name;
            _description = description;
            _status = status;
        }

        public bool IsSame(Category other)
        {
            return (this._id == other._id &&
                    this._name == other._name &&
                    this._description == other._description &&
                    this._status == other._status );
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj) && IsSame((Category)obj);
        }
    }
}
