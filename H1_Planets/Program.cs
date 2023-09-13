namespace H1_Planets
{
    internal class Program
    {
        /// <summary>
        /// Calls the controller and gets out of static
        /// </summary>
        static void Main()
        {
            Controller.Controller controller = new Controller.Controller();
            controller.MainController();
        }
    }
}