using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * author: Carolin Gellner
 */
namespace RSSReader.Objects
{
    /// <summary>
    /// Repraesentiert eine Kategorie.
    /// </summary>
    public class Category
    {

        #region Fields

        private int _Id;
        private string _Name;

        #endregion


        #region Constructor

        /// <summary>
        /// Erstellt eine neue Instanz der Klasse Category.
        /// </summary>
        public Category()
        {

        }

        /// <summary>
        /// Erstellt eine neue Instanz der Klasse Category.
        /// </summary>
        /// <param name="id">ID der Kategorie</param>
        public Category(int id)
        {
            _Id = id;
        }

        /// <summary>
        /// Erstellt eine neue Instanz der Klasse Category.
        /// </summary>
        /// <param name="name">Bezeichnung</param>
        public Category(string name)
        {
            _Name = name;
        }

        /// <summary>
        /// Erstellt eine neue Instanz der Klasse Category.
        /// </summary>
        /// <param name="id">Id</param>
        /// <param name="name">Bezeichnung</param>
        public Category(int id, string name)
        {
            _Id = id;
            _Name = name;
        }

        #endregion


        #region Properties

        /// <summary>
        /// Id der Kategorie
        /// </summary>
        public int ID
        {
            get { return _Id; }
            set { _Id = value; }
        }

        /// <summary>
        /// Bezeichnung der Kategorie
        /// </summary>
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        #endregion

    }
}
