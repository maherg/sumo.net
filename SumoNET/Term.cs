using System;
using System.Collections;

namespace SumoNET
{
    public class Term
    {
    	private KnowledgeBase _kb;
        private string _text;

        #region Constructors

        public Term(KnowledgeBase kb, string text)
        {
        	_kb = kb;
            _text = text;
        }

        #endregion
        
        #region Public Properties

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
            }
        }
        
        public ArrayList Instances
        {
        	get
        	{
        		return _kb.Ask(2, _text, 0, "instance");
        	}
        }
        
        public ArrayList InstanceOf
        {
        	get
        	{
        		return _kb.Ask(1, _text, 0, "instance");
        	}
        }
        
        public ArrayList Subclasses
        {
        	get
        	{
        		return _kb.Ask(2, _text, 0, "subclass");
        	}
        }
        
        public ArrayList Superclasses
        {
        	get
        	{
        		return _kb.Ask(1, _text, 0, "subclass");
        	}
        }
        
        public string Documentation
        {
        	get
        	{
        		ArrayList list = _kb.Ask(1, _text, 0, "documentation");
        		string doc = "";
        		if(list.Count > 0)
        		{
        			Formula f = (Formula)list[0];
        			doc = f.GetArgument(2).Trim(new char[]{'\"'});
        		}
        		return doc;
        	}
        }
        
        public Hashtable Appearances
        {
        	get
        	{
        		Hashtable table = new Hashtable();
        		for(int i = 0;i < 7; i++)
        		{
        			ArrayList list = _kb.Ask("arg", i, _text);
        			table[i] = list;
        		}
        		return table;
        	}
        }
        
        public ArrayList Words
        {
        	get
        	{
        		return SUMO.WordNet.GetWordsFromTerm(_text);
        	}
        }
        
        #endregion
        
    }
}
