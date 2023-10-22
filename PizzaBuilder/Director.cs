using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
   public class Director
    {
        private AbstractBuilder builder;
        public AbstractBuilder Builder
        {
            set { builder = value; }
        }

        public void Hunting_pizza()
        {
            this.builder.BuildBase();
            this.builder.BuildHunting_sausages();
            this.builder.BuildMushrooms();
        }

        public void Mushroom_pizza()
        {
            this.builder.BuildBase();
            this.builder.BuildProvencalHerbs();
            this.builder.BuildTomatoes();
            this.builder.BuildMushrooms();

        }

        public void Herbs_pizza()
        {
            this.builder.BuildBase();
            this.builder.BuildOnion();
            this.builder.BuildProvencalHerbs();
            this.builder.BuildTomatoes();
        }
    }
}
