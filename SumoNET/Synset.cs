/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 1/1/2008
 * Time: 2:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;
using System.Reflection;

namespace SumoNET
{
	/// <summary>
	/// Description of Synset.
	/// </summary>
	public class Synset
	{
		private string _id;
		private Hashtable _glosses;
		private Hashtable _nounTerms;
		private Hashtable _verbTerms;
		private Hashtable _adjTerms;
		private Hashtable _advTerms;
		
		#region Constructors
		/// <summary>
		/// Synset constructor
		/// </summary>
		/// <param name="id">Non-Prefixed Synset ID</param>
		public Synset(string id)
		{
			_id = id;
			// Cancelled these calls here, only call them when we need them.
			//_GetGlossesUsingReflection();
			//_GetTerms();
		}
		
		#endregion
		
		#region Private Methods
		
		private void _GetGlossesUsingReflection()
		{
			com.articulate.sigma.WordNet wn = SUMO.WordNet.Intern;
			FieldInfo nounType = wn.GetType().GetField("nounDocumentationHash", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
			FieldInfo verbType = wn.GetType().GetField("verbDocumentationHash", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
			FieldInfo adjType = wn.GetType().GetField("adjectiveDocumentationHash", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
			FieldInfo advType = wn.GetType().GetField("adverbDocumentationHash", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
			java.util.Hashtable nounHash = (java.util.Hashtable)nounType.GetValue(wn);
			java.util.Hashtable verbHash = (java.util.Hashtable)verbType.GetValue(wn);
			java.util.Hashtable adjHash = (java.util.Hashtable)adjType.GetValue(wn);
			java.util.Hashtable advHash = (java.util.Hashtable)advType.GetValue(wn);
			_glosses = new Hashtable();
			_glosses.Add(SpeechTypes.Noun , nounHash.get(_id) == null ? "" : nounHash.get(_id) );
			_glosses.Add(SpeechTypes.Verb , verbHash.get(_id) == null ? "" : verbHash.get(_id) );
			_glosses.Add(SpeechTypes.Adjective , adjHash.get(_id) == null ? "" : adjHash.get(_id) );
			_glosses.Add(SpeechTypes.Adverb , advHash.get(_id) == null ? "" : advHash.get(_id) );
		}
		
		private void _GetTerms()
		{
			com.articulate.sigma.WordNet wn = SUMO.WordNet.Intern;
			java.util.Iterator it;

                        _nounTerms = new Hashtable();
			it = wn.nounSUMOHash.keySet().iterator();
			while(it.hasNext())
			{
				string s = it.next().ToString();
				string[] terms = wn.nounSUMOHash.get(s).ToString().Split(' ');
				foreach(string t in terms)
				{
					char type = t[t.Length - 1];
                                        if(_nounTerms[type] == null)
                                        {
                                            _nounTerms[type] = new ArrayList();
                                        }
                                        string t1 = t.Substring(2);
					((ArrayList)_nounTerms[type]).Add(t1.Remove(t1.Length - 1));
				}
			}
                        
			_verbTerms = new Hashtable();
			it = wn.verbSUMOHash.keySet().iterator();
			while(it.hasNext())
			{
				string s = it.next().ToString();
				string[] terms = wn.verbSUMOHash.get(s).ToString().Split(' ');
				foreach(string t in terms)
				{
					char type = t[t.Length - 1];
                                        if(_verbTerms[type] == null)
                                        {
                                            _verbTerms[type] = new ArrayList();
                                        }
                                        string t1 = t.Substring(2);
					((ArrayList)_verbTerms[type]).Add(t1.Remove(t1.Length - 1));
				}
			}
			
			_adjTerms = new Hashtable();
			it = wn.adjectiveSUMOHash.keySet().iterator();
			while(it.hasNext())
			{
				string s = it.next().ToString();
				string[] terms = wn.adjectiveSUMOHash.get(s).ToString().Split(' ');
				foreach(string t in terms)
				{
					char type = t[t.Length - 1];
                                        if(_adjTerms[type] == null)
                                        {
                                            _adjTerms[type] = new ArrayList();
                                        }
                                        string t1 = t.Substring(2);
					((ArrayList)_adjTerms[type]).Add(t1.Remove(t1.Length - 1));
				}
			}			
			
			_advTerms = new Hashtable();
			it = wn.adverbSUMOHash.keySet().iterator();
			while(it.hasNext())
			{
				string s = it.next().ToString();
				string[] terms = wn.adverbSUMOHash.get(s).ToString().Split(' ');
				foreach(string t in terms)
				{
					char type = t[t.Length - 1];
                                        if(_advTerms[type] == null)
                                        {
                                            _advTerms[type] = new ArrayList();
                                        }
                                        string t1 = t.Substring(2);
					((ArrayList)_advTerms[type]).Add(t1.Remove(t1.Length - 1));
				}
			}
		}
		
		#endregion
		
		#region Public Properties
		
		public string ID
		{
			get
			{
				return _id;
			}
		}
		
		public Hashtable Glosses
		{
			get
			{
				if(_glosses == null)
				{
					_GetGlossesUsingReflection();
				}
				return _glosses;
			}
		}
		
		public WordCollection Nouns
		{
			get
			{
				return new WordCollection(this, SpeechTypes.Noun);
			}
		}
		
		public WordCollection Verbs
		{
			get
			{
				return new WordCollection(this, SpeechTypes.Verb);
			}
		}
		
		public WordCollection Adjectives
		{
			get
			{
				return new WordCollection(this, SpeechTypes.Adjective);
			}
		}
		
		public WordCollection Adverbs
		{
			get
			{
				return new WordCollection(this, SpeechTypes.Adverb);
			}
		}
		
		public WordCollection Words
		{
			get
			{
				return new WordCollection(this);
			}
		}
		
		public Hashtable NounTerms
		{
			get
			{
				if(_nounTerms == null)
				{
					_GetTerms();
				}
				return _nounTerms;
			}
		}
		
		public Hashtable VerbTerms
		{
			get
			{
				if(_verbTerms == null)
				{
					_GetTerms();
				}
				return _verbTerms;
			}
		}
		
		public Hashtable AdjectiveTerms
		{
			get
			{
				if(_adjTerms == null)
				{
					_GetTerms();
				}
				return _adjTerms;
			}
		}
		
		public Hashtable AdverbTerms
		{
			get
			{
				if(_advTerms == null)
				{
					_GetTerms();
				}
				return _advTerms;
			}
		}
		
		#endregion
	}
}
