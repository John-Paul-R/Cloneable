namespace Cloneable.Sample;

[Cloneable]
public partial class DeepClone
{
    public string A { get; set; }
    public SimpleClone Simple { get; set; }

    public override string ToString()
    {
        return $"{nameof(DeepClone)}:{Environment.NewLine}" +
            $"\tA:\t{A}" +
            Environment.NewLine +
            $"\tSimple.A:\t{Simple?.A}" +
            Environment.NewLine +
            $"\tSimple.B:\t{Simple?.B}";
    }
}

[Cloneable(NullableReferenceHandling = NullableReferenceHandling.AllowAlways)]
public partial class DeepClone_NullAllowAlways
{
    public string A { get; set; }
    public SimpleClone Simple { get; set; }

    public override string ToString()
    {
        return $"{nameof(DeepClone)}:{Environment.NewLine}" +
            $"\tA:\t{A}" +
            Environment.NewLine +
            $"\tSimple.A:\t{Simple?.A}" +
            Environment.NewLine +
            $"\tSimple.B:\t{Simple?.B}";
    }
}
