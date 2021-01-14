/////////////////////////////////////////////////////////////////////////////////
//
//         FileName : DBConnect.cs
//           Author : Marco A. Palomino
//
//      Description : A class to introduce some basic principles for connecting
//                    to a MySQL database using C#. The solution employs the
//                    MySQL Connector/NET 8.0.
//
/////////////////////////////////////////////////////////////////////////////////

using System;
using MySql.Data.MySqlClient;

namespace AssignmentFaceBook
{
    static class DBConnect
    {
        /// <summary>
        /// The username that we use when connecting to the server. It has the form
        /// soft562_<your name>.
        /// </summary>
        public static string USER_NAME = "";

        /// <summary>
        /// The name or network address of the server. The default value is
        /// 'localhost', but in our case this will be proj-mysql.uopnet.plymouth.ac.uk.
        /// </summary>
        public static string SERVER = "";

        /// <summary>
        /// The name of the database to use. Recall that the names of databases
        /// on Xserve have the form soft562_<your name>.
        /// </summary>
        public static string DATABASE_NAME = "";

        /// <summary>
        /// The password for the MySQL account being used.
        /// </summary>
        public static string PASSWORD = "";

        /// <summary>
        /// Security state of connection to server.
        /// </summary>
        public static string SslMode = "none";


    } // End of class DBConnect
}
