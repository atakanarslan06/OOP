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
        #region Property
        MyClass myClass = new MyClass();
        Console.WriteLine(myClass.Yasi);
        myClass.Yasi = 3;
        #endregion
        #endregion
    }
}

class MyClass
{
    int yasi;
    string b;

    #region Full Property
    //Property hangi türden bir field'i temsil ediyorsa o türden olmalıdır...
    //Propertyler temsil ettikleri fieldların isimlerinin baş harfi büyük olacak şekilde isimlendirilir.

    public int Yasi
    {
        //Protery üzerinden değer talep edildiğinde bu blok tetiklernir.
        //yani değer buradan gönderilir.
        get { return yasi; }
        set { yasi = value; }
        #endregion
    }
}
