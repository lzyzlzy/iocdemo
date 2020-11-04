using iocdemo.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;

namespace iocdemo
{
    public class ServiceCollection : IServiceCollection
    {
        private readonly List<ServiceDescriptor> _descriptors = new List<ServiceDescriptor>();

        public ServiceDescriptor this[int index] { get => _descriptors[index]; set => throw new NotImplementedException(); }

        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(ServiceDescriptor item)
        {
            _descriptors.Add(item);
        }

        public void Clear()
        {
            _descriptors.Clear();
        }

        public bool Contains(ServiceDescriptor item) => _descriptors.Contains(item);

        public void CopyTo(ServiceDescriptor[] array, int arrayIndex) => _descriptors.CopyTo(array, arrayIndex);

        public IEnumerator<ServiceDescriptor> GetEnumerator() => _descriptors.GetEnumerator();

        public int IndexOf(ServiceDescriptor item) => _descriptors.IndexOf(item);

        public void Insert(int index, ServiceDescriptor item) => _descriptors.Insert(index, item);

        public bool Remove(ServiceDescriptor item) => _descriptors.Remove(item);

        public void RemoveAt(int index)=> _descriptors.RemoveAt(index);

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
