using System;
using System.Collections.Generic;
using System.Text;

namespace Full_GRASP_And_SOLID
{
    public class Adapter : TimerClient
    {
        public Recipe recipe { get; set; }

        public CountdownTimer timer { get; set; }
        public Adapter(Recipe Recipe)
        {
            this.timer = new CountdownTimer();
            this.recipe = Recipe;
        }

        public void TimeOut()
        {
            recipe.Cooked = true;
        }
        public void Start()
        {

            this.timer.Register(recipe.GetCookTime(), this);
        }
    }
}