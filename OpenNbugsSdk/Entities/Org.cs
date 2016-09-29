namespace ONS.Entities
{
    public class Org
    {
        public string id { get; set; }
        public int studentCount { get; set; }
        public int teacherCount { get; set; }
        public string name { get; set; }
        public string parentOrgUuid { get; set; }
        public string type { get; set; }
        public string loginOrgId { get; set; }
        public string secondType { get; set; }
        public string standardName { get; set; }
        public int sort { get; set; }

    }
}
