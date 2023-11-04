using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Guided_Aignment_List
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Global List
        List<string> studentNames = new List<string>();

        List<string> matthewAddComment = new List<string>();

        List<string> matthewBrowseComment = new List<string>();

        List<string> matthewRemoveComment = new List<string>();

        Random random = new Random();

        

        public MainWindow()
        {
            InitializeComponent();
            // Calling my Preload() method
            Preload();
            DisplayStudents();
            Comments();
            //^Need to remember this, almost forgot how to make these things function
        } // Main Window

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Random text generator when text is changed
            int randomIndexBr = random.Next(0, matthewBrowseComment.Count);
            int randomIndexAd = random.Next(0, matthewAddComment.Count);
            int randomIndexRe = random.Next(0, matthewRemoveComment.Count);

            string randomCommentBr = matthewBrowseComment[randomIndexBr];
            string randomCommentAd = matthewAddComment[randomIndexAd];
            string randomCommentRe = matthewRemoveComment[randomIndexRe];

        }
        // Part 1
        // Calling this method clears the rich text box and displays all students names
        public void DisplayStudents()
        {
            rtbDisplay.Text = ""; // Used to clear the display before redisplaying names

            for (int i = 0; i < studentNames.Count; i++)
            {
                rtbDisplay.Text += $"{i} - {studentNames[i]}\n"; // Formatted to display index and student name
            }

            lblCount.Content = $"Count: {studentNames.Count}"; // Updates Current List Count
        } // DisplayStudents()

        // I create a preload method that I fill with stuff I want to run when the program loads. Then call it from MainWindow()
        // This keeps the MainWindow() a lot cleaner
        public void Preload()
        {
            studentNames.Add("Will");
            studentNames.Add("Hannah");
            studentNames.Add("Dylan");
            studentNames.Add("Kristyn");
            studentNames.Add("Josh");
            studentNames.Add("Manjula");

        } // Preload()

        // Part 2
        // Click Event : Adds Student When Clicked
        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            string studentName = txtNewStudent.Text; // Grab student name

            studentNames.Add(studentName); // Add the student name to list

            DisplayStudents(); // Redisplay Info

            //Adding what I learned, just a side-thing :)
            int randomIndexBr = random.Next(0, matthewBrowseComment.Count);
            int randomIndexAd = random.Next(0, matthewAddComment.Count);
            int randomIndexRe = random.Next(0, matthewRemoveComment.Count);

            string randomCommentBr = matthewBrowseComment[randomIndexBr];
            string randomCommentAd = matthewAddComment[randomIndexAd];
            string randomCommentRe = matthewRemoveComment[randomIndexRe];

            Little_notes_I_took.Text = randomCommentAd;
        } // btnAddStudent

        // Part 3
        // Click Event : When clicked, a Message Box appears with the students name
        private void btnDisplayStudent_Click(object sender, RoutedEventArgs e)
        {
            string indexString = txtIndex.Text; // Getting the users selection
            int index = int.Parse(indexString); // Parsing value to int

            string selectedStudent = studentNames[index]; // Saving the selected student

            MessageBox.Show(selectedStudent); // Displaying Student

            //Adding what I learned, just a side-thing :)
            int randomIndexBr = random.Next(0, matthewBrowseComment.Count);
            int randomIndexAd = random.Next(0, matthewAddComment.Count);
            int randomIndexRe = random.Next(0, matthewRemoveComment.Count);

            string randomCommentBr = matthewBrowseComment[randomIndexBr];
            string randomCommentAd = matthewAddComment[randomIndexAd];
            string randomCommentRe = matthewRemoveComment[randomIndexRe];

            Little_notes_I_took.Text = randomCommentAd; ;
        } // btnDisplayStudent_Click


        // Part 4
        // Click Event : Removes Student at index
        private void btnRemoveAtIndex_Click(object sender, RoutedEventArgs e)
        {
            string indexString = txtIndex.Text; // Getting the users selection
            int index = int.Parse(indexString); // Parsing value to int

            studentNames.RemoveAt(index); // Passing index of student to remove

            DisplayStudents(); // Redisplay updated list of students

            //Adding what I learned, just a side-thing :)
            int randomIndexBr = random.Next(0, matthewBrowseComment.Count);
            int randomIndexAd = random.Next(0, matthewAddComment.Count);
            int randomIndexRe = random.Next(0, matthewRemoveComment.Count);

            string randomCommentBr = matthewBrowseComment[randomIndexBr];
            string randomCommentAd = matthewAddComment[randomIndexAd];
            string randomCommentRe = matthewRemoveComment[randomIndexRe];

            Little_notes_I_took.Text = randomCommentRe;
        } // btnRemoveAtIndex_Click


        public void Comments()
        {
            matthewAddComment.Add("Code code coding");
            matthewAddComment.Add("Make that name yourself?");
            matthewAddComment.Add("Creating name");
            matthewAddComment.Add("Indexing name");
            matthewAddComment.Add("Nice name? Or not? Maybe its a great person, who knows");
            matthewAddComment.Add("Gradient");
            matthewAddComment.Add("This is kind of a test for lists, working it out as we go");
            matthewAddComment.Add("Rich Text Box functionality? Neat");
            matthewAddComment.Add("Wow, nice index code");
            matthewBrowseComment.Add("Searching Searching");
            matthewBrowseComment.Add("Who knows what name you'll find now");
            matthewBrowseComment.Add("Crazy");
            matthewBrowseComment.Add("Loving the browsing");
            matthewBrowseComment.Add("Genuinely this code is helpful though");
            matthewBrowseComment.Add("Indexing name");
            matthewBrowseComment.Add("Cool names to search through");
            matthewBrowseComment.Add("Glad you don't deal with errors here");
            matthewBrowseComment.Add("Imagine looking through names");
            matthewBrowseComment.Add("In case you were wondering, yes this code works");
            matthewRemoveComment.Add("What did that name do to you?");
            matthewRemoveComment.Add("Practice");
            matthewRemoveComment.Add("What did that name do to you?");
            matthewRemoveComment.Add("Good choice");
            matthewRemoveComment.Add("Good call");
            matthewRemoveComment.Add("Deleted");
            matthewRemoveComment.Add("Whittling down the options");
            matthewRemoveComment.Add("Well it all worked out in the end, except for that one");
            matthewRemoveComment.Add("Poor guy, got deleted");
            matthewRemoveComment.Add("Removed!");
            matthewRemoveComment.Add("Touche");

        }


        // Part 5
        // Click Event : Adds Student at Index
        private void btnAddStudentAtIndex_Click(object sender, RoutedEventArgs e)
        {
            string studentName = txtNewStudent.Text; // Grab student name

            string indexString = txtIndex.Text; // Getting the users selection
            int index = int.Parse(indexString); // Parsing value to int

            studentNames.Insert(index, studentName); // Insert student name at index

            DisplayStudents(); // Redisplay Students

            //Adding what I learned, just a side-thing :)
            int randomIndexBr = random.Next(0, matthewBrowseComment.Count);
            int randomIndexAd = random.Next(0, matthewAddComment.Count);
            int randomIndexRe = random.Next(0, matthewRemoveComment.Count);

            string randomCommentBr = matthewBrowseComment[randomIndexBr];
            string randomCommentAd = matthewAddComment[randomIndexAd];
            string randomCommentRe = matthewRemoveComment[randomIndexRe];

            Little_notes_I_took.Text = randomCommentAd;

        } // btnAddStudentAtIndex_Click

        // Part 6
        // Click Event : Clear List
        private void btnClearList_Click(object sender, RoutedEventArgs e)
        {
            studentNames.Clear(); // Clearing the list of all names

            DisplayStudents(); // Redisplaying the list ( which should now be empty )


        } // btnClearList_Click


    } // class

} // namespace