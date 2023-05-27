using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public interface IGameSaver
    {
        public void Save(SaveSnapshot snapshot);
        public SaveSnapshot? Load();
    }
}
