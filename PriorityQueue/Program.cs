
PriorityQueue<string, string> bankQueue = new PriorityQueue<string, string>(new TitleComparer());
bankQueue.Enqueue("Robert Plant", "Sir");
bankQueue.Enqueue("Keith Richards", "Mr");
bankQueue.Enqueue("Tom Jones", "Mr");
bankQueue.Enqueue("Paul McCartney", "Sir");

Console.WriteLine("Clearing Customers Now");
while (bankQueue.TryDequeue(out string item, out string priority))
{
    Console.WriteLine($"Popped Item : {item}. Priority Was : {priority}");
}
