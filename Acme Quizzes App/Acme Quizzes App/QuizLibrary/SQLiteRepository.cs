using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuizLibrary
{
    //implementing the interface
    public class SQLiteRepository:IQuizRepository
    {
        //adding a database layer to the repository
        private DatabaseLayer dbLayer = null;
        //specifying path of where to install db on android device
        private string dbLocation;

        public SQLiteRepository()
        {

            dbLocation = DatabaseFilePath;
            //passing the path to our database layer object
            dbLayer = new DatabaseLayer(dbLocation);
        }

        private string DatabaseFilePath
        {
            get
            {
                //hard coded file name and path to be passed to constructor
                string sqliteFileName = "Quiz.sqlite";
                //path where database is being installed, this special folder / personal will make it specfic to the app
                string libraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

                //create a single string for file path
                var path = Path.Combine(libraryPath, sqliteFileName);

                return path;
            }
        }

       //implementations of methods from repository
        public void AddNewQuestion(Question question)
        {
            //adds question from the db layer
            dbLayer.AddQuestion(question);   
        }

        public void DeleteQuestion(Question question)
        {
            //deletes question from db layer
            dbLayer.DeleteQuestion(question);
        }

        public void EditQuestion(Question question)
        {
            //edits the question from the db layer
            dbLayer.EditQuestion(question);
        }

        public List<Question> GetAllQuestions()
        {
            //gets all quesions from the db layer
            return dbLayer.GetQuestions();
        }
    }
}
