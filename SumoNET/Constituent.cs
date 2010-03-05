using System;
using System.Collections;

namespace SumoNET
{
    public class Constituent
    {
        private KnowledgeBase _kb;
        private string _path;

        #region Constructors
        
        public Constituent(KnowledgeBase kb, string path)
        {
            _kb = kb;
            _path = path;
        }

        #endregion

        #region Public Properties

        public string Path
        {
            get
            {
                return _path;
            }
        }

        #endregion

        #region Public Methods

        public void Remove()
        {
            int i = _kb.Intern.constituents.indexOf(_path);
            if(i > 0)
            {
                _kb.Intern.constituents.remove(i);
            }
        }

        #endregion
    }
}
