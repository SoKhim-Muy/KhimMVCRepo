public class Department {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<string> Employees { get; set; } = new();
    public Department(int id, string name, List<string> emps) { Id = id; Name = name; Employees = emps; }
}