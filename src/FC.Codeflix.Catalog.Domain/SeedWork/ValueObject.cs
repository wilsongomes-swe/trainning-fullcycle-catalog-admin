﻿namespace FC.Codeflix.Catalog.Domain.SeedWork;

public abstract class ValueObject : IEquatable<ValueObject>
{
    public abstract bool Equals(ValueObject? other);
    public abstract int GetCustomHashCode();

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(obj, null)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == this.GetType() && Equals((ValueObject)obj);
    }

    public override int GetHashCode() 
        => GetCustomHashCode();

    public static bool operator ==(ValueObject? a, ValueObject? b)
    {
        if (a is null || b is null)
            return false;

        return a.Equals(b);
    }

    public static bool operator !=(ValueObject? a, ValueObject? b) => !(a == b);
}
