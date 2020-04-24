using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TryApp.Persistance
{
   public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
