namespace MAUI_Final_Project;
using Models;
using DataTransactions;
public partial class Student : ContentPage
{
	public Student()
	{
		InitializeComponent();
        Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();
	}

    private void add_btn_Clicked(System.Object sender, System.EventArgs e)
    {
        App.DBTrans.Add(new Models.StudentClass
        {
            Name = Stu_Name.Text,
            Department=Stu_Dept.Text,

        });
    }

   private void delete_btn_Clicked(System.Object sender, System.EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.Delete((int)button.BindingContext);
        Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();
    }

    private void show_btn_Clicked(System.Object sender, System.EventArgs e)
    {
        Stu_List_View.ItemsSource = App.DBTrans.GetAllStudents();
    }
}
