using PatternProxyComposite.Composite;

namespace PatternProxyComposite
{
    public class Client
    {
        public User LogIn(User currentUser)
        {
            using (IGlobus globus = new GlobusStoreProxy())
            {
                User user = globus.Authenticate(currentUser.Login, currentUser.PassWord);
                if (user != null)
                {
                    return user;
                }
            }
            return null;
        }

        public int GetOrderAmount()
        {
            Basket basket = new Basket("Globus");

            Component meet = new Basket("Мясо");

            meet.Add(new Meet("Курица"));
            meet.Add(new Meet("Свинина"));
            meet.Add(new Meet("Говядина"));

            Component fruit = new Basket("Фрукты");

            fruit.Add(new Fruit("Яблоки"));
            fruit.Add(new Fruit("Бананы"));

            basket.Add(meet);
            basket.Add(fruit);

            return basket.GetPrice();
        }
    }
}
