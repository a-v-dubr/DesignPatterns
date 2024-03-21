using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.Classes
{
    internal class ProductTraining(string theme) : Event
    {
        protected override string Theme => theme;

        protected override void MeetAndGreet()
        {
            Console.WriteLine($"Training '{theme}'");
            base.MeetAndGreet();
        }

        protected override void PracticePart()
        {
            Console.WriteLine("Master class and crash test");
        }

        protected override void TheoryPart()
        {
            Console.WriteLine("Products' report and demonstration");
        }
    }
}
