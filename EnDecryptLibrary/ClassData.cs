using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnDecryptLibrary
{
    public class ClassData
    {
        string cha;
        int id;
        string shuf;

        #region Properties
        public string Cha
        {
            get { return cha; }
            set { cha = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Shuf
        {
            get { return shuf; }
            set { shuf = value; }
        }
        #endregion

        #region Constructors
        public ClassData(string c, int i, string s)
        {
            Cha = c;
            Id = i;
            Shuf = s;
        }
        #endregion
    }
}
