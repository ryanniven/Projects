using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizLibrary
{
    [Table("Questions")]
    //added a table attribute so it knows this class will be mapped to a table
    public class Question
    {
        public Question()
        {
        }
        //creating contructor class for the question, this will store all the data from each field in the database
        public Question(int questionID, string questionText, string option1, string option2, string option3, string option4, string option5, string correctAnswer)
        {
            QuestionID = questionID;
            QuestionText = questionText;
            Option1 = option1;
            Option2 = option2;
            Option3 = option3;
            Option4 = option4;
            Option5 = option5;
            CorrectAnswer = correctAnswer;
        }
        //used autoincrement for when we add admin functionaility, this will generate the ID when a new record is added to the table        
        [PrimaryKey, AutoIncrement]
        //properties of each parameter that map to the constructor
        public int QuestionID {
            get;
            set;
        }

        public string QuestionText {
            get;
            set;
        }

        public string Option1 {
            get;
            set;
        }
        public string Option2
        {
            get;
            set;
        }
        public string Option3
        {
            get;
            set;
        }
        public string Option4
        {
            get;
            set;
        }
        public string Option5
        {
            get;
            set;
        }
        public string CorrectAnswer
        {
            get;
            set;
        }
    }
}
