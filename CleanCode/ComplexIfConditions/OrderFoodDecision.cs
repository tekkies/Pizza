using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.CleanCode.ComplexIfConditions
{
    class OrderFoodDecision
    {
        void DecideWithInlineLogic()
        {
            if (IsRaining() || Meetings.Count() > 5)
            {
                ChooseFullLoadedPizza();
            }
            else
            {
                ChooseSalad();
            }
        }

        void DecideWithEncapsulatedLogic()
        {
            if (HadABadDay())
            {
                ChooseFullLoadedPizza();
            }
            else
            {
                ChooseSalad();
            }
        }

        public bool HadABadDay()
        {
            return IsRaining()
                   || (Meetings.Count() > 5);

        }

        ///////////////////////////////////////////////////////////////////////////////////

        public bool IsRaining()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Meetings => new string[] { "Disciplinary", "Paul", "Mary" };

        private void ChooseFullLoadedPizza()
        {
            throw new NotImplementedException();
        }

        private void ChooseSalad()
        {
            throw new NotImplementedException();
        }
    }
}
