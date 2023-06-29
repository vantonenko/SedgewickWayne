namespace SedgewickWayne.Extensions
{
    internal static class EnumerableExtensions
    {
        public static string AsString(this IEnumerable<bool> bits) =>
            $"{bits.Select(b => b ? '1' : '0').Join()}b";

        public static string Join<T>(this IEnumerable<T> items, string separator = "") =>
            string.Join(separator, items);
    }
}