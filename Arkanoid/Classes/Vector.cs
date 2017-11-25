using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arkanoid.Classes
{
    class Vector
    {
        private double fx;
        private double fy;

        public Vector(double ax, double ay)
        {
            fx = ax;
            fy = ay;
        }
        public Vector(PointD a, PointD b)
        {
            fx = b.X - a.X;
            fy = b.Y - a.Y;
        }

        public double X { get { return fx; } set { fx = value; } }
        public double Y { get { return fy; } set { fy = value; } }
        public double Length{ get { return Math.Sqrt(X * X + Y * Y); } }
        public double SqrLength { get { return X * X + Y * Y; } }

        public void Set(double ax, double ay)
        {
            fx = ax; fy = ay;
        }
        public Vector Normalize()
        {
            return new Vector(X / Length, Y / Length);
        }
        public Vector Perpendicular()
        {
            return new Vector(Y, -X);
        }
        public double AngleBetween( Vector v1, Vector v2)
        {
            return Math.Acos(v1.Normalize() * v2.Normalize());
        }
        public Vector Reflect(Vector v1)
        {
            return
                 this - (v1.Perpendicular().Normalize() * (2 * (this * v1.Perpendicular().Normalize())));
        }
        public Vector Negate()
        {
            return new Vector(-X, -Y);
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y);
        }
        public static Vector operator *(Vector v, double r)
        {
            return new Vector(v.X * r, v.Y * r);
        }
        public static double operator *(Vector v1, Vector v2)
        {
            return v1.X * v2.X + v1.Y * v2.Y;
        }
    }
}
