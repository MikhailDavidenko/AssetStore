namespace AssetStore.Models
{
    public class AssetsViewModel
    {
        public IEnumerable<Asset> Assets { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
