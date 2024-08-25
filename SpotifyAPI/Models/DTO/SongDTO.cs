namespace SpotifyAPI.Models.DTO
{
    public class SongDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public TimeSpan? Duration { get; set; } // Продолжительность песни
        public int TrackNumber { get; set; } // Номер трека в релизе
        public string? Lyrics { get; set; } // Текст песни (опционально)

        // Внешний ключ для связи с релизом
        public int ReleaseId { get; set; }
        public long Listeners { get; set; } = 0;
        public List<string> Artists { get; set; } = new List<string>();
    }
}
