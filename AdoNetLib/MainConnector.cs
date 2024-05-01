using Microsoft.Data.SqlClient;
using System.Data;
using System.Threading.Tasks;
using AdoNetLib.Configurations;

namespace AdoNetLib
{
    public class MainConnector
    {
        private readonly SqlConnection сonnection = new SqlConnection(ConnectionString.MsSqlConnection);
        
        public async Task<bool> ConnectAsync()
        {
            bool result;
            try
            {
                await сonnection.OpenAsync();
                result = true;
            }
            catch
            {
                result = false;
            }
            return result;
        }

       public async void DisconnectAsync()
        {
            if (сonnection.State == ConnectionState.Open) {
            await сonnection.OpenAsync();
            }
                
        }
    }
}
