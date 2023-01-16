using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AuthorBiography
    {
        private int _id;
        public int Id => _id;

        private string _biography;
        public string Biography => _biography;

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
