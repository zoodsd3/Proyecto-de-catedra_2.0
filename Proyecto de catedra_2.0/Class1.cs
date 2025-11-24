using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public static class DataAccess
{
    // Modifica esta cadena a tu servidor/instancia. Ejemplo:
    // @"Server=.\SQLEXPRESS;Database=TransExpressDB;Integrated Security=true;"
    public static string connectionString = @"Server=CARLOSRAMIREZ13\SQLEXPRESS;Database=TransExpressDB;Integrated Security=True;";
    // Inserta o actualiza (upsert) un registro de bus. Usa RutaBus como clave natural.
    public static void SaveOrUpdateBus(
        string rutaBus, int numeroUnidades, TimeSpan? horaLlegada, TimeSpan? horaSalida,
        int unidadesDisponibles, int unidadesFuera, string lugarSalida, string puntoLlegada)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            // Intentaremos primero actualizar; si no existe, insertamos.
            string updateSql = @"
                UPDATE Buses
                SET NumeroUnidades = @NumeroUnidades,
                    HoraLlegada = @HoraLlegada,
                    HoraSalida = @HoraSalida,
                    UnidadesDisponibles = @UnidadesDisponibles,
                    UnidadesFuera = @UnidadesFuera,
                    LugarSalida = @LugarSalida,
                    PuntoLlegada = @PuntoLlegada
                WHERE RutaBus = @RutaBus;
            ";

            using (SqlCommand cmd = new SqlCommand(updateSql, conn))
            {
                cmd.Parameters.AddWithValue("@RutaBus", rutaBus);
                cmd.Parameters.AddWithValue("@NumeroUnidades", (object)numeroUnidades ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@HoraLlegada", (object)horaLlegada ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@HoraSalida", (object)horaSalida ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@UnidadesDisponibles", (object)unidadesDisponibles ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@UnidadesFuera", (object)unidadesFuera ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@LugarSalida", (object)lugarSalida ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@PuntoLlegada", (object)puntoLlegada ?? DBNull.Value);

                int rows = cmd.ExecuteNonQuery();
                if (rows == 0)
                {
                    string insertSql = @"
                        INSERT INTO Buses (RutaBus, NumeroUnidades, HoraLlegada, HoraSalida, UnidadesDisponibles, UnidadesFuera, LugarSalida, PuntoLlegada)
                        VALUES (@RutaBus, @NumeroUnidades, @HoraLlegada, @HoraSalida, @UnidadesDisponibles, @UnidadesFuera, @LugarSalida, @PuntoLlegada);
                    ";
                    using (SqlCommand ins = new SqlCommand(insertSql, conn))
                    {
                        ins.Parameters.AddWithValue("@RutaBus", rutaBus);
                        ins.Parameters.AddWithValue("@NumeroUnidades", (object)numeroUnidades ?? DBNull.Value);
                        ins.Parameters.AddWithValue("@HoraLlegada", (object)horaLlegada ?? DBNull.Value);
                        ins.Parameters.AddWithValue("@HoraSalida", (object)horaSalida ?? DBNull.Value);
                        ins.Parameters.AddWithValue("@UnidadesDisponibles", (object)unidadesDisponibles ?? DBNull.Value);
                        ins.Parameters.AddWithValue("@UnidadesFuera", (object)unidadesFuera ?? DBNull.Value);
                        ins.Parameters.AddWithValue("@LugarSalida", (object)lugarSalida ?? DBNull.Value);
                        ins.Parameters.AddWithValue("@PuntoLlegada", (object)puntoLlegada ?? DBNull.Value);
                        ins.ExecuteNonQuery();
                    }
                }
            }
        }
    }

    // Inserta un boleto
   

    // Método auxiliar: obtener todos los buses (DataTable)
    public static DataTable GetAllBuses()
    {
        DataTable dt = new DataTable();
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Buses", conn))
            {
                da.Fill(dt);
            }
        }
        return dt;
    }

    public static void InsertBoleto(decimal valor, string destinoFinal, TimeSpan horaSalida, string ruta)
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            string query = @"INSERT INTO Boletos (Valor, DestinoFinal, HoraSalida, Ruta)
                         VALUES (@Valor, @DestinoFinal, @HoraSalida, @Ruta)";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Valor", valor);
                cmd.Parameters.AddWithValue("@DestinoFinal", destinoFinal);
                cmd.Parameters.AddWithValue("@HoraSalida", horaSalida);
                cmd.Parameters.AddWithValue("@Ruta", ruta);

                cmd.ExecuteNonQuery();
            }
        }
    }
}