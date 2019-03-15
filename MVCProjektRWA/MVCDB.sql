USE AdventureWorksOBP
go


CREATE PROCEDURE GetGradove
AS
BEGIN
	select * from Grad
END
GO

CREATE PROCEDURE GetGrad
	@GradID INT
AS
BEGIN
	SELECT * from Grad WHERE IDGrad = @GradID
END
GO

CREATE PROCEDURE GetDrzave
AS
BEGIN
	select * from Drzava
END
GO

CREATE PROCEDURE GetGradForDrzava
	@DrzavaID INT
AS
BEGIN
	SELECT * FROM Grad WHERE DrzavaID = @DrzavaID
END
GO

CREATE PROCEDURE GetKupceGrada
	@GradID INT
AS
BEGIN
	SELECT * FROM Kupac WHERE GradID = @GradID
END
GO

CREATE PROCEDURE GetKupce
AS
BEGIN
	SELECT * FROM Kupac
END

go
CREATE PROCEDURE GetKupac
	@IDKupac int
AS
BEGIN
	select * from Kupac where IDKupac=@IDKupac
END
GO

	CREATE PROCEDURE GetRacuneForKupac
		@IDKupac int
	AS
	BEGIN
		select * from Racun where KupacID=@IDKupac
	END

GO

CREATE PROCEDURE GetRacuneKupca
	@IDKupac int
AS
BEGIN
	SELECT r.IDRacun, r.DatumIzdavanja, r.BrojRacuna, r.Komentar, k.IDKomercijalist, k.Ime, k.Prezime, 
	k.StalniZaposlenik, kk.IDKreditnaKartica, kk.Tip, kk.Broj, kk.IstekMjesec, kk.IstekGodina FROM Racun as r 
	INNER JOIN
	Komercijalist as k 
	ON r.KomercijalistID = k.IDKomercijalist
	INNER JOIN 
	KreditnaKartica as kk 
	ON r.KreditnaKarticaID = kk.IDKreditnaKartica
	WHERE @IDKupac = KupacID
END


GO
CREATE PROCEDURE UpdateKupac
	@id int,
	@ime nvarchar(50),
	@prezime nvarchar(50),
	@email nvarchar(50),
	@telefon nvarchar(25),
	@gradID int
AS
BEGIN
	update Kupac set Ime=@ime, Prezime=@prezime, Email=@email, Telefon=@telefon, GradID=@gradID where IDKupac=@id 
END
GO

CREATE PROCEDURE InsertKupac
	@ime nvarchar(50),
	@prezime nvarchar(50),
	@email nvarchar(50),
	@telefon nvarchar(25),
	@gradID int
AS
BEGIN
	insert into Kupac values(@ime, @prezime, @email, @telefon, @gradID)
END
GO

CREATE PROCEDURE GetStavkaProizvodPotkategorijaKategorija
	@RacunID INT
AS
BEGIN
	SELECT s.IDStavka, s.Kolicina, s.CijenaPoKomadu, s.PopustUPostocima, s.UkupnaCijena,
	p.IDProizvod, p.Naziv, p.BrojProizvoda, p.Boja, p.MinimalnaKolicinaNaSkladistu, p.CijenaBezPDV, pk.IDPotkategorija,
	pk.Naziv, k.IDKategorija, k.Naziv FROM Stavka as s 
	INNER JOIN
	Proizvod as p 
	ON s.ProizvodID = p.IDProizvod
	INNER JOIN 
	Potkategorija as pk
	ON p.PotkategorijaID = pk.IDPotkategorija
	INNER JOIN
	Kategorija as k
	ON pk.KategorijaID = k.IDKategorija
	WHERE @RacunID = RacunID
END

GO


CREATE PROCEDURE DohvatiBrojKupaca
AS
BEGIN
	select COUNT(*) from Kupac
END
GO