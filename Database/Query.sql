CREATE TABLE tempatpengepul (
	Id_tempatpengepul serial PRIMARY KEY,
	Nama_Tempat varchar not null,
	Alamat varchar not null,
	Deskripsi text);
	
CREATE TABLE Kurir (
	Id_Kurir serial PRIMARY KEY,
	Nama_Kurir varchar not null,
	Username_Kurir varchar not null,
	Password_Kurir varchar not null,
	No_HP varchar not null,
	Id_tempatpengepul int);
ALTER TABLE Kurir
add constraint fk_tempatpengepul
foreign key (Id_tempatpengepul)
references tempatpengepul(Id_tempatpengepul);

CREATE TABLE admin_tempat_pengepul(
	Id_Admin serial PRIMARY KEY,
	Nama_Admin varchar not null,
	Username_Admin varchar not null,
	Password_Admin varchar not null,
	Alamat varchar not null,
	No_HP varchar not null,
	Id_tempatpengepul int);
ALTER TABLE Admin_Tempat_Pengepul
add constraint fk_tempatpengepul
foreign key (Id_tempatpengepul)
references tempatpengepul(Id_tempatpengepul);

CREATE TABLE Customer (
	Id_Customer serial PRIMARY KEY,
	Nama_Customer varchar not null,
	Username_Customer varchar not null,
	Password_Customer varchar not null,
	No_HP varchar not null,
	Alamat varchar not null,
	Saldo int not null);
	
CREATE TABLE Transaksi (
	Id_Transaksi serial PRIMARY KEY,
	Tanggal_Transaksi date not null,
	Id_tempatpengepul int,
	Id_Admin int,
	Id_Customer int);
alter table transaksi
add constraint fk_admin_tempat_pengepul
foreign key (Id_Admin)
references admin_tempat_pengepul(Id_Admin);
alter table transaksi
add constraint fk_tempatpengepul
foreign key (Id_tempatpengepul)
references tempatpengepul (Id_tempatpengepul);
alter table transaksi
add constraint fk_Customer
foreign key (Id_Customer)
references Customer(Id_Customer);

CREATE TABLE Jenis_Sampah (
	Id_Jenis_Sampah serial PRIMARY KEY,
	Nama_Jenis_Sampah varchar not null,
	Harga int not null,
	Deskripsi text);
	
CREATE TABLE Detail_Transaksi (
	Id_Transaksi int,
	Id_Jenis_Sampah int,
	Kuantitas int not null,
	constraint fk_Transaksi
	foreign key (Id_Transaksi)
	references Transaksi(Id_Transaksi),
	constraint fk_Jenis_Sampah
	foreign key (Id_Jenis_Sampah)
	references Jenis_Sampah(Id_Jenis_Sampah)
);

INSERT INTO tempatpengepul(Nama_tempat, Alamat, Deskripsi)
VALUES('Bank Sampah Sahabat Ibu', 'Jl. Perumahan Taman Gading, Kaliwates, Jember','');

INSERT INTO customer(Nama_Customer, Username_Customer, Password_Customer, No_HP, Alamat, Saldo)
VALUES ('Fajar Danuarta','FajarUye','Fajar123','082229336987','Jl. Kalimantan V, Sumbersari, Jember', 0);

INSERT INTO admin_tempat_pengepul(Nama_admin, Username_Admin, Password_Admin, Alamat, No_HP, Id_tempatpengepul)
VALUES ('Adrianno','Adrianno12','Adrianno157','Jl. Kalimantan XVI, Sumbersari, Jember', '081332456777', 1);

INSERT INTO kurir(Nama_Kurir,Username_Kurir,Password_Kurir,No_HP,Id_tempatpengepul)
VALUES ('Jefri Nichol','JefriFriendly','Jefri123','085258909788',1);

INSERT INTO transaksi (tanggal_transaksi, id_tempatpengepul,id_customer, id_admin)
VALUES('2024-04-23', 1,1,1);

INSERT INTO jenis_sampah (Nama_Jenis_Sampah, Harga, Deskripsi)
VALUES('Kaca',1200,'Sampah berbasis kaca, contohnya : Botol Minuman'),
	  ('Plastik',2000,'Sampah berbasis plastik, contohnya : Botol Plastik, Kantong Plastik, Kemasan produk');

INSERT INTO Detail_Transaksi (id_transaksi, id_jenis_sampah, kuantitas)
VALUES (1,1,3);

INSERT INTO Detail_Transaksi (id_transaksi, id_jenis_sampah, kuantitas)
VALUES (1,2,10);






