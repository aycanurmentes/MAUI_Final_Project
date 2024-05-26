namespace MAUI_Final_Project;

public partial class Course : ContentPage
{
	public Course()
	{
		InitializeComponent();
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();
	}

    private void addcourse_btn_Clicked(System.Object sender, System.EventArgs e)
    {
        App.DBTrans.AddCourse(new Models.CourseClass
        {
            Crs_Code = Course_Code.Text,
            Crs_Name = Course_Name.Text,
        });
    }

    private void deletecourse_btn_Clicked(System.Object sender, System.EventArgs e)
    {
        Button button = (Button)sender;
        App.DBTrans.DeleteCourse((int)button.BindingContext);
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();
    }

    private void showcourse_btn_Clicked(System.Object sender, System.EventArgs e)
    {
        Course_List_View.ItemsSource = App.DBTrans.GetAllCourses();
    }
}
