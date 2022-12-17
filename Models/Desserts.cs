using System;
using caseStudy;
using Contentful.Core.Models;
using System.Collections.Generic;


namespace caseStudy.Models
{
    public class Desserts
    {
        public string DessertName {get; set;}

        public Asset DessertImage {get; set;}

        public string DessertDescription {get; set;}

        public string DessertTutorial {get; set;}

        public int CookingTime {get; set;}
    }


}