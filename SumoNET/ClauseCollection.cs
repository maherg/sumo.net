using System;
using System.Collections;

namespace SumoNET
{
    public class ClauseCollection : IEnumerable, IEnumerator
    {
        private Formula _formula;
        private java.util.Iterator _it;
        
        #region Constructors
        
        public ClauseCollection(Formula formula)
        {
            _formula = formula;
            _it = _formula.Intern.getClauses().iterator();
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
        	_it = _formula.Intern.getClauses().iterator();
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
                return _formula.Intern.getClauses().size();
            }
        }

        #endregion
    }
}
