// Uygulama durumunu belirleyen enum. Başvuru süreçlerinin her aşaması bu enum ile takip edilir.
public enum ApplicationState
{
    PENDING,     // Başvuru beklemede
    APPROVED,    // Başvuru onaylandı
    REJECTED,    // Başvuru reddedildi
    IN_REVIEW,   // Başvuru incelemede
    CANCELLED    // Başvuru iptal edildi
}

// Uygulama başvurusunu temsil eden entity. Başvuruya ait tüm bilgileri içerir.
public class Application
{
    public int Id { get; set; }  // Başvurunun benzersiz ID'si
    public int ApplicantId { get; set; }  // Başvuran kişinin ID'si (yabancı anahtar)
    public int BootcampId { get; set; }  // Başvurulan Bootcamp'in ID'si (yabancı anahtar)
    public ApplicationState ApplicationState { get; set; }  // Başvuru durumu

    // İlişkili Bootcamp ve Applicant entity'lerine ait navigasyon özellikleri
    public virtual Bootcamp Bootcamp { get; set; }
    public virtual Applicant Applicant { get; set; }
}
