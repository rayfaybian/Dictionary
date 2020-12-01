using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DictLogic
{
    public class DictionaryController
    {
        Dictionary<string, string> gerToEng;
        Dictionary<string, string> gerToDia;

        private string _englishFilepath = "C:\\Coding\\C#\\Dictionary\\Dictionary\\english.txt";
        public string EnglishFilepath { get => _englishFilepath; }


        private string _dialectFilepath = "C:\\Coding\\C#\\Dictionary\\Dictionary\\dialect.txt";

        public string DialectFilepath { get => _dialectFilepath; }

        private string _alphabetFilepath = "C:\\Coding\\C#\\Dictionary\\Dictionary\\Alphabet.txt";

        public string AlphabetFilepath { get => _alphabetFilepath; }

        private string _currentLanguage;
        public string CurrentLanguage { get { return _currentLanguage; } set => _currentLanguage = value; }

        public DictionaryController()
        {
            gerToEng = new Dictionary<string, string>();
            gerToDia = new Dictionary<string, string>();

            _currentLanguage = "eng";
        }



        public List<string> UpdateTranslation()
        {
            List<string> output = new List<string>();
            if (CurrentLanguage.Equals("eng"))
            {
                output = SortDictionary(gerToEng).Keys.ToList();
            }
            else if (CurrentLanguage.Equals("dia"))
            {
                output = SortDictionary(gerToDia).Keys.ToList();
            }

            return output;
        }

        private Dictionary<string, string> SortDictionary(Dictionary<string, string> dictionary)
        {
            List<string> words = new List<string>(dictionary.Keys);
            words.Sort();
            Dictionary<string, string> orderedDictionary = new Dictionary<string, string>();

            foreach (var key in words)
            {
                orderedDictionary.Add(key, dictionary[key]);
            }
            return orderedDictionary;
        }

        public string GetTranslation(string word)
        {
            string translation = string.Empty;

            if (CurrentLanguage.Equals("eng") && gerToEng.ContainsKey(word))
            {
                translation = gerToEng[word];
            }
            else if (CurrentLanguage.Equals("dia") && gerToDia.ContainsKey(word))
            {
                translation = gerToDia[word];
            }
            return translation;
        }

        public void ReadFiles()
        {
            string[] english = System.IO.File.ReadAllLines(EnglishFilepath);
            string[] dialect = System.IO.File.ReadAllLines(DialectFilepath);

            importFileData(gerToEng, english);
            importFileData(gerToDia, dialect);
        }

        private void importFileData(Dictionary<string, string> dictionary, string[] array)
        {
            string[] temp;
            int counter = 0;

            foreach (var element in array)
            {
                temp = element.Split(';');
                dictionary.Add(temp[0], temp[1]);
                counter++;
            }

        }

        public string ShowTranslation(string key)
        {

            Dictionary<string, string> dict = new Dictionary<string, string>();
            if (CurrentLanguage.Equals("eng"))
            {
                dict = gerToEng;
            }
            else if (CurrentLanguage.Equals("dia"))
            {
                dict = gerToDia;
            }
            return dict[key];

        }
        private void TranslateWord(string original, string translated, Dictionary<string, string> dictionary)
        {
            var word = original;
            var translation = translated;

            dictionary.Add(word, translation);
        }

        public void NewGermanWord(string german, string english)
        {           
            TranslateWord(german, english, gerToEng);
        }

        public void NewDialectWord(string german, string dialect)
        {         
            TranslateWord(german, dialect, gerToDia);
        }

        public void SetCurrentLanguage(string selection)
        {
            if (selection.Equals("eng"))
            {
                CurrentLanguage = "eng";
            }
            else if (selection.Equals("dia"))
            {
                CurrentLanguage = "dia";
            }
        }
        public string GetCurrentLanguage()
        {
            string output = string.Empty;
            if (CurrentLanguage.Equals("eng"))
            {
                output = "eng";
            }
            else if (CurrentLanguage.Equals("dia"))
            {
                output = "dia";
            }
            return output;
        }

        private string[] ExportFileData(Dictionary<string, string> dictionary)
        {
            string[] array = new string[dictionary.Count];
            var temp = "";
            var counter = 0;


            foreach (KeyValuePair<string, string> entry in SortDictionary(dictionary))
            {
                temp = entry.Key + ";" + entry.Value;
                array[counter] = temp;
                counter++;
            }
            return array;
        }

        public void SaveFiles()
        {
            System.IO.File.WriteAllLines(DialectFilepath, ExportFileData(gerToDia));
            System.IO.File.WriteAllLines(EnglishFilepath, ExportFileData(gerToEng));
        }



        public List<string> SelectByLetter(string selection)
        {
            char[] selectedLetter = selection.ToCharArray();

            Dictionary<string, string> dict = new Dictionary<string, string>();
            if (CurrentLanguage.Equals("eng"))
            {
                dict = gerToEng;
            }
            else if (CurrentLanguage.Equals("dia"))
            {
                dict = gerToDia;
            }

            List<string> words = new List<string>();


            foreach (var item in dict.Keys)
            {
                char[] letters = item.ToCharArray();
                if (letters[0].Equals(selectedLetter[0]))
                {
                    words.Add(item);
                }
            }
            return words;
        }

        public List<string> ImportAlphabet()
        {
            string[] alphabetArray = System.IO.File.ReadAllLines(AlphabetFilepath);
            List<string> alphabetList = new List<string>();
            string[] temp;

            foreach (var letter in alphabetArray)
            {
                temp = letter.Split(';');
                alphabetList.Add(temp[0]);
            }
            return alphabetList;
        }

        public List<string> GetSearchResults(string searchText)
        {
            List<string> results = new List<string>();

            var text = searchText;
            Dictionary<string, string> selection = new Dictionary<string, string>();
            if (CurrentLanguage.Equals("eng"))
            {
                foreach (var word in gerToEng)
                {
                    if (word.Key.ToLower().Contains(text))
                    {
                        selection.Add(word.Key, gerToEng[word.Key]);
                    }
                }
                results = SortDictionary(selection).Keys.ToList();
            }
            else if (CurrentLanguage.Equals("dia"))
            {
                foreach (var word in gerToDia)
                {
                    if (word.Key.ToLower().Contains(text))
                    {
                        selection.Add(word.Key, gerToDia[word.Key]);
                    }
                }
                results = SortDictionary(selection).Keys.ToList();
            }
            return results;
        }
    }
}
