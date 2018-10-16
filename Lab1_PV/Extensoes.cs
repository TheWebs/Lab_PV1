
namespace Lab1_PV
{
    public static class Extensoes
    {

        public static string AppendColor(this string s, Peca p)
        {
            if (p.corBranca)
                return s + "(B)";
            else
                return s + "(P)";
        }
    }
}