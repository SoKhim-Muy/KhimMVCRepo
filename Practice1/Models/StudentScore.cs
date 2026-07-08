public class StudentScore {
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Attendance { get; set; }
    public double Midterm { get; set; }
    public double Final { get; set; }
    public StudentScore(int id, string name, double att, double mid, double fin) {
        Id = id; Name = name; Attendance = att; Midterm = mid; Final = fin;
    }
    public double GetTotal() => Attendance + Midterm + Final;
    public string GetGrade() {
        double t = GetTotal();
        if (t >= 85) return "A"; else if (t >= 75) return "B";
        else if (t >= 65) return "C"; else if (t >= 50) return "D";
        else return "F";
    }
}