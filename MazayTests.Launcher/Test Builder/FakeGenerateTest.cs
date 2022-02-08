﻿using MazayTests.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test_Builder
{
    class FakeGenerateTest
    {
        public Question GetQuestion( string text, string rightAnswers, string anwer)
        {
            Question q = new();
            Answer a1 = new();
            Answer a2 = new();
            q.Text = text;
            q.RightAnswers.Add(rightAnswers);
            a1.Text = rightAnswers;
            a2.Text = anwer;
            q.Answers.Add(a1);
            q.Answers.Add(a2);
            return q;
        }
        public InteractiveTest GetInteractiveTest()
        {
            InteractiveTest Test = new();
            Question q1 = GetQuestion("Так называется самый крупный каменноугольный бассейн России.", "Кузнецкий", "Печорский");
            Question q2 = GetQuestion("Согласно некоторым данным, на этой планете были найдены признаки жизни.", "Марс", "Нептун");
            Question q3 = GetQuestion("В античности это - надпись на памятнике, здании. Также это - текст, " +
                "помещаемый автором перед текстом всего художественного произведения или его частей.", "Эпиграф", "Варьете");
            Test.Questions.Add(q1);
            Test.Questions.Add(q2);
            Test.Questions.Add(q3);
            Test.Images = null;
            Test.Sounds = null;
            Test.StartProperties = new() {Timer =new(), withBackButton = false, withNextButton = false,
            QuestionCount = 0, AnswerRandom= true, QuestionRandom = true};
            return Test;
        }  
    }
}
