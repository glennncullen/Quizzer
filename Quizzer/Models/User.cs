//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quizzer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public Nullable<int> historyHighScore { get; set; }
        public Nullable<decimal> historyTime { get; set; }
        public Nullable<int> scienceHighScore { get; set; }
        public Nullable<decimal> scienceTime { get; set; }
        public Nullable<int> geographyHighScore { get; set; }
        public Nullable<decimal> geographyTime { get; set; }
    }
}
