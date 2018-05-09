using System;

namespace DatingApp.API.Models
{
   public class Photo
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }

        //desse modo indica para o EF que a exclusão está em modo cascata
        public User User { get; set; }
        public int UserId { get; set; }
    } 
}

