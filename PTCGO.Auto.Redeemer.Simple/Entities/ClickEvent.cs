namespace PTCGO.Auto.Redeemer.Simple.Entities
{
    public class ClickEvent
    {
        public string Name { get; set; }
        
        public (int x, int y) Coordinates { get; set; }
    }
}