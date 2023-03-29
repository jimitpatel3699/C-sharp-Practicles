namespace practicle2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "jimit patel";
            long accountNO = 10000000234588;
            CustomerAccount customer1 = new CustomerAccount(name,accountNO);
            customer1.PrintInfo();
        }
    }
}