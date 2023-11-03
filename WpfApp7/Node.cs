namespace WpfApp7;

using System.Windows.Markup;

[ContentProperty(nameof(Name))]
public sealed class Node
{
    public string Name { get; set; } = string.Empty;
}