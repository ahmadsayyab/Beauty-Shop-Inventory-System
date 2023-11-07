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
    public class ProcedureServices : Services
    {


        public string nameLabel = "Name";
        public string descLabel = "Description";
        public string priceLabel = "Price";
        public string minutesLabel = "Minutes";


        //add procedure to file
        public bool Add(Procedure procedure)
        {
            bool nameExists = false;
            string[] lines = File.ReadAllLines(Services.Path);

            foreach (string line in lines)
            {
                if (line.Contains(nameLabel + ": " + procedure.Name))
                {
                    nameExists = true;
                    break;
                }
            }

            if (!nameExists)
            {
                using (StreamWriter streamWriter = new StreamWriter(Services.Path, true))
                {

                    streamWriter.WriteLine(nameLabel + ": " + procedure.Name);
                    streamWriter.WriteLine(descLabel + ": " + procedure.Description);
                    streamWriter.WriteLine(priceLabel + ": " + procedure.Price);
                    streamWriter.WriteLine(minutesLabel + ": " + procedure.Minutes);
                    streamWriter.WriteLine("\n");
                }
            }

            return nameExists;
        }

        //update procedure
        public void Update(Procedure procedure)
        {
            string target = procedure.Name;
            string[] lines = File.ReadAllLines(Services.Path);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(target))
                {
                    if (i + 1 < lines.Length)
                    {
                        string prefix = descLabel + ":";
                        if (lines[i + 1].StartsWith(prefix))
                        {
                            lines[i + 1] = prefix + procedure.Description;
                        }
                    }

                    if (i + 2 < lines.Length)
                    {
                        string prefix = priceLabel + ":";
                        if (lines[i + 2].StartsWith(prefix))
                        {
                            lines[i + 2] = prefix + procedure.Price;
                        }

                    }
                    if (i + 3 < lines.Length)
                    {
                        string prefix = minutesLabel + ":";
                        if (lines[i + 3].StartsWith(prefix))
                        {
                            lines[i + 3] = prefix + procedure.Minutes;
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

        //delete procedure
        public void Delete(Procedure procedure)
        {
            string target = procedure.Name;
            string[] lines = File.ReadAllLines(Services.Path);
            List<string> newFile = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(target))
                {

                    i += 3;
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
