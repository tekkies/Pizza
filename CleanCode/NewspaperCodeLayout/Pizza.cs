using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.CleanCode.NewspaperCodeLayout
{
    class Pizza
    {
        /// <summary>
        /// Problem: Taking the newspaper layout literally, AddCheese() would come after MakeMargaritaPizza()
        /// but that would break the rule of not mixing levels of abstraction.
        /// </summary>

        //Pizza level of abstraction
        void MakeMargaritaPizza()
        {
            AddCheese();
            AddTomatoPaste();
        }

        void MakePepperoniPizza()
        {
            AddCheese();
            AddTomatoPaste();
            AddPepperoni();
        }

        //Ingredient level of abstraction, in caller order, if possible.
        private void AddCheese()
        {
        }

        private void AddTomatoPaste()
        {
        }

        private void AddPepperoni()
        {
        }
    }
}
