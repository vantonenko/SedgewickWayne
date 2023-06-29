namespace SedgewickWayne.Exercises._1_1_9.Extensions
{
    public static class IntExtensions
    {
        public static IEnumerable<bool> AsBinary(this int value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            if (value == 0)
            {
                yield return false;
                yield break;
            }

            int t = value;
            while (t > 0)
            {
                yield return t % 2 == 1;
                t /= 2;
            }
        }

        public static string AsBinaryString(this int value) => value.AsBinary().AsString();
    }
}