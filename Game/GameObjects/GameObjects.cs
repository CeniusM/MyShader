using Game.GamePhysics;

namespace Game.GameObjects
{
    class GameObjects
    {
        struct Sphere
        {
            Color color;
            Position3 position3;
            float radius;
            public Sphere(Color color, Position3 position3, int r)
            {
                this.color = color;
                this.position3 = position3;
                radius = r;
            }
        }

        struct Square
        {

        }
    }
}