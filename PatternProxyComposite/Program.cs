using System;


namespace PatternProxyComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            User user = client.LogIn(new User() { Login = "globus2", PassWord = "globus1234" });
            if(user != null)
            {
                int sum = client.GetOrderAmount();

                Console.WriteLine($"Сумма заказа пользователя {user.Name} составляет {sum} руб.");
            } 
        }
    }
}

