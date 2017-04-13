using System;
using System.Collections.Generic;
using System.Text;

namespace QuizLibrary
{
    public interface IQuizRepository
    {
        //method signature to get all the questions from the database 
        List<Question> GetAllQuestions();

        //TODO admin functionality intended on creating UI for this and linking this functionality

        void AddNewQuestion(Question question);
        void EditQuestion(Question quesiton);
        void DeleteQuestion(Question question);
    }
}
