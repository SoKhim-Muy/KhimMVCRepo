public class Book {
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public decimal DiscountedPrice => Price * 0.9m; // 10% Discount
    public Book(int id, string title, decimal price) { Id = id; Title = title; Price = price; }
}