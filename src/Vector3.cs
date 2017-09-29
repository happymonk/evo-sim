namespace evolution.simulator.algebra
{
    public class Vector3
    {
        private float _x, _y, _z;

        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public float Y 
        { 
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            } 
        }
        public float Z 
        { 
            get
            {
                return _z;
            }
            set
            {
                _z = value;
            } 
        }

        public Vector3()
        {
            X = Y = Z = 0;
        }

        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString() 
        {
            return X + ", " + Y + ", " + Z;
        }
    }
}