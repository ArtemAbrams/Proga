using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    abstract class Worker
    {
        public string Name;
        public string Position;
        public string WorkDay = "Sunday"; 
        public Worker (string Name)
        {
            this.Name = Name;
        }
        public void Call()
        {
            Console.WriteLine("Визов");
        }
        public void WriteCode()
        {
            Console.WriteLine("Пише код");
        }
        public void Relax()
        {
            Console.WriteLine("Відпочиває");
        }
        public abstract void FillWorkDay();

    }
}
