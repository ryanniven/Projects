using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizLibrary
{
    public class DatabaseLayer
    {
        private SQLiteConnection connection;
        public DatabaseLayer(string dbLocation)
        {
            connection = new SQLiteConnection(new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid(), dbLocation);
            connection.CreateTable<Question>();
        }

        public Question GetNextQuestion(int questionID)
        {
            return connection.Table<Question>().SingleOrDefault(q => q.QuestionID == questionID);
        }

        public Question GetQuestionByText(string questionText)
        {
            return connection.Table<Question>().SingleOrDefault(q => q.QuestionText == questionText);
        }
        public Question GetCorrectAnswer(string correctAnswer)
        {
            return connection.Table<Question>().SingleOrDefault(c => c.CorrectAnswer == correctAnswer);
        }
        public List<Question> GetQuestions()
        {
            return new List<Question> (connection.Table<Question>());
        }


        //TODO Admin functionality
        public void AddQuestion(Question question)
        {
            connection.Insert(question);
        }

        public void DeleteQuestion(Question question)
        {
            connection.Delete(question);
        }

        public void EditQuestion(Question question)
        {
            connection.Update(question);
        }
    }
}
