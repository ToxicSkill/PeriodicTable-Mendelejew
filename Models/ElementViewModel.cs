namespace MendelejewNsp.Models
{
    public class ElementViewModel
    {
        /// <summary>
        /// Konstruktor ze wszytskimi zmiennymi
        /// </summary>
        /// <param name="shortName"></param>
        /// <param name="name"></param>
        /// <param name="latinName"></param>
        /// <param name="atomicNumber"></param>
        /// <param name="massNumber"></param>
        /// <param name="yearOfDiscover"></param>
        /// <param name="density"></param>
        /// <param name="type"></param>
        public ElementViewModel(string shortName, string name, string latinName, int atomicNumber, int massNumber,
            string yearOfDiscover, double density, string type)
        {
            this.ShortName = shortName;
            this.Name = name;
            this.LatinName = latinName;
            this.AtomicNumber = atomicNumber;
            this.MassNumber = massNumber;
            this.YearOfDiscover = yearOfDiscover;
            this.Protons = atomicNumber;
            //liczba neutronów to liczba masowa pomniejszona o protony
            this.Neutrons = this.MassNumber - this.Protons;
            this.Density = density;
            this.Type = type;
        }
        /// <summary>
        /// pusty konstrukor (dla formularza dla nowego pierwiastka)
        /// </summary>
        public ElementViewModel()
        {

        }
        /// <summary>
        /// Symbol pierwiastka
        /// </summary>
        public string ShortName { get; set; }

        /// <summary>
        /// Pełna nazwa 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Łacińska nazwa 
        /// </summary>
        public string LatinName { get; set; }

        /// <summary>
        /// Liczba atomowa
        /// </summary>
        public int AtomicNumber { get; set; }

        /// <summary>
        /// Liczba masowa
        /// </summary>
        public int MassNumber { get; set; }

        /// <summary>
        /// Rok odkrycia
        /// </summary>
        public string YearOfDiscover { get; set; }

        /// <summary>
        /// Liczba protonów
        /// </summary>
        public int Protons { get; set; }

        /// <summary>
        /// Liczba neutronów
        /// </summary>
        public int Neutrons { get; set; }

        /// <summary>
        /// Gęstość
        /// </summary>
        public double Density { get; set; }

        /// <summary>
        /// Rodzaj
        /// </summary>
        public string Type { get; set; }
    }
}