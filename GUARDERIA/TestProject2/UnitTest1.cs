using NUnit.Framework;
using System.Data.SqlClient;
using System;

namespace Tests
{
    [TestFixture]
    public class ConexionBDTests
    {
        private string connectionString = @"server=DESKTOP-DVVAAHH\SQLEXPRESS; Initial Catalog=GUARDERIA; integrated security=true";
        private SqlConnection conexion;

        [SetUp]
        public void Setup()
        {
            // Inicializamos la conexi�n
            conexion = new SqlConnection(connectionString);
        }

        [Test]
        public void Conexion_SeAbreYCierraCorrectamente()
        {
            try
            {
                // Abrir la conexi�n
                conexion.Open();

                // Verificar que la conexi�n est� abierta
                Assert.Equals(System.Data.ConnectionState.Open, conexion.State);

                // Cerrar la conexi�n
                conexion.Close();

                // Verificar que la conexi�n est� cerrada
                Assert.Equals(System.Data.ConnectionState.Closed, conexion.State);
            }
            catch (Exception ex)
            {
                // Si ocurre una excepci�n, la prueba fallar�
                Assert.Fail("La conexi�n a la base de datos fall�: " + ex.Message);
            }
        }
    }
}