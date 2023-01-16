using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment : Entity
    {

        private int _id;
        public int Id => _id;

        private string _user_name;
        public string UserName => _user_name;

        private string _title;
        public string Title => _title;

        private string _content;
        public string Content => _content;

        private DateTime _date;
        public DateTime Date => _date;

        private bool _status;
        public bool Status => _status;

        private int _post_id;
        public Post Post { get; set; }
        private Comment()
        {

        }
        public Comment(int id, int postId, string user_name, string title, string content, DateTime date, bool status)
        {
            _id = id;
            _post_id = postId;
            _user_name = user_name;
            _title = title;
            _content = content;
            _date = date;
            _status = status;
        }

        public bool IsSame(Comment other)
        {
            return (this._id == other._id &&
                    this._post_id== other._post_id &&
                    this._title == other._title &&
                    this._user_name == other._user_name &&
                    this._content== other._content &&
                    this._date == other._date &&
                    this._status == other._status);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj) && IsSame((Comment)obj);
        }
    }
}
