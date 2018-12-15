using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.CommandLineClasses;

namespace BLL.BuyClasses
{
    public class Buy : IList<CommandLine>
    {
        private List<CommandLine> _buyCommands;
        private DateTime _date;

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public Buy()
        {
            _buyCommands = new List<CommandLine>();
        }

        public int IndexOf(CommandLine item)
        {
            return _buyCommands.IndexOf(item);
        }

        public void Insert(int index, CommandLine item)
        {
            _buyCommands.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _buyCommands.RemoveAt(index);
        }

        public CommandLine this[int index]
        {
            get
            {
                return _buyCommands[index];
            }
            set
            {
                _buyCommands[index] = value;
            }
        }

        public void Add(CommandLine item)
        {
            _buyCommands.Add(item);
        }

        public void Clear()
        {
            _buyCommands.Clear();
        }

        public bool Contains(CommandLine item)
        {
            return _buyCommands.Contains(item);
        }

        public void CopyTo(CommandLine[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public int Count
        {
            get { return _buyCommands.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(CommandLine item)
        {
            if (_buyCommands.Remove(item))
            {
                return true;
            }
            return false;
        }

        public IEnumerator<CommandLine> GetEnumerator()
        {
            return _buyCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
