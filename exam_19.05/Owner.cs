namespace exam_19._05
{
    internal class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Owner()
        {
            Id = 0;
            Name = "No name given yet";
            Address = "No address given yet";
        }
        public Owner(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
    }
}
