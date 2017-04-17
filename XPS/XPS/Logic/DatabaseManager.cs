using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPS.Models;
using MySql.Data.MySqlClient;

namespace XPS.Logic
{
    public class DatabaseManager
    {
        //The connection String for our database.
        private String _connectionString = @"server=138.197.112.204;Port=3306;Database=XPS;uid=masone@localhost;pwd=Tundra95;";
        private MySqlConnection _connection = null;

        /// <summary>
        /// Initializes the DatabaseManager object with the connection string. 
        /// </summary>
        public DatabaseManager()
        {
            _connection = new MySqlConnection(_connectionString);
        }

        /// <summary>
        /// This Method opens our connection to the server.
        /// </summary>
        private void OpenConnection()
        {
            try
            {
                _connection.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// This method closes our connection to the server.
        /// </summary>
        private void CloseConnection()
        {
            try
            {
                _connection.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// This method will be used to validate a user's log in credentials.
        /// </summary>
        /// <param name="userName"> The username from the log in form </param>
        /// <param name="passWord"> The password from the log in form </param>
        /// <returns>
        /// The result is the user object. If the method returns null, the user
        /// was not validated.
        /// </returns>
        public User ValidateUser(String userName, String passWord)
        {
            XPS.Models.User result = null;
            //This query will select the entire row from the user table wiht the given username and password.
            String query = @"
				SELECT * 
				
				FROM 
					User
				WHERE
					UPPER(Username) = UPPER(@username)
					AND Password = @password;";
            try
            {
                OpenConnection();
                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    //Adds the parameters to the query.
                    command.Parameters.AddWithValue("@username", userName);
                    command.Parameters.AddWithValue("@password", passWord);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Builds the user object from the row in the database.
                            result = new XPS.Models.User()
                            {
                                UserID = Int32.Parse(reader.GetString("UserID"))
                                , FirstName = reader.GetString("FirstName")
                                , LastName = reader.GetString("LastName")
                                , UserName = reader.GetString("UserName")
                                , PassWord = reader.GetString("Password")
                                , UserType = reader.GetString("UserType").ToCharArray()[0]
                            };
                        }
                    }
                }

                CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// Returns a user object for a given userID.
        /// </summary>
        /// <param name="userID"> The userID</param>
        /// <returns>The User object</returns>
        public User GetUser(int userID)
        {
            XPS.Models.User result = null;
            //This query will return the row in the User table for the userID.
            String commandString = @"                    
                SELECT *

                FROM 
                    User
                WHERE
                    UserID = @UserID;";

            try
            {
                OpenConnection();

                using (MySqlCommand command = new MySqlCommand(commandString, _connection))
                {
                    //Adds the parameter to the query.
                    command.Parameters.AddWithValue("@UserID", userID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //Builds the user object from the row in the database.
                            result = new XPS.Models.User()
                            {
                                UserID = Int32.Parse(reader.GetString("UserID"))
                                , FirstName = reader.GetString("FirstName")
                                , LastName = reader.GetString("LastName")
                                , UserName = reader.GetString("UserName")
                                , PassWord = reader.GetString("Password")
                                , UserType = reader.GetChar("UserType")
                            };
                        }
                    }
                }

                CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// This method will pull be used to pull the questions from the database
        /// based on the parameters that the user enteres. 
        /// </summary>
        /// <param name="n">The number of questions. </param>
        /// <param name="categories">The question categories. </param>
        /// <returns></returns>
        public List<Question> GetQuestions(int n, int[] categories)
        {
            List<Question> result = new List<Question>();
            string query = String.Format(@"
                SELECT TOP {0} * 

                FROM       
                    Question
                WHERE
                    Category IN {1};
            ", n, Utilities.CategoryString(categories));

            try
            {
                OpenConnection();

                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Question question = new Question()
                            {
                                QuestionID = Int32.Parse(reader.GetString("QuestionID"))
                                , QuestionCategory = Int32.Parse(reader.GetString("Category"))
                                , QuestionText = reader.GetString("QuestionText")
                                , CorrectAnswer = reader.GetString("CorrectAnswer")
                                , IncorrectAnswer1 = reader.GetString("IncorrectAnswer1")
                                , IncorrectAnswer2 = reader.GetString("IncorrectAnswer2")
                                , IncorrectAnswer3 = reader.GetString("IncorrectAnswer3")
                                , IncorrectAnswer4 = reader.GetString("IncorrectAnswer4")
                            };

                            result.Add(question);
                        }
                    }
                }

                CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// This method inserts a Question Response object into the database.
        /// </summary>
        /// <param name="qr">The Question Response object being inserted.</param>
        /// <returns>The return result indicates the success of the insert.</returns>
        public bool InsertQuestionResponse(QuestionResponse qr)
        {
            bool result = false;
            string query = @"
                INSERT INTO QuestionResponse
                (
                    QuestionID
                    , UserID
                    , Correct
                )
                VALUES
                (
                    @QuestionID
                    , @UserID
                    , @Correct
                );
            ";

            try
            {
                OpenConnection();

                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@QuestionID", qr.QuestionID);
                    command.Parameters.AddWithValue("@UserID", qr.UserID);
                    command.Parameters.AddWithValue("@Correct", (qr.Correct) ? 1 : 0);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        result = true;
                    }
                    else
                    {
                        throw new Exception("Error inserting Question Response.");
                    }
                }

                CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// Inserts a test object into the database.
        /// </summary>
        /// <param name="test"> The object being inserted. </param>
        /// <returns></returns>
        public bool InsertTest(Test test)
        {
            bool result = false;
            String query = @"
                INSERT INTO Test
                (
                    UserID
                    , Attempted
                    , Correct
                    , Time
                )
                VALUES
                (
                    @UserID
                    , @Attempted
                    , @Correct
                    , @Time
                );
            ";

            try
            {
                OpenConnection();

                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@UserID", test.UserID);
                    command.Parameters.AddWithValue("@Attempted", test.Attempted);
                    command.Parameters.AddWithValue("@Correct", test.Correct);
                    command.Parameters.AddWithValue("@Time", test.Time);

                    if (command.ExecuteNonQuery() == 1)
                    {
                        result = true;
                    }
                }

                CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// This method inserts a user into the user table.
        /// </summary>
        /// <param name="user">The user object that will be inserted into the database</param>
        /// <returns>The return value indicates whether the operation was successful</returns>
        public bool InsertUser(User user)
        {
            bool result = false;
            String query = @"
				INSERT INTO User
				(
                    UserID
					, FirstName
					, LastName
					, UserName
					, Password
					, UserType
				)
				VALUES
				(
                    @UserID
					, @FirstName
					, @LastName
					, @UserName
					, @Password
					, @UserType
				);";

            try
            {
                OpenConnection();

                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    //Adds the parameters to the query from the user object.
                    command.Parameters.AddWithValue("@UserID", user.UserID);
                    command.Parameters.AddWithValue("@FirstName", user.FirstName.Trim());
                    command.Parameters.AddWithValue("@LastName", user.LastName.Trim());
                    command.Parameters.AddWithValue("@username", user.UserName.Trim());
                    command.Parameters.AddWithValue("@password", user.PassWord.Trim());
                    command.Parameters.AddWithValue("@UserType", user.UserType);

                    //If there was a row effected(inserted).
                    if (command.ExecuteNonQuery() == 1)
                    {
                        result = true;
                    }
                }

                CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// This method deletes the user with the given userID.
        /// </summary>
        /// <param name="userID">The userID of the user to be deleted</param>
        /// <returns>The result returned indicates where the operation was successful</returns>
        public bool DeleteUser(int userID)
        {
            bool result = false;
            //This query will delete the user from the table.
            String query = @"DELETE FROM User WHERE UserID = @UserID;";

            try
            {
                OpenConnection();

                using (MySqlCommand command = new MySqlCommand(query, _connection))
                {
                    //Adds the userID to the query.
                    command.Parameters.AddWithValue("@UserID", userID);

                    //If the row was deleted.
                    if (command.ExecuteNonQuery() == 1)
                    {
                        result = true;
                    }
                }

                CloseConnection();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }
    }
}
