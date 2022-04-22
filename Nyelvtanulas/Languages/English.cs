namespace Nyelvtanulas.Languages
{
    public class English : Language
    {
        public override string Name()
        {
            return "English";
        }

        private English() : base()
        { }

        private static English? current = null;

        public static English Current()
        {
            if (current is null)
            {
                current = new English();
            }
            return current;
        }
    }
}
