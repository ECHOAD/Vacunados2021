using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IDataAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U parameteres, string conectionString);

        Task<T> LoadObject<T, U>(string sql, U parameteres, string conectionString);

        Task<int> SaveData<T>(string sql, T parameteres, string conectionString);
    }
}