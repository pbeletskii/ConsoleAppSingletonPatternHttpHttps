namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Servers servers = new Servers();
            servers.Add("http://rrrr");
            servers.Add("https://rrrr");
            servers.Add("avb://rrrr");

            List<string> serv = servers.GetServer();
            foreach (string s in serv)
            {
                Console.WriteLine(s);
            }

            serv = servers.GetServer("http");
            foreach (string s in serv)
            {
                Console.WriteLine(s);
            }

            serv = servers.GetServer("https");
            foreach (string s in serv)
            {
                Console.WriteLine(s);
            }
        }
    }
}
