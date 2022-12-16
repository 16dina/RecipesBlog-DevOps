using System;
using caseStudy;
using Contentful.Core.Models;
using System.Collections.Generic;


namespace caseStudy.Models
{
    public class MainDishes
    {
        public string MainDishName {get; set;}

        public Asset MainDishImage {get; set;}

        public string MainDishDescription {get; set;}

        public string MainDishTutorial {get; set;}
    }


}