using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace UyumsoftHastaneWS.Models
{
    public partial class Model : DbContext
    {
        public Model()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Departmanlar> Departmanlars { get; set; }
        public virtual DbSet<HastaneYonetimi> HastaneYonetimis { get; set; }
        public virtual DbSet<Hekimler> Hekimlers { get; set; }
        public virtual DbSet<IMCalisanlari> IMCalisanlaris { get; set; }
        public virtual DbSet<ISBasvurulari> ISBasvurularis { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilars { get; set; }
        public virtual DbSet<PoliklinikYonetimi> PoliklinikYonetimis { get; set; }
        public virtual DbSet<Randevular> Randevulars { get; set; }
        public virtual DbSet<Sonuclar> Sonuclars { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TibbiBolum> TibbiBolums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departmanlar>()
                .HasMany(e => e.IMCalisanlaris)
                .WithRequired(e => e.Departmanlar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hekimler>()
                .Property(e => e.kimlikNumarasi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hekimler>()
                .Property(e => e.telNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hekimler>()
                .Property(e => e.mail)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Hekimler>()
                .Property(e => e.imagePath)
                .IsUnicode(false);

            modelBuilder.Entity<Hekimler>()
                .HasMany(e => e.HastaneYonetimis)
                .WithRequired(e => e.Hekimler)
                .HasForeignKey(e => e.baskan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hekimler>()
                .HasMany(e => e.HastaneYonetimis1)
                .WithRequired(e => e.Hekimler1)
                .HasForeignKey(e => e.baskanYardimcisi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hekimler>()
                .HasMany(e => e.PoliklinikYonetimis)
                .WithRequired(e => e.Hekimler)
                .HasForeignKey(e => e.tibbiDirektor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hekimler>()
                .HasMany(e => e.PoliklinikYonetimis1)
                .WithRequired(e => e.Hekimler1)
                .HasForeignKey(e => e.tibbiDirektorYardimcisi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hekimler>()
                .HasMany(e => e.Randevulars)
                .WithRequired(e => e.Hekimler)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hekimler>()
                .HasMany(e => e.PoliklinikYonetimis2)
                .WithRequired(e => e.Hekimler2)
                .HasForeignKey(e => e.tibbiDirektorAsistani)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IMCalisanlari>()
                .Property(e => e.kimlikNumarasi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IMCalisanlari>()
                .Property(e => e.telNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IMCalisanlari>()
                .Property(e => e.mail)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<IMCalisanlari>()
                .HasMany(e => e.HastaneYonetimis)
                .WithRequired(e => e.IMCalisanlari)
                .HasForeignKey(e => e.uye)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanicilar>()
                .Property(e => e.kimlikNumarasi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kullanicilar>()
                .Property(e => e.telNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kullanicilar>()
                .Property(e => e.hastalik)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kullanicilar>()
                .HasMany(e => e.Sonuclars)
                .WithRequired(e => e.Kullanicilar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Kullanicilar>()
                .HasMany(e => e.Randevulars)
                .WithRequired(e => e.Kullanicilar)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TibbiBolum>()
                .HasMany(e => e.Hekimlers)
                .WithRequired(e => e.TibbiBolum)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TibbiBolum>()
                .HasMany(e => e.Randevulars)
                .WithRequired(e => e.TibbiBolum)
                .WillCascadeOnDelete(false);
        }
    }
}
