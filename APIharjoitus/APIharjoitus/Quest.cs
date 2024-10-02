using Microsoft.AspNetCore.SignalR;

namespace APIharjoitus
{
    public class Quest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int reward { get; set; }
    }
}
