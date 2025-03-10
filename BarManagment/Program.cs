class Program
{
    static void Main()
    {
        while (true)
        {
            Bar bar = new Bar();
            User user = LoginSystem.Login();
            user.ShowOptions(bar);

        }
    }
}