using System;

namespace SharpPhysics.Core
{
    public struct Vector3
    {
        public readonly double X, Y, Z;
        
        public Vector3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
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
