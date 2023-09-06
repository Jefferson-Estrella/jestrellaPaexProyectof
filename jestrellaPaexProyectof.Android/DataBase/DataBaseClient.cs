using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SQLite;
using jestrellaPaexProyectof.interfaces;
using System.IO;
using jestrellaPaexProyectof.Droid.DataBase;

using Xamarin.Forms;
[assembly: Xamarin.Forms.Dependency(typeof(DataBaseClient))]

namespace jestrellaPaexProyectof.Droid.DataBase
{
    public class DataBaseClient : DataBaseServer
    {
        public SQLiteAsyncConnection GetConnection()
        {
            // Ruta de guardado de base de datos
            var ruta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);

            // Crear base de datos
            var baseDatos = Path.Combine(ruta, "jestrella.db");

            // retorno de la conexion
            return new SQLiteAsyncConnection(baseDatos);
        }
    }
}