namespace GET_OUT
{
    public class Door
    {
        public Room FromRoom { get; set; }
        public Room ToRoom { get; set; }
        public int[] Position { get; set; }
        public int[] Size { get; set; }
        public bool IsLocked { get; set; }
        public string ID { get; set; }
    }
}
