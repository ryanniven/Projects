using System;
using System.Collections.Generic;
using System.Text;

namespace QuizLibrary
{
    public interface QuizRepository
    {
        List<Question> GetAllQuestions();

        //TODO admin functionality

        void AddNewQuestion(Question question);
        void EditQuestion(Question quesiton);
        void DeleteQuestion(Question question);
    }
}
