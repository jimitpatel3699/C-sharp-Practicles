namespace Practicle6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.StartProcess();
        }
        // event handler
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Method Invoked");
        }
    }
}