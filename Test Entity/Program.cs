namespace Test_Entity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            userService.Add(1, "Ты супер", "");
        }
    }
}