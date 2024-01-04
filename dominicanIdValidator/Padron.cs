using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dominicanIdValidator
{
    [Table("padron")]
    public class Padron
    {
        [Key]
        public string Cedula { get; set; }

        public string Nombres { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string LugarNacimiento { get; set; }
        public string IDCategoria { get; set; }
        public string IdSexo { get; set; }
        public string IdEstadoCivil { get; set; }
        public string IdOcupacion { get; set; }
        public string IDNacionalidad { get; set; }
        public string IDMunicipio_Original { get; set; }
        public string IdSectorParaje { get; set; }
        public string IDColegio { get; set; }
        public string IDCausaCancelacion { get; set; }
        public string IDEstatus { get; set; }
        public string EstatusCedulaAzul { get; set; }
        public string CedulaAnterior { get; set; }
        public string mun_ced { get; set; }
        public string ver_ced { get; set; }
        public string IdProvincia { get; set; }
        public string Provincia { get; set; }
        public string CodigoCircunscripcion { get; set; }
        public string IdDistritoMunicipal { get; set; }
        public string DistritoMunicipal { get; set; }
        public string CodigoRecinto { get; set; }
        public string DireccionRecinto { get; set; }
        public string CodigoSector { get; set; }
        public string SectorRecinto { get; set; }
        public string SectorResidencia { get; set; }
        public string Colegio { get; set; }
        public string Municipio { get; set; }
        public string Categoria { get; set; }
        public string IdMunicipio { get; set; }

    }
}