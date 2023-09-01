namespace Cloneable.Attributes;

[AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
public sealed class CloneAttribute : Attribute
{
    public CloneAttribute()
    {
    }

    public bool PreventDeepCopy { get; set; }
}
