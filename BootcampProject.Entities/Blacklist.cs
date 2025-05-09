// Kara listeye alınan başvurunun nedenini temsil eden entity.
public class Blacklist
{
    public int Id { get; set; }  // Kara liste kaydının benzersiz ID'si
    public string Reason { get; set; }  // Kara listeye alma sebebi
    public DateTime Date { get; set; }  // Kara listeye alma tarihi
    public int ApplicantId { get; set; }  // Kara listeye alınan başvuranın ID'si

    // Kara listeye alınan başvurunun ilişkilendirildiği başvuru
    public virtual Application Application { get; set; }
}
