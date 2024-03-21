namespace Builder.Domain
{
    internal class House
    {
        public string Walls { get; }
        public string Roof { get; }
        public string Windows { get; }
        public string Door { get; }
        public string? Garage { get; }
        public string? Lawn { get; }
        public string? Description { get; set; }

        public House(string walls, string roof, string windows, string door, string? garage = default, string? lawn = default)
        {
            Walls = walls;
            Roof = roof;
            Windows = windows;
            Door = door;
            Garage = garage;
            Lawn = lawn;
        }

        public override string ToString()
        {
            return Description is not null ? Description : base.ToString()!;
        }
    }
}
