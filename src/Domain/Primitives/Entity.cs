namespace Domain.Primitives;

public abstract class Entity : IEquatable<Entity>
{
    public Guid Id { get; protected set; }

    public Entity(Guid id)
    {
        Id = id;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Entity);
    }

    public bool Equals(Entity other)
    {
        return other != null &&
            EqualityComparer<TId>.Default.Equals(Id, other.Id);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }

    public static bool operator ==(Entity left, Entity right)
    {
        return EqualityComparer<Entity>.Default.Equals(left, right);
    }

    public static bool operator !=(Entity left, Entity right)
    {
        return !(left == right);
    }
}