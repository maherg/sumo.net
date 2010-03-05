using System;
using System.Collections;
using com.articulate.sigma;

namespace SumoNET
{
    public class KnowledgeBaseCollection : IEnumerable, IEnumerator
    {
        private KBmanager _mgr;
        private java.util.Iterator _it;

        #region Constructors
        
        public KnowledgeBaseCollection()
        {
            _mgr = KBmanager.getMgr();
            _it = _mgr.getKBnames().iterator();
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
            _it = _mgr.getKBnames().iterator();
        }

        public object Current
        {
            get
            {
                return new KnowledgeBase(_mgr.getKB((string)_it.next()));
            }
        }

        #endregion

        #region Public Properties
        
        public int Count
        {
            get
            {
                return _mgr.getKBnames().size();
            }
        }

        #endregion

        #region Public Indexers

        public KnowledgeBase this[string key]
        {
            get
            {
                if(_mgr.getKBnames().contains(key))
                {
                    KB kb = _mgr.getKB(key);
                    return new KnowledgeBase(kb);
                }
                else
                {
                    return null;
                }
            }
        }

        #endregion

        #region Public Methods
        
        public KnowledgeBase Add(string name)
        {
            _mgr.addKB(name);
            return this[name];
        }

        public void Remove(string name)
        {
            _mgr.removeKB(name);
        }

        public bool Exists(string name)
        {
            return _mgr.existsKB(name);
        }

        #endregion
    }
}
