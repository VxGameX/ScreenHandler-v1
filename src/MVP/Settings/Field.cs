namespace MVP.Settings
{
    public class Field
    {
        public string Name { get; set; } = null!;
        public Type Type { get; set; } = null!;
        public bool IsRequired { get; set; } = default;
    }
}
