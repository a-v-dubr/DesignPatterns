using Builder.Domain;

namespace Builder.BuilderClasses
{
    internal class Director(HouseBuilder houseBuilder)
    {
        private readonly HouseBuilder _houseBuilder = houseBuilder;

        public House BuildHouse()
        {
            return _houseBuilder.SetWalls().SetRoof().SetWindows().SetDoor().SetGarage().SetLawn().BuildHouse();
        }
    }
}
