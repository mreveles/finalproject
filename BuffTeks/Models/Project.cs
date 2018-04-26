using System;
using System.Collections.Generic;

namespace BuffTeks.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string ProjectName {get; set; }
        public string ProjectDescription {get; set; }
        public List<ProjectParticipant> Participants {get; set;}

        public override string ToString(){
            return $"Project Name: {this.ProjectName}\n Project Description: {this.ProjectDescription}";
        }

    }
}