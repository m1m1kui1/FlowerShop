using FlowerShop.Models;

namespace FlowerShop.Services;

public class FlowerService : IFlowerService
{
    private readonly List<Flower> _flowers;

    public FlowerService()
    {
        // Имитируем базу данных
        _flowers = new List<Flower>
        {
            new Flower { Id = 1, Name = "Красная роза", Description = "Классика, символ любви.", Price = 150, Emoji = "🌹" },
            new Flower { Id = 2, Name = "Тюльпан", Description = "Весеннее настроение.", Price = 100, Emoji = "🌷" },
            new Flower { Id = 3, Name = "Подсолнух", Description = "Маленькое солнце.", Price = 200, Emoji = "🌻" },
            new Flower { Id = 4, Name = "Лаванда", Description = "Успокаивает и пахнет летом.", Price = 250, Emoji = "💜" }
        };
    }

    public List<Flower> GetCatalog() => _flowers;
    public Flower? GetById(int id) => _flowers.FirstOrDefault(f => f.Id == id);
}
