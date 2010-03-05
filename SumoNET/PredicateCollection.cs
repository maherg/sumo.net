using System;
using System.Collections;

namespace SumoNET
{
    public class PredicateCollection : IEnumerable, IEnumerator
    {
        private KnowledgeBase _kb;
        private java.util.Iterator _it;

        #region Constructors
        
        public PredicateCollection(KnowledgeBase kb)
        {
            _kb = kb;
            _it = _kb.Intern.collectPredicates().iterator();
        }

        #endregion

        #region IEnumerable Implementation

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            if(_it.hasNext())
            {
                return true;
            }
            else
            {
            	Reset();
                return false;
            }
        }

        public void Reset()
        {
            _it = _kb.Intern.collectPredicates().iterator();
        }

        public object Current
        {
            get
            {
                return _it.next();
            }
        }
        #endregion

        #region Public Properties

        public int Count
        {
            get
            {
                return _kb.Intern.collectPredicates().size();
            }
        }

        #endregion
    }
}
