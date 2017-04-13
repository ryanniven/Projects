using SQLite.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuizLibrary
{
    public class DatabaseLayer
    {
        //connection to the database via the path set in the repository
        private SQLiteConnection connection;
        public DatabaseLayer(string dbLocation)
        {
            //providing information on the platform the database is installed on
            connection = new SQLiteConnection(new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid(), dbLocation);
            //create a table based on the Question class, if there is already one there use it
            connection.CreateTable<Question>();
        }

        public List<Question> GetQuestions()
        {
            //create SQL to get questions from the database and return as a list of question objects
            return new List<Question> (connection.Table<Question>());
        }


        //TODO Admin functionality
        public void AddQuestion(Question question)
        {
            //method to insert a question
            connection.Insert(question);
        }

        public void DeleteQuestion(Question question)
        {
            //method to delete a question
            connection.Delete(question);
        }

        public void EditQuestion(Question question)
        {
            //method to edit a question
            connection.Update(question);
        }
    }
}
