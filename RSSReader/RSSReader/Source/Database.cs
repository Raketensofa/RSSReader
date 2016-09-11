using System;
using System.Collections.Generic;
using System.Data.SQLite;
using RSSReader.Objects;

/*
 * author: Carolin Gellner
 */
namespace RSSReader.Source
{
    /// <summary>
    /// Repaesentiert die Datenbank die SQLite Datenabank des Programms und bietet diverse Funktionen zum Einfuegen und Auslesen von Datenbankinhalten.
    /// </summary>
    public class Database
    {

        #region Fields

        private string _Name = "databaseRssReader.db";
        private SQLiteConnection _Connection;

        #endregion


        #region Constructor

        /// <summary>
        /// Erstellt eine neue Instanz der Klasse Database.
        /// </summary>
        public Database()
        {
            //Falls die Datenbanktabellen nicht existieren diese erstellen
            createTables();
        }

        #endregion


        #region (Public) Methods

        /// <summary>
        /// Erstellt eine Verbindung zur Datenbank.
        /// </summary>
        public void open()
        {
            _Connection= new SQLiteConnection();

            _Connection.ConnectionString = "Data Source=" + _Name;

            _Connection.Open();

        }

        /// <summary>
        /// Schliesst die Verbindung zur Datenbank.
        /// </summary>
        public void close()
        {
            _Connection.Close();
            _Connection.Dispose();
        }

        /// <summary>
        /// Erstellt die Tabellen der Datenbank.
        /// </summary>
        public void createTables()
        {
            open();

            SQLiteCommand command = new SQLiteCommand(_Connection);

            string query = getCreateTableCommandText("feeds") + getCreateTableCommandText("categories");

            command.CommandText = query;

            command.ExecuteNonQuery();

            command.Dispose();

            close();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="categoryName"></param>
        public bool saveNewCategory(string categoryName)
        {
            bool saved = false;

            open();

            string sqlStr = "INSERT INTO categories (name) VALUES ('" + categoryName + "')";

            saved = addData(sqlStr);

            close();

            return saved;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="feed"></param>
        /// <returns></returns>
        public bool saveNewFeed(Feed feed)
        {
            bool saved = false;

            open();

            string sqlStr = "INSERT INTO feeds (name, link, categoryId) VALUES ('" + feed.Name + "', '" + feed.Link + "'," + feed.UserCategoryId + ")";

            saved = addData(sqlStr);

            close();

            return saved;
        }

        /// <summary>
        /// Loescht einen Feed aus der Datenbank.
        /// </summary>
        /// <param name="id">Feed-Id</param>
        /// <returns>true: geloescht, false: nicht geloescht</returns>
        public bool deleteFeed(int id)
        {
            bool delete = false;

            open();

            string sqlStr = "DELETE FROM feeds WHERE id = " + id;

            delete = addData(sqlStr);

            close();

            return delete;
        }
   
        /// <summary>
        /// Loescht eine Kategorie aus der Datenbank.
        /// </summary>
        /// <param name="id">Feed-Id</param>
        /// <returns>true: geloescht, false: nicht geloescht</returns>
        public bool deleteCategory(int id)
        {
            bool delete = false;

            open();

            string sqlStr = "DELETE FROM feed WHERE id = " + id;

            delete = addData(sqlStr);

            close();

            return delete;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newName"></param>
        /// <returns></returns>
        public bool updateCategoryName(int id, string newName)
        {
            bool update = false;

            open();

            string sqlStr = "UPDATE categories SET name = '" + newName + "' WHERE id = " + id;

            update = addData(sqlStr);

            close();

            return update;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="newName"></param>
        /// <returns></returns>
        public bool updateFeedCategoryId(int feedId, int newCategoryId)
        {
            bool update = false;

            open();

            string sqlStr = "UPDATE feeds SET categoryId = " + newCategoryId + " WHERE id = " + feedId;

            update = addData(sqlStr);

            close();

            return update;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="feedId"></param>
        /// <param name="newName"></param>
        /// <param name="newCategoryId"></param>
        /// <returns></returns>
        public bool updateFeed(int feedId, string newName, int newCategoryId)
        {
            bool update = false;

            open();

            string sqlStr = "UPDATE feeds SET categoryId = " + newCategoryId + ", name = '" + newName  + "' WHERE id = " + feedId;

            update = addData(sqlStr);

            close();

            return update;
        }

        /// <summary>
        /// Ruft alle Kategorien aus der Datenbank ab und legt diese in einer Liste ab.
        /// </summary>
        /// <returns>Liste mit allen Kategorien</returns>
        public List<Category> getAllCategories()
        {
            List<Category> listCategories = null;
            SQLiteCommand command = null;
            SQLiteDataReader reader = null;

            open();


            try
            {
                command = new SQLiteCommand(_Connection);

                command.CommandText = "SELECT * FROM categories";

             
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    listCategories = new List<Category>();

                    while (reader.Read())
                    {
                        Category category = new Category();
                        
                        category.ID = Convert.ToInt32(reader["id"]);
                        category.Name = reader["name"].ToString();

                        listCategories.Add(category);
                    }
                }
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                command.Dispose();
                reader.Close();
                reader.Dispose();
                close();
            }

            return listCategories;
        }

        /// <summary>
        /// Ruft alle Feeds aus der Datenbank entsprechend der Kategorie-Id ab und legt diese in einer Liste ab.
        /// Ist die KategorieId '-1' dann werden die Feeds aller Kategorien abgefragt.
        /// </summary>
        /// <returns>Liste mit Feeds</returns>
        public List<Feed> getAllFeeds(int categoryId)
        {
            List<Feed> listFeeds = null;
            SQLiteCommand command = null;
            SQLiteDataReader reader = null;

            open();


            try
            {
                command = new SQLiteCommand(_Connection);

                if(categoryId == -1)
                {
                    command.CommandText = "SELECT * FROM feeds";

                }else if(categoryId >= 0)
                {
                    command.CommandText = "SELECT * FROM feeds WHERE categoryId = " + categoryId;
                }


                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    listFeeds = new List<Feed>();

                    while (reader.Read())
                    {
                        Feed feed = new Feed();
                        feed.Id = Convert.ToInt32(reader["id"]);
                        feed.Name = reader["name"].ToString();
                        feed.Link = reader["link"].ToString();
                        feed.UserCategoryId = Convert.ToInt32(reader["categoryId"]);

                        listFeeds.Add(feed);
                    }
                }
            }
            catch (Exception)
            {

                return null;
            }
            finally
            {
                command.Dispose();
                reader.Close();
                reader.Dispose();
                close();
            }

            return listFeeds;
        }

        /// <summary>
        /// Ueberprueft, ob die uebergebene Kategorie bereits existiert.
        /// </summary>
        /// <param name="categoryName">Name der Kategorie</param>
        /// <returns></returns>
        public bool existsCategory(string categoryName)
        {
            bool exists = false;
            SQLiteCommand command = null;
            SQLiteDataReader reader = null;

            open();

            try
            {
                command = new SQLiteCommand(_Connection);
                command.CommandText = "SELECT id FROM categories WHERE name = '" + categoryName + "'";
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    exists = true;
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                command.Dispose();
                reader.Close();
                reader.Dispose();
                close();
            }

            return exists;
        }

        /// <summary>
        /// Ueberprueft ob ein Link bereits in der Datenbank existiert.
        /// </summary>
        /// <param name="link">Feed Link</param>
        /// <returns>true, wenn existiert - false, wenn nicht exisitert</returns>
        public bool existsFeedLink(string link)
        {
            bool exists = false;
            SQLiteCommand command = null;
            SQLiteDataReader reader = null;

            open();

            try
            {
                command = new SQLiteCommand(_Connection);
                command.CommandText = "SELECT id FROM feeds WHERE link = '" + link + "'";
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    exists = true;
                }

            }
            catch (Exception)
            {

            }
            finally
            {
                command.Dispose();
                reader.Close();
                reader.Dispose();
                close();
            }

            return exists;
        }

        #endregion


        #region (Private) Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName">Name der Tabelle</param>
        /// <returns>"Create Table" Sql-Befehl</returns>
        private string getCreateTableCommandText(string tableName)
        {
            string commandText = string.Empty;

            switch (tableName)
            {
                case "feeds":
                    commandText = "CREATE TABLE IF NOT EXISTS feeds (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, name VARCHAR(150) NOT NULL, link VARCHAR NOT NULL, categoryId INTEGER NOT NULL);";
                    break;

                case "categories":
                    commandText = "CREATE TABLE IF NOT EXISTS categories (id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, name VARCHAR(150) NOT NULL);";
                    break;

                default:
                    commandText = string.Empty;
                    break;
            }

            return commandText;
        }


        /// <summary>
        /// Schreibt neue Daten in die Datenbank entsprechend des uebergebenen Sql-Strings.
        /// </summary>
        /// <param name="sqlQuery">SQL-Befehl (Insert oder Update)</param>
        private bool addData(string sqlQuery)
        {
            bool saved = false;
            SQLiteCommand command = null;

            try
            {
                command = new SQLiteCommand(_Connection);

                command.CommandText = sqlQuery;

                command.ExecuteNonQuery();

                saved = true;

            }catch(Exception)
            { 
                return false;
            }
            finally
            {
                command.Dispose();
            }

            return saved;

        }

        #endregion

    }
}
