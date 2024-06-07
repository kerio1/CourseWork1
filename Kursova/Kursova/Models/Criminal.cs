using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    public class Criminal
    {
        private int id;
        private string lastName;
        private string firstName;
        private string nickname;
        private int height;
        private string hairColor;
        private string eyeColor;
        private string specialMarks;
        private string citizenship;
        private string birthPlace;
        private DateOnly birthDate;
        private string lastResidence;
        //private List<string> languages;
        private string criminalProfession;
        private bool archive;
        private int? crimeGroupId;

        private string languagesString;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public string HairColor
        {
            get { return hairColor; }
            set { hairColor = value; }
        }

        public string EyeColor
        {
            get { return eyeColor; }
            set { eyeColor = value; }
        }

        public string SpecialMarks
        {
            get { return specialMarks; }
            set { specialMarks = value; }
        }

        public string Citizenship
        {
            get { return citizenship; }
            set { citizenship = value; }
        }

        public string BirthPlace
        {
            get { return birthPlace; }
            set { birthPlace = value; }
        }

        public DateOnly BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        public string LastResidence
        {
            get { return lastResidence; }
            set { lastResidence = value; }
        }

        //public List<string> Languages
        //{
        //    get { return languages; }
        //    set { languages = value; }
        //}

        public string LanguagesString
        {
            get { return languagesString; }
            set { languagesString = value; }//+
        }

        public string CriminalProfession
        {
            get { return criminalProfession; }
            set { criminalProfession = value; }
        }

        public bool Archive
        {
            get { return archive; }
            set { archive = value; }
        }

        public int? CrimeGroupId
        {
            get { return crimeGroupId; }
            set { crimeGroupId = value; }
        }

        //public Criminal(int id, string firstName, string lastName, string nickname, int height, string hairColor, string eyeColor, string specialMarks, string citizenship, string birthPlace, DateOnly birthDate, string lastResidence, List<string> languages, string criminalProfession, bool archive = false)
        public Criminal(int id, string firstName, string lastName, string nickname, int height, string hairColor, string eyeColor, string specialMarks, 
            string citizenship, string birthPlace, DateOnly birthDate, string lastResidence, string languagesString, string criminalProfession, 
            bool archive = false, int? crimeGroupId = null)
        {
            this.id = id;
            this.lastName = lastName;
            this.firstName = firstName;
            this.nickname = nickname;
            this.height = height;
            this.hairColor = hairColor;
            this.eyeColor = eyeColor;
            this.specialMarks = specialMarks;
            this.citizenship = citizenship;
            this.birthPlace = birthPlace;
            this.birthDate = birthDate;
            this.lastResidence = lastResidence;
            //this.languages = languages;
            this.criminalProfession = criminalProfession;
            this.archive = archive;

            //this.languagesString = String.Join(',', this.languages);
            this.languagesString = languagesString;

            this.crimeGroupId = crimeGroupId;
        }
    }
}