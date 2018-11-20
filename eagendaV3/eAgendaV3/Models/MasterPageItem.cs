using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace eAgendaV3.Models
{
    public class MasterPageItem
    {
        public string titulo { get; set; }
        public Type targtType { get; set; }

        public static implicit operator ObservableCollection<object>(MasterPageItem v)
        {
            throw new NotImplementedException();
        }
    }
}
