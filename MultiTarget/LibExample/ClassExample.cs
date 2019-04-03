namespace LibExample
{
    public class ClassExample
    {
        public string TST;
        public ClassExample()
        {
#if NETFULL
            TST = "NETFULL";
#endif

#if NETSTANDARD
            TST = "NETSTANDARD";
#endif
        }
    }
}
