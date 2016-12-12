using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Quizzer.Models
{
    public class Question
    {

        //private ICollection<User> _user;

        public Question(int id)
        {
            //_user = new List<User>();
        }

        public int id { get; set; }

        //public User createdBy { get; set; }

        public String question { get; set; }

        public String answerOne { get; set; }

        public String answerTwo { get; set; }

        public String answerThree { get; set; }

        public String answerFour { get; set; }

        public String correctAnswer { get; set; }

        //public virtual ICollection<User> User
        //{
        //    get { return _user; }
        //    set { _user = value; }
        //}

        public void Load(int id)
        {

        }
        
    }
}




// Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;