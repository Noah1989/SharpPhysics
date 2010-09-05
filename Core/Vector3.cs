using System;

namespace SharpPhysics.Core
{
    public struct Vector3
    {
        public static readonly Vector3 Zero = new Vector3(0, 0, 0);
    
        private readonly double _x, _y, _z;
        
        public double X { get { return _x; } }
        public double Y { get { return _y; } }
        public double Z { get { return _z; } }
        
        public Vector3(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }
        
        public static Vector3 operator *(Vector3 vector, double scalar)
        {
            return new Vector3(vector._x * scalar,
                               vector._y * scalar,
                               vector._z * scalar);
        }
        
        public static Vector3 operator /(Vector3 vector, double scalar)
        {
            return new Vector3(vector._x / scalar,
                               vector._y / scalar,
                               vector._z / scalar);
        }
        
        public static Vector3 operator *(Vector3 vectorA, Vector3 vectorB)
        {
            return vectorA.CrossProduct(vectorB);
        }
        
        public Vector3 CrossProduct(Vector3 other)
        {
            throw new NotImplementedException();
        }
        
        public static Vector3 operator +(Vector3 vectorA, Vector3 vectorB)
        {
            throw new NotImplementedException();
        }
        
        public static Vector3 operator -(Vector3 vectorA, Vector3 vectorB)
        {
            throw new NotImplementedException();
        }
    }
}
