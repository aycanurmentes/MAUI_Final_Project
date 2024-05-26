namespace MAUI_Final_Project;
using MAUI_Final_Project.Models;

public partial class Enroll : ContentPage
{
	public Enroll()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        lstStudents.ItemsSource = App.DBTrans.GetAllStudents();
        lstCourses.ItemsSource = App.DBTrans.GetAllCourses();
    }

    private void enrolladd_btn_Clicked(System.Object sender, System.EventArgs e)
    {
        var student = lstStudents.SelectedItem as StudentClass;
        var course = lstCourses.SelectedItem as CourseClass;

        if(student != null && course != null)
        {
            var enroll = new EnrollClass
            {
                Stu_ID = student.ID,
                Crs_Code = course.Crs_Code
            };
            App.DBTrans.AddEnroll(enroll);


        }
        else
        {
            DisplayAlert("Error", "Please select both a student and a course", "OK");
        }
        lstStudents.SelectedItem = null;
        lstCourses.SelectedItem = null;
    }

    private void enrollshow_btn_Clicked(System.Object sender, System.EventArgs e)
    {
        var enrollments = App.DBTrans.GetAllEnrolls();
        lstEnrollments.ItemsSource = enrollments;
    }

    private void enrolldelete_btn_Clicked(System.Object sender, System.EventArgs e)
    {
        var selectedEnrollment = lstEnrollments.SelectedItem as EnrollClass;
        if (selectedEnrollment != null)
        {
            App.DBTrans.DeleteEnroll(selectedEnrollment.En_ID);
            enrollshow_btn_Clicked(sender, e);

        }
        else
        {
            DisplayAlert("Error", "Please select both a student and a course", "OK");
        }
    }
}
