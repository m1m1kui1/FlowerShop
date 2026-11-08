using FlowerShop.Models;

namespace FlowerShop.Services;

public interface IFlowerService
{
    List<Flower> GetCatalog();
    Flower? GetById(int id);
}