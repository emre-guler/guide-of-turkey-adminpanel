using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuideOfTurkey_AdminPanel.Models
{
    public class Comment 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int UserID { get; set; }
        public int PlaceID { get; set; }
        public string userComment { get; set; }
        public float Rating { get; set; }
        public DateTime Date { get; set; }
        public bool deleteState { get; set; }
    }
}