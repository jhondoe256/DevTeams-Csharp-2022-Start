using static System.Console;

public class DeveloperUI
{
    private bool isRunningDevUI;
    private DeveloperTeamUI _dtUI;

    public void Run()
    {
        RunApplication();
    }

    private void RunApplication()
    {
        isRunningDevUI = true;
        while (isRunningDevUI)
        {
            WriteLine("== Komodo DevTeams Developer UI ==\n" +
                  "Please Make a Selection:\n" +
                  "1. Add A Developer\n" +
                  "2. View All Developers\n" +
                  "3. View Developer By ID\n" +
                  "4. Update Existing Developer\n" +
                  "5. Delete Existing Developer\n" +
                  "6. (challenge) View All Developers with a Pluralsight Acct.\n" +
                  "-------------------------------\n" +
                  "7. Back To Main Menu\n" +
                  "-------------------------------\n" +
                  "0. Close Application\n");

            string userInputMenuSelection = ReadLine();
            switch (userInputMenuSelection)
            {
                case "1":
                    AddADeveloper();
                    break;
                case "2":
                    ViewAllDevelopers();
                    break;
                case "3":
                    ViewDeveloperByID();
                    break;
                case "4":
                    UpdateAnExistingDeveloper();
                    break;
                case "5":
                    DeleteAnExistingDeveloper();
                    break;
                case "6":
                    ViewDevsWithPluralsight();
                    break;
                case "7":
                    BackToMainMenu();
                    break;
                case "0":
                    CloseApplication();
                    break;
                default:
                    WriteLine("Invalid Selection");
                    DTUtils.PressAnyKey();
                    break;
            }
        }
    }

    private void CloseApplication()
    {
        isRunningDevUI = false;
        DTUtils.isRunning = false;
        WriteLine("Closing Application");
        DTUtils.PressAnyKey();
    }

    private void BackToMainMenu()
    {
        Clear();
        isRunningDevUI = false;
    }

    private void ViewDevsWithPluralsight()
    {
        throw new NotImplementedException();
    }

    private void DeleteAnExistingDeveloper()
    {
        throw new NotImplementedException();
    }

    private void UpdateAnExistingDeveloper()
    {
        throw new NotImplementedException();
    }

    private void ViewDeveloperByID()
    {
        throw new NotImplementedException();
    }

    private void ViewAllDevelopers()
    {
        throw new NotImplementedException();
    }

    private void AddADeveloper()
    {
        throw new NotImplementedException();
    }
}
