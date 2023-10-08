using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBuilder
{
    public interface AbstractBuilder
    {
    void BuildBase();
    void BuildHunting_sausages();
    void BuildMushrooms();
    void BuildOnion();
    void BuildProvencalHerbs();
    void BuildTomatoes();
    }
}
