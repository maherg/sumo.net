using System;
using System.Collections;
using com.articulate.sigma;

namespace SumoNET
{
    public class ConstituentCollection : IEnumerable, IEnumerator
    {
        private KnowledgeBase _kb;
        private java.util.Iterator _it;

        #region Constructors

        public ConstituentCollection(KnowledgeBase kb)
        {
            _kb = kb;
            _it = _kb.Intern.constituents.iterator();
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
            _it = _kb.Intern.constituents.iterator();
        }

        public object Current
        {
            get
            {
                return new Constituent( _kb, (string)_it.next() );
            }
        }

        #endregion
        
        #region Public Properties

        public int Count
        {
            get
            {
                return _kb.Intern.constituents.size();
            }
        }

        #endregion

        #region Public Indexers

        public Constituent this[int key]
        {
            get
            {
                if(key >=0 && key < _kb.Intern.constituents.size())
                {
                    return new Constituent(_kb, (string)_kb.Intern.constituents.get(key));
                }
                else
                {
                    return null;
                }
            }
        }

        #endregion

        #region Public Methods

        public void Add(string filename)
        {
            _kb.Intern.addConstituent(filename);
        }

        public void Add(string filename, bool buildCache, bool loadVampire)
        {
            _kb.Intern.addConstituent(filename, buildCache, loadVampire);
        }

        #endregion
    }
}
