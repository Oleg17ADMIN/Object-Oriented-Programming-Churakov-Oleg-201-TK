using System;

namespace LabChurakov2
{
    public class Vector3D
    {
        public double X1, Y1, Z1, X2, Y2, Z2;

        public Vector3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            X1 = x1; Y1 = y1; Z1 = z1;
            X2 = x2; Y2 = y2; Z2 = z2;
        }

        public (double dx, double dy, double dz) Components()
        {
            return (X2 - X1, Y2 - Y1, Z2 - Z1);
        }

        public double Length()
        {
            var c = Components();
            return Math.Sqrt(c.dx * c.dx + c.dy * c.dy + c.dz * c.dz);
        }

        public static Vector3D Add(Vector3D v1, Vector3D v2)
        {
            var a = v1.Components();
            var b = v2.Components();
            return new Vector3D(0, 0, 0, a.dx + b.dx, a.dy + b.dy, a.dz + b.dz);
        }

        public static Vector3D Subtract(Vector3D v1, Vector3D v2)
        {
            var a = v1.Components();
            var b = v2.Components();
            return new Vector3D(0, 0, 0, a.dx - b.dx, a.dy - b.dy, a.dz - b.dz);
        }

        public static double DotProduct(Vector3D v1, Vector3D v2)
        {
            var a = v1.Components();
            var b = v2.Components();
            return a.dx * b.dx + a.dy * b.dy + a.dz * b.dz;
        }

        public static double CosAngle(Vector3D v1, Vector3D v2)
        {
            return DotProduct(v1, v2) / (v1.Length() * v2.Length());
        }

        public override string ToString()
        {
            var c = Components();
            return $"ΔX={c.dx:F2}, ΔY={c.dy:F2}, ΔZ={c.dz:F2}";
        }
    }
}