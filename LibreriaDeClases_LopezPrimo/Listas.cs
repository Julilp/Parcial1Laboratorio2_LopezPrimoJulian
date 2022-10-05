using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaDeClases_LopezPrimo
{
    public class Listas
    {

        public static List<Usuario> listOfUsers = new List<Usuario>()
        {
            new Usuario() {idUsuario= "julian lopez", contraseniaUsuario= "julil"},
            new Usuario() {idUsuario= "pedro martinez", contraseniaUsuario= "pedrom"},
            new Usuario() {idUsuario= "1", contraseniaUsuario= "1"}
        };
        public static List<Cruceros> listOfCruceros = new List<Cruceros>()
        {
            new Cruceros() { IdCrucero = "AF342GT", NombreCrucero = "Mugiwaras", CantidadCamarotes = 50,CapacidadBodega=25000, SalonesExistentes = new Salones(1, 1, 1, 0, 1, 2, 0, 0, 1, 1) },
            new Cruceros() { IdCrucero = "QR334BO", NombreCrucero = "Titanic", CantidadCamarotes = 120,CapacidadBodega=50000, SalonesExistentes = new Salones(1, 2, 1, 1, 1, 2, 1, 1, 1, 1) },
            new Cruceros() { IdCrucero = "WR645DF", NombreCrucero = "Aida", CantidadCamarotes = 200, CapacidadBodega=250000,SalonesExistentes = new Salones(2, 3, 4, 5, 6, 7, 2, 3, 1, 1) },
            new Cruceros() { IdCrucero = "VC489DM", NombreCrucero = "Cunard ", CantidadCamarotes = 320,CapacidadBodega=500000, SalonesExistentes = new Salones(2, 5, 1, 0, 1, 2, 1, 1, 1, 5) },
            new Cruceros() { IdCrucero = "MY432LR", NombreCrucero = "Princess ", CantidadCamarotes = 400,CapacidadBodega=5000000, SalonesExistentes = new Salones(6, 1, 3, 6, 2, 2, 2, 5, 6, 5) },
            new Cruceros() { IdCrucero = "CN345HE", NombreCrucero = "Seabourn", CantidadCamarotes = 750,CapacidadBodega=800000, SalonesExistentes = new Salones(6, 8, 0, 4, 9, 6, 0, 0, 4, 1) },
            new Cruceros() { IdCrucero = "NM538LO", NombreCrucero = "Norwegian", CantidadCamarotes = 5000,CapacidadBodega=90000000, SalonesExistentes = new Salones(10, 6, 3, 8, 9, 2, 5, 4, 10, 10) },
        };
        public static List<Viajes> listOfViajes = new List<Viajes>();
    }
}
