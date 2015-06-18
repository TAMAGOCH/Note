using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Library
{
    public class zapis
    {
        public List<author> authors;
        public List<string> publishers;

        public zapis()
        {
            authors = new List<author>();
            publishers = new List<string>();
        }

        public void Addpublisher(string name)
        {
            publishers.Add(name);
        }

        public void Addauthor(string name)
        {
            author pr = new author(name);
            authors.Add(pr);
        }

        public int AddpublisherToauthor(string nameauthor, string namepublisher)
        {
            author prep;

            if ((prep = authors.Find(delegate(author a) { return a.Name == nameauthor; })) == null)
                return -1;

            if (publishers.Exists(delegate(string s) { return s == namepublisher; }) == false)
                return -1;

            prep.AddpublisherToMyMap(namepublisher);

            return 0;
        }

        public int Findauthors(string namepublisher, out string[] rezult)
        {
            if (publishers.Exists(delegate(string s) { return s == namepublisher; }) == false)
            {
                rezult = null;
                return -1;
            }

            List<author> preps;

            preps = authors.FindAll(delegate(author a) { return a.my_publishers.Exists(delegate(string s) { return s == namepublisher; }); });
            rezult = new string[preps.Count];
            for (int i = 0; i < preps.Count; ++i)
                rezult[i] = preps[i].Name;

            return 0;
        }

        public int Findpublishers(string nameauthor, out string[] rezult)
        {
            author prep;

            if ((prep = authors.Find(delegate(author a) { return a.Name == nameauthor; })) == null)
            {
                rezult = null;
                return -1;
            }

            rezult = new string[prep.my_publishers.Count];
            for (int i = 0; i < prep.my_publishers.Count; ++i)
                rezult[i] = prep.my_publishers[i];

            return 0;
        }

        public void Printpublishers(out string[] rezult)
        {
            rezult = new string[publishers.Count];
            for (int i = 0; i < publishers.Count; ++i)
                rezult[i] = publishers[i];
        }

        public void Printauthors(out string[] rezult)
        {
            rezult = new string[authors.Count];
            for (int i = 0; i < authors.Count; ++i)
                rezult[i] = authors[i].Name;
        }

        public void SaveToFile(string fileName)
        {
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.GetEncoding(1251)))
            {
                sw.WriteLine(publishers.Count);
                foreach (string s in publishers)
                    sw.WriteLine(s);

                foreach (author a in authors)
                {
                    sw.Write(a.Name + "," + a.my_publishers.Count);
                    foreach (string s in a.my_publishers)
                        sw.Write("," + s);
                    sw.WriteLine();
                }
            }
        }

        public void LoadFromFile(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName, Encoding.GetEncoding(1251)))
            {
                publishers.Clear();
                authors.Clear();

                int n = Convert.ToInt32(sr.ReadLine());
                for (int i = 0; i < n; ++i)
                    publishers.Add(sr.ReadLine());

                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] s = str.Split(',');

                    author a = new author(s[0]);

                    n = Convert.ToInt32(s[1]);
                    for (int i = 0; i < n; ++i)
                        a.AddpublisherToMyMap(s[i + 2]);

                    authors.Add(a);
                }
            }
        }
    }
}
