using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.CommandLineClasses;

namespace BLL.SellClasses
{
    class Sell : IList<CommandLine>
    {
        private List<CommandLine> _sellCommands;
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public Sell()
        {
            _sellCommands = new List<CommandLine>();
        }

        public int IndexOf(CommandLine item)
        {
            return _sellCommands.IndexOf(item);
        }

        public void Insert(int index, CommandLine item)
        {
            _sellCommands.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _sellCommands.RemoveAt(index);
        }

        public CommandLine this[int index]
        {
            get
            {
                return _sellCommands[index];
            }
            set
            {
                _sellCommands[index] = value;
            }
        }

        public void Add(CommandLine item)
        {
            _sellCommands.Add(item);
        }

        public void Clear()
        {
            _sellCommands.Clear();
        }

        public bool Contains(CommandLine item)
        {
            return _sellCommands.Contains(item);
        }

        public void CopyTo(CommandLine[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return _sellCommands.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(CommandLine item)
        {
            if (_sellCommands.Remove(item))
            {
                return true;
            }
            return false;
        }

        public IEnumerator<CommandLine> GetEnumerator()
        {
            return _sellCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
