using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About : Entity
    {
        private int _id;
        public int GetId => _id;

        private string _details1;
        public string GetDetails1 => _details1; 

        private string _details2;
        public string GetDetails2 => _details2;

        private string _image1;
        public string GetImage1 => _image1;
        
        private string _image2;
        public string GetImage2 => _image2;
        private string _map_location;
        public string GetMapLocation => _map_location;

        private bool _status;
        public bool GetStatus => _status;
        protected About()
        {

        }
        public About(int id, string details1, string details2, string image1, string image2, string mapLocation, bool status) :this()
        {
            _id = id;
            _details1 = details1;
            _details2 = details2;
            _image1 = image1;
            _image2 = image2;
            _map_location = mapLocation;
            _status = status; 
        }

        public bool IsSame(About other)
        {
            return (this._id == other._id &&
                    this._details1 == other._details1 &&
                    this._details2 == other._details2 &&
                    this._image1 == other._image1     &&
                    this._image2 == other._image2     &&
                    this._map_location == other._map_location &&
                    this._status == other._status);
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj) && IsSame((About)obj);
        }

    } 
}
