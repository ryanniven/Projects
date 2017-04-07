using System;
using System.Collections.Generic;
using System.Text;

namespace QuizLibrary
{
    public interface QuizRepository
    {
        Question GetNextQuestion(int questionID);
        Question GetCorrectAnswer(string correctAnswer);
        Question GetQuestionByText(string questionText);
        List<Question> GetAllQuestions();

        //TODO admin functionality

        void AddNewQuestion(Question question);
        void EditQuestion(Question quesiton);
        void DeleteQuestion(Question question);
    }
}
