using System;
using System.Collections.Generic;
// Я создаю класс телефон 
class Phone
{
    //делаю св класса
    public string Brand { get; set; }
    public string Model { get; set; }
    public int StorageSize { get; set; }
    public int Quantity { get; set; }

    // Присваиваем поля 
    public Phone(string brand, string model, int storageSize, int quantity)
    {
        Brand = brand;
        Model = model;
        StorageSize = storageSize;
        Quantity = quantity;
    }
}

class PhoneWarehouse
{
    private List<Phone> phones;

    public PhoneWarehouse()
    {
        // Инициализируем  спискок телефонов при создании склада
        phones = new List<Phone>();
    }

    public void AddPhone(Phone phone)
    {
        // добавление в список на складе
        phones.Add(phone);
    }

    public void RemovePhone(string brand, string model, int storageSize)
    {
        // убираем телефон из списка на складе, используя  совпадения модели, гб и бренда
        phones.RemoveAll(p => p.Brand == brand && p.Model == model && p.StorageSize == storageSize);
    }

    public void ListPhones()
    {
        Console.WriteLine("Телефоны на складе:");
        foreach (var phone in phones)
        {
            // вывод информации о каждом телефоне на складе
            Console.WriteLine($"Бренд: {phone.Brand}, Модель: {phone.Model}, Память: {phone.StorageSize} ГБ, Количество: {phone.Quantity}");
        }
    }
}

class Program
{
    static void Main()
    {
        PhoneWarehouse warehouse = new PhoneWarehouse();  // Создание экземпляра склада телефонов

        // Добавяю нескольких телефонов на склад
        warehouse.AddPhone(new Phone("Apple", "iPhone 13", 128, 10));
        warehouse.AddPhone(new Phone("Samsung", "Galaxy S21", 256, 15));
        warehouse.AddPhone(new Phone("Google", "Pixel 6", 128, 20));

        // Вывод информации
        warehouse.ListPhones();

        // Удаление телефона 
        warehouse.RemovePhone("Apple", "iPhone 13", 128);
    }
}
