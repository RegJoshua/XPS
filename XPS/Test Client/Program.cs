using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XPS;
using XPS.Logic;
using XPS.Models;
using MySql.Data.MySqlClient;

namespace TestClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(90, 25);
            MainMenu();
            Console.ReadLine();
        }

        public static void MainMenu()
        {
            int selection = 0;

            Console.WriteLine("XPS Test Client");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("1. Select Users");
            Console.WriteLine("2. Insert User");
            Console.WriteLine("3. Delete User");
            Console.WriteLine("4. Validate User");
            Console.WriteLine("5. Get User");
            Console.WriteLine("6. Get Questions");
            Console.WriteLine("7. Insert Question Response");
            Console.WriteLine("8. Permutation Tester");
            Console.WriteLine("9. Exit");

            try
            {
                selection = Int32.Parse(Console.ReadLine());
                Console.Clear();

                switch (selection)
                {
                    case 1:
                        SelectUserTest();
                        break;
                    case 2:
                        InsertUserTest();
                        break;
                    case 3:
                        DeleteUserTest();
                        break;
                    case 4:
                        ValidateUserTest();
                        break;
                    case 5:
                        GetUserTest();
                        break;
                    case 6:
                        GetQuestionsTest();
                        break;
                    case 7:
                        InsertQuestionResponseTest();
                        break;
                    case 8:
                        PermutationTest();
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                }

                MainMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void SelectUserTest()
        {
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("SELECT USER TEST");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("UserID   First Name      Last Name       UserName        Password        User Type");
            Console.WriteLine("----------------------------------------------------------------------------------");

            string commandText = @"SELECT * FROM User;";
            string connectionString = "server=138.197.112.204;Port=3306;Database=XPS;uid=masone@localhost;pwd=Tundra95;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand command = new MySqlCommand(commandText, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string output = "";
                output = reader.GetString("UserID").PadRight(9);
                output += reader.GetString("FirstName").PadRight(16);
                output += reader.GetString("LastName").PadRight(16);
                output += reader.GetString("UserName").PadRight(16);
                output += reader.GetString("Password").PadRight(16);
                output += reader.GetString("UserType");
                Console.WriteLine(output);
            }

            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }

        public static void InsertUserTest()
        {
            DatabaseManager db = new DatabaseManager();
            int userid = 0;
            String firstName = "";
            String lastName = "";
            String userName = "";
            String passWord = "";
            Char userType = 'S';
            User user = null;

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("INSERT USER TEST");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("User ID: ");
            userid = Int32.Parse(Console.ReadLine());
            Console.WriteLine("First Name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Username: ");
            userName = Console.ReadLine();
            Console.WriteLine("Password: ");
            passWord = Console.ReadLine();
            Console.WriteLine("UserType: ");
            userType = Console.ReadLine().ToCharArray()[0];

            try
            {
                user = new User()
                {   
                    UserID = userid
                    , FirstName = firstName
                    ,LastName = lastName
                    ,UserName = userName
                    ,PassWord = passWord
                    ,UserType = userType
                };

                if (db.InsertUser(user))
                {
                    Console.WriteLine("User Entered. Press Enter to Continue");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("User Insert Failed.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Console.Clear();
            }

        }

        public static void DeleteUserTest()
        {
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("DELETE USER TEST");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("UserID: ");
            int userID = Int32.Parse(Console.ReadLine());
            Console.WriteLine(String.Format("Are you sure that you would like to delete user {0} (Y/N).", userID));
            char ch = (char)Console.Read();
            if (ch == 'Y' || ch == 'y')
            {
                try
                {
                    DatabaseManager db = new DatabaseManager();
                    if (db.DeleteUser(userID))
                    {
                        Console.WriteLine("User Deleted. Press Enter to continue.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Error Deleting User");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Press Enter to return to the Main Menu.");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void ValidateUserTest()
        {
            String username = "";
            String password = "";
            DatabaseManager db = new DatabaseManager();

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("VALIDATE USER TEST");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Username: ");
            username = Console.ReadLine();
            Console.WriteLine("Password: ");
            password = Console.ReadLine();

            User user = db.ValidateUser(username, password);

            if (user == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Username or Password");
            }
            else
            {
                Console.WriteLine(String.Format("USER VALIDATED: {0}", user.FirstName + " " + user.LastName));
            }

            Console.WriteLine("Press Enter to return to the menu.");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void GetUserTest()
        {
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("GET USER TEST");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("Enter a UserID: ");
            int userID = Int32.Parse(Console.ReadLine());
            DatabaseManager db = new DatabaseManager();
            User user = db.GetUser(userID);

            if (user != null)
            {
                Console.WriteLine(String.Format("UserID: {0}", user.UserID));
                Console.WriteLine(String.Format("First Name: {0}", user.FirstName));
                Console.WriteLine(String.Format("Last Name: {0}", user.LastName));
                Console.WriteLine(String.Format("Username: {0}", user.UserName));
                Console.WriteLine(String.Format("Password: {0}", user.PassWord));
                Console.WriteLine(String.Format("User Type: {0}", user.UserType));

                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid UserID.");
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
            }
        }

        public static void GetQuestionsTest()
        {
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("GET QUESTIONS TEST");
            Console.WriteLine("**********************************************************************************");

            DatabaseManager db = new DatabaseManager();
            List<Question> temp = db.GetQuestions(1, new int[] {1, 2, 3});
            Console.WriteLine("Done");
            Console.ReadLine();
            Console.Clear();
        }

        public static void InsertQuestionResponseTest()
        {
            int questionID = 0;
            int userID = 0;
            string input = "";
            DatabaseManager db = new DatabaseManager();

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("INSERT QUESTION RESPONSE TEST");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("QuestionID:");
            questionID = Int32.Parse(Console.ReadLine());
            Console.WriteLine("UserID: ");
            userID = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Correct? (Y/N)");
            input = Console.ReadLine();

            while (!new string[] { "y", "Y", "n", "N" }.Contains(input))
            {
                Console.WriteLine("Invalid input.");
                input = Console.ReadLine();
            }

            try
            { 
                QuestionResponse qr = new QuestionResponse()
                {
                    QuestionID = questionID
                    , UserID = userID
                    , Correct = (input == "y" || input == "Y")
                };

                if (db.InsertQuestionResponse(qr))
                {
                    Console.WriteLine("Question Response Inserted");
                }
                else
                {
                    Console.WriteLine("Failure");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
            Console.Clear();
        }

        public static void PermutationTest()
        {
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("PERMUTATION TEST");
            Console.WriteLine("**********************************************************************************");

            for (int i = 0; i < 10; i++)
            {
                int[] permutation = XPS.Logic.Utilities.Permutation();
                string output = permutation[0] + " ";
                output += permutation[1] + " ";
                output += permutation[2] + " ";
                output += permutation[3] + " ";
                output += permutation[4];

                Console.WriteLine(output);
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}


