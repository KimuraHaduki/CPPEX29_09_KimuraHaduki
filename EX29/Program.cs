using System;

namespace EX29
{
    class Program
    {
        static void Main(string[] args)
        {
            float cylinderRadius = Input("円柱\n半径", 1, 1000);
            float cylinderHeight = Input("高さ", 1, 1000);

            float sphereRadius = Input("\n球\n半径", 1, 1000);

            float triangularPrismBottom = Input("\n三角柱\n底辺", 1, 1000);
            float triangularPrismheight = Input("底面の高さ", 1, 1000);
            float triangularPrismTop = Input("高さ", 1, 1000);

            Console.WriteLine("\n円柱" +
                "\n表面積 :" + Cylinder.GetSurface(cylinderRadius, cylinderHeight) + "cm²" +
                "\n体積 :" + Cylinder.GetVolume(cylinderRadius, cylinderHeight) + "cm³\n" +
                "\n球" +
                "\n表面積 :" + Sphere.GetSurface(sphereRadius) + "cm²" +
                "\n体積 :" + Sphere.GetVolume(sphereRadius) + "cm³\n" +
                "\n三角柱" +
                "\n表面積 :" + TriangularPrism.GetSurface(triangularPrismBottom, triangularPrismheight, triangularPrismTop) + "cm²" +
                "\n体積 :" + TriangularPrism.GetVolume(triangularPrismBottom, triangularPrismheight, triangularPrismTop) + "cm³");
        }

        static float Input(string message, float min, float max)
        {
            while (true)
            {
                float number;
                Console.Write(message + "(" + min + "～" + max + ")  : ");
                try
                {
                    number = float.Parse(Console.ReadLine());


                    if (min <= number && number <= max)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("入力エラーです");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("えらー");
                }
            }
        }
    }

    class Cylinder
    {
        float radius;
        float height;

        public Cylinder(float r, float h)
        {
            this.radius = r;
            this.height = h;
        }

        public static float GetSurface(float radius, float height)
        {
            return radius * radius * (float)Math.PI * 2 + radius * 2 * height;
        }

        public static float GetVolume(float radius, float height)
        {
            return radius * radius * (float)Math.PI * height;
        }
    }

    class Sphere
    {
        float radius;
        public Sphere(float r)
        {
            this.radius = r;
        }
        public static float GetSurface(float radius)
        {
            return 4 * (float)MathF.PI * radius * radius;
        }

        public static float GetVolume(float radius)
        {
            return 4 / 3 * (float)Math.PI * radius * radius * radius;
        }
    }

    class TriangularPrism
    {
        float bottom;
        float height;
        float top;
        public TriangularPrism(float b, float h, float t)
        {
            this.bottom = b;
            this.height = h;
            this.top = t;
        }
        public static float GetSurface(float bottom, float height, float top)
        {
            return bottom * height / 2 * 2 +
                ((float)Math.Sqrt(bottom * bottom + height * height) + bottom + height) * top;
        }

        public static float GetVolume(float bottom, float height, float top)
        {
            return bottom * height / 2 * top;
        }
    }
}
