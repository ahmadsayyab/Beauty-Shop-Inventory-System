using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MianLogic_ClassLibrary
{
    public class ProductServices : Services
    {

        

        public string nameLabel = "Name";
        public string descLabel = "Description";
        public string priceLabel = "Price";
        
       

        //Method to add items into the textfile
        public bool Add(Product product)
        {
            bool nameExists = false;
            string[] lines = File.ReadAllLines(Services.Path);

            foreach (string line in lines)
            {
                if (line.Contains(nameLabel + ": " + product.Name))
                {
                    nameExists = true;
                    break;
                }
            }

            if (!nameExists)
            {
                using (StreamWriter streamWriter = new StreamWriter(Services.Path, true))
                {

                    streamWriter.WriteLine(nameLabel + ": " + product.Name);
                    streamWriter.WriteLine(descLabel + ": " + product.Description);
                    streamWriter.WriteLine(priceLabel + ": " + product.Price);
                    streamWriter.WriteLine("\n");
                }
            }

            return nameExists;
        }


        //update a product
        public void Update(Product product)
        {

            string target = product.Name;
            string[] lines = File.ReadAllLines(Services.Path);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(target))
                {
                    if (i + 1 < lines.Length)
                    {
                        string prefix = descLabel + ": ";
                        if (lines[i + 1].StartsWith(prefix))
                        {
                            lines[i + 1] = prefix + product.Description;
                        }
                    }

                    if (i + 2 < lines.Length)
                    {
                        string prefix = priceLabel + ": ";
                        if (lines[i + 2].StartsWith(prefix))
                        {
                            lines[i + 2] = prefix + product.Price;
                        }
                        break;
                    }
                }
            }

            // Clear the file before writing the updated lines
            File.WriteAllText(Services.Path, string.Empty);

            // Write the updated lines to the file
            File.WriteAllLines(Services.Path, lines);

        }


        //Delete Product
        public void Delete(Product product)
        {

            string target = product.Name;
            string[] lines = File.ReadAllLines(Services.Path);
            List<string> newFile = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(target))
                {

                    i += 2;
                }
                else
                {
                    newFile.Add(lines[i]);
                }
            }

            // Clear the file before writing the updated lines
            File.WriteAllText(Services.Path, string.Empty);

            // Write the updated lines to the file
            File.WriteAllLines(Services.Path, newFile);


        }
    }
}
