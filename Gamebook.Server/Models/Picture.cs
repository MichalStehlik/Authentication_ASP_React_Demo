namespace Gamebook.Server.Models
{
    public class Picture
    {
        public int FileId { get; set; }
        public File? File { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public required string ContentType { get; set; }
        public required byte[] Content { get; set; }
        public required DateTime CreatedAt { get; set; } = DateTime.Now;
        public User? CreatedBy { get; set; }
        public required string CreatedById { get; set; }
    }
}
