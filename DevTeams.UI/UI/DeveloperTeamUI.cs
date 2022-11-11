using static System.Console;

public class DeveloperTeamUI
{
    private bool isRunningDevTeamUI;
    public void Run()
    {
        RunApplication();
    }

    private void RunApplication()
    {
        isRunningDevTeamUI = true;
        while (isRunningDevTeamUI)
        {
            WriteLine("== DeveloperTeams UI ==\n" +
                  "Please Make a Selection:\n" +
                  "1. Add A Developer Team\n" +
                  "2. View All Developer Teams\n" +
                  "3. View Developer Team By ID\n" +
                  "4. Update Existing Developer Team\n" +
                  "5. Delete Existing Developer Team\n" +
                  "6. (challenge) Add Multi. Devs To A Team.\n" +
                  "-------------------------------\n" +
                  "7. Open Main Menu\n" +
                  "-------------------------------\n" +
                  "0. Close Application\n");

            string userInputMenuSelection = ReadLine();

            switch (userInputMenuSelection)
            {
                case "1":
                    AddADeveloperTeam();
                    break;
                case "2":
                    ViewAllDeveloperTeams();
                    break;
                case "3":
                    ViewDeveloperTeamByID();
                    break;
                case "4":
                    UpdateAnExistingDeveloperTeam();
                    break;
                case "5":
                    DeleteAnExistingDeveloperTeam();
                    break;
                case "6":
                    AddMultiDevsToATeam();
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
        isRunningDevTeamUI = false;
        DTUtils.isRunning = false;
        WriteLine("Closing Application");
        DTUtils.PressAnyKey();
    }

    private void BackToMainMenu()
    {
        Clear();
        isRunningDevTeamUI = false;
    }

    private void AddMultiDevsToATeam()
    {
        throw new NotImplementedException();
    }

    private void DeleteAnExistingDeveloperTeam()
    {
        throw new NotImplementedException();
    }

    private void UpdateAnExistingDeveloperTeam()
    {
        throw new NotImplementedException();
    }

    private void ViewDeveloperTeamByID()
    {
        throw new NotImplementedException();
    }

    private void ViewAllDeveloperTeams()
    {
        throw new NotImplementedException();
    }

    private void AddADeveloperTeam()
    {
        throw new NotImplementedException();
    }
}
