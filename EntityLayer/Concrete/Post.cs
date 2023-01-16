using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Post : Entity
    {

        private int _id;
        public int GetId => _id;

        private string _title;
        public string Title => _title;

        private string _content;
        public string Content => _content;

        private string _thumbnailImage;
        public string ThumbnailImage => _thumbnailImage;

        private string _image;
        public string Image => _image;

        private DateTime _createDate;
        public DateTime CreateDate => _createDate;

        private DateTime _updateDate;
        public DateTime UpdateDate => _updateDate;

        private bool _status;
        public bool Status => _status;

        private int _author_id; 
        public Author Author { get; set; }

        public ICollection<Category> Categories { get; set; }
        private Post()
        {

        }

        public Post(int id, int authorId, string title, string content, string thumbnailImage, string image, DateTime createDate, DateTime updateDate, bool status) : this()
        {
            _id = id;
            _author_id = authorId;
            _title = title;
            _content = content;
            _thumbnailImage = thumbnailImage;
            _image = image;
            _createDate = createDate;
            _updateDate = updateDate;
            _status = status;
        }
        public bool IsSame(Post other)
        {
            return (this._id == other._id &&
                    this._author_id == other._author_id &&
                    this._title == other._title &&
                    this._content == other._content &&
                    this._thumbnailImage == other._thumbnailImage &&
                    this._image == other._image &&
                    this._createDate == other._createDate &&
                    this._updateDate == other._updateDate &&
                    this._status == other._status);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj) && IsSame((Post)obj);
        }
    }
}
