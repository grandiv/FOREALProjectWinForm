using System.Data.SqlClient;

internal static class SqlConnection
{
    public static SqlCommand GetSqlConDonation()
    {
        System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        con.ConnectionString = "Server=tcp:forealserver.database.windows.net,1433;Initial Catalog=FOREAL;Persist Security Info=False;User ID=grandiv;Password=Vidnarg12345$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;";
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        return cmd;
    }
}