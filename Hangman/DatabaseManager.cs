using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Hangman;
using SQLite;
using Environment = Android.OS.Environment;
using Path = System.IO.Path;

namespace PlayerData
{
    class DatabaseManager
    {
        //Your class name must be your table name

        //Connection path
        SQLiteConnection db = new SQLiteConnection(Path.Combine(Environment.ExternalStorageDirectory.ToString(), "PlayerData.sqlite"));

        public DatabaseManager()
        {
            
        }

        public List<tblHangmanDB> ViewAll()
        {
            try
            {
                SQLiteConnection db = new SQLiteConnection(Path.Combine(Environment.ExternalStorageDirectory.ToString(), "PlayerData.sqlite"));

                return db.Query<tblHangmanDB>("SELECT * from HangmanDB");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e.Message);
                return null;
            }
        }

        public void AddItem(string title, string details)
        {
            try
            {
                using (SQLiteConnection db = new SQLiteConnection(Path.Combine(Environment.ExternalStorageDirectory.ToString(), "PlayerData.sqlite")))
                {
                    
                }

            
            }
            catch (Exception e)
            {
                
                throw;
            }
        }
    }
}