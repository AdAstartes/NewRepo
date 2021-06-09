using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinante
{
    class Money 
    {
        static public Dictionary<string, float> calculate_total(string recurenta, DateTime date1, DateTime date2, string tip)
        {
            
            string sqlFormattedDate1 = date1.ToString("yyyy-MM-dd");
            string sqlFormattedDate2 = date2.ToString("yyyy-MM-dd");
            string command;
            List<string> field_lst = new List<string>();
            field_lst.Add("valoare");
            field_lst.Add("tip");

            switch (recurenta)
            {
                case "Fixe":
                    command = "Select valoare, tip from "+tip+" WHERE tip = 'fix' and data_document <= '" + sqlFormattedDate2 + "' and data_document >'" + sqlFormattedDate1 + "'";
                    break;
                case "Recurente":
                    {
                        command = "Select valoare, tip, recurenta, data_document from  " + tip + " WHERE tip = 'recurenta' and data_document <= '" + sqlFormattedDate2 + "'";
                        field_lst.Add("recurenta");
                        field_lst.Add("data_document");
                        break;
                    }
                default:
                    command = "Select valoare, tip, recurenta, data_document from  " + tip + " WHERE data_document <= '" + sqlFormattedDate2 + "' and data_document >'" + sqlFormattedDate1 + "'";
                    field_lst.Add("recurenta");
                    field_lst.Add("data_document");
                    break;
            }


            int count = 0;
            float sum = 0;

            string total = "";
            foreach (var el in Database.select(command, field_lst))
            {
                total += "+ " + el["valoare"];
                if (el["tip"] == "fix")
                {
                    sum += float.Parse(el["valoare"]);
                    count++;
                }

                else
                {
                    int mult = 0;
                    System.TimeSpan diff1;
                    DateTime start_date = Convert.ToDateTime(el["data_document"].ToString());
                    if (date1 > start_date)
                    {

                        diff1 = date2.Subtract(date1);
                    }
                    else
                    {
                        diff1 = date2.Subtract(start_date);
                    }
                    int days = diff1.Days;
                    switch (el["recurenta"])
                    {
                        case "Zi":
                            {
                                mult = days;

                                break;
                            }
                        case "Saptamana":
                            {
                                mult = days / 7;
                                if (start_date > date1 && start_date < date2)
                                    mult++;
                                if (days % 7 == 0)
                                    mult--;
                                break;
                            }
                        case "Luna":
                            {
                                mult = days / 30;
                                if (start_date > date1 && start_date < date2)
                                    mult++;
                                if (days % 30 == 0)
                                    mult--;
                                break;
                            }
                        case "Trimestru":
                            {
                                mult = days / 91;
                                if (start_date > date1 && start_date < date2)
                                    mult++;
                                if (days % 91 == 0)
                                    mult--;

                                break;
                            }
                        case "An":
                            {
                                mult = days / 365;
                                if (start_date > date1 && start_date < date2)
                                    mult++;
                                if (days % 365 == 0)
                                    mult--;
                                break;
                            }
                        default:
                            mult = days;
                            break;

                    }
                    count += mult;
                    sum += float.Parse(el["valoare"]) * mult;
                }

            }

            Dictionary<string, float> returndict = new Dictionary<string, float>();
            returndict["value"] = sum;
            returndict["count"] = count;
            return returndict;
        }

        static public Dictionary<string, float> dump(string recurenta, DateTime date1, DateTime date2, string tip)
        {

            string sqlFormattedDate1 = date1.ToString("yyyy-MM-dd");
            string sqlFormattedDate2 = date2.ToString("yyyy-MM-dd");
            string command;
            List<string> field_lst = new List<string>();
            field_lst.Add("valoare");
            field_lst.Add("tip");

            switch (recurenta)
            {
                case "Fixe":
                    command = "Select valoare, tip from " + tip + " WHERE tip = 'fix' and data_document <= '" + sqlFormattedDate2 + "' and data_document >'" + sqlFormattedDate1 + "'";
                    break;
                case "Recurente":
                    {
                        command = "Select valoare, tip, recurenta, data_document from  " + tip + " WHERE tip = 'recurenta' and data_document <= '" + sqlFormattedDate2 + "'";
                        field_lst.Add("recurenta");
                        field_lst.Add("data_document");
                        break;
                    }
                default:
                    command = "Select valoare, tip, recurenta, data_document from  " + tip + " WHERE data_document <= '" + sqlFormattedDate2 + "' and data_document >'" + sqlFormattedDate1 + "'";
                    field_lst.Add("recurenta");
                    field_lst.Add("data_document");
                    break;
            }


            int count = 0;
            float sum = 0;

            string total = "";
            foreach (var el in Database.select(command, field_lst))
            {
                total += "+ " + el["valoare"];
                if (el["tip"] == "fix")
                {
                    sum += float.Parse(el["valoare"]);
                    count++;
                }

                else
                {
                    int mult = 0;
                    System.TimeSpan diff1;
                    DateTime start_date = Convert.ToDateTime(el["data_document"].ToString());
                    if (date1 > start_date)
                    {

                        diff1 = date2.Subtract(date1);
                    }
                    else
                    {
                        diff1 = date2.Subtract(start_date);
                    }
                    int days = diff1.Days;
                    switch (el["recurenta"])
                    {
                        case "Zi":
                            {
                                mult = days;

                                break;
                            }
                        case "Saptamana":
                            {
                                mult = days / 7;
                                if (start_date > date1 && start_date < date2)
                                    mult++;
                                if (days % 7 == 0)
                                    mult--;
                                break;
                            }
                        case "Luna":
                            {
                                mult = days / 30;
                                if (start_date > date1 && start_date < date2)
                                    mult++;
                                if (days % 30 == 0)
                                    mult--;
                                break;
                            }
                        case "Trimestru":
                            {
                                mult = days / 91;
                                if (start_date > date1 && start_date < date2)
                                    mult++;
                                if (days % 91 == 0)
                                    mult--;

                                break;
                            }
                        case "An":
                            {
                                mult = days / 365;
                                if (start_date > date1 && start_date < date2)
                                    mult++;
                                if (days % 365 == 0)
                                    mult--;
                                break;
                            }
                        default:
                            mult = days;
                            break;

                    }
                    count += mult;
                    sum += float.Parse(el["valoare"]) * mult;
                }

            }

            Dictionary<string, float> returndict = new Dictionary<string, float>();
            returndict["value"] = sum;
            returndict["count"] = count;
            return returndict;
        }

    }
}
