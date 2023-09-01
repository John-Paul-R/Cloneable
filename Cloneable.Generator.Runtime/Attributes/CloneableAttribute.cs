namespace Cloneable.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = true, AllowMultiple = false)]
public sealed class CloneableAttribute : Attribute
{
    public CloneableAttribute()
    {
    }

    public bool ExplicitDeclaration { get; set; }

    public NullableReferenceHandling NullableReferenceHandling { get; set; }
}

public enum NullableReferenceHandling
{
    /// <summary>
    /// Reference-typed properties are expected to never have a null value, unless they are annotated as nullable. If
    /// a non-nullable reference type property has a null value when `Clone` is invoked, a Null Reference Exception will
    /// be thrown. The generated code with this flag has no null checks, so will be slightly faster than
    /// <see cref="NullableReferenceHandling.AllowAlways"/>
    /// </summary>
    CodeMatchesAnnotation = default,

    /// <summary>
    /// All reference-typed properties are treated as they can always be null, regardless of nullability annotations.
    /// This is the "safest" option, in that a null value will never trigger a Null Reference Exception, but it
    /// introduces extra null checks, so may be slower than <see cref="NullableReferenceHandling.CodeMatchesAnnotation"/>
    /// </summary>
    AllowAlways,
}
