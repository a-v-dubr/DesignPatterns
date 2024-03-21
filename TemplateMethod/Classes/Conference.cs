using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Classes
{
    internal class Conference(string theme) : Event
    {
        protected override string Theme => theme;

        protected override void MeetAndGreet()
        {
            Console.WriteLine($"Conference '{theme}'");
            base.MeetAndGreet();
        }

        protected override void PracticePart()
        {
            Console.WriteLine("Round table discussion");
        }

        protected override void TheoryPart()
        {
            Console.WriteLine("Plenary session");
        }
    }
}
