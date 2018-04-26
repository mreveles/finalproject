using System;
using System.Collections.Generic;

namespace BuffTeks.Models
{
    public class ProjectParticipant
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public override string ToString(){
            return $"Project FName: {this.FName}\n LName: {this.LName}";
        }
    
    }
}