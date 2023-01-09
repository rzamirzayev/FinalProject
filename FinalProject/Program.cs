using FinalProject.Services.Implementations;

int selection;
do
{
    Console.WriteLine("1.Create Group");
    Console.WriteLine("2.GetAll Group");
    Console.WriteLine("3.Edit Group");
    Console.WriteLine("4.Get Group's Students");
    Console.WriteLine("5.Get All Student");
    Console.WriteLine("6.Create Student");
    int.TryParse(Console.ReadLine(), out selection);
    switch (selection)
    {
        case 1:
            MenuService.CreateGroupMenu();
            break;
        case 2:
            MenuService.GetAllGroupMenu(); 
            break;
        case 3:
            MenuService.EditGroupMenu();
            break;
        case 4:
            MenuService.GetGroupStudentsMenu();
            break;
        case 5:
            MenuService.GetAllStudentsMenu();
            break;
        case 6:
            MenuService.CreateStudentMenu();
            break;
        default:
            if (selection != 0)
            {
                Console.WriteLine("Duzgun secim daxil edin");
            }
            break;
    }
}while(selection!=0);