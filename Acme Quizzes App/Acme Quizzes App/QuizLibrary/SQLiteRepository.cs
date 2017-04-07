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

        public Question GetCorrectAnswer(string correctAnswer)
        {
            return dbLayer.GetCorrectAnswer("This is the answer");
        }

        public Question GetNextQuestion(int questionID)
        {
            return dbLayer.GetNextQuestion(1);
        }

        public Question GetQuestionByText(string questionText)
        {
            return dbLayer.GetQuestionByText("this is a test?");
        }

        public List<Question> GetAllQuestions()
        {
            return dbLayer.GetQuestions();
        }
    }
}
