namespace AssetStore.Models
{
    public class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; } // Путь к файлу для скачивания
        public string ImagePath { get; set; } // Путь к изображению
    }
}

