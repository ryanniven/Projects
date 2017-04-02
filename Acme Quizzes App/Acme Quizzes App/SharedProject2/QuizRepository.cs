using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizLibrary
{
   public interface QuizRepositry
    {
        Question GetNextQuestion(int questionID);
        Question GetCorrectAnswer(string correctAnswer);
        Question GetUsersAnswer(string optionSelected);
        
        void AddNewQuestion(Question question);
        void EditQuestion(Question question);
        void DeleteQuestion(Question question);
    }
}
