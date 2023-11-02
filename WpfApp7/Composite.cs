namespace WpfApp7;

using System.Collections.Generic;
using System.Windows.Markup;

[ContentProperty(nameof(Inputs))]
public sealed class Composite : IFace
{
    public List<IFace> Inputs { get; } = new();
}