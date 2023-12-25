using System.Data.SqlClient;

public class Oyun
{
    public int OyunId { get; set; }
    public string OyunResim { get; set; }

    // Yapýcý metot
    private Oyun(Builder builder)
    {
        OyunId = builder.OyunId;
        OyunResim = builder.OyunResim;
    }

    public class Builder
    {
        public int OyunId { get; set; }
        public string OyunResim { get; set; }

        public Oyun Build()
        {
            return new Oyun(this);
        }
    }
}

public class OyunService
{
    private readonly string connectionString;

    public OyunService(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void GuncelleOyunResim(int oyunId, string oyunResim)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string kayit = "UPDATE OYUNLAR SET OYUN_RESIM = @oyun_resim WHERE OYUN_ID = @oyun_id";
            using (SqlCommand komut = new SqlCommand(kayit, connection))
            {
                komut.Parameters.AddWithValue("@oyun_id", oyunId);
                komut.Parameters.AddWithValue("@oyun_resim", oyunResim);

                komut.ExecuteNonQuery();
            }
        }
    }

    public Oyun GetOyunById(int oyunId)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string kayit = "SELECT * FROM OYUNLAR WHERE OYUN_ID = @oyun_id";
            using (SqlCommand komut = new SqlCommand(kayit, connection))
            {
                komut.Parameters.AddWithValue("@oyun_id", oyunId);

                using (SqlDataReader dr = komut.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        // Builder Pattern ile Oyun nesnesi oluþtur
                        Oyun.Builder builder = new Oyun.Builder
                        {
                            OyunId = Convert.ToInt32(dr["OYUN_ID"]),
                            OyunResim = dr["OYUN_RESIM"].ToString(),
                        };

                        return builder.Build();
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }

    public string ResimYolunuGetir(int oyunId)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            string query = "SELECT OYUN_RESIM FROM OYUNLAR WHERE OYUN_ID = @OyunId";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@OyunId", oyunId);
                return command.ExecuteScalar() as string;
            }
        }
    }
}