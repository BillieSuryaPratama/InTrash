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
	
CREATE TABLE MetodePencairan (
	Id_Metode serial PRIMARY KEY,
	Nama_Metode varchar not null);
	
CREATE TABLE Status_Transaksi (
	Id_StatusTransaksi serial PRIMARY KEY,
	Status varchar not null,
	Keterangan varchar not null);
	
CREATE TABLE Transaksi (
	Id_Transaksi serial PRIMARY KEY,
	Tanggal_Transaksi date not null,
	Jumlah_Imbalan int,
	Id_tempatpengepul int,
	Id_Admin int REFERENCES admin_tempat_pengepul(Id_Admin) ON DELETE CASCADE,
	Id_Customer int REFERENCES Customer(Id_Customer) ON DELETE CASCADE,
	Id_StatusTransaksi int);
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
alter table transaksi
add constraint fk_Status_Transaksi
foreign key (Id_StatusTransaksi)
references Status_Transaksi(Id_StatusTransaksi);

CREATE TABLE Jenis_Sampah (
	Id_Jenis_Sampah serial PRIMARY KEY,
	Nama_Jenis_Sampah varchar not null,
	Harga int not null,
	Deskripsi text);
	
CREATE TABLE Detail_Transaksi (
	Id_Transaksi int REFERENCES Transaksi(Id_Transaksi) ON DELETE CASCADE,
	Id_Jenis_Sampah int,
	Kuantitas numeric not null,
	constraint fk_Transaksi
	foreign key (Id_Transaksi)
	references Transaksi(Id_Transaksi),
	constraint fk_Jenis_Sampah
	foreign key (Id_Jenis_Sampah)
	references Jenis_Sampah(Id_Jenis_Sampah)
);

CREATE TABLE Status_Pencairan (
	Id_StatusPencairan serial PRIMARY KEY,
	Status varchar not null,
	Keterangan varchar not null);
	
CREATE TABLE Pencairan (
	ID_Pencairan Serial PRIMARY KEY,
	Rekening_Tujuan varchar,
	Nominal_Pencairan int,
	Id_StatusPencairan int,
	Id_Metode int,
	Id_Customer int REFERENCES Customer(Id_Customer) ON DELETE CASCADE,
	constraint fk_Customer
	foreign key (Id_Customer)
	references Customer(Id_Customer),
	constraint fk_MetodePencairan
	foreign key (Id_Metode)
	references MetodePencairan(Id_Metode),
	constraint fk_Status_Pencairan
	foreign key (Id_StatusPencairan)
	references Status_Pencairan(Id_StatusPencairan)
);

INSERT INTO Status_Pencairan(Status, Keterangan)
VALUES('Diproses', 'Admin belum melakukan konfirmasi pencairan'),
	  ('Selesai', 'Admin telah melakukan konfirmasi pencairan'),
	  ('Dibatalkan', 'Pencairan dibatalkan');
	
INSERT INTO Status_Transaksi(Status, Keterangan)
VALUES('Diproses', 'Admin belum melakukan konfirmasi terhadap setoran sampah'),
	  ('Terkonfirmasi', 'Admin telah melakukan konfirmasi terhadap setoran sampah'),
	  ('Selesai', 'Kurir telah mengirimkan sampah ke bank sampah'),
	  ('Dibatalkan', 'Transaksi setor sampah dibatalkan');

INSERT INTO tempatpengepul(Nama_tempat, Alamat, Deskripsi)
VALUES('Bank Sampah Sahabat Ibu', 'Jl. Perumahan Taman Gading, Kaliwates, Jember',''),
	  ('Bank Sampah Peduli Lingkungan', 'Jl. Raya Sumberbaru, Sumberbaru, Jember', ''),
	  ('Bank Sampah Hijau Lestari', 'Jl. Riau No.5, Sumbersari, Jember', '');

INSERT INTO customer(Nama_Customer, Username_Customer, Password_Customer, No_HP, Alamat, Saldo)
VALUES ('Fajar Danuarta','FajarUye','Fajar123','082229336987','Jl. Kalimantan V, Sumbersari, Jember', 20000),
       ('Siti Aminah', 'Siti', 'Siti123', '081234567890', 'Jl. Merak No.10, Patrang, Jember', 20000),
       ('Budi Santoso', 'BudSan', 'Budi123', '085678901234', 'Jl. Jawa No.20, Kaliwates, Jember', 20000);

INSERT INTO admin_tempat_pengepul(Nama_admin, Username_Admin, Password_Admin, Alamat, No_HP, Id_tempatpengepul)
VALUES ('Adrianno','Adrianno12','Adrianno157','Jl. Kalimantan XVI, Sumbersari, Jember', '081332456777', 1),
  	   ('Rina Andriani', 'RinaAndri', 'Rina456', 'Jl. Jawa VIII, Kaliwates, Jember', '082145678901', 2),
       ('Shodiqin', 'sodiq', 'soqin', 'Jl. Sumatera II, Patrang, Jember', '083156789012', 3);

INSERT INTO kurir(Nama_Kurir,Username_Kurir,Password_Kurir,No_HP,Id_tempatpengepul)
VALUES ('Jefri Nichol','JefriFriendly','Jefri123','085258909788',1),
	   ('Andi Wijaya', 'Andiw', 'Andi456', '081334567890', 2),
       ('Dewi Sartika', 'Deewi', 'Dewi789', '082145678901', 3);

INSERT INTO MetodePencairan (Nama_Metode)
VALUES ('Bank BCA'),
	   ('Bank Mandiri'),
	   ('OVO'),
	   ('Dana'),
	   ('GoPay');

INSERT INTO transaksi (tanggal_transaksi, id_tempatpengepul, id_customer, id_admin, jumlah_imbalan, Id_StatusTransaksi)
VALUES ('2024-02-18', 1, 2, 1, 6000, 2),
	   ('2024-03-25', 1, 3, 1, 13000, 2),
	   ('2024-04-20', 3, 1, 3, 3900, 3),
	   ('2024-05-05', 2, 2, 2, 6000, 2),
	   ('2024-05-15', 2, 1, 2, 8000, 3),
	   ('2024-06-10', 1, 3, 1, 6900, 3);

INSERT INTO jenis_sampah (Nama_Jenis_Sampah, Harga, Deskripsi)
VALUES('Kaca', 1200, 'Sampah berbasis kaca, contohnya: Botol Minuman'),
      ('Plastik', 2000, 'Sampah berbasis plastik, contohnya: Botol Plastik, Kantong Plastik, Kemasan produk'),
      ('Kertas', 1500, 'Sampah berbasis kertas, contohnya: Kardus, Kertas HVS, Majalah'),
      ('Logam', 3000, 'Sampah berbasis logam, contohnya: Kaleng, Tutup Botol');

INSERT INTO Detail_Transaksi (id_transaksi, id_jenis_sampah, kuantitas)
VALUES (1, 3, 2), 
       (1, 4, 1), 
       (2, 2, 5),   
       (2, 4, 1),  
       (3, 1, 2), 
       (3, 3, 1), 
       (4, 2, 3),
       (5, 2, 1), 
       (5, 4, 2), 
       (6, 1, 2), 
       (6, 3, 3);
	   
INSERT INTO Pencairan (Rekening_Tujuan, Nominal_Pencairan, Id_StatusPencairan, Id_Metode, Id_Customer)
VALUES('1234567890', 3000, 1, 1, 1),
      ('9876543210', 2000, 2, 2, 1),
      ('5678901234', 5000, 3, 1, 1);
	

