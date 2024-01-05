using dominicanIdValidator.Interface;
using System.Data;
using System.Data.SqlClient;

namespace dominicanIdValidator.Service
{
    public class CedulaService : ICedulaService
    {
        private readonly ICedulaRepository _repo;

        public CedulaService(ICedulaRepository rep)
        {
            _repo = rep;
        }
        public Task<Padron> CreatePadron(Padron Padron)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Padron> getAllPadrons()
        {
            throw new NotImplementedException();
        }

        public Padron getPadronById(string id)
        {
            
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");

            SqlConnection connection = new SqlConnection(connectionString);

            string queryString = "SELECT * FROM Padron WHERE Cedula = @valor";

            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@valor", id);
            Padron data=new Padron();
            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    data.Cedula = String.Format("{0}", reader["Cedula"]);
                    data.fechaNacimiento = String.Format("{0}", reader["FechaNacimiento"]);
                    data.Nombres = String.Format("{0}", reader["Nombres"]);
                    data.Apellido1 = String.Format("{0}", reader["Apellido1"]);
                    data.Apellido2 = String.Format("{0}", reader["Apellido2"]);
                    data.LugarNacimiento = String.Format("{0}", reader["LugarNacimiento"]);
                    data.IDCategoria = String.Format("{0}", reader["IDCategoria"]);
                    data.IdSexo = String.Format("{0}", reader["IdSexo"]);
                    data.IdEstadoCivil = String.Format("{0}", reader["IdEstadoCivil"]);
                    data.IdOcupacion = String.Format("{0}", reader["IdOcupacion"]);
                    data.IDNacionalidad = String.Format("{0}", reader["IDNacionalidad"]);
                    data.IDMunicipio_Original = String.Format("{0}", reader["IDMunicipio_Original"]);
                    data.IdSectorParaje = String.Format("{0}", reader["IdSectorParaje"]);
                    data.IDColegio = String.Format("{0}", reader["IDColegio"]);
                    data.IDCausaCancelacion = String.Format("{0}", reader["IDCausaCancelacion"]);
                    data.IDEstatus = String.Format("{0}", reader["IDEstatus"]);
                    data.EstatusCedulaAzul = String.Format("{0}", reader["EstatusCedulaAzul"]);
                    data.CedulaAnterior = String.Format("{0}", reader["CedulaAnterior"]);
                    data.mun_ced = String.Format("{0}", reader["mun_ced"]);
                    data.ver_ced = String.Format("{0}", reader["ver_ced"]);
                    data.IdProvincia = String.Format("{0}", reader["IdProvincia"]);
                    data.Provincia = String.Format("{0}", reader["Provincia"]);
                    data.CodigoCircunscripcion = String.Format("{0}", reader["CodigoCircunscripcion"]);
                    data.IdDistritoMunicipal = String.Format("{0}", reader["IdDistritoMunicipal"]);
                    data.DistritoMunicipal = String.Format("{0}", reader["DistritoMunicipal"]);
                    data.CodigoRecinto = String.Format("{0}", reader["CodigoRecinto"]);
                    data.DireccionRecinto = String.Format("{0}", reader["DireccionRecinto"]);
                    data.CodigoSector = String.Format("{0}", reader["CodigoSector"]);
                    data.SectorRecinto = String.Format("{0}", reader["SectorRecinto"]);
                    data.SectorResidencia = String.Format("{0}", reader["SectorResidencia"]);
                    data.Colegio = String.Format("{0}", reader["Colegio"]);
                    data.Municipio = String.Format("{0}", reader["Municipio"]);
                    data.Categoria = String.Format("{0}", reader["Categoria"]);
                    data.IdMunicipio = String.Format("{0}", reader["IdMunicipio"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            return data;
        }

        public Task<bool> RemovePadron(Guid PadronId)
        {
            throw new NotImplementedException();
        }

        public Task<Padron> UpdatePadron(Padron Padron)
        {
            throw new NotImplementedException();
        }
    }
}
