using System;
using System.Collections;
using com.articulate.sigma;

namespace SumoNET
{
    public class TermCollection : IEnumerable, IEnumerator
    {
        private KnowledgeBase _kb;
        private java.util.Iterator _it;

        #region Constructors

        public TermCollection(KnowledgeBase kb)
        {
            _kb = kb;
            _it = _kb.Intern.terms.iterator();
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
            _it = _kb.Intern.terms.iterator();
        }

        public object Current
        {
            get
            {
                return new Term(_kb, (string)_it.next());
            }
        }
            
        #endregion

        #region Public Properties
        
        public int Count
        {
            get
            {
                return _kb.Intern.getCountTerms();
            }
        }
        
        public Term this[string term]
        {
        	get
        	{
        		if(_kb.Intern.terms.contains(term))
        		{
        			return new Term(_kb, term);
        		}
        		java.util.Iterator it = _kb.Intern.terms.iterator();
        		while(it.hasNext())
        		{
        			if(term == it.next().ToString())
        			{
        				return new Term(_kb, term);
        			}
        		}
        		return null;
        	}
        }

        #endregion

        #region Public Methods
        
        public bool Contains(string term)
        {
            return _kb.Intern.containsTerm(term);
        }

        public bool Contains(Term term)
        {
            return _kb.Intern.containsTerm(term.Text);
        }

        #endregion
    }
}
