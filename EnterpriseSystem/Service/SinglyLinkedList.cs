using System.Collections;

namespace EnterpriseSystem.Service
{
    // creating a generic collection
    public class SinglyLinkedList<T> : IEnumerable<T> where T : class // implemented covariant generic interface
    {
        private Node<T>? _head;
        private Node<T>? _tail;
        private int _count;

        public int Count => _count;
        public bool IsEmpty => _count == 0;

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (_head == null)
            {
                _head = node;
            }
            else
            {
                _tail!.Next = node;
            }

            _tail = node;
            _count++;
        }

        // Func delegate is used here
        public bool Delete(T data)
        {
            return Remove(data, Remove_Main);
        }
        private bool Remove(T data, Func<T, bool> removeOperation) => removeOperation(data);
        private bool Remove_Main(T data)
        {
            Node<T>? current = _head;
            Node<T>? previous = null;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous!.Next = current.Next;

                        if (current.Next == null)
                        {
                            _tail = previous;
                        }
                    }
                    else
                    {
                        _head = _head!.Next;

                        if (_head == null)
                        {
                            _tail = null;
                        }
                    }

                    _count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }

        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }

        public bool Contains(T data)
        {
            Node<T>? current = _head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        #region Sorting
        // Action delegate is used here
        public void SortAll<K>(K sorter) where K : class
        {
            Sort(sorter, Sort_Main);
        }
        private void Sort<K>(K sorter, Action<K> sortAction) => sortAction(sorter);
        private void Sort_Main<K>(K sorter)
        {
            List<T> buffer = this.ToList();
            buffer.Sort(sorter as IComparer<T>);
            this.Clear();
            foreach (var e in buffer)
            {
                this.Add(e);
            }
        }
        #endregion



        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T>? current = _head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
