 using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Clothes.Models;

namespace Clothes.Data
{
    public class ClotheDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public ClotheDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Clothe>().Wait();
        }

        public Task<List<Clothe>> GetClothesAsync()
        {
            return _database.Table<Clothe>().ToListAsync();
        }

        public Task<Clothe> GetClotheAsync(int id)
        {
            return _database.Table<Clothe>()
                            .Where(i => i.Id == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveClotheAsync(Clothe clothe)
        {
            if (clothe.Id != 0)
            {
                return _database.UpdateAsync(clothe);
            }
            else
            {
                return _database.InsertAsync(clothe);
            }
        }

        public Task<int> DeleteClotheAsync(Clothe clothe)
        {
            return _database.DeleteAsync(clothe);
        }
    }
}
