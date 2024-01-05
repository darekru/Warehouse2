namespace Warehouse2
{
    class Program
    {
        public const string FILE_NAME = @"C:\WarehouseFiles\ImportFile.xlsx";
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            ItemService itemService = new ItemService();
            actionService = Initialize(actionService);

            Console.WriteLine("Welcome to warehouse app!");
            Console.WriteLine("PLease let me know what you want todo:");

            var mainMenu = actionService.GetMenuActionByMenuName("Main");
            for (int i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
            }

            var operation = Console.ReadKey();
            
            switch (operation.KeyChar)
            {
                case '1':
                    var keyInfo = itemService.AddNewItemView(actionService);
                    var id = itemService.AddNewItem(keyInfo.KeyChar);
                    break;
                case '2':
                    var removeId = itemService.RemoveItemView();
                    itemService.RemoveItem(removeId);
                    break;
                case '3':
                    var detailId = itemService.ItemDetailSelectionView();
                    itemService.ItemDetailView(detailId);
                    break;
                case '4':
                    var typeId = itemService.ItemTypeSelectionView();
                    itemService.ItemsByTypeIdView(typeId);
                    break;
                default:
                    Console.WriteLine("Action you entered does not exist");
                    break;
            }
        }

        



        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Add item", "Main");
            actionService.AddNewAction(2, "Remoive item", "Main");
            actionService.AddNewAction(3, "Show details", "Main");
            actionService.AddNewAction(4, "List of items", "Main");

            actionService.AddNewAction(1, "Clothing", "AddNewItemMenu");
            actionService.AddNewAction(2, "Electronics", "AddNewItemMenu");
            actionService.AddNewAction(3, "Grocery", "AddNewItemMenu");
           

            return actionService;
        }
    }
}
