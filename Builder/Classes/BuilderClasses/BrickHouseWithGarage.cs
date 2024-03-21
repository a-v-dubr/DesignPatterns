namespace Builder.BuilderClasses
{
    internal class BrickHouseWithGarage : HouseBuilder
    {
        protected override string Description => "brick house with garage";

        public override HouseBuilder SetWalls()
        {
            _walls = "brick walls";
            return this;
        }
        public override HouseBuilder SetLawn()
        {
            _lawn = null;
            return this;
        }

        public override HouseBuilder SetGarage()
        {
            _garage = "garage";
            return this;
        }
    }
}
