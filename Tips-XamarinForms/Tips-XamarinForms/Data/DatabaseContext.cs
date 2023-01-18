using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace TipsXamarinForms.Data
{
	public class DatabaseContext
	{
		readonly SQLiteAsyncConnection Connection;

		public DatabaseContext(string path)
		{
            Connection = new SQLiteAsyncConnection(path);
			Connection.CreateTableAsync<Tip>().Wait();
        }

        #region CRUD

        public async Task<int> SaveTipAsync(Tip tip)
		{
			if (tip.Id != 0)
			{
                return await Connection.UpdateAsync(tip);
            }
			else
			{
                return await Connection.InsertAsync(tip);
            }
		}

		public async Task<List<Tip>> GetTipsAsync()
		{
			return await Connection.Table<Tip>().OrderByDescending(e => e.UpdateDate).ToListAsync();
        }

        public async Task<int> DeleteTipAsync(Tip tip)
        {
			return await Connection.DeleteAsync(tip);
        }

        #endregion
    }
}

