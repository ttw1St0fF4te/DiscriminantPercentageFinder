namespace DiscriminantPercentFinder
{
    public class DiscPercFinder
    {
        public static (double?, double?) FindRoots(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
            {
                return (null, null);
            }
            else if (discriminant == 0)
            {
                double root = -b / (2 * a);
                return (root, root);
            }
            else
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return (root1, root2);
            }
        }

        public static double CalculatePercentage(double number, double percentage)
        {
            return (number * percentage) / 100;
        }

        public static void Main()
        {
            
        }
    }
}