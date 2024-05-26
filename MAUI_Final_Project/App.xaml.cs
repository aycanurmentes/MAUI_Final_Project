using MAUI_Final_Project.DataTransactions;

namespace MAUI_Final_Project;

public partial class App : Application
{
	public static DBTrans DBTrans { get; private set; }
	public App(DBTrans dbtrans)
	{
		InitializeComponent();

		MainPage = new AppShell();
		DBTrans = dbtrans;
	}
}

