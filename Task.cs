using System;
using System.Collections.Generic;

namespace Capstone_2
{
    public class Task
    {
        private string name1;
        private string description1;
        private string due1;
        private bool complete1;

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Due { get; set; }
        public bool Complete { get; set; }

        

        public Task(string name, string description,DateTime due )
        {

            this.name1 = name;
            this.description1 = description;
            this.due1 = due.ToString("d");
            this.complete1 = false;

        }

        public void CompleteTask()
        {
            this.complete1 = true;
        }

        public override string ToString()
        {
            return "Name: " + name1 + 
                   ". Description: " + description1 + ". Due Date: " + 
                   due1 + ". Is complete: " + complete1;
        }
    }
}