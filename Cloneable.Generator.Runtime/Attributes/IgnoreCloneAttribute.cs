namespace Cloneable.Attributes;

[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
public sealed class IgnoreCloneAttribute : Attribute
{
    public IgnoreCloneAttribute()
    {
    }
}
