using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using MendelejewNsp.Models;

namespace MendelejewNsp.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Lista pierwiastków do wyświetlenia
        /// </summary>
        readonly List<ElementViewModel> allElements;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public HomeController()
        {
            //zainicjowanie listy
            allElements = new List<ElementViewModel>();
            //wywołanie metody uzupełniającej listę pierwiastków
            FillElements();
        }
        /// <summary>
        /// Metoda uzupełniająca listę pierwiastków
        /// </summary>
        private void FillElements()
        {
            allElements.Add(new ElementViewModel("H", "Wodór", "Hydrogenium", 1, 1, "1766", 0.0000899, "nonMetal"));
            allElements.Add(new ElementViewModel("He", "Hel", "Helium", 2, 4, "1895", 0.00017846, "nobleGas"));

            allElements.Add(new ElementViewModel("Li", "Lit", "Lithium", 3, 7, "1817", 0.534, "alcaic"));
            allElements.Add(new ElementViewModel("Be", "Beryl", "Beryllium", 4, 9, "1798", 1.848, "earthAlcaic"));
            allElements.Add(new ElementViewModel("B", "Bor", "Boron", 5, 11, "1808", 2.34, "metaloid"));
            allElements.Add(new ElementViewModel("C", "Węgiel", "Carbon", 6, 12, "Głęboka starożytność", 2.26, "nonMetal"));
            allElements.Add(new ElementViewModel("N", "Azot", "Nitrogen", 7, 14, "1772", 0.001251, "nonMetal"));
            allElements.Add(new ElementViewModel("O", "Tlen", "Oxygen", 8, 16, "1774", 0.00142897, "nonMetal"));
            allElements.Add(new ElementViewModel("F", "Fluor", "Fluorine", 9, 19, "1886", 0.001696, "halogen"));
            allElements.Add(new ElementViewModel("Ne", "Neon", "Neon", 10, 20, "1898", 0.0009, "nobleGas"));

            allElements.Add(new ElementViewModel("Na", "Sód", "Natrium", 11, 23, "1807", 0.971, "alcaic"));
            allElements.Add(new ElementViewModel("Mg", "Magnez", "Magnesium", 12, 24, "1808", 1.738, "earthAlcaic"));
            allElements.Add(new ElementViewModel("Al", "Glin", "Aluminium", 13, 27, "1825", 2.7, "semiConductor"));
            allElements.Add(new ElementViewModel("Si", "Krzem", "Silicium", 14, 28, "1824", 2.33, "metaloid"));
            allElements.Add(new ElementViewModel("P", "Fosfor", "Phosphorus", 15, 31, "1669", 2.82, "nonMetal"));
            allElements.Add(new ElementViewModel("S", "Siarka", "Sulphuris", 16, 32, "600 p.n.e.", 2.07, "nonMetal"));
            allElements.Add(new ElementViewModel("Cl", "Chlor", "Chlorum", 17, 35, "1774", 0.003214, "halogen"));
            allElements.Add(new ElementViewModel("Ar", "Argon", "Argon", 18, 40, "1894", 0.001784, "nobleGas"));

            allElements.Add(new ElementViewModel("K", "Potas", "Kalium", 19, 39, "1807", 0.856, "alcaic"));
            allElements.Add(new ElementViewModel("Ca", "Wapń", "Calcium", 20, 40, "1808", 1.55, "earthAlcaic"));
            allElements.Add(new ElementViewModel("Sc", "Skand", "Scandium", 21, 45, "1879", 2.99, "transitionMetal"));
            allElements.Add(new ElementViewModel("Ti", "Tytan", "Titanium", 22, 48, "1795", 4.54, "transitionMetal"));
            allElements.Add(new ElementViewModel("V", "Wanad", "Vanadium", 23, 51, "1830", 6.11, "transitionMetal"));
            allElements.Add(new ElementViewModel("Cr", "Chrom", "Chromium", 24, 52, "1797", 7.19, "transitionMetal"));
            allElements.Add(new ElementViewModel("Mn", "Mangan", "Manganum", 25, 20, "1774", 7.21, "transitionMetal"));
            allElements.Add(new ElementViewModel("Fe", "Żelazo", "Ferrum", 26, 56, "1735", 7.88, "transitionMetal"));
            allElements.Add(new ElementViewModel("Co", "Kobalt", "Cobaltum", 27, 59, "1735", 8.9, "transitionMetal"));
            allElements.Add(new ElementViewModel("Ni", "Nikiel", "Niccolum", 28, 59, "1751", 8.9, "transitionMetal"));
            allElements.Add(new ElementViewModel("Cu", "Miedź", "Cuprum", 29, 64, "Głęboka starożytność", 8.92, "transitionMetal"));
            allElements.Add(new ElementViewModel("Zn", "Cynk", "Zincum", 30, 65, "1300 - 100 p.n.e.", 7.133, "transitionMetal"));
            allElements.Add(new ElementViewModel("Ga", "Gal", "Gallium", 31, 69, "1875", 5.91, "semiConductor"));
            allElements.Add(new ElementViewModel("Ge", "German", "Germanium", 32, 73, "1886", 5.323, "metaloid"));
            allElements.Add(new ElementViewModel("As", "Arsen", "Arsenicum", 33, 75, "1250", 5.72, "metaloid"));
            allElements.Add(new ElementViewModel("Se", "Selen", "Selenium", 34, 79, "1817", 4.79, "nonMetal"));
            allElements.Add(new ElementViewModel("Br", "Brom", "Bromum", 35, 80, "1826", 3.14, "halogen"));
            allElements.Add(new ElementViewModel("Kr", "Krypton", "Krypton", 36, 84, "1898", 0.003749, "nobleGas"));

            allElements.Add(new ElementViewModel("Rb", "Rubid", "Rubidium", 37, 85, "1861", 1.53, "alcaic"));
            allElements.Add(new ElementViewModel("Sr", "Stront", "Strontium", 38, 88, "1790", 2.54, "earthAlcaic"));
            allElements.Add(new ElementViewModel("Y", "Itr", "Yttrium", 39, 89, "1794", 4.47, "transitionMetal"));
            allElements.Add(new ElementViewModel("Zr", "Cyrkon", "Zirconium", 40, 91, "1789", 6.51, "transitionMetal"));
            allElements.Add(new ElementViewModel("Nb", "Niob", "Niobium", 41, 93, "1801", 8.58, "transitionMetal"));
            allElements.Add(new ElementViewModel("Mo", "Molibden", "Molybdaenum", 42, 96, "1778", 10.22, "transitionMetal"));
            allElements.Add(new ElementViewModel("Tc", "Technet", "Technetium", 43, 98, "1937", 11.49, "transitionMetal"));
            allElements.Add(new ElementViewModel("Ru", "Ruten", "Ruthenium", 44, 101, "1844", 12.41, "transitionMetal"));
            allElements.Add(new ElementViewModel("Rh", "Rod", "Rhodium", 45, 103, "1804", 12.41, "transitionMetal"));
            allElements.Add(new ElementViewModel("Pd", "Pallad", "Palladium", 46, 106, "1803", 12.02, "transitionMetal"));
            allElements.Add(new ElementViewModel("Ag", "Srebro", "Argentum", 47, 108, "Głęboka starożytność", 10.49, "transitionMetal"));
            allElements.Add(new ElementViewModel("Cd", "Kadm", "Cadmium", 48, 112, "1817", 8.64, "transitionMetal"));
            allElements.Add(new ElementViewModel("In", "Ind", "Indium", 49, 115, "1863", 7.31, "semiConductor"));
            allElements.Add(new ElementViewModel("Sn", "Cyna", "Stannum", 50, 119, "Głęboka starożytność", 7.29, "semiConductor"));
            allElements.Add(new ElementViewModel("Sb", "Antymon", "Stibium", 51, 121, "< 300 p.n.e.", 6.69, "metaloid"));
            allElements.Add(new ElementViewModel("Te", "Tellur", "Tellurium", 52, 127, "1782", 6.25, "metaloid"));
            allElements.Add(new ElementViewModel("I", "Jod", "Iodium", 53, 127, "1811", 4.94, "halogen"));
            allElements.Add(new ElementViewModel("Xe", "Ksenon", "Xenon", 54, 131, "1898", 0.005894, "nobleGas"));

            allElements.Add(new ElementViewModel("Cs", "Cez", "Caesium", 55, 133, "1860", 1.9, "alcaic"));
            allElements.Add(new ElementViewModel("Ba", "Bar", "Barium", 56, 137, "1774", 3.5, "earthAlcaic"));
            allElements.Add(new ElementViewModel("Hf", "Hafin", "Hafnium", 72, 178, "1923", 13.31, "transitionMetal"));
            allElements.Add(new ElementViewModel("Ta", "Tantal", "Tantalum", 73, 181, "1802", 16.68, "transitionMetal"));
            allElements.Add(new ElementViewModel("W", "Wolfram", "Wolframium", 74, 183, "1781", 19.26, "transitionMetal"));
            allElements.Add(new ElementViewModel("Re", "Ren", "Rhenium", 75, 186, "1925", 21.03, "transitionMetal"));
            allElements.Add(new ElementViewModel("Os", "Osm", "Osmium", 76, 190, "1804", 22.587, "transitionMetal"));
            allElements.Add(new ElementViewModel("Ir", "Iryd", "Iridium", 77, 192, "1804", 22.562, "transitionMetal"));
            allElements.Add(new ElementViewModel("Pt", "Platyna", "Platinum", 78, 195, "1735", 21.45, "transitionMetal"));
            allElements.Add(new ElementViewModel("Au", "Złoto", "Aurum", 79, 197, "Głęboka starożytność", 19.3, "transitionMetal"));
            allElements.Add(new ElementViewModel("Hg", "Rtęć", "Hydrargyrum", 80, 201, "< 1500 p.n.e", 13.55, "transitionMetal"));
            allElements.Add(new ElementViewModel("Tl", "Tal", "Thallium", 81, 204, "1861", 11.85, "semiConductor"));
            allElements.Add(new ElementViewModel("Pb", "Ołów", "Plumbum", 82, 207, "Głęboka starożytność", 11.34, "semiConductor"));
            allElements.Add(new ElementViewModel("Bi", "Bizmut", "Bisemutum", 83, 209, "1450", 9.8, "semiConductor"));
            allElements.Add(new ElementViewModel("Po", "Polon", "Polonium", 84, 209, "1898", 9.2, "metaloid"));
            allElements.Add(new ElementViewModel("At", "Astat", "Astatum", 85, 210, "1940", 6.4, "halogen"));
            allElements.Add(new ElementViewModel("Rn", "Radon", "Radon", 86, 222, "1900", 0.0098, "nobleGas"));


            allElements.Add(new ElementViewModel("Fr", "Frans", "Francium", 87, 223, "1939", 2.48, "alcaic"));
            allElements.Add(new ElementViewModel("Ra", "Rad", "Radium", 88, 226, "1898", 5.5, "earthAlcaic"));
            allElements.Add(new ElementViewModel("Rf", "Rutherford", "Ruthenfordium", 104, 267, "1964", 23, "transitionMetal"));
            allElements.Add(new ElementViewModel("Db", "Dubn", "Dubnium", 105, 268, "1968", 29, "transitionMetal"));
            allElements.Add(new ElementViewModel("Sg", "Seaborg", "Seaborgium", 106, 271, "1974", 35, "transitionMetal"));
            allElements.Add(new ElementViewModel("Bh", "Bohr", "Bohrium", 107, 272, "1981", 37, "transitionMetal"));
            allElements.Add(new ElementViewModel("Hs", "Has", "Hassium", 108, 270, "1984", 0, "transitionMetal"));
            allElements.Add(new ElementViewModel("Mt", "Meitner", "Meitnerium", 109, 276, "1982", 37.4, "transitionMetal"));
            allElements.Add(new ElementViewModel("Ds", "Darmsztadt", "Darmstadtium", 110, 281, "1994", 34.8, "transitionMetal"));
            allElements.Add(new ElementViewModel("Rg", "Roentgen", "Roentgenium", 111, 280, "1994", 20, "transitionMetal"));
            allElements.Add(new ElementViewModel("Cn", "Kopernik", "Copernecium", 112, 285, "1996", 16, "transitionMetal"));
            allElements.Add(new ElementViewModel("Nh", "Nihonium", "Nihonium", 113, 286, "2004", 14, "semiConductor"));
            allElements.Add(new ElementViewModel("Fl", "Flerow", "Flerovium", 114, 289, "1998", 0.00142897, "semiConductor"));
            allElements.Add(new ElementViewModel("Mc", "Moscovium", "Moscovium", 115, 289, "2003", 13.5, "semiConductor"));
            allElements.Add(new ElementViewModel("Lv", "Liwermor", "Livermorium", 116, 293, "2000", 0, "semiConductor"));
            allElements.Add(new ElementViewModel("Ts", "Tennessine", "Tennessine", 117, 294, "2010", 0, "halogen"));
            allElements.Add(new ElementViewModel("Og", "Oganesson", "Oganneson", 118, 294, "2002 - 2005", 5, "nobleGas"));

            allElements.Add(new ElementViewModel("La", "Lantan", "Lanthanum", 57, 139, "1939", 6.16, "lanthanoid"));
            allElements.Add(new ElementViewModel("Ce", "Cer", "Cerium", 58, 140, "1803", 6.77, "lanthanoid"));
            allElements.Add(new ElementViewModel("Pr", "Prazeodym", "Praseodymium", 59, 141, "1885", 6.773, "lanthanoid"));
            allElements.Add(new ElementViewModel("Nd", "Neodym", "Nedoymium", 60, 144, "1885", 7, "lanthanoid"));
            allElements.Add(new ElementViewModel("Pm", "Promet", "Promethium", 61, 145, "1945", 7.2, "lanthanoid"));
            allElements.Add(new ElementViewModel("Sm", "Samar", "Samarium", 62, 150, "1979", 7.54, "lanthanoid"));
            allElements.Add(new ElementViewModel("Eu", "Europ", "Europium", 63, 152, "1901", 5.25, "lanthanoid"));
            allElements.Add(new ElementViewModel("Gd", "Gadolin", "Gadolinium", 64, 157, "1886", 7.89, "lanthanoid"));
            allElements.Add(new ElementViewModel("Tb", "Terb", "Terbium", 65, 159, "1843", 8.25, "lanthanoid"));
            allElements.Add(new ElementViewModel("Dy", "Dysproz", "Dysprosium", 66, 162, "1886", 8.56, "lanthanoid"));
            allElements.Add(new ElementViewModel("Ho", "Holm", "Holium", 67, 165, "1878", 8.78, "lanthanoid"));
            allElements.Add(new ElementViewModel("Er", "Erb", "Erbium", 68, 167, "1842", 9.05, "lanthanoid"));
            allElements.Add(new ElementViewModel("Tm", "Tul", "Thullium", 69, 169, "1879", 9.32, "lanthanoid"));
            allElements.Add(new ElementViewModel("Yb", "Iterb", "Ytterbium", 70, 173, "1878", 6.97, "lanthanoid"));
            allElements.Add(new ElementViewModel("Lu", "Lutet", "Lutetium", 71, 175, "1907", 9.84, "lanthanoid"));

            allElements.Add(new ElementViewModel("Ac", "Aktyn", "Actinium", 89, 227, "1899", 10.07, "actinide"));
            allElements.Add(new ElementViewModel("Th", "Tor", "Thorium", 90, 232, "1828", 11.72, "actinide"));
            allElements.Add(new ElementViewModel("Pa", "Proaktyn", "Protactinium", 91, 231, "1918", 15.37, "actinide"));
            allElements.Add(new ElementViewModel("U", "Uran", "Uranium", 92, 238, "1789", 19.05, "actinide"));
            allElements.Add(new ElementViewModel("Np", "Neptun", "Neptunium", 93, 237, "1940", 20.48, "actinide"));
            allElements.Add(new ElementViewModel("Pu", "Pluton", "Plutonium", 94, 244, "1940", 19.74, "actinide"));
            allElements.Add(new ElementViewModel("Am", "Ameryk", "Americium", 95, 243, "1944", 13.67, "actinide"));
            allElements.Add(new ElementViewModel("Cm", "Kiur", "Curium", 96, 247, "1944", 13.51, "actinide"));
            allElements.Add(new ElementViewModel("Bk", "Berkel", "Berkelium", 97, 247, "1949", 13.25, "actinide"));
            allElements.Add(new ElementViewModel("Cf", "Kaliforn", "Californium", 98, 251, "1950", 15.1, "actinide"));
            allElements.Add(new ElementViewModel("Es", "Einstein", "Einsteinium", 99, 252, "1952", 13.5, "actinide"));
            allElements.Add(new ElementViewModel("Fm", "Ferm", "Fermium", 100, 257, "1952", 19.05, "actinide"));
            allElements.Add(new ElementViewModel("Md", "Mendelew", "Mendelevium", 101, 258, "1955", 0, "actinide"));
            allElements.Add(new ElementViewModel("No", "Nobel", "Nobelium", 102, 259, "1965", 0, "actinide"));
            allElements.Add(new ElementViewModel("Lr", "Lorens", "Lawrencium", 103, 262, "1961", 0, "actinide"));
        }

        /// <summary>
        /// Strona główna
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Strona z układem okresowym
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ElementsTable()
        {
            return View(this.allElements);
        }

        /// <summary>
        /// Strona z niemetalami
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetNonMetals()
        {
            List<ElementViewModel> allNonMetals = allElements.Where(a => a.Type == "nonMetal").ToList();
            return View(allNonMetals);
        }

        /// <summary>
        /// Stron z alkaloidami
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAlcaicMetals()
        {
            List<ElementViewModel> allAclaicMetals = allElements.Where(a => a.Type == "alcaic").ToList();
            return View(allAclaicMetals);
        }

        /// <summary>
        /// Strona z metalami ziem alkaicznych
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetEarthAlcaicMetals()
        {
            List<ElementViewModel> allEarthAclaicMetals = allElements.Where(a => a.Type == "earthAlcaic").ToList();
            return View(allEarthAclaicMetals);
        }

        /// <summary>
        /// Strona z metalami przejściowymi
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetTransitionMetals()
        {
            List<ElementViewModel> allTransitionMetals = allElements.Where(a => a.Type == "transitionMetal").ToList();
            return View(allTransitionMetals);
        }

        /// <summary>
        /// Strona z metaloidami
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetMetaloids()
        {
            List<ElementViewModel> allmetaloid = allElements.Where(a => a.Type == "metaloid").ToList();
            return View(allmetaloid);
        }

        /// <summary>
        /// Strona z półprzewodnikami
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetSemiConductors()
        {
            List<ElementViewModel> allSemiConductors = allElements.Where(a => a.Type == "semiConductor").ToList();
            return View(allSemiConductors);
        }

        /// <summary>
        /// Strona z halogenami
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetHalogens()
        {
            List<ElementViewModel> allHalogens = allElements.Where(a => a.Type == "halogen").ToList();
            return View(allHalogens);
        }

        /// <summary>
        /// Strona z gazami szlachetnymi
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetNobleGases()
        {
            List<ElementViewModel> allNobleGases = allElements.Where(a => a.Type == "nobleGas").ToList();
            return View(allNobleGases);
        }

        /// <summary>
        /// Strona z lantanowcami
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetLanthanoids()
        {
            List<ElementViewModel> allLanthanoids = allElements.Where(a => a.Type == "lanthanoid").ToList();
            return View(allLanthanoids);
        }

        /// <summary>
        /// Strona z aktynowcami
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetActinides()
        {
            List<ElementViewModel> allActinides = allElements.Where(a => a.Type == "actinide").ToList();
            return View(allActinides);
        }

        /// <summary>
        /// Strona do wyświetlenia szczegółów dotyczących pierwiastka
        /// </summary>
        /// <param name="elementShotName"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetElement(string elementShotName)
        {
            //przeszukanie listy w celu znalezienia pasującego pierwiastka pod względem symbolu
            ElementViewModel element = this.allElements.Where(a => a.ShortName.ToLower() == elementShotName.ToLower()).FirstOrDefault();
            return View(element);
        }

        /// <summary>
        /// Strona z formularzem do uzupełnienia nazw nowego pierwiastka i wyświetlenia kolejnego okna
        /// </summary>
        /// <param name="newElement"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult NewElementFormNames(ElementViewModel newElement)
        {
            //wykorzystanie temp data do przeniesienia informacji o wybranych nazwach do kolejngo widoku
            TempData["elementName"] = newElement;
            return View("NewElementFormNumbers");
        }

        /// <summary>
        /// Strona z formularzem do uzupełnienia nazw nowego pierwiastka
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult NewElementFormNames()
        {
            return View();
        }

        /// <summary>
        /// Strona z fromularzem do uzupełnienia liczb charakteryzujących nowy pierwiastek i wyświetlenia kolejnego okna
        /// </summary>
        /// <param name="newElement"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult NewElementFormNumbers(ElementViewModel newElement)
        {
            //wykorzystanie temp data do przeniesienia informacji o wybranych nazwach do kolejngo widoku
            TempData["element"] = newElement;
            return View("CreatedElement");
        }
        /// <summary>
        /// Strona z fromularzem do uzupełnienia kontaktu
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult ContactForm()
        {
            return View();
        }

        /// <summary>
        /// Strona wyświetlająca informacje dotyczące kontaktu po uzupełnieniu formularza
        /// </summary>
        /// <param name="userData"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult ContactForm(ContactFormViewModel userData)
        {
            string fullName = userData.FirstName + " " + userData.LastName;
            ViewBag.UserName = fullName;
            return View("ContactSummary");
        }

        /// <summary>
        /// Wyświetlenie informacji o błędzie
        /// </summary>
        /// <returns></returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}