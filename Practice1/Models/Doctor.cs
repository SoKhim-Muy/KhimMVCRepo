namespace Practice1.Models;
public class Doctor(int id, string name, string specialty)
{
    public int Id { get; set; } = id;
    public string Name { get; set; } = name;
    public string Specialty { get; set; } = specialty;
}