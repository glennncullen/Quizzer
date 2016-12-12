using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Quizzer.Models
{
    public class QuestionContext : DbContext
    {
        public QuestionContext() : base("QuestionContext")
        {

        }

        public DbSet<Question> Queston { get; set; }

    }
}