namespace RestaurantSystem.Models
{
    internal class MenuItem
    {
        public int ItemID{ get; set; }
        public string Name{ get; set; }
        public string ShortDescription{ get; set; }
        public string LongDescription{ get; set; }
        public decimal Price{ get; set; }
        public string Category{ get; set; }
        public byte[] Image{ get; set; }
    }
}
