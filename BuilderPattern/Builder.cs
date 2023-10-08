using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PizzaBuilder
{
    class Builder : AbstractBuilder
    {
        private Pizza pizza = new Pizza();
        public Builder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.pizza = new Pizza();
        }

        public void BuildBase()
        {
            this.pizza.Add("Base");
        }

        public void BuildHunting_sausages()
        {
            this.pizza.Add("hunting_sausages");
        }

        public void BuildMushrooms()
        {
            this.pizza.Add("Mushrooms");
        }

        public void BuildOnion()
        {
            this.pizza.Add("Onion");
        }

        public void BuildTomatoes()
        {
            this.pizza.Add("Tomatoes");
        }
        public void BuildProvencalHerbs()
        {
            this.pizza.Add("Provencal_herbs");
        }

        public Pizza GetProduct()
        {
            Pizza result = this.pizza;

            this.Reset();

            return result;
        }
    }
    public class Pizza{
            private List<Image> parts = new List<Image>();

            public void Add(string part)
            {
                this.parts.Add((Image)Properties.Resources.ResourceManager.GetObject(part));


            if (part == "Base")
            {
                this.parts[this.parts.Count - 1].Tag = 170;
            }
            else {
                this.parts[this.parts.Count - 1].Tag = 130;
            }
        }

            public List<Image> ListParts()
            {
                return parts;
            }
    }
}
