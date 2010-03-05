using System;
using System.Collections;

namespace SumoNET
{
    public class TptpCollection : IEnumerable, IEnumerator
    {
        private Formula _formula;
        private int _position = -1;
        
        #region Constructors
        
        public TptpCollection(Formula formula)
        {
            _formula = formula;
        }

        #endregion

        #region IEnumerable Implementation

        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this;
        }

        public bool MoveNext()
        {
            _position++;
            if(_position < _formula.Intern.getTheTptpFormulas().size())
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
            _position = -1;
        }

        public object Current
        {
            get
            {
                return _formula.Intern.getTheTptpFormulas().get(_position);
            }
        }

        #endregion

        #region Public Properties

        public int Count
        {
            get
            {
                return _formula.Intern.getTheTptpFormulas().size();
            }
        }

        #endregion

        #region Public Methods

        public void Clear()
        {
            _formula.Intern.clearTheTptpFormulas();
        }

        #endregion
    }
}
