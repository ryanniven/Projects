using System;


namespace QuizLibrary
{
    class InterfaceRepository : FunctionRepository

    {
        private DatabaseLayer dblayer = null;
        private string dbLocation;

        public InterfaceRepository()
        {
            dbLocation = DatabaseFilePath;
        }

        private string DatabaseFilePath
        {
            get
            {
                string sqliteFilename = "Quiz.sqlite";
                string libraryPath = 


            }
        }

        public void AddQuestion(Question question)
        {
            throw new NotImplementedException();
        }

        public void DeleteQuestion(Question question)
        {
            throw new NotImplementedException();
        }

        public void EditQuestion(Question question)
        {
            throw new NotImplementedException();
        }

        public Question GetQuestion(int questionID)
        {
            throw new NotImplementedException();
        }
    }
}
