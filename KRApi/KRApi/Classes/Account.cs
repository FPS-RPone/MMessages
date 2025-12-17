namespace KRApi.Classes
{
    public class Account
    {
        internal int Id { get; set; }
        public string Name { get; set; }
        public string Tag {  get; set; }
        internal string Password { get; set; }
        public string ImagePath { get; set; } = "mrbrokenglasses.png";
        public List<int> ChatIDs { get; set; }

        public Account(int id, string name, string tag, string password, string imagePath, List<int> chatIDs)
        {
            Id = id;
            Name = name;
            Tag = tag;
            Password = password;
            ImagePath = imagePath;
            ChatIDs = chatIDs;
        }
    }
}
