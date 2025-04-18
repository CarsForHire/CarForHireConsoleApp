﻿using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Data.SqlClient;
namespace CarForHireConsoleApp
    
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=localhost\\SQLEXPRESS;Database=EVMotors_DB;Trusted_Connection=True;TrustServerCertificate=True;";
            bool isExit = true;
            MainLoop(ref isExit, ref connectionString);
            
        }
        // main loop
        private static void MainLoop(ref bool isExit,ref string connectionString)
        {
            // This code get the choice of the user ....by Matthew 15/4/2025
            MenuBoard();
            while (isExit)
            {
              GetUserChoice(ref isExit,ref connectionString);
            }
        }


        private static void MenuBoard()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("1.) Add New Record  *");
            Console.WriteLine("2.) Delete Record   *");
            Console.WriteLine("3.) Edit Record     *");
            Console.WriteLine("4.) Display Records *");
            Console.WriteLine("5.) Exit Program    *");
            Console.WriteLine("*********************");
        }

        private static int GetUserChoice(ref bool isExit,ref string connectionString)
        {
            Console.WriteLine("Enter choice: ");
            int choice = ValidateInput();
            ProcessMenuSelection(ref choice,ref isExit,ref connectionString);
            return choice;

        }

        private static int ProcessMenuSelection(ref int  choice,ref bool isExit,ref string connectionString)
        {
            switch (choice)
            {
                case 1: InsertRecord(ref connectionString);
                    break;

                case 2: DeleteRecord(ref connectionString);
                    break;

                case 3: UpdateRecord(ref connectionString);
                    break;

                case 4: DisplayAllRecords(ref connectionString);
                    break;

                case 5: Console.WriteLine("Exiting.........");
                    isExit = false;
                    break;

                default:Console.WriteLine("INVALID INPUT! PLEASE TRY AGAIN! Options (1-5)");
                    break;
            }
            return choice;
        }

        //Todo Kevin
        private static void InsertRecord(ref string connectionString)
        {
            Console.WriteLine("Insert method");
        }
        //Todo Matthew 
        private static void DeleteRecord(ref string connectionString)
        {
            Console.WriteLine("Delete method");
        }
        //Todo Matthew
        private static void UpdateRecord(ref string connectionString) 
        {
            Console.WriteLine("Update record");
        }
        //Todo Kevin
        private static void DisplayAllRecords(ref string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM EVMotors";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("\nCar List");
                    while (reader.Read())
                    {
                        DateTime dateReg = Convert.ToDateTime(reader["DateRegistered"]);
                        string formattedDate = dateReg.ToString("dd/MM/yyyy");
                        Console.WriteLine($"Vehicle Reg: {reader["VehicleRegNo"]}, VehicleMake: {reader["VehicleMake"]}, VehicleEngineSize: {reader["VehicleEngineSize"]}, Date Registered: {formattedDate}, Rent Per Day: {reader["RentPerDay"]}, Availibility: { reader["Available"]}");
                    }

                }
            }
        }

        //Checks for bad input
        private static int ValidateInput()
        {
            while (true)
            {
                string? input = Console.ReadLine();
                if(int.TryParse(input,out int result))
                {
                    return result;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("INVALID INPUT! NUMBERS ONLY! TRY AGAIN!");
                    Console.ResetColor();
                }
            }
        }
    }
}
