public class Order {
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public List<string> Items { get; set; }
    public Order(int id, DateTime date, List<string> items) { OrderId = id; OrderDate = date; Items = items; }
}