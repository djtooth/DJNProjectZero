using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace GenericObjects
{
    public class nameList
    {
        public List<string> beginning = new List<string>(new string[] { "Yum", "Yummy ", "Edible-" });
        public List<string> ending = new List<string>(new string[] { "Yum", "Food ", "Steaks", "MEAT!", "Greens" });
        public List<string> first = new List<string>(new string[] { "Yumi", "Fred ", "Steve", "Meat", "Grodon" });
        public List<string> last = new List<string>(new string[] { "Ysolda", "Jood ", "Steakson", "Meatingsmith!", "Green" });
    }


    public class ObjCollector<T> : ICollection
    {
        private ArrayList objCollect = new ArrayList();

        public T this[int index]
        {
            get { return (T)objCollect[index]; }
        }
        public int Count
        {
            get { return objCollect.Count; }
        }

        public object SyncRoot
        {
            get { return this; }
        }
        public bool IsSynchronized
        {
            get { return false; }
        }
        public IEnumerator GetEnumerator()
        {
            return objCollect.GetEnumerator();
        }

        public void Add(T newObj)
        {
            objCollect.Add(newObj);
        }

        public void CopyTo(Array array, int index)
        {
            objCollect.CopyTo(array, index);
        }
    }

    public class Test<O>
    {
        public void SerializeCollection(string filename)
        {
            ObjCollector<O> OCollection = new ObjCollector<O>();
            O newb;
            XmlSerializer xmlSerial = new XmlSerializer(typeof(ObjCollector<O>));
            TextWriter writer = new StreamWriter(filename);
            xmlSerial.Serialize(writer, OCollection);
        }
    }

    /*public class Superconstructor
    {
        

        public Superconstructor(ObjCollector<Review> reviewCollection, ObjCollector resterauntsCollection)
            {
                
            }
    }*/
}
