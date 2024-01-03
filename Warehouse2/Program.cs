namespace Warehouse2
{
    class Program
    {
        public const string FILE_NAME = @"C:\WarehouseFiles\ImportFile.xlsx";
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);

            Console.WriteLine("Welcome to warehouse app!");
            Console.WriteLine("PLease let me know what you want todo:");

            var mainMenu = actionService.GetMenuActionByMenuName("Main");
            for (int i = 0; i < mainMenu.Count;  i++) 
            {
                Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
            }
        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Add item", "Main");
            actionService.AddNewAction(2, "Remoive item", "Main");
            actionService.AddNewAction(3, "Show details", "Main");
            actionService.AddNewAction(4, "List of items", "Main");

            return actionService;
        }
    }
}
