using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Test
    {
        public void Sample()
        {
            List<Student> listStudent = new List<Student>();
            IEnumerable<Student> enumStudent = listStudent ;
            


        }
        
       
        
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class ListParents : IList<Student>
    {
        public Student this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(Student item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Student item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(Student[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Student> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(Student item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, Student item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Student item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
