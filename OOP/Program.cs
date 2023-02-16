internal class Program
{
    private static void Main(string[] args)
    {
        #region Class Members
        #region Field
        //Nesne içerisinde değer tutmamızı sağlayan alanlardır
        MyClass m1 = new MyClass(); //Nesne Oluşturduk!!!
        m1.a = 1;
        MyClass m2 = new MyClass(); //Nesne Oluşturduk!!!
        m2.a = 2;

        #endregion
        #endregion
    }
}

class MyClass
{
    public int a;
    public string b;
}
