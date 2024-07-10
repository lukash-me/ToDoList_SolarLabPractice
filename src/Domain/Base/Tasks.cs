namespace Base
{
    /// <summary>
    /// Задача.
    /// </summary>
    public class Tasks
    {
        public int id { get; set; }
        public string name { get; set; }
        public string tag { get; set; }
        public string priority { get; set; }
        public string status { get; set; }
        public double duration { get; set; }
        public DateTime deadline { get; set; }
    }
}
