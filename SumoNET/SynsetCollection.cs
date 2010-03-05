/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 1/13/2008
 * Time: 11:31 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;

namespace SumoNET
{
	/// <summary>
	/// Description of SynsetCollection.
	/// </summary>
	public class SynsetCollection : IEnumerator, IEnumerable
	{
		private java.util.ArrayList _synsets;
		private java.util.Iterator _it;
		
		public SynsetCollection()
		{
			_synsets = new java.util.ArrayList();
			_synsets.addAll(SUMO.WordNet.Intern.nounSUMOHash.keySet());
			java.util.Iterator it = SUMO.WordNet.Intern.verbSUMOHash.keySet().iterator();
			while(it.hasNext())
			{
				string s = it.next().ToString();
				if(_synsets.contains(s)) continue;
				_synsets.add(s);
			}
			it = SUMO.WordNet.Intern.adjectiveSUMOHash.keySet().iterator();
			while(it.hasNext())
			{
				string s = it.next().ToString();
				if(_synsets.contains(s)) continue;
				_synsets.add(s);
			}
			it = SUMO.WordNet.Intern.adverbSUMOHash.keySet().iterator();
			while(it.hasNext())
			{
				string s = it.next().ToString();
				if(_synsets.contains(s)) continue;
				_synsets.add(s);
			}
			_it = _synsets.iterator();
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
        	_it = _synsets.iterator();
        }

        public object Current
        {
            get
            {
            	return new Synset(_it.next().ToString());
            }
        }
		
		#endregion
		
		#region Public Properties
		
		public int Count
		{
			get
			{
				return _synsets.size();
			}
		}
		
		#endregion
	}
}
