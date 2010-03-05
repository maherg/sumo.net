/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 1/14/2008
 * Time: 8:13 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;

namespace SumoNET
{
	/// <summary>
	/// Description of WordCollection.
	/// </summary>
	public class WordCollection : IEnumerator , IEnumerable
	{
		private Synset _synset;
		private java.util.ArrayList _words;
		private java.util.Iterator _it;
		
		public WordCollection(Synset synset, SpeechTypes type)
		{
			_synset = synset;
			_words = (java.util.ArrayList)SUMO.WordNet.Intern.synsetsToWords.get((int)type + _synset.ID);
			if(_words == null) _words = new java.util.ArrayList();
			_it = _words.iterator();
		}
		
		public WordCollection(Synset synset)
		{
			_synset = synset;
			_words = new java.util.ArrayList();
			java.util.ArrayList nouns = (java.util.ArrayList)SUMO.WordNet.Intern.synsetsToWords.get((int)SpeechTypes.Noun + _synset.ID);
			java.util.ArrayList verbs = (java.util.ArrayList)SUMO.WordNet.Intern.synsetsToWords.get((int)SpeechTypes.Verb + _synset.ID);
			java.util.ArrayList adjs = (java.util.ArrayList)SUMO.WordNet.Intern.synsetsToWords.get((int)SpeechTypes.Adjective + _synset.ID);
			java.util.ArrayList advs = (java.util.ArrayList)SUMO.WordNet.Intern.synsetsToWords.get((int)SpeechTypes.Adverb + _synset.ID);
			if(nouns != null) _words.addAll(nouns);
			if(verbs != null) _words.addAll(verbs);
			if(adjs != null) _words.addAll(adjs);
			if(advs != null) _words.addAll(advs);
			_it = _words.iterator();
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
            _it = _words.iterator();
        }

        public object Current
        {
            get
            {
            	return new Word(_synset, _it.next().ToString());
            }
        }

        #endregion

        #region Public Properties
        
        public int Count
        {
            get
            {
                return _words.size();
            }
        }

        #endregion
	}
}
