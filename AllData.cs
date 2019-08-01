using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodicTable
{
    class AllData
    {
        public Bitmap[] images = {null,
            Properties.Resources.e1, Properties.Resources.e2, Properties.Resources.e3, Properties.Resources.e4, Properties.Resources.e5, Properties.Resources.e6, Properties.Resources.e7, Properties.Resources.e8, Properties.Resources.e9, Properties.Resources.e10,
            Properties.Resources.e11, Properties.Resources.e12, Properties.Resources.e13, Properties.Resources.e14, Properties.Resources.e15, Properties.Resources.e16, Properties.Resources.e17, Properties.Resources.e18, Properties.Resources.e19, Properties.Resources.e20,
            Properties.Resources.e21, Properties.Resources.e22, Properties.Resources.e23, Properties.Resources.e24, Properties.Resources.e25, Properties.Resources.e26, Properties.Resources.e27, Properties.Resources.e28, Properties.Resources.e29, Properties.Resources.e30,
            Properties.Resources.e31, Properties.Resources.e32, Properties.Resources.e33, Properties.Resources.e34, Properties.Resources.e35, Properties.Resources.e36, Properties.Resources.e33, Properties.Resources.e38, Properties.Resources.e39, Properties.Resources.e40,
            Properties.Resources.e41, Properties.Resources.e42, Properties.Resources.e43, Properties.Resources.e44, Properties.Resources.e45, Properties.Resources.e46, Properties.Resources.e47, Properties.Resources.e48, Properties.Resources.e49, Properties.Resources.e50,
            Properties.Resources.e51, Properties.Resources.e52, Properties.Resources.e53, Properties.Resources.e54, Properties.Resources.e55, Properties.Resources.e56, Properties.Resources.e57, Properties.Resources.e8, Properties.Resources.e59, Properties.Resources.e60,
            Properties.Resources.e61, Properties.Resources.e62, Properties.Resources.e63, Properties.Resources.e64, Properties.Resources.e65, Properties.Resources.e66, Properties.Resources.e67, Properties.Resources.e8, Properties.Resources.e69, Properties.Resources.e70,
            Properties.Resources.e71, Properties.Resources.e72, Properties.Resources.e73, Properties.Resources.e74, Properties.Resources.e75, Properties.Resources.e76, Properties.Resources.e77, Properties.Resources.e8, Properties.Resources.e79, Properties.Resources.e80,
            Properties.Resources.e81, Properties.Resources.e82, Properties.Resources.e83, Properties.Resources.e84, null, Properties.Resources.e86, null, Properties.Resources.e8, Properties.Resources.e89, Properties.Resources.e90,
            Properties.Resources.e91, Properties.Resources.e92, Properties.Resources.e93, Properties.Resources.e94, Properties.Resources.e95, Properties.Resources.e96, Properties.Resources.e97, Properties.Resources.e8, Properties.Resources.e99, null,
            null, null, null, null, null, null, null, null, null, null, null
        };

        public string[] inventor = {"",
            "Henry Cavendish", "Pierre Janssen, Norman Lockyer", "Johan August Arfwedson", "Louis Nicolas Vauquelin", "Joseph Louis Gay-Lussac and Louis Jacques", "Egyptians and Sumerians", "Daniel Rutherford", "Carl Wilhelm Scheele", "André-Marie Ampère", "William Ramsay & Morris Travers",
            "Humphry Davy", "Joseph Black", "Antoine Lavoisier", "Jöns Jacob Berzelius", "Hennig Brand", "Chinese", "Carl Wilhelm Scheele", "Lord Rayleigh and William Ramsay ", "Humphry Davy", "Humphry Davy",
            "Lars Fredrik Nilson", "William Gregor", "Andrés Manuel del Río", "Louis Nicolas Vauquelin", "Carl Wilhelm Scheele", "", "Georg Brandt", "Axel Fredrik Cronstedt", "Middle East", "Indian metallurgists",
            "Lecoq de Boisbaudran", "Clemens Winkler", "Early Bronze Age", "Jöns Jakob Berzelius and Johann Gottlieb Gahn", "Antoine Jérôme Balard and Carl Jacob Löwig ", "William Ramsay and Morris Travers", "Robert Bunsen and Gustav Kirchhoff", "William Cruickshank", "Johan Gadolin", "Martin Heinrich Klaproth",
            "Charles Hatchett","Carl Wilhelm Scheele","Emilio Segrè and Carlo Perrier","Karl Ernst Claus","William Hyde Wollaston ","William Hyde Wollaston","","Karl Samuel Leberecht Hermann and Friedrich Stromeyer"," 	Ferdinand Reich and Hieronymous Theodor Richter","",
            "","Franz-Joseph Müller von Reichenstein","Bernard Courtois","William Ramsay and Morris Travers","Robert Bunsen and Gustav Kirchhoff","Carl Wilhelm Scheele","Carl Gustaf Mosander","Martin Heinrich Klaproth, Jöns Jakob Berzelius, Wilhelm Hisinger","Carl Auer von Welsbach","Carl Auer von Welsbach",
            "Chien Shiung Wu, Emilio Segrè, Hans Bethe","Lecoq de Boisbaudran","Eugène-Anatole Demarçay","Jean Charles Galissard de Marignac","Carl Gustaf Mosander","Lecoq de Boisbaudran","Jacques-Louis Soret","Carl Gustaf Mosander","Per Teodor Cleve","Jean Charles Galissard de Marignac",
            "Carl Auer von Welsbach and Georges Urbain","Dirk Coster and George de Hevesy","Anders Gustaf Ekeberg","Carl Wilhelm Scheele","Masataka Ogawa","Smithson Tennant","Smithson Tennant","Antonio de Ulloa","In the Middle East","Ancient Chinese and Indians",
            "William Crookes","Middle Easterns","Claude François Geoffroy","Pierre and Marie Curie ","Dale R. Corson, Kenneth Ross MacKenzie, Emilio Segrè ","Ernest Rutherford and Robert B. Owens","Marguerite Perey","Pierre and Marie Curie","Friedrich Oskar Giesel","Jöns Jakob Berzelius",
            "Kasimir Fajans and Oswald Helmuth Göhring","Martin Heinrich Klaproth","Edwin McMillan and Philip H. Abelson","Glenn T. Seaborg, Arthur Wahl, Joseph W. Kennedy, Edwin McMillan","Glenn T. Seaborg, Ralph A. James, Leon O. Morgan, Albert Ghiorso","Glenn T. Seaborg, Ralph A. James, Albert Ghiorso","Lawrence Berkeley National Laboratory","Lawrence Berkeley National Laboratory","Lawrence Berkeley National Laboratory","Lawrence Berkeley National Laboratory",
            "Lawrence Berkeley National Laboratory","Joint Institute for Nuclear Research","Lawrence Berkeley National Laboratory and Joint Institute for Nuclear Research","Joint Institute for Nuclear Research and Lawrence Berkeley National Laboratory","independently by the University of California and the Joint Institute for Nuclear Research","Lawrence Berkeley National Laboratory","Gesellschaft für Schwerionenforschung","Gesellschaft für Schwerionenforschung","Gesellschaft für Schwerionenforschung","Gesellschaft für Schwerionenforschung","Gesellschaft für Schwerionenforschung" };

        public string[] symble = {"",
            "H","He","Li","Be","B","C","N","O","F","Ne","Na","Mg","Al","Si","P","S","Cl","Ar","K","Ca","Sc","Ti","V","Cr","Mn",
            "Fe","Co","Ni","Cu","Zn","Ga","Ge","As","Se","Br","Kr","Rb","Sr","Y","Zr","Nb","Mo","Tc","Ru","Rh","Pd","Ag","Cd","In","Sn",
            "Sb","Te","I","Xe","Cs","Ba","La","Ce","Pr","Nd","Pm","Sm","Eu","Gd","Tb","Dy","Ho","Er","Tm","Yb","Lu","Hf","Ta","W","Re",
            "Os","Ir","Pt","Au","Hg","Tl","Pb","Bi","Po","At","Rn","Fr","Ra","Ac","Th","Pa","U","Np","Pu","Am","Cm","Bk","Cf","Es","Fm",
            "Md","No","Lr","Rf","Db","Sg","Bh","Hs","Mt","Ds","Rg"};

        public string[] nameBangla = {"",
            "হাইড্রোজেন", "হিলিয়াম","লিথিয়াম", "বেরিলিয়াম", "বোরন", "কার্বন", "নাইট্রোজেন", "অক্সিজেন", "ফ্লোরিন", "নিয়ন",
            "সোডিয়াম", "ম্যাগনেসিয়াম", "অ্যালুমিনিয়াম", "সিলিকন", "ফসফরাস", "সালফার", "ক্লোরিন", "আর্গন", "পটাশিয়াম", "ক্যালশিয়াম", "স্ক্যান্ডিয়াম", "টাইটেনিয়াম",
            "ভ্যানাডিয়াম", "ক্রোমিয়াম", "ম্যাঙ্গানিজ", "আয়রন", "কোবাল্ট", "নিকেল", "কপার", "জিংক", "গ্যালিয়াম", "জার্মেনিয়াম", "আর্সেনিক", "সেলেনিয়াম", "ব্রোমিন",
            "ক্রিপটন", "রুবিডিয়াম", "স্ট্রোনসিয়াম", "ইটরিয়াম", "জারকোনিয়াম", "নায়োবিয়াম", "মলিবডেনাম", "টেকনেসিয়াম", "রুথেনিয়াম", "রোডিয়াম", "প্যালাডিয়াম",
            "সিলভার", "ক্যাডমিয়াম", "ইন্ডিয়াম", "টিন", "এন্টিমনি", "টেলুরিয়াম", "আয়োডিন", "জেনন", "সিজিয়াম", "বেরিয়াম", "ল্যান্থানাম", "সেরিয়াম", "প্রাসেওডিমিয়াম",
            "নিওডিমিয়াম","প্রোমেথিমিয়াম","সামারিয়াম","ইউরোপিয়াম","গ্যাডোলেনিয়াম","টার্বিয়াম","ডিসপ্রোসিয়াম","হলমিয়াম","আরবিয়াম","থুলিয়াম","ইটারবিয়াম","লুটেসিয়াম","হাফনিয়াম",
            "ট্যান্টেলাম","ট্যাংস্টেন","রেনিয়াম","অসমিয়াম","ইরিডিয়াম","প্লাটিনাম","গোল্ড","মার্কারি","থ্যালিয়াম","লেড","বিসমাথ","পোলোনিয়াম","আস্টেটিন","রেডন","ফ্র্যান্সিয়াম","রেডিয়াম",
            "অ্যাক্টেনিয়াম","থোরিয়াম","প্রোটোঅ্যাক্টেনিয়াম","ইউরেনিয়াম","নেপচুনিয়াম","প্লুটোনিয়াম","আমেরিসিয়াম","কুরিয়াম","বারকেলিয়াম","ক্যালিফারমিয়াম","আইনস্টেনিয়াম","ফারমিয়াম",
            "মেন্ডেলেভিয়াম","নোবেলিয়াম","লরেনসিয়াম","রাদারফোর্ডিয়াম","ডুবনিয়াম","সিওবোরগিয়াম","বোহরিয়াম","হ্যাসিয়াম","মাইটনেরিয়াম","ডারমেস্টেনিয়াম","রঞ্জেনিয়াম"};

        public string[] nameEnglish = {"",
              "Hydrogen","Helium","Lithium","Beryllium","Boron","Carbon","Nitrogen","Oxygen","Fluorine","Neon","Sodium","Magnesium",
              "Aluminium","Silicon","Phosphorus","Sulphur","Chlorine","Argon","Potassium","Calcium","Scandium","Titanium","Vanadium","Chromium","Manganese",
              "Iron","Cobalt","Nickel","Copper","Zinc","Gallium","Germanium","Arsenic","Selenium","Bromine","Krypton","Rubidium","Strontium","Yttrium","Zirconium",
              "Niobium","Molybdenum","Technetium","Ruthenium","Rhodium","Palladium","Silver","Cadmium","Indium","Tin","Antimony","Tellurium","Iodine","Xenon",
              "Caesium","Barium","Lanthanum","Cerium","Praseodimium","Neodimium","Promethium","Samarium","Europium","Gadolinium","Terbium","Dysprosium","Holmium",
              "Erbium","Thulium","Ytterbium","Lutetium","Hafnium","Tantalum","Tungsten","Rhenium","Osmium","Iridium","Platinum","Gold","Mercury","Thallium","Lead",
              "Bismuth","Polonium","Astetine","Radon","Francium","Radium","Actinium","Thorium","Protoactinium","Uranium","Neptunium","Plutonium","Americium",
              "Curium","Berkelium","Californium","Einsteinium","Fermium","Mendelevium","Nobelium","Lawrencium","Rutherfordium","Dubnium","Seaborgium","Bohrium",
              "Hassium","Meitnerium","Darmstadtium","Roentgenium"};

        public string[] electronegativity = {"",
            "2.2","0","1.0","1.5","2.0","2.5","3.1","3.5","4.1","0","1.0","1.2","1.5","1.7","2.1","2.4","2.8","0","0.9","1.0",
            "1.2","1.3","1.5","1.6","1.6","1.6","1.7","1.8","1.8","1.7","1.8","2.0","2.2","2.5","2.7","0","0.9","1.0","1.1","1.2","1.2","1.3","1.4","1.4","1.5",
            "1.4","1.4","1.5","1.5","1.7","1.8","2.0","2.2","0","0.9","1.0","1.1","1.1","1.1","1.1","1.1","1.1","1.0","1.1","1.1","1.1","1.1","1.1","1.1","1.1",
            "1.1","1.2","1.3","1.4","1.5","1.5","1.6","1.4","1.4","1.5","1.4","1.6","1.7","1.8","2.0","0","0.9","1.0","1.0","1.1","1.1","1.2","1.2","1.2","-1.2",
            "-1.2","-1.2","-1.2","-1.2","-1.2","-1.2", "","","","","","","","","","","","","","","","","","","","","","",""};

        public string[] oxidation = {"",
            "0","-1,1","0","1","2","3","-4,2,4","-3,2,3,4,5","-2,-1","-1",
            "0","1","2","3","4","-3,3,5","-2,2,4,6","-1,1,3,5,7","0","1","2","3",
            "3,4","2,3,4,5","2,3,6","2,3,4,6,7","2,3,6","2,3","2,3","1.2","2","3",
            "4","-3,3,5","-2,4,6","-1,1,3,5,7","0","1","2","3","4","3,5","2,3,4,5,6","7",
            "3,4,8","1,2,3,4","2,4","1,2","2","3","2,4","-3,3,5","-2,4,6","-1,1,3,5,7",
            "2,4,6","1","2","3","3.4","3.4","3","3","2,3","2,3","3","3,4","3","3","3",
            "2,3","2,3","3","4","5","2,3,4,5,6","2,4,7","2,3,4,6,8","1,2,3,4,6","1.4",
            "1.3","1.2","1,3","2,4","3,5","2,4,6","-1,1,3,5,7","2","1","2","3","4",
            "4.5","3,4,5,6","3,4,5,6","3,4,5,6","3,4,5,6","3,4","3,4","3,4","3","3",
            "3","2,3","3","","","","","","","",
            "","","","","","","","","","","",""
        };

        public string[] atomic_mass = {"",
            "1.008","4.003","6.94","9.012","10.81","12.011","14.007","16.00","19.00","20.18","22.99","24.30","26.982","28.086","30.974",
            "32.064","35.46","39.948","39.10","40.08","44.956","47.67","50.942","52.00","54.94","55.85","58.93","58.69","63.546","65.41","69.72","72.64","74.922",
            "78.96","79.904","83.80","85.68","87.62","88.910","91.224","92.910","95.94","99.00","101.07","102.91","106.42","107.87","112.41","114.76","118.70",
            "121.76","127.60","126.90","131.29","132.91","137.34","138.91","140.12","140.91","144.24","146.92","150.36","151.96","157.25","158.93","162.50",
            "164.93","167.26","168.93","173.04","174.97","178.49","180.95","183.84","186.21","190.23","192.22","195.08","196.97","200.59","204.38","207.20",
            "208.98","208.98","210.00","222.02","223.02","226.03","227.03","232.04","231.04","238.03","237.05","244.06","243.06","247.07","247.07","251.08",
            "252.08","257.01","258.01","259.01","262.11","261.11","262.11","262.11","266.12","264.12","277.00","268.13","271.00","272.00"};

        public string[] freezing_point = {"",
            "-259.14","-272.2","180.54","1278","2079","3387","-209.86","-218.4","-219.62","-248.67","97.81","648.8","660.37","14.10","44.1",
            "112.8","-100.98","-189.2","63.65","839","1541","1660","1890","1857","1244","1535","1495","1453","1083","419.6","29.78","937.4","817","217","-7.2",
            "-156.6","38.89","769","1522","1852","2468","2617","2172","2310","1966","1552","961.9","320.9","156.6","232","630.7","449.5","113.5","-111.9","28.40",
            "725","921","799","931","1021","1168","1077","822","1331","1356","1412","1474","1497","1545","819","1663","2227","2996","3410","3180","3045","2410",
            "1772","1064","-38.84","303.5","327.5","271.8","254","302","71","27","700","1050","1750","1600","1132","640","641","994","1340", "","","","","","",
            "","","","","","","","","","","","","","","","",""};

        public string[] meltting_point = {"",
            "-252.87","-268.93","1347","2970","2550","4827","-195.8","-182.96","-188.14","-246.05","882.9","1090","2467","2355","280",
            "444.67","-34.6","-185.7","774","1484","2831","3287","3380","2672","1962","2750","2870","2732","2567","907","2403","2830","613","684.9","58.78","-152.3",
            "688","1384","3338","4377","4742","4612","4877","3900","3727","3140","2212","765","2080","2270","1750","990","184.4","-107.1","678.4","1640","3757",
            "3426","3512","3068","2460","1791","1597","3266","3123","2562","2695","2900","1947","1194","3395","4602","5425","5660","5627","5027","4130","3827",
            "2807","356.6","1457","1740","1560","962","337","-61.8","677","1140","32000","4790","","3818","3902","3232","2607", "","","","","","","","","","","",
            "","","","","","","","","","","",""};

        public string[] location1 = {"",
            "IA","O or VIIIA","IA","IIA","IIIA","IVA","VA","VIA","VIIIA","O or VIIIA","IA","IIA","IIIA","IVA","VA","VIA","VIIA","O or VIIIA","IA",
            "IIA","IIIB","IVB","VB","VIB","VIIB","VIII","VIII","VIII","IB","IIB","IIIA","IVA","VA","VIA","VIIA","O or VIIIA","IA","IIA","IIIB","IVB","VB","VIB",
            "VIIB","VIII","VIII","VIII","IB","IIB","IIIA","IVA","VA","VIA","VIIA","O or VIIIA","IA","IIA","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB",
            "IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IVB","VB","VIB","VIIB","VIII","VIII","VIII","IB","IIB","IIIA","IVA","VA","VIA","VIIA","O or VIIIA",
            "IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IA","IIA","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB",
            "IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IVB","VB","VIB","VIIB","VIII","VIII","VIII","IB","IIB","IIIA","IVA","VA","VIA","VIIA","O or VIIIA",
            "IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB","IIIB"};

        public string[] location2 = {"",
            "1st","1st","2nd","2nd","2nd","2nd","2nd","2nd","2nd","2nd","3th","3th","3th","3th","3th","3th","3th","3th","4th","4th","4th","4th",
            "4th","4th","4th","4th","4th","4th","4th","4th","4th","4th","4th","4th","4th","4th","5th","5th","5th","5th","5th","5th","5th","5th","5th","5th","5th",
            "5th","5th","5th","5th","5th","5th","5th","6th","6th","6th","6th","6th","6th","6th","6th","6th","6th","6th","6th","6th","6th","6th","6th","6th","6th",
            "6th","6th","6th","6th","6th","6th","6th","6th","6th","6th","6th","6th","6th","6th","7th","7th","7th","7th","7th","7th","7th","7th","7th","7th",
            "7th","7th","7th","7th","7th","7th","7th","7th","7th","7th","7th","7th","7th","7th","7th"};

        public string[] blocks = {"",
            "s","s","s","s","p","p","p","p","p","p","s","s","p","p","p","p","p","p","s","s",
            "d","d","d","d","d","d","d","d","d","d","p","p","p","p","p","p","s","s","d","d",
            "d","d","d","d","d","d","d","d","p","p","p","p","p","p","s","s","f","f","f","f",
            "f","f","f","f","f","f","f","f","f","f","f","d","d","d","d","d","d","d","d","d",
            "p","p","p","p","p","p","s","s","f","f","f","f","f","f","f","f","f","f","f","f",
            "f","f","f","d","d","d","d","d","d","d","d" };

        public string[] classElement1 = {"","non metal","non metal","metal","metal","non metal","non metal","non metal","non metal","non metal","non metal","metal","metal","metal",
            "non metal","non metal","non metal","non metal","non metal","metal","metal","metal","metal","metal","metal","metal","metal","metal","metal","metal",
            "metal","metal","metal","non metal","non metal","non metal","non metal","metal","metal","metal","metal","metal","metal","metal","metal","metal",
            "metal","metal","metal","metal","metal","metal","non metal","non metal","non metal","metal","metal","metal","metal","metal","metal","metal","metal",
            "metal","metal","metal","metal","metal","metal","metal","metal","metal","metal","metal","metal","metal","metal","metal","metal","metal","metal",
            "metal","metal","metal","metal","non metal","non metal","metal","metal","metal","metal","metal","metal","metal","metal","metal","metal","metal",
            "metal","metal","metal","metal","metal","metal","metal","metal","metal","metal","metal","metal","metal","metal",};

        public string[] color = {"", "বর্ণহীন","বর্ণহীন","রূপালী-সাদা","সাদা-ধূসর","কালো-বাদামী","কালো","বর্ণহীন","বর্ণহীন","","বর্ণহীন","রুপালী-সাদা","চকচকে ধূসর","রূপালি ধূসর","","বর্ণহীন","লেবু হলুদ","ফ্যাকাশে হলুদ সবুজ","","রূপালি ধূসর","নিস্তেজ ধূসর",
            "রূপালী সাদা","রূপালি ধূসর-সাদা","নীল-রুপালী ধূসর","রূপালী ধাতব","রূপালী ধাতব","","ধূসর","","লাল কমলা","রপালি ধূসর","রূপালি-সাদা","ধুসর-সাদা","ধাতব ধুসর","কালো এবং লাল অ্যালোট্রোপ","লাল বাদামী","বর্ণহীন","ধূসর সাদা","রূপালি সাদা","রূপালী সাদা","",
            "ধূসর ধাতব","ধূসর ধাতব","","রূপালি সাদা","রূপালি সাদা","রূপালি সাদা","সাদা ধাতু","রূপালি ধূসর ধাতব","রূপালি চিকন ধূসর","রূপালি চিকন ধূসর","রূপালি চিকন ধূসর","রূপালি চিকন ধূসর","বেগুনি-অন্ধকার ধূসর","বর্ণহীন","রূপালি স্বর্ণ","রূপালি সাদা","রূপালি সাদা","রূপালি সাদা","রূপালি সাদা হরিদ্রাভ আমেজ","রূপালি সাদা হরিদ্রাভ আমেজ",
            "","রূপালি সাদা","রূপালি সাদা","রূপালি সাদা","রূপালি সাদা","রূপালি সাদা","রূপালি সাদা","রূপালি সাদা","রূপালি ধূসর","রূপালি সাদা","রূপালি সাদা","ধূসর ইস্পাত","ধূসর নীল","ধূসর সাদা","ধূসর সাদা","রূপালি, নীল নিক্ষিপ্ত","রূপালি সাদা","ধূসর সাদা","ধাতব হলুদ","রূপালি সাদা",
            "রূপালি সাদা","নীলাভ ধূসর","লালচে সাদা","","","বর্ণহীন","","রূপালি সাদা","","রূপালি সাদা","উজ্জ্বল, রূপালি ধাতব","রূপালি ধূসর ধাতব","","রূপালি সাদা","রূপালি সাদা","রূপালি","","","সাদা বা ধাতব ধূসর","রূপালি সাদা বা ধাতব ধূসর",
            "রূপালি সাদা বা ধাতব ধূসর","রূপালি সাদা বা ধাতব ধূসর","রূপালি সাদা বা ধাতব ধূসর","রূপালি সাদা বা ধাতব ধূসর","","","","রূপালি","","","রূপালি"};

        public string[] state = {"",
            "গ্যাস","গ্যাস","কঠিন","কঠিন","কঠিন","কঠিন","গ্যাস","গ্যাস","গ্যাস","গ্যাস","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন দানাদার","গ্যাস","গ্যাস","কঠিন","কঠিন",
            "কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","তরল","গ্যাস","কঠিন","কঠিন","কঠিন","কঠিন",
            "কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","গ্যাস","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন",
            "কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","তরল",
            "কঠিন","কঠিন","কঠিন","কঠিন","গ্যাস","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন",
            "কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন","কঠিন"};

         public string[] density = {"",
            "0.08988 g/L","0.1786","0.534 ","1.85 ","","1.8–2.1","1.251 ","1.429 ","1.696","0.9002 ","0.968 ","1.738 ","2.70","2.3290 ","1.823","2.07 ","3.2 ","","0.862 ","1.55 ",
            "2.985 ","4.506 ","6.0","7.19 ","7.21 ","7.874 ","8.90 ","8.908 ","8.94 ","7.14 ","5.91 ","5.323 ","5.727 ","4.81 ","3.1028 ","3.749 ","1.532 ","2.64 ","4.472 ","",
            "8.57 ","10.28 ","","12.45 ","12.41 ","12.023 ","10.49 ","8.65 ","7.31 ","7.265 ","6.697 ","6.24 ","4.933 ","5.894 ","1.93","3.51 ","6.162 ","6.770 ","6.77 ","7.01 ",
            "7.26 ","7.52 ","5.264 ","7.90 ","8.23 ","8.540 ","8.79 ","9.066 ","9.32 ","6.90 ","9.841 ","13.31 ","16.69 ","19.25 ","21.02 ","22.61 ","22.65 ","21.45 ","19.30 ","13.534 ",
            "11.85 ","11.34 ","9.78 ","9.196 ","U","9.73 ","1.87 ","5.5 ","10 ","11.7 ","15.37 ","19.1 ","U","19.816 ","12 ","13.51 ","U","U","8.84 ","U",
            "","","","","2.93 ","35.0 ","37.1 ","40.7","37.4 ","34.8 ","28.7"};


        public string[] fluidDensity = {"",
            "0.07099 g·cm−৩","0.145","0.512 ","1.690 ","2.08 ","3.515 ","0.808 ","1.141 ","1.505","1.207","0.927 ","1.584 ","2.375 ","2.57 ","","1.819 ","1.5625","","0.828 ","1.378 ",
            "2.80 ","4.11 ","5.5 ","6.3 ","5.95 ","6.98 ","7.75 ","7.81 ","8.02 ","6.57 ","6.095 ","5.60 ","5.22 ","3.99 ","","2.413","1.46 ","2.375 ","4.24 ","",
            "","9.33 ","","10.65 ","10.7 ","10.38 ","9.320 ","7.996 ","7.02 ","6.99 ","6.53 ","5.70 ","","","1.843 ","3.338 ","5.94 ","6.55 ","6.50 ","6.89 ",
            "7.26 ","7.16 ","5.13 ","7.4 ","7.65 ","8.37 ","8.34 ","8.86 ","8.56 ","6.90 ","9.3 ","12 ","15 ","17.6 ","18.9 ","20 ","19 ","19.77 ","17.31 ","",
            "11.22 ","10.66 ","10.05 ","","","","","","","","","","","16.63 ","","","","","","",
            "","","","","","","","","","",""};


        public string[] triplePoint = {"",
            "13.8033 কে, ​7.042 kPa","","","","","4600 কে, ​10800 kPa","63.1526 কে, ​12.53 kPa","","","24.5561 কে, ​43 kPa","","","","","862.7 কে, 4367 kPa","","","","336.35 কে, ​ kPa","",
            "","","","","","","","","","","","","1090 কে, ​3628 kPa","","","115.775 কে, ​73.2 kPa ","","","","",
            "","","","","","","","","","","","","","161.405 কে, ​81.6 kPa","","","","","","",
            "","","","","","","","","","","","","","","","","","","","",
            "","","","","","","","","","","","","","","","","","","","","","","","","","","","","","","" };


        public string[] criticalPoint = {"",
            "32.97 কে, 1.293 MPa","5.19 কে, 0.227 MPa","3223 কে, 67 MPa","","","","126.19 কে, 3.3978 MPa","154.59 কে, 5.043 MPa","144.00 কে, 5.220 MPa","44.4 কে, 2.76 MPa","2573 কে, 35 MPa","","","","","1314 কে, 20.7 MPa","416.9 কে, 7.991 MPa","","","",
            "","","","","","","","","","","","","1673 কে, ? MPa","1766 কে, 27.2 MPa","588 কে, 10.34 MPa","209.41 কে, 5.50 MPa","2093 কে, 16 MPa","","","",
            "","","","","","","","","","","","","","289.77 কে, 5.841 MPa","1938 কে, 9.4 MPa","","","","","",
            "","","","","","","","","","","","","","13892 কে,  MPa","","","","","","",
            "","","","","","377 কে, 6.28 MPa","","","","","","","","","","","","","","",
            "","","","","","","","","","","" };


        public string[] fusionsEnthalpi = {"",
            "0.117 kJ·mol−১","0.0138","3.00 ","12.2 ","50.2 ","117 ","0.72 ","0.444 ","0.51","0.335 ","2.60 ","8.48 ","10.71","50.21 ","0.66 ","1.727 ","6.406 ","","2.33 ","8.54 ",
            "2.80 ","14.15 ","21.5 ","21.0 ","12.91","13.81 ","16.06 ","17.48","13.26 ","7.32","5.59 ","36.94 ","24.44 ","6.69 ","10.571 ","1.64","2.19 ","7.43 ","11.42 ","",
            "30 ","37.48 ","","38.59 ","26.59 ","","","","","","","","","2.27 ","2.09","","","","","",
            "","","","","","","","","","","","","","35.3 ","","","","","12.55","",
            "","","","","","3.247","","","14","","","","","","","","","","","",
            "","","","","","","","","","","" };

        public string[] speedOfSound = {"",
            "1310 m·s−১","972","6000 ","12870","16,200 ","18350 ","353 ","330 ","","435 ","3200 ","4940 ","5,000","8433 ","","","206 ","","2000 ","3810",
            "","5,090 ","4560 ","5940 ","5150 ","5120 ","4720 ","4900 ","3810 ","3850 ","2740 ","5400 ","","3350 ","206 ","1120 ","1300 ","","3300 ","",
            "3480 ","","","5970 ","4700 ","3070 ","2680 ","2310 ","1215 ","2730 ","3420 ","2610 ","","1090 ","","1620 ","2475 ","2100 ","2280 ","2330 ",
            "","2130 ","","2680 ","2620 ","2710 ","2760 ","2830 ","","1590 ","","3010 ","3400 ","4620 ","4700 ","4940 ","4825 ","2800 ","2030","1451.4 ",
            "818 ","1190 ","1790 ","","","","","","","2490 ","","3155 ","","2260","","","","","","",
            "","","","","","","","","","","" };


        public string[] crystalStructure = {"",
            "Hexagonal","hexagonal close-packed","body-centered cubic","​hexagonal","","","","","","","","","","","","","","","","","",
             "","","","","","","","","","","","","","","","","","","",
            "","","","","","","","","","","","","","","","","","","","",
            "","","","hexagonal","hexagonal","hexagonal","hexagonal","hexagonal","cubic face centered","hexagonal","hexagonal","cubic face centered","cubic body centered","​body-centered cubic","hexagonal","hexagonal","cubic face centered","cubic face centered","cubic face centered","rhombohedral",
            "hexagonal","cubic face centered","rhombohedral","cubic","no data","​কিউবিক ফেস সেন্ট্রেড","cubic body centered","cubic body centered","কিউবিক ফেইস সেন্ট্রেড","cubic face centered","orthorhombic","orthorhombic","93","​monoclinic","","","","","","",
            "","","","","body-centered cubic","body-centered cubic","hexagonal close-packed","hexagonal close-packed","face-centered cubic","body-centered cubic","body-centered cubic" };

         public string[] magnetism = {"",
            "Diamagnetic","Diamagnetic","Paramagnetic","Diamagnetic","Diamagnetic","Diamagnetic","Diamagnetic","Paramagnetic","Diamagnetic","Diamagnetic","Paramagnetic","Paramagnetic","Paramagnetic়","Diamagnetic","Diamagnetic","Diamagnetic","Diamagnetic","","Paramagnetic","Diamagnetic",
            "Paramagnetic","Paramagnetic","Paramagnetic","AFM","Paramagnetic","Ferromagnetic","Ferromagnetic","Ferromagnetic","Diamagnetic","Diamagnetic","Diamagnetic","Diamagnetic","Diamagnetic","Diamagnetic","Diamagnetic","Diamagnetic","Paramagnetic","Paramagnetic","Paramagnetic","",
            "Paramagnetic","Paramagnetic","","Paramagnetic","Paramagnetic","","","","","","","","","Nonmagnetic","Paramagnetic","","","","","",
            "","","","","","","","","","","","","","Paramagnetic","","","","","","",
            "","","","","","nonmagnetic","","","","","","","","Paramagnetic","","","","","","",
            "","","","","","","","Paramagnetic","",""};


         public string[] cashRegiNo = {"",
            "1333-74-0","7440-59-7","7439-93-2","7440-41-7","7440-42-8","7440-44-0","7727-37-9","7782-44-7","7782-41-4","7440-01-9","7440-23-5","7439-95-4","7429-90-5","7440-21-3","7723-14-0","7704-34-9","7782-50-5"," ","7440-09-7","7440-70-2",
            "7440-20-2","7440-32-6","7440-62-2","7440-47-3","7439-96-5","7439-89-6","7440-48-4","7440-02-0","7440-50-8","7440-66-6","7440-55-3","7440-56-4","7440-38-2","7782-49-2","7726-95-6","7439-90-9","7440-17-7","7440-24-6","7440-65-5"," ",
            "7440-03-1","7439-98-7"," ","7440-18-8","7440-16-6","7440-05-3","7440-22-4","7440-43-9","7440-74-6","7440-31-5","7440-36-0","13494-80-9","7553-56-2","7440-63-3","7440-46-2","7440-39-3","7439-91-0","7440-45-1","7440-10-0","7440-00-8",
            "7440-12-2","7440-19-9","7440-53-1","7440-54-2","7440-27-9","7429-91-6","7440-60-0","7440-52-0","7440-30-4","7440-64-4","7439-94-3","7440-58-6","7440-25-7","7440-33-7","7440-15-5","7440-04-2","7439-88-5","7440-06-4","7440-57-5","7439-97-6",
            "7440-28-0","7439-92-1","7440-69-9","7440-08-6","7440-68-8","10043-92-2","7440-73-5","7440-14-4","7440-34-8","7440-29-1","7440-13-3","7440-61-1"," ","7440-07-5","7440-35-9","7440-51-9"," "," ","7429-92-7","7440-72-4",
            "7440-11-1","10028-14-5","22537-19-5","53850-36-5","53850-35-4","54038-81-2","54037-14-8","54037-57-9","54038-01-6","54083-77-1","54386-24-2","54084-26-3","54084-70-7","54085-16-4","54085-64-2"," ","87658-56-8","54144-19-3" };

        public string[] heatCapacity = {"",
            "28.836 ","20.786 ","24.860 ","16.443 ","11.087 ","8.517","29.124 ","29.378 ","825 ","20.786 ","28.230 ","24.869 ","24.200 ","19.789 ","23.824 ","22.75 ","33.949 "," ","29.6 ","25.929 ",
            "25.52 ","25.060 ","24.89 ","23.35 ","26.32 ","25.10 ","24.81 ","26.07 ","24.440 ","25.470 ","25.86 ","23.222 ","24.64 ","25.363 ","75.69 ","20.786 ","31.060 ","26.4 ","26.53 "," ",
            "24.60 ","24.06 ","24.27 ","24.06 ","24.98 "," "," "," "," "," "," "," "," ","20.786 ","32.210 "," "," "," "," "," ",
            "","","","","","","","",""," ","","","","24.27 ","","","","","25.418 ","",
            "","","","","","20.786 ","","","27.2 ","","","","","35.5 ","","","","","","",
            " "," "," "," "," "," "," "," "," "," "," " };

        public string[] criticalHeat = {"",
            "0.904 kJ·mol−১","0.0829","147.1 ","297","480","","5.56 ","6.82 ","3.27","1.71 ","97.42 ","128 ","294.0","359 ","12.4 ","45 ","20.41 ","","76.9 ","154.7 ",
            "332.7 ","425 ","459 ","339.5 ","221 ","340 ","377 ","377.5 ","300.4 ","123.6 ","254 ","334 ","34.76 ","95.48 ","29.96 ","9.08 ","75.77 ","136.9 ","365 ","",
            "689.9 ","598 ","","591.6 ","494 ","362 ","258 ","99.87 ","231.8 ","296.1 ","193.43 ","114.1 ","41.57 ","12.64 ","63.9","140.3 ","402.1 ","398 ","331 ","289 ",
            "289 ","165 ","176 ","301.3 ","293 ","280 ","265 ","280 ","247 ","159 ","414 ","571 ","732.8 ","774 ","704 ","738 ","231.8 ","469 ","","59.11 ",
            "165 ","179.5","151 ","102.91 ","40 ","18.10","65 ","113 ","400","514 ","481 ","417.1 ","","333.5","","","","","","",
            "","","","","","","","","","","" };

        //

        public string[] vanderWallasRadius = {"",
            "120 pm","140 ","182 ","153 ","192 ","170 ","155 ","152 ","147 ","154 ","227 ","173 ","184 ","210 ","180 ","180 ","175 ","","275 ","231 ",
            "211 ","","","","","","","163 ","140 ","139 ","187 ","211 ","185 ","190 ","185 ","202 ","303 ","249 ","","",
            "","","","","","163 ","172 ","158 ","193 ","217 ","","206 ","198 ","216 ","343 ","","","","","",
            "","","","","","","","","","","","","","","","","","175 ","166 ","155 ",
            "196 ","202 ","","","","","","","","","","186 ","","","","","","","","",
            "","","","","","","","","","","" };

        public string[] heatPoribahokotto = {"",
            "0.1805 W·m−১·K−১","0.1513","84.8 ","200 ","27.4 ","900-2300","25.83 × 10−3","26.58x10-3","0.02591","49.1x10-3","142 ","156 ","237","149 ","12.1 ","0.205 ","8.9×10−3 ","","102.5 ","201 ",
            "15.8 ","21.9 ","30.7 ","93.9 ","7.81 ","80.4 ","100 ","90.9 ","401 ","116 ","40.6 ","60.2 ","50.2 ","0.519 ","0.122 ","9.43×10-3 ","58.2 ","35.4 ","17.2 ","",
            "53.7 ","138 ","","117 ","150","","","","","","","","","5.65x10-3","35.9","","","","","",
            "","","","","","","","","","","","","","173 ","","","","","318","",
            "","","","","","3.61","","","","","","","","6.74","","","","","","",
            "","","","","","","","","","","" };

        public string[] nuclearRadius = {"",
            " pm","","152 ","112 ","90 ","","","","","","186 ","160 ","143 ","111 ","","","","","227 ","197 ",
            "162 ","147 ","134 ","128 ","127 ","126 ","125 ","124 ","128 ","134 ","135 ","122 ","119 ","120 ","120 ","","248 ","215 ","180 ","",
            "146 ","139 ","","134 ","134 ","140 ","160 ","155 ","155 ","145 ","145 ","	140 ","140 ","108 ","265 ","215 ","195 ","	185 ","185 ","185 ",
            "185 ","185 ","185 ","180 ","175 ","175 ","175 ","175 ","175 ","175 ","175 ","155 ","145 ","139 ","135 ","130 ","135 ","135 ","135 or 174 ","150 ",
            "190 ","180 ","160 ","190 ","","120 ","","215 ","195 ","180 ","180 ","175 ","","159 ","175 ","","","","","",
            "","","","","139 ","132 ","128 ","126 ","128 ","132 ","138 " };

        public string[] electricalMagnetism = {"",
            "2.20", "", "0.98", "1.57", "2.04",

            "2.55 ","3.04 ","3.44 ","3.98 ","","0.93 ","1.31 ","1.61 ","1.90 ","2.19 ","2.58 ","3.16 ","","0.82 ","1.00 ",
            "1.36 ","1.54 ","1.63 ","1.66 ","1.55 ","1.83 ","1.88 ","1.91 ","1.90 ","1.65 ","1.81 ","2.01 ","2.18 ","2.55 ","2.96 ","3.00 ","0.82 ","0.95 ","1.22 ","",
            "1.6 ","2.16 ","","2.2 ","2.28 ","2.20 ","1.93 ","1.69 ","1.78 ","1.96 ","2.05 ","2.1 ","2.66 ","2.6 ","0.79 ","0.89 ","1.10 ","1.12 ","1.13 ","1.14 ",
            "1.13 ","1.17 ","1.2 ","1.20 ","1.2 ","1.22 ","1.23 ","1.24 ","1.25 ","1.1 ","1.27 ","1.3 ","1.5 ","2.36 ","1.9 ","2.2 ","2.20 ","2.28 ","2.54 ","2.00 ",
            "1.62 ","2.33 ","2.02 ","2.0 ","2.2 ","","0.7 ","0.9 ","1.1 ","1.3 ","1.5 ","1.38 ","","1.28 ","1.3 ","1.3 ","","","1.3 ","1.3 ",
            "1.3 ","1.3 ","","","","","","","","","" };
        // checking ok
        public string[] covalentRadius = {"",
            "31±5 pm", "28","128±7","96±3","84±3", "77(sp³), 73(sp²), 69(sp)","71±1","66±2","64","58",
            "166±9", "141±7", "121±4", "111", "107±3", "105±3", "102±4", "106±10", "204±12", "176±10",
            "170±7", "160±8", "153±8", "139±5", "139±5 (low spin), 161±8 (high spin)","132±3 (low spin), 152±6 (high spin)", "126±3 (low spin), 150±7 (high spin)", "124±4", "132±4", "122±4",
            "122±3", "122", "119±4", "120±4", "120±3", "116±4", "220±9", "195±10", "190±7", "175±7",
            "164±6", "154±5", "147±7", "146±7", "142±7", "139±6", "145±5", "148", "142±5", "139±4",
            "139±5", "138±4", "139±3", "140±9", "244±11", "215±11", "207±8", "204±9", "203±7", "201±6",
            "199", "198±8", "198±6", "196±6", "194±5", "192±7", "192±7", "189±6", "190±10", "187±8",
            "187±8", "175±10", "170±8", "162±7", "151±7", "144±4", "141±6", "136±5", "136±6", "132±5",
            "145±7", "146±5", "148±4", "140±4", "150", "150", "260", "221±2", "215", "206±6",
            "200", "196±7", "190±1", "187±1", "180±6", "169±3","","","","",
            "","","","157","149", "143","141","134","129","128","121"
        };
    }
}
