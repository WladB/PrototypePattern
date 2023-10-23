using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaBuilder
{
    class BuilderHuntingPizza :  AbstractBuilder
    {
        private Pizza pizza1 = new Pizza();
        public BuilderHuntingPizza()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.pizza1 = new Pizza();
        }

        public void BuildBase()
        {
            
            this.pizza1.Add("Base");
            
        }

        public void BuildHunting_sausages()
        {
           
            this.pizza1.Add("hunting_sausages");
        }

        public void BuildMushrooms()
        {
           
            this.pizza1.Add("Mushrooms");
        }

        public void BuildOnion()
        { }

        public void BuildTomatoes()
        { }
        public void BuildProvencalHerbs()
        {}

       
        public Pizza GetProduct()
        {
            Pizza result = this.pizza1;

            return result;
        }
    }
    class BuilderHerbsPizza : AbstractBuilder
    {
        private Pizza pizza2 = new Pizza();
        public BuilderHerbsPizza()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.pizza2 = new Pizza();
        }

        public void BuildBase()
        {
            this.pizza2.Add("Base");
        }

        public void BuildHunting_sausages()
        {}

        public void BuildMushrooms()
        {  }
        public void BuildOnion()
        {
            this.pizza2.Add("Onion");
        }

        public void BuildTomatoes()
        {
            this.pizza2.Add("Tomatoes");
        }
        public void BuildProvencalHerbs()
        {
            this.pizza2.Add("Provencal_herbs");
        }
      
        public Pizza GetProduct()
        {
            Pizza result = this.pizza2;

            return result;
        }
    }
    class BuilderMushroomsPizza : AbstractBuilder
    {
        private Pizza pizza3 = new Pizza();
        public BuilderMushroomsPizza()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.pizza3 = new Pizza();
        }

        public void BuildBase()
        {
            this.pizza3.Add("Base");
        }

        public void BuildHunting_sausages()
        {}

        public void BuildMushrooms()
        {
            this.pizza3.Add("Mushrooms");
        }

        public void BuildOnion()
        { }

        public void BuildTomatoes()
        {

            this.pizza3.Add("Tomatoes");
        }
        public void BuildProvencalHerbs()
        {
            this.pizza3.Add("Provencal_herbs");
        }
      
        public Pizza GetProduct()
        {
            Pizza result = this.pizza3;

            return result;
        }
    }
    class BuilderPizza : AbstractBuilder
    {
        private Pizza pizza4 = new Pizza();
        public BuilderPizza()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.pizza4 = new Pizza();
        }

        public void BuildBase()
        {
            this.pizza4.Add("Base");
        }

        public void BuildHunting_sausages()
        {

            this.pizza4.Add("hunting_sausages");
        }


        public void BuildMushrooms()
        {
            this.pizza4.Add("Mushrooms");
        }

        public void BuildOnion()
        {
            this.pizza4.Add("Onion");
        }

        public void BuildTomatoes()
        {

            this.pizza4.Add("Tomatoes");
        }
        public void BuildProvencalHerbs()
        {
            this.pizza4.Add("Provencal_herbs");
        }

        public void SetProduct(Pizza result)
        {
            this.pizza4=  result.clone();
        }

        public Pizza GetProduct()
        {
            Pizza result = this.pizza4;
            this.Reset();
            return result;
        }
    }
    public class Pizza{
        private List<Image> parts = new List<Image>();
        public Pizza()
        { }
        public Pizza(Pizza p)
        {
            this.parts = p.parts;
        }
        public Pizza clone()
        {
            return new Pizza(this);
        }
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
