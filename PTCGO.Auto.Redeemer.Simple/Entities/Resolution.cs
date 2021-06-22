using System.Collections.Generic;

namespace PTCGO.Auto.Redeemer.Simple.Entities
{
    public class Resolution
    {
        public string ResolutionName { get; set; }
        
        public List<ClickEvent> ClickEvents { get; set; }
    }
}