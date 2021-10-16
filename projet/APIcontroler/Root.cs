using System.Collections.Generic;

namespace projet.APIcontroler
{
    public class Root
    {
        public Config config { get; set; }
        public Usage usage { get; set; }
        public List<Datum> data { get; set; }
    }
}