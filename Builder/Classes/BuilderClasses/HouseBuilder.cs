using Builder.Domain;

namespace Builder.BuilderClasses
{
    internal abstract class HouseBuilder
    {
#pragma warning disable
        protected abstract string Description { get; }
        protected string _walls;
        protected string _roof;
        protected string _windows;
        protected string _door;
        protected string? _garage;
        protected string? _lawn;
#pragma warning restore

        public virtual HouseBuilder SetWalls()
        {
            _walls = "walls";
            return this;
        }

        public virtual HouseBuilder SetRoof()
        {
            _roof = "roof";
            return this;
        }

        public virtual HouseBuilder SetWindows()
        {
            _windows = "windows";
            return this;
        }

        public virtual HouseBuilder SetDoor()
        {
            _door = "door";
            return this;
        }

        public abstract HouseBuilder SetGarage();

        public abstract HouseBuilder SetLawn();

        public House BuildHouse()
        {
            if (_walls is null || _roof is null || _windows is null || _door is null)
            {
                throw new ArgumentException("House property cannot be null");
            }

            var house = new House(_walls, _roof, _windows, _door, _garage, _lawn) { Description = Description };
            return house;
        }
    }
}
