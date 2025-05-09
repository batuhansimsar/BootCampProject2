# BootcampProject2

.NET 8 ile geliştirilmiş katmanlı mimariye sahip Web API projesidir. Bu proje, başvuru yönetimi, bootcamp (kamp) yönetimi ve kara liste işlemleri gibi temel CRUD işlemlerini içeren örnek bir yapıyı temsil eder.

---

## 📌 1. Proje Yapısı (Katmanlar)

```plaintext
BootcampProject
├── BootcampProject                → ASP.NET Core Web API (Giriş noktası)
├── BootcampProject.Business      → İş kuralları (Managers & Interfaces)
├── BootcampProject.Entities      → Entity sınıfları (Veri modelleri)
├── BootcampProject.Core          → Ortak yapı / yardımcı sınıflar (isteğe bağlı)
├── BootcampProject.Repositories  → EF Core ile veri erişimi (DbContext, Configurations, Repositories)
