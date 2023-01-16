
using EntityLayer.Concrete;
using System;

public abstract class Entity
{
    int _id;
    public virtual int Id
    {
        get { return _id; }
        set { _id = value; }
    }


    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        if (object.ReferenceEquals(this, obj)) return true;
        if (this.GetType() != obj.GetType()) return false;
        return this.Id == ((Entity)obj).Id;
    }

    public static bool operator ==(Entity left, Entity right)
    {
        if (Object.Equals(left, null))
            return (Object.ReferenceEquals(right, null)) ? true : false;
        else
            return left.Equals(right);
    }
    public static bool operator !=(Entity left, Entity right)
    {
        return !(left == right);
    }
}