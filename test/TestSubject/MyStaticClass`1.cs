namespace TestSubject
{
    public static class MyStaticClass<T>
    {
        public static readonly T Instance;

        static MyStaticClass()
        {
            MyStaticClass<T>.Instance = default;
        }
    }
}
