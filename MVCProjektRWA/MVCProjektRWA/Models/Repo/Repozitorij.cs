using MVCProjektRWA.Models.MyModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using Microsoft.ApplicationBlocks.Data;
using System.Web;
using System.Web.Mvc;

namespace MVCProjektRWA.Models.Repo
{
    public class Repozitorij
    {
        public static DataSet ds { get; set; }
        public static DataRow dr { get; set; }
        private static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public Repozitorij()
        {

        }

        public static IEnumerable<Grad> GetGradove()
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetGradove");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Grad
                {
                    IDGrad = (int)row["IDGrad"],
                    Naziv = row["Naziv"].ToString()
                };
            }
        }


        internal static IEnumerable<Drzava> GetDrzave()
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetDrzave");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Drzava
                {
                    IDDrzava = (int)row["IDDrzava"],
                    Naziv = row["Naziv"].ToString()
                };
            }
        }

        public static Grad GetGrad(int id)
        {

            DataRow row = SqlHelper.ExecuteDataset(cs, "GetGrad", id).Tables[0].Rows[0];

            return new Grad
            {
                IDGrad = (int)row["IDGrad"],
                Naziv = row["Naziv"].ToString(),
                DrzavaID = (int)row["DrzavaID"]
            };
        }

        internal static IEnumerable<Grad> GetGradForDrzava(int drzavaID)
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetGradForDrzava", drzavaID);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Grad
                {
                    IDGrad = (int)row["IDGrad"],
                    Naziv = row["Naziv"].ToString(),
                    DrzavaID = (int)row["DrzavaID"]
                };
            }
        }

        internal static IEnumerable<Kupac> GetKupceGrada(int gradId)
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetKupceGrada", gradId);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Kupac
                {
                    IDKupac = (int)row["IDKupac"],
                    Ime = row["Ime"].ToString(),
                    Prezime = row["Prezime"].ToString(),
                    Email = row["Email"].ToString(),
                    Telefon = row["Telefon"].ToString(),
                    GradID = (int)row["GradID"]
                };
            }
        }

        public static IEnumerable<Kupac> GetKupce()
        {
            DataSet ds = SqlHelper.ExecuteDataset(cs, "GetKupce");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Kupac
                {
                    IDKupac = (int)row["IDKupac"],
                    Ime = row["Ime"].ToString(),
                    Prezime = row["Prezime"].ToString(),
                    Email = row["Email"].ToString(),
                    Telefon = row["Telefon"].ToString(),
                    GradID = (int)row["GradID"]
                };
            }
        }


        internal static Kupac GetKupac(int IDKupac)
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetKupac", IDKupac);
            DataRow row = ds.Tables[0].Rows[0];

            Kupac k = new Kupac();
            k.IDKupac = IDKupac;
            k.Ime = row["Ime"].ToString();
            k.Prezime = row["Prezime"].ToString();
            k.Email = row["Email"].ToString();
            k.Telefon = row["Telefon"].ToString();
            k.GradID = (int)row["GradID"];

            return k;
        }

        internal static IEnumerable<Racun> GetRacuneKupca(int kupacID)
        {

            ds = SqlHelper.ExecuteDataset(cs, "GetRacuneKupca", kupacID);
           // DataRow row = ds.Tables[0].Rows[0];

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Racun
                {
                    IDRacun = (int)row["IDRacun"],
                    DatumIzdavanja = (DateTime)row["DatumIzdavanja"],
                    BrojRacuna = row["BrojRacuna"].ToString(),
                    Komentar = row["Komentar"].ToString(),

                    Komercijalist = new Komercijalist
                    {
                        IDKomercijalist = (int)row["IDKomercijalist"],
                        KomercijalistIme = row["Ime"].ToString(),
                        KomercijalistPrezime = row["Prezime"].ToString(),
                        StalniZaposlenik = (bool)row["StalniZaposlenik"]
                    },

                    KreditnaKartica = new KreditnaKartica
                    {
                        IDKreditnaKartica = (int)row["IDKreditnaKartica"],
                        TipKartice = row["Tip"].ToString(),
                        BrojKartice = row["Broj"].ToString(),
                        IstekMjesec = (byte)row["IstekMjesec"],
                        IstekGodina = (short)row["IstekGodina"]
                    }
                };
            }
           
        }

        internal static IEnumerable<Stavka> GetStavkeRacuna(int racunID)
        {
            ds = SqlHelper.ExecuteDataset(cs, "GetStavkaProizvodPotkategorijaKategorija", racunID);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                yield return new Stavka
                {
                    IDStavka = (int)row["IDStavka"],
                    Kolicina = (short)row["Kolicina"],
                    CijenaPoKomadu = (decimal)row["CijenaPoKomadu"],
                    Popust = (decimal)(row["PopustUPostocima"]),
                    UkupnaCijena = (decimal)row["UkupnaCijena"],

                    Proizvod = new Proizvod
                    {
                        IDProizvod = (int)row["IDProizvod"],
                        Naziv = row["Naziv"].ToString(),
                        BrojProizvoda = row["BrojProizvoda"].ToString(),
                        Boja = row["Boja"].ToString(),
                        MinimalnaKolicinaNaSkladistu = (short)row["MinimalnaKolicinaNaSkladistu"],
                        CijenaBezPDV = (decimal)row["CijenaBezPDV"]
                    },

                    Potkategorija = new Potkategorija
                    {
                        IDPotkategorija = (int)row["IDPotkategorija"],
                        Naziv = row["Naziv"].ToString()
                    },

                    Kategorija = new Kategorija
                    {
                        IDKategorija = (int)row["IDKategorija"],
                        Naziv = row["Naziv"].ToString()
                    }
                };
            }
        }

        //internal static int EditKupac(Kupac kupac)
        //{
        //    return SqlHelper.ExecuteNonQuery
        //        (cs, "EditKupac", kupac.IDKupac, kupac.Ime, kupac.Prezime, kupac.Email, kupac.Telefon, kupac.GradID);
        //}

        public static int UpdateKupac(Kupac kupac)
        {
            return SqlHelper.ExecuteNonQuery(cs, "UpdateKupac", kupac.IDKupac, kupac.Ime, kupac.Prezime, kupac.Email, kupac.Telefon, kupac.GradID);
        }

        public static void InsertKupac(Kupac kupac)
        {
            SqlHelper.ExecuteNonQuery(cs, "InsertKupac", kupac.Ime, kupac.Prezime, kupac.Email, kupac.Telefon, kupac.GradID);
        }

        public static int DohvatiBrojKupaca()
        {
            return (int)SqlHelper.ExecuteScalar(cs, "DohvatiBrojKupaca");
        }
    }
}