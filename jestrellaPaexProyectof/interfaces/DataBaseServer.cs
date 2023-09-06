using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace jestrellaPaexProyectof.interfaces
{
    public interface DataBaseServer
    {
        SQLiteAsyncConnection GetConnection();
    }
}
