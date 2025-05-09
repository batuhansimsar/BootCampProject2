using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BootcampProject.Repositories.Configurations
{
    //Bu yapılandırma, veritabanı tabloları ile entity'ler arasındaki ilişkiyi belirtir.
    //Application entitysi için Fluent API konfigürasyonu

    public void Configure(EntityTypeBuilder<Application> builder)
    {
        builder.HasKey(a => a.Id);  // ID'yi birincil anahtar olarak belirler
        builder.Property(a => a.ApplicationState).HasDefaultValue(ApplicationState.PENDING);  // Varsayılan değer olarak PENDING belirler
        builder.HasOne(a => a.Bootcamp).WithMany().HasForeignKey(a => a.BootcampId);  // Bootcamp ile ilişkiyi belirtir
        builder.HasOne(a => a.Applicant).WithMany().HasForeignKey(a => a.ApplicantId);  // Applicant ile ilişkiyi belirtir
    }
}
