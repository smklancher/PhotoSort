using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PhotoSort
{
    public class PhotoCollection : IList<Photo>
    {
        // helpful tip: https://stackoverflow.com/a/57493432/221018
        readonly IList<Photo> list = new List<Photo>();

        public Photo this[int index] { get => list[index]; set => list[index] = value; }

        public int Count => list.Count;

        public bool IsReadOnly => list.IsReadOnly;

        public void Add(Photo item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(Photo item)
        {
            return list.Contains(item);
        }

        public void CopyTo(Photo[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Photo> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public int IndexOf(Photo item)
        {
            return list.IndexOf(item);
        }

        public void Insert(int index, Photo item)
        {
            list.Insert(index, item);
        }

        public bool Remove(Photo item)
        {
            return list.Remove(item);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public static PhotoCollection FromFolder(string FolderPath)
        {
            var di = new DirectoryInfo(FolderPath);
            var pc = new PhotoCollection();
            foreach(var f in di.GetFiles("*.jpg", SearchOption.AllDirectories))
            {
                pc.Add(new Photo(f.FullName));
            }
            return pc;
        }



        public void Test()
        {
            ((List<Photo>)list).Sort();
        }
    }
}
