namespace Nyelvtanulas.Languages
{
    public class Hungarian : Language
    {
        public override string Name()
        {
            return "Hungarian";
        }

        private Hungarian(): base()
        {}

        private static Hungarian? current = null;

        public static Hungarian Current()
        {
            if (current is null)
            {
                current = new Hungarian();
            }
            return current;
        }
    }
}
