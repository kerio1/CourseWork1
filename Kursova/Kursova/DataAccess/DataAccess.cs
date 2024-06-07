using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Kursova.Models;

namespace Kursova
{
    public static class DataAccess
    {
        //private static readonly string filePath = @"C:\Users\Kirill\Desktop\criminals.txt"; // Змінити шлях!!
        //private static readonly string filePathCriminalGroups = @"C:\Users\Kirill\Desktop\crimeGroups.txt"; // Змінити шлях!!
        private static readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "criminals.txt");
        private static readonly string filePathCriminalGroups = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "crimeGroups.txt");

        public static string FilePath 
        {
            get { return filePath; }
        }

        public static string FilePathCriminalGroups
        {
            get { return filePathCriminalGroups; }
        }

        public static List<Criminal> ReadCriminalsFromFile()
        {
            var criminals = new List<Criminal>();
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var fields = line.Split('|');
                    if (fields.Length >= 15)
                    {
                        var criminal = new Criminal(
                            int.Parse(fields[0]),
                            fields[1],
                            fields[2],
                            fields[3],
                            int.Parse(fields[4]),
                            fields[5],
                            fields[6],
                            fields[7],
                            fields[8],
                            fields[9],
                            DateOnly.Parse(fields[10]),
                            fields[11],
                            fields[12],
                            fields[13],
                            Convert.ToBoolean(fields[14]),
                            fields.Length >= 16 && fields[15].Length > 0 ? int.Parse(fields[15]) : null
                        );
                        criminals.Add(criminal);
                    }
                }
            }
            return criminals;
        }

        public static void WriteCriminalsToFile(List<Criminal> criminals)
        {
            var lines = new List<string>();
            foreach (var criminal in criminals)
            {
                var line = string.Join("|",
                    criminal.Id,
                    criminal.FirstName,
                    criminal.LastName,
                    criminal.Nickname,
                    criminal.Height,
                    criminal.HairColor,
                    criminal.EyeColor,
                    criminal.SpecialMarks,
                    criminal.Citizenship,
                    criminal.BirthPlace,
                    criminal.BirthDate.ToString("yyyy-MM-dd"),
                    criminal.LastResidence,
                    //string.Join(",", criminal.Languages),
                    criminal.LanguagesString,
                    criminal.CriminalProfession,
                    criminal.Archive,
                    criminal.CrimeGroupId != null ? criminal.CrimeGroupId : ""
                );
                lines.Add(line);
            }
            File.WriteAllLines(filePath, lines);
        }

        public static List<CrimeGroup> ReadCrimeGroupsFromFile()
        {
            var crimeGroups = new List<CrimeGroup>();
            if (File.Exists(filePathCriminalGroups))
            {
                var lines = File.ReadAllLines(filePathCriminalGroups);
                foreach (var line in lines)
                {
                    var fields = line.Split('|');
                    if (fields.Length >= 2)
                    {
                        var crimeGroup = new CrimeGroup(
                            int.Parse(fields[0]),
                            fields[1]
                        );
                        crimeGroups.Add(crimeGroup);
                    }
                }
            }
            return crimeGroups;
        }

        public static void WriteCrimeGroupsToFile(List<CrimeGroup> crimeGroups)
        {
            var lines = new List<string>();
            foreach (var criminal in crimeGroups)
            {
                var line = string.Join("|",
                    criminal.Id,
                    criminal.Name
                );
                lines.Add(line);
            }
            File.WriteAllLines(filePathCriminalGroups, lines);
        }
    }
}

