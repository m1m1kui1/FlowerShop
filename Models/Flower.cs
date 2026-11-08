namespace FlowerShop.Models;

public class Flower
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string Emoji { get; set; } = "🌸"; // Используем эмодзи вместо картинок, чтобы сайт точно загрузился
}