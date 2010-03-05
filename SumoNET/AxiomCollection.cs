/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 1/5/2008
 * Time: 11:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;

namespace SumoNET
{
	/// <summary>
	/// Description of AxiomCollection.
	/// </summary>
	public class AxiomCollection : IEnumerable, IEnumerator
	{
		private KnowledgeBase _kb;
		private java.util.Iterator _it;
		
		public AxiomCollection(KnowledgeBase kb)
		{
			_kb = kb;
			_it = _kb.Intern.formulaMap.keySet().iterator();
		}
		
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
        	_it = _kb.Intern.formulaMap.keySet().iterator();
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
        		return _kb.Intern.formulaMap.size();
        	}
        }
        
        #endregion
	}
}
