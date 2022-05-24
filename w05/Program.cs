VendingMachine v = new VendingMachine();
v.Populate();
v.getList();

public class Item {
    private string name;
    private double price;
    private string location;
    private int quantity;

    public Item(string name, double price, string location, int quantity = 3) {
        this.name = name;
        this.price = price;
        this.location = location;
        this.quantity = quantity;        
    }

    private double totalValue() {
        return quantity * price;
    }

    public void showItem(){
        Console.WriteLine($"{name} - {price} - {location} - QTY:{quantity}");
        Console.WriteLine($"Total Value: {totalValue()}");
    }

}

public class VendingMachine {
    // public List<item> items { get; set; }
    private List<Item> items = new List<Item>();

    public VendingMachine() {
            Console.WriteLine("I'm a vending machine");
    }

    public void Populate() {
        items.Add(new Item("Doritos", 2.5, "A1"));
        items.Add(new Item("Reese's", .75, "A2"));
        items.Add(new Item("Coke", 5.00, "A3"));
    }

    public void getList() {
        Console.WriteLine("Hi, here are the items in the vending machine!");
        foreach (Item item in items) {
            item.showItem();
            
        }
        // return items;
    }

}