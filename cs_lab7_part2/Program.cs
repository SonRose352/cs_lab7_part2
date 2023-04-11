using cs_lab7_part2;
using System.Collections.Immutable;

//Иван Кукин
Person ivan = new Person("Иван", "Кукин", new DateTime(1950, 4, 1), 'м');
Worker wIvan = new Worker("Иван", "Кукин", new DateTime(1950, 4, 1), 'м', 30000, 25);

//Людмила Кукина
Person lyuda = new Person("Людмила", "Кукина", new DateTime(1965, 5, 1), 'ж');
Worker wLyuda = new Worker("Людмила", "Кукина", new DateTime(1965, 5, 1), 'ж', 35000, 0);

//Дом
Building house = new Building(ivan, 3000000, "Зайцева, 79");

//Земельный участок
Stead landPlot = new Stead(ivan, 500000, 600);

//Садовый участок
Stead gardenPlot = new Stead(ivan, 300000, 1000);

//Лошадь
Horse horse = new Horse(ivan, 20000, "Ромашка", 100, 7, 250);

//Автомобиль
Car car = new Car(ivan, 10000, "ЗАЗ-965", 600, 27);

//Лодка
SmallShip ship = new SmallShip(ivan, 25000, "Лодка с мотором", 300, 0, 15);

//Всё имущество Кукиных
Holding[] holdings = new Holding[6] {house, landPlot, gardenPlot, horse, car, ship};
double allCost = 0;
foreach (Holding holding in holdings)
{
    allCost += holding.Cost;
}
Console.WriteLine($"Общая стоимость имущества Кукиных: {allCost}");

//Общая сумма налога выплачиваемая Кукиными
INalog[] nalogs = new INalog[7] {wIvan, wLyuda, house, landPlot, gardenPlot, car, ship};
double allNalog = 0;
foreach (INalog nalog in nalogs)
{
    allNalog += nalog.nalog();
}
Console.WriteLine($"Общая сумма выплачиваемых налогов Кукиных: {allNalog}");

//Сортировка массива holdings
Array.Sort(holdings);
foreach (Holding holding in holdings)
{
    Console.WriteLine(holding.Cost);
}