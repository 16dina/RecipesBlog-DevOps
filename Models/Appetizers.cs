using System;
using caseStudy;
using Contentful.Core.Models;
using System.Collections.Generic;


namespace caseStudy.Models
{
    public class Appetizers
    {
        public string AppetizerName {get; set;}

        public Asset AppetizerImage {get; set;}

        public string AppetizerDescription {get; set;}

        public string AppetizerTutorial {get; set;}
    }


}