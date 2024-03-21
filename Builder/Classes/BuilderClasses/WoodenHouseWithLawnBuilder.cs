namespace Builder.BuilderClasses
{
    internal class WoodenHouseWithLawnBuilder : HouseBuilder
    {
        protected override string Description => "wooden house with lawn";

        public override HouseBuilder SetWalls()
        {
            _walls = "wooden walls";
            return this;
        }
        public override HouseBuilder SetLawn()
        {
            _lawn = "lawn";
            return this;
        }

        public override HouseBuilder SetGarage()
        {
            _garage = null;
            return this;
        }
    }
}
