// Bootcamp'in durumunu belirleyen enum. Bootcamp'in aşama geçişlerini takip eder.
public enum BootcampState
{
    PREPARING,          // Bootcamp hazırlık aşamasında
    OPEN_FOR_APPLICATION, // Başvuruya açılmış
    IN_PROGRESS,        // Devam etmekte olan
    FINISHED,           // Tamamlanmış
    CANCELLED           // İptal edilmiş
}

// Bootcamp başvurularını ve yönetimini temsil eden entity. Bootcamp'in temel bilgilerini içerir.
public class Bootcamp
{
    public int Id { get; set; }  // Bootcamp'in benzersiz ID'si
    public string Name { get; set; }  // Bootcamp'in adı
    public int InstructorId { get; set; }  // Bootcamp eğitmeninin ID'si (yabancı anahtar)
    public DateTime StartDate { get; set; }  // Bootcamp'in başlama tarihi
    public DateTime EndDate { get; set; }    // Bootcamp'in bitiş tarihi
    public BootcampState BootcampState { get; set; }  // Bootcamp'in durumu

    // Bootcamp'in eğitmeniyle olan ilişkiyi tanımlar
    public virtual Instructor Instructor { get; set; }
}
