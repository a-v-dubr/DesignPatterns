using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Classes
{
    internal abstract class Event
    {
        protected abstract string Theme { get; }

        public void Run()
        {
            MeetAndGreet();
            TheoryPart();
            CoffeeBreak();
            PracticePart();
            CorporateDinner();
        }

        protected virtual void MeetAndGreet()
        {
            Console.WriteLine("Participants' meeting. Welcome speech");
        }

        protected abstract void TheoryPart();

        protected abstract void PracticePart();

        protected virtual void CoffeeBreak()
        {
            Console.WriteLine("Coffee break");
        }

        protected virtual void CorporateDinner()
        {
            Console.WriteLine("Corporate dinner");
        }
    }
}
