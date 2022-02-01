using System;
using System.Text.Json;
using System.IO;

namespace Warehouse_Transfer_Finder
{
    class SearchJsonFiles
    {
        public static string SearchPerishableA(int userStoreNumber, string perishableAFile)
        {
            TransferWeek today = new();
            var weekdayName = Convert.ToString(today.GetWeekDayName());
            var perishableA = File.ReadAllText(perishableAFile);

            JsonModel.RootModel jModPerishableA = JsonSerializer.Deserialize<JsonModel.RootModel>(perishableA);

            try
            {

                if (weekdayName == "Monday")
                {
                    foreach (var item in jModPerishableA.Monday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PERISHABLE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Tuesday")
                {
                    foreach (var item in jModPerishableA.Tuesday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PERISHABLE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Wednesday")
                {
                    foreach (var item in jModPerishableA.Wednesday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PERISHABLE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Thursday")
                {
                    foreach (var item in jModPerishableA.Thursday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PERISHABLE";

                        else
                            continue;
                    }

                }
                else if (weekdayName == "Friday")
                {
                    foreach (var item in jModPerishableA.Friday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PERISHABLE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Saturday")
                {
                    foreach (var item in jModPerishableA.Saturday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PERISHABLE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Sunday")
                {
                    foreach (var item in jModPerishableA.Sunday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PERISHABLE";

                        else
                            continue;
                    }
                }
            }

            catch (Exception)
            {
                return "Whoops. Broke it";
            }

            return "No perishable truck.";
        }

        public static string SearchProduceA(int userStoreNumber, string produceAFile)
        {
            TransferWeek today = new();
            var weekdayName = Convert.ToString(today.GetWeekDayName());
            var produceA = File.ReadAllText(produceAFile);

            JsonModel.RootModel jModProduceA = JsonSerializer.Deserialize<JsonModel.RootModel>(produceA);

            try
            {
                if (weekdayName == "Monday")
                {
                    foreach (var item in jModProduceA.Monday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PRODUCE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Tuesday")
                {
                    foreach (var item in jModProduceA.Tuesday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PRODUCE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Wednesday")
                {
                    foreach (var item in jModProduceA.Wednesday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PRODUCE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Thursday")
                {
                    foreach (var item in jModProduceA.Thursday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PRODUCE";

                        else
                            continue;
                    }
                }
                else if (weekdayName == "Friday")
                {
                    foreach (var item in jModProduceA.Friday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PRODUCE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Saturday")
                {
                    foreach (var item in jModProduceA.Saturday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PRODUCE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Sunday")
                {
                    foreach (var item in jModProduceA.Sunday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PRODUCE";

                        else
                            continue;
                    }
                }
            }

            catch (Exception)
            {
                return "Whoops. Broke it";
            }

            return "No produce truck.";
        }

        public static string SearchPerishableB(int userStoreNumber, string perishableBFile)
        {
            TransferWeek today = new();
            var weekdayName = Convert.ToString(today.GetWeekDayName());
            var perishableB = File.ReadAllText(perishableBFile);

            JsonModel.RootModel jModPerishableB = JsonSerializer.Deserialize<JsonModel.RootModel>(perishableB);

            try
            {

                if (weekdayName == "Monday")
                {
                    foreach (var item in jModPerishableB.Monday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PERISHABLE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Tuesday")
                {
                    foreach (var item in jModPerishableB.Tuesday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PERISHABLE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Wednesday")
                {
                    foreach (var item in jModPerishableB.Wednesday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PERISHABLE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Thursday")
                {
                    foreach (var item in jModPerishableB.Thursday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PERISHABLE";

                        else
                            continue;
                    }

                }
                else if (weekdayName == "Friday")
                {
                    foreach (var item in jModPerishableB.Friday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PERISHABLE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Saturday")
                {
                    foreach (var item in jModPerishableB.Saturday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PERISHABLE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Sunday")
                {
                    foreach (var item in jModPerishableB.Sunday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PERISHABLE";

                        else
                            continue;
                    }
                }
            }

            catch (Exception)
            {
                return "Whoops. Broke it";
            }

            return "No perishable truck.";

        }

        public static string SearchProduceB(int userStoreNumber, string produceBFile)
        {
            TransferWeek today = new();
            var weekdayName = Convert.ToString(today.GetWeekDayName());
            var produceB = File.ReadAllText(produceBFile);

            JsonModel.RootModel jModProduceB = JsonSerializer.Deserialize<JsonModel.RootModel>(produceB);

            try
            {
                if (weekdayName == "Monday")
                {
                    foreach (var item in jModProduceB.Monday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PRODUCE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Tuesday")
                {
                    foreach (var item in jModProduceB.Tuesday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PRODUCE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Wednesday")
                {
                    foreach (var item in jModProduceB.Wednesday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PRODUCE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Thursday")
                {
                    foreach (var item in jModProduceB.Thursday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PRODUCE";

                        else
                            continue;
                    }
                }
                else if (weekdayName == "Friday")
                {
                    foreach (var item in jModProduceB.Friday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PRODUCE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Saturday")
                {
                    foreach (var item in jModProduceB.Saturday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PRODUCE";

                        else
                            continue;
                    }
                }

                else if (weekdayName == "Sunday")
                {
                    foreach (var item in jModProduceB.Sunday)
                    {
                        if (userStoreNumber == item.Store)
                            return $"Transfer {userStoreNumber} to PRODUCE";

                        else
                            continue;
                    }
                }
            }

            catch (Exception)
            {
                return "Whoops. Broke it";
            }

            return "No produce truck.";
        }
    }
}
