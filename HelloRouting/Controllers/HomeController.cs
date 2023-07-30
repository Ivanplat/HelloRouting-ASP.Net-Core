namespace HelloRouting.Controllers
{
    public class HomeController
    {
        public string Index(string? id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return $"Привет из контроллера!";
            }
            else
            {
                return $"Привет! Это {id}.";
            }
        }
    }
}
