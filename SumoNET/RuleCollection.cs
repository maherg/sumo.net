using System;
using System.Collections;

namespace SumoNET
{
    public class RuleCollection
    {
        private KnowledgeBase _kb;

        #region Contructors
        
        public RuleCollection(KnowledgeBase kb)
        {
            _kb = kb;
        }

        #endregion

        #region Public Properties

        public int Count
        {
            get
            {
                return _kb.Intern.getCountRules();
            }
        }

        #endregion
    }
}
