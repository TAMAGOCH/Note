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

        public int Addpublisher(string name)
        {
            if (publishers.Exists(delegate(string s) { return s == name; }) == true)
                return -1;
            publishers.Add(name);
            return 0;
        }

        public int Addauthor(string name)
        {
            if (authors.Exists(delegate(author s) { return s.Name == name; }) == true)
                return -1;
            author pr = new author(name);
            authors.Add(pr);
            return 0;
        }

        public int AddpublisherToauthor(string nameauthor, string namepublisher)
        {
            author avtor;

            if ((avtor = authors.Find(delegate(author a) { return a.Name == nameauthor; })) == null)
                return -1;

            if (publishers.Exists(delegate(string s) { return s == namepublisher; }) == false)
                return -1;

            avtor.AddpublisherToMyMap(namepublisher);

            return 0;
        }

        public int Findauthors(string namepublisher, out string[] zud)
        {
            if (publishers.Exists(delegate(string s) { return s == namepublisher; }) == false)
            {
                zud = null;
                return -1;
            }

            List<author> avtors;

            avtors = authors.FindAll(delegate(author a) { return a.my_publishers.Exists(delegate(string s) { return s == namepublisher; }); });
            zud = new string[avtors.Count];
            for (int i = 0; i < avtors.Count; ++i)
                zud[i] = avtors[i].Name;

            return 0;
        }

        public int Findpublishers(string nameauthor, out string[] zud)
        {
            author avtor;

            if ((avtor = authors.Find(delegate(author a) { return a.Name == nameauthor; })) == null)
            {
                zud = null;
                return -1;
            }

            zud = new string[avtor.my_publishers.Count];
            for (int i = 0; i < avtor.my_publishers.Count; ++i)
                zud[i] = avtor.my_publishers[i];

            return 0;
        }

        public void Printpublishers(out string[] zud)
        {
            zud = new string[publishers.Count];
            for (int i = 0; i < publishers.Count; ++i)
                zud[i] = publishers[i];
        }

        public void Printauthors(out string[] zud)
        {
            zud = new string[authors.Count];
            for (int i = 0; i < authors.Count; ++i)
                zud[i] = authors[i].Name;
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
