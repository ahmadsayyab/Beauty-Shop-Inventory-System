using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace MianLogic_ClassLibrary
{
    public class Services
    {


       public static string  Path = "C:\\Users\\Sayyabkhan\\Desktop\\beauty-shop-inventory.txt";

      

        //method to read textfile items into listbox
        public List<string> GetAllItems(string itemName)
        {

            List<string> names = new List<string>();
            string[] lines = File.ReadAllLines(Path);

            foreach (string line in lines)
            {

                if (line.StartsWith(itemName))
                {

                    string name = line.Substring(itemName.Length);
                    name = name.TrimStart(':');
                    names.Add(name);
                }
            }
            return names;
        }

        //method to get item description
        public string GetItemDescription(string itemDesc, string descLabel)
        {
            string targetString = itemDesc;
            string[] lines = File.ReadAllLines(Path);

            string itemDescription = "";

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(targetString))
                {
                    if (i + 1 < lines.Length)
                    {

                        itemDescription = lines[i + 1];
                       
                        int labelPos = itemDescription.IndexOf(descLabel);

                        if (labelPos >= 0)
                        {
                            // Remove the label and any leading/trailing white spaces
                            itemDescription = itemDescription.Substring(labelPos + descLabel.Length).Trim();
                        }

                        break;

                    }

                }
            }

            return itemDescription;
        }

        //method to get item price
        public string GetItemPrice(string itemPrice, string priceLabel)
        {
            string targetString = itemPrice;
            string[] lines = File.ReadAllLines(Path);

            string itemPr = "";

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(targetString))
                {
                    if (i + 2 < lines.Length)
                    {

                        itemPr = lines[i + 2];
                       
                        int labelPos = itemPr.IndexOf(priceLabel);

                        if (labelPos >= 0)
                        {
                            // Remove the label and any leading/trailing white spaces
                            itemPr = itemPr.Substring(labelPos + priceLabel.Length).Trim();
                        }
                        break;

                    }

                }
            }

            return itemPr;
        }

        //Method to get procedure minutes
        public string GetProcedureMinutes(string procedureMinutes, string procedureMinutesLabel)
        {
            string target = procedureMinutes;
            string[] lines = File.ReadAllLines(Path);

            string procedureMins = "";

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(target))
                {
                    if (i + 3 < lines.Length)
                    {

                        procedureMins = lines[i + 3];
                       

                        int labelPos = procedureMins.IndexOf(procedureMinutesLabel);

                        if (labelPos >= 0)
                        {
                            // Remove the label and any leading/trailing white spaces
                            procedureMins = procedureMins.Substring(labelPos + procedureMinutesLabel.Length).Trim();
                        }
                        break;

                    }

                }
            }

            return procedureMins;
        }
        




        //method to load product data and procedure data into
        //their respective textboxex
        
        public string GetProductOrProcedure(string selectedName,string priceLabel, string minutesLabel)
        {

            string[] lines = File.ReadAllLines(Path);
            string target = selectedName;
            string targetData = "";
          

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(target))
                {
                    
                    if (i + 3 <= lines.Length && lines[i + 3].StartsWith(minutesLabel))
                    {
                        targetData = "procedure";
                    }
                    else 
                    {
                        targetData = "product";
                    }
                }
            }

            
            return targetData;

        }

        //search an item in textfile
        public string GetItemByName(string name , string nameLabel)
        {
            string target = name;
            string[] lines = File.ReadAllLines(Path);

           
            string targetName = "";

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(target))
                {
                    targetName = lines[i];


                    string prefix = nameLabel + ": ";
                    if (targetName.StartsWith(prefix))
                    {
                        targetName = targetName.Substring(prefix.Length);
                    }
                    break;



                }
               
            }

            return targetName;
        }
    }
}


    

        
    

