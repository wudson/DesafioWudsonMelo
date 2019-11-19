namespace projeto2
{
    public class ClasseComVariaveisGlobais
    {
        public static bool UsarDev;
        public static bool UsarDevExpress
        {
            get => UsarDev;
            set => UsarDev = value;
        }
    }
}
