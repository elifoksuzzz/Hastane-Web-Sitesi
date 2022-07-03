create database Hastane
use Hastane

create table Departmanlar(
	departman_id int PRIMARY KEY IDENTITY(1,1),
	adi nvarchar(100) NOT NULL,
	gorevi nvarchar(1000)
);

create table IMCalisanlari(
	IMCalisan_id int PRIMARY KEY IDENTITY(1,1),
	departman_id int NOT NULL,
	CONSTRAINT FK_IMCalisanlari FOREIGN KEY (departman_id) REFERENCES Departmanlar (departman_id),
	adi nvarchar(100) NOT NULL,
	soyadi nvarchar(100) NOT NULL,
	kimlikNumarasi char(11) UNIQUE NOT NULL,  
	dilBilgisi nvarchar(100) NOT NULL,
	telNo char(13) NOT NULL,
	mail char(100)
);

create table TibbiBolum(
	tibbiBolum_id int PRIMARY KEY IDENTITY(1,1),
	adi nvarchar(100) NOT NULL,
	hizmetleri nvarchar(max)
);

create table Hekimler(
	hekim_id int PRIMARY KEY IDENTITY(1,1),
	tibbiBolum_id int NOT NULL,
	CONSTRAINT FK_Hekimler FOREIGN KEY (tibbiBolum_id) REFERENCES TibbiBolum (tibbiBolum_id),
	adi nvarchar(100) NOT NULL,
	soyadi nvarchar(100) NOT NULL,
	kimlikNumarasi char(11) UNIQUE NOT NULL,
	akademikUnvani nvarchar(100) NOT NULL,
	dilBilgisi nvarchar(100),
	telNo char(13),
	mail char(100) NOT NULL,
	egitimBilgileri nvarchar(100),
	imagePath nvarchar(max)
);

create table Kullanicilar(
	kullanici_id int PRIMARY KEY IDENTITY(1,1),
	adi nvarchar(100) NOT NULL,
	soyadi nvarchar(100) NOT NULL,
	kimlikNumarasi char(11) UNIQUE NOT NULL, 
	dogumYili nvarchar(100) NOT NULL,
	telNo char(13),
	hastalik char(100),
	kullaniciAdi nvarchar(50) not null unique,
	parola nvarchar(50),
	rol nvarchar(3)
);

create table Randevular(
	randevu_id int PRIMARY KEY IDENTITY(1,1),
	tibbiBolum_id int NOT NULL,
	hekim_id int NOT NULL,
	kullanicilar_id int NOT NULL,
	CONSTRAINT FK1_Randevular FOREIGN KEY (tibbiBolum_id) REFERENCES TibbiBolum (tibbiBolum_id),
	CONSTRAINT FK2_Randevular FOREIGN KEY (hekim_id) REFERENCES Hekimler (hekim_id),
	CONSTRAINT FK3_Randevular FOREIGN KEY (kullanicilar_id) REFERENCES Kullanicilar (kullanicilar_id),
	tarih datetime NOT NULL
);

create table Sonuclar(
	sonuc_id int PRIMARY KEY IDENTITY(1,1),
	kullanicilar_id int NOT NULL,
	CONSTRAINT FK_Sonuclar FOREIGN KEY (kullanicilar_id) REFERENCES Kullanicilar (kullanicilar_id),
	sonuc nvarchar(300)
);


create table PoliklinikYonetimi( 
	poliklinikYonetim_id int PRIMARY KEY IDENTITY(1,1),
	tibbiDirektor int NOT NULL,
	tibbiDirektorYardimcisi int NOT NULL,
	tibbiDirektorAsistani int NOT NULL,
	CONSTRAINT FK1_PoliklinikYonetimi FOREIGN KEY (tibbiDirektor) REFERENCES Hekimler (hekim_id),
	CONSTRAINT FK2_PoliklinikYonetimi FOREIGN KEY (tibbiDirektorYardimcisi) REFERENCES Hekimler (hekim_id),
	CONSTRAINT FK3_PoliklinikYonetimi FOREIGN KEY (tibbiDirektorAsistani) REFERENCES Hekimler (hekim_id)
);

create table HastaneYonetimi( 
	hastaneYonetim_id int PRIMARY KEY IDENTITY(1,1),
	baskan int NOT NULL,
	baskanYardimcisi int NOT NULL,
	uye int NOT NULL,
	CONSTRAINT FK1_HastaneYonetimi FOREIGN KEY (baskan) REFERENCES Hekimler (hekim_id),
	CONSTRAINT FK2_HastaneYonetimi FOREIGN KEY (baskanYardimcisi) REFERENCES Hekimler (hekim_id),
	CONSTRAINT FK3_HastaneYonetimi FOREIGN KEY (uye) REFERENCES IMCalisanlari (IMCalisan_id)
);

create table ISBasvurulari(
	basvuru_id int PRIMARY KEY IDENTITY(1,1),
	cv nvarchar(300) NOT NULL
);
