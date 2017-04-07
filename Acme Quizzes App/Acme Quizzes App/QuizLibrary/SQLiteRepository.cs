using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuizLibrary
{
    public class SQLiteRepository:QuizRepository
    {
        private DatabaseLayer dbLayer = null;
        private string dbLocation;

        public SQLiteRepository()
        {
            dbLocation = DatabaseFilePath;
            dbLayer = new DatabaseLayer(dbLocation);
        }

        private string DatabaseFilePath
        {
            get
            {
                string sqliteFileName = "Quiz.sqlite";
                string libraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

                var path = Path.Combine(libraryPath, sqliteFileName);

                return path;
            }
        }

        public void AddNewQuestion(Question question)
        {
            dbLayer.AddQuestion(question);   
        }

        public void DeleteQuestion(Question question)
        {
            dbLayer.DeleteQuestion(question);
        }

        public void EditQuestion(Question question)
        {
            dbLayer.EditQuestion(question);
        }

        public List<Question> GetAllQuestions()
        {
            return dbLayer.GetQuestions();
        }
    }
}
