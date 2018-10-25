using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Element_List_Testing.Models
{
    public class PortfolioCreationViewModel
    {
        public List<Section> Sections { get; set; }
        public List<Content> Contents { get; set; }
        public Section section { get; set; }
        public Content content { get; set; }


    }
}