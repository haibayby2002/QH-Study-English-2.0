using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QHStudyEnglish.myClass
{
    class VocaBulary
    {
        //Field
        protected string name, meaning;
        protected int id_set, total, answerRight;
        protected float ratio;

        #region Constructor
        public VocaBulary()
        {
            name = meaning = "";
            id_set = total = answerRight = 0;
            ratio = -1;
        }

        public VocaBulary(string name, int id_set)
        {
            this.name = name;
            this.id_set = id_set;
            this.total = this.answerRight = 0;
            this.ratio = -1;
        }
        
        public VocaBulary(string name, int id_set, string meaning):this(name, id_set)
        {
            this.meaning = meaning;
        }

        public VocaBulary(string name, int id_set, string meaning, float ratio):this(name, id_set, meaning)
        {
            this.ratio = ratio;
        }

        public VocaBulary(string name, int id_set, string meaning, float ratio, int total): this(name, id_set, meaning, ratio)
        {
            this.total = total;
        }

        public VocaBulary(string name, int id_set, string meaning, int total, int answerRight) : this(name, id_set, meaning)
        {
            this.answerRight = answerRight;
            this.total = total;
            this.ratio = (float)answerRight / total;
        }
        #endregion


    }
}
