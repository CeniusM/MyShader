namespace Game.GamePhysics
{
    public struct Vector2
    {
        public float x = 0f;
        public float y = 0f;
        public float Lenght
        {
            get
            {
                return GetLenght();
            }
        }

        public Vector2()
        {

        }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2(Vector2 other)
        {
            this.x = other.x;
            this.y = other.y;
        }

        private float GetLenght()
        {
            float lenght = x * x + y * y;
            lenght = (float)Math.Sqrt(lenght);
            return lenght;
        }

        public void Reverse()
        {
            x = -x;
            y = -y;
        }

        public void Scale(float factor)
        {
            x *= factor;
            y *= factor;
        }

        public void Add(Vector2 other)
        {
            this.x += other.x;
            this.y += other.y;
        }

        public void MakeUnit()
        {
            x *= Lenght;
            y *= Lenght;
        }

        public string GetString()
        {
            return $"{x},{y}";
        }

        // static methods
        public static Vector2 Addition(Vector2 v1, Vector2 v2)
        {
            Vector2 vector = new Vector2(v1.x + v2.x, v1.y + v2.y);
            return vector;
        }
    }
}