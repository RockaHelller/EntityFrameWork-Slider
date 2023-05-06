using Front_To_Back.Models;
using Microsoft.Build.Evaluation;
using Microsoft.CodeAnalysis;

namespace Front_To_Back.ViewModels
{
    public class HomeVM
    {

        //public Feature Feature { get; set; }
        public List<Slider> Sliders { get; set; }
        public List<Feature> Features { get; set; }
        public List<Service> Services { get; set; }
        public List<Strategy> Strategies { get; set; }
        //public List<Project> Projects{ get; set; }


    }
}
