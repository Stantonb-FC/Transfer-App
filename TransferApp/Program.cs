using System;

namespace Warehouse_Transfer_Finder
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("What store you looking for?");
                int userInput;
                while (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Please enter numbers only.");
                }
                var userInputInt = userInput;

                // Main Code executes here

                LookUpTransferPerishable(userInputInt);
                LookUpTransferProduce(userInputInt);

            }
        }
        static void LookUpTransferPerishable(int userInputInt)
        {
            string perishableAFile = "Perishable A.json";
            string perishableBFile = "Perishable B.json";
            TransferWeek getWeek = new();
            var week = getWeek.CurrentWeek();

            try
            {
                while (week == "AWeek")
                {
                    var aWeekLookUpPerishable = SearchJsonFiles.SearchPerishableA(userInputInt, perishableAFile);

                    if (aWeekLookUpPerishable != "No trucks found tonight.")
                    {
                        Console.WriteLine(aWeekLookUpPerishable);
                    }

                    else if (aWeekLookUpPerishable == "No perishable truck.")
                    {
                        continue;
                    }

                    break;
                }

                while (week == "BWeek")
                {

                    var bWeekLookUpPerishable = SearchJsonFiles.SearchPerishableB(userInputInt, perishableBFile);

                    if (bWeekLookUpPerishable != "No trucks found tonight.")
                    {
                        Console.WriteLine(bWeekLookUpPerishable);

                    }

                    else if (bWeekLookUpPerishable == "No perishable truck.")
                    {
                        continue;
                    }

                    break;
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Unable to decipher week. Make sure date/time is correct.");
            }

            finally
            {
                var aWeekLookUpPerishable = SearchJsonFiles.SearchProduceA(userInputInt, perishableAFile);
                var bWeekLookUpPerishable = SearchJsonFiles.SearchProduceB(userInputInt, perishableBFile);

                if ((aWeekLookUpPerishable == "No produce truck.") &&
                    (bWeekLookUpPerishable == "No produce truck."))
                {
                    Console.WriteLine("No trucks tonight sorry.");
                }

            }
        }

        static void LookUpTransferProduce(int userInputInt)
        {
            string produceAFile = "Produce A.json";
            string produceBFile = "Produce B.json";
            TransferWeek getWeek = new();
            var week = getWeek.CurrentWeek();

            try
            {
                while (week == "AWeek")
                {
                    var aWeekLookUpProduce = SearchJsonFiles.SearchProduceA(userInputInt, produceAFile);

                    if (aWeekLookUpProduce != "No trucks found tonight.")
                    {
                        Console.WriteLine(aWeekLookUpProduce);
                    }

                    else if (aWeekLookUpProduce == "No produce truck.")
                    {
                        continue;
                    }

                    break;
                }

                while (week == "BWeek")
                {
                    var bWeekLookUpProduce = SearchJsonFiles.SearchProduceB(userInputInt, produceBFile);
                    if (bWeekLookUpProduce != "No trucks found tonight.")
                    {
                        Console.WriteLine(bWeekLookUpProduce);
                    }

                    else if (bWeekLookUpProduce == "No produce truck.")
                    {
                        continue;
                    }

                    break;
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Something went wrong when selecting what week to check.");
            }

            finally
            {
                var aWeekLookUpProduce = SearchJsonFiles.SearchProduceA(userInputInt, produceAFile);
                var bWeekLookUpProduce = SearchJsonFiles.SearchProduceB(userInputInt, produceBFile);4

                if ((aWeekLookUpProduce == "No produce truck.") &&
                    (bWeekLookUpProduce == "No produce truck."))
                {
                    Console.WriteLine("No trucks tonight sorry.");
                }

            }

        }
    }

}