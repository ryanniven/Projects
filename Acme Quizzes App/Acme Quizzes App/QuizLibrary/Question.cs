using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite.Net.Attributes;

namespace QuizLibrary
{
    [Table("Customers")]
    public class Question
    {

        public Question()
        {
        }
        //constructors to match db fields to make information accessible as an object
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
        //properties
        [PrimaryKey, AutoIncrement]
        public int QuestionID
        {
            get;
            set;
        }

        public string QuestionText
        {
            get;
            set;
        }

        public string Option1
        {
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
