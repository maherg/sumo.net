using System;
using System.IO;
using System.Collections;

namespace SumoNET
{
    /// <summary>
    /// The Japanese Beast !
    /// Wraps the (com.articulate.sigma.KBmanager)
    /// </summary>
    /// <example>
    /// <code>
    /// // Example Usage
    /// class MyClass
    /// {
    ///     public static Main()
    ///     {
    ///         SUMO.Init("/path/to/directory");
    ///         Console.WriteLine("We have {0} KBs", SUMO.KnowledgeBases.Count);
    ///         foreach(KnowledgeBase kb in SUMO.KnowledgeBases)
    ///         {
    ///             Console.WriteLine(kb.Name);
    ///             Console.WriteLine("{0} Language(s)", kb.Languages.Count);
    ///             foreach(string lang in kb.Languages)
    ///             {
    ///                 Console.WriteLine("Found {0}", lang);
    ///             }
    ///             Console.WriteLine("{0} Constituents", kb.Constituents.Count);
    ///             foreach(Constituent c in kb.Constituents)
    ///             {
    ///                 Console.WritLine("Consituent {0}", c.Path);
    ///             }
    ///             Console.WriteLine("{0} Terms", kb.Terms.Count);
    ///             Console.WriteLine("{0} Formulas", kb.Formulas.Count);
    ///             Console.WriteLine("{0} Rules", kb.Rules.Count);
    ///         }
    ///         Console.WriteLine("Done !");
    ///     }
    /// }
    /// </code>
    /// </example>
    public static class SUMO
    {
        private static com.articulate.sigma.KBmanager _mgr;
        private static bool _initialized;

        #region Constructors

        /// <summary>
        /// Basic constructor
        /// </summary>
        static SUMO()
        {
            _mgr = com.articulate.sigma.KBmanager.getMgr();
            _initialized = false;
        }

        #endregion
        
        #region Properties
        
        /// <summary>
        /// Determine wether SUMO has been initialized
        /// </summary>
        public static bool IsInitialized
        {
            get
            {
                return _initialized;
            }
        }

        /// <summary>
        /// SUMO would sometimes throw some error messages here
        /// </summary>
        public static string ErrorMessage
        {
            get
            {
                return _mgr.getError();
            }
        }

        /// <summary>
        /// Access all knowledgebases through this collection
        /// </summary>
        public static KnowledgeBaseCollection KnowledgeBases
        {
            get
            {
            	return new KnowledgeBaseCollection();
            }
        }

        /// <summary>
        /// Access all preferences through this collection
        /// </summary>
        public static PreferenceCollection Preferences
        {
            get
            {
            	return new PreferenceCollection();
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Initialize SUMO (This usually takes some time)
        /// </summary>
        /// <param name="baseDirectory">The directory path which contains the 'KBs' directory</param>
        public static void Init(string baseDirectory)
        {
            if(!_initialized)
            {
                if(Directory.Exists(baseDirectory))
                {
                    Environment.SetEnvironmentVariable("SIGMA_HOME", baseDirectory);
                    _mgr.initializeOnce();
                    WordNet.Init(); // Initialize the wordnet mappings too !
                    _initialized = true;
                }
                else
                {
                    throw new DirectoryNotFoundException("Cannot find " + baseDirectory);
                }
            }
        }

        /// <summary>
        /// Save the current configuration to the config.xml file
        /// </summary>
        public static void WriteConfiguration()
        {
            _mgr.writeConfiguration();
        }

        #endregion

        #region WordNet Inner Class

        /// <summary>
        /// Infer the SUMO-WordNet mappings here
        /// </summary>
        public static class WordNet
        {
            private static com.articulate.sigma.WordNet _wn;
            private static SynsetCollection _synsets;
			
            public static com.articulate.sigma.WordNet Intern
            {
            	get
            	{
            		return _wn;
            	}
            }
            /// <summary>
            /// Basic Initialization
            /// </summary>
            public static void Init()
            {
                com.articulate.sigma.WordNet.initOnce();
                _wn = com.articulate.sigma.WordNet.wn;
            }

            /// <summary>
            /// Determine wether a word of a specific type exists in WordNet
            /// </summary>
            /// <param name="word">The word text</param>
            /// <param name="type">Type of word (Noun, Verb, ...etc.)</param>
            /// <returns>True if it exists, False if not</returns>
            public static bool Contains(string word, SpeechTypes type)
            {
                return _wn.containsWord(word, (int)type);
            }
            /// <summary>
            /// 
            /// </summary>
            /// <param name="sentence">The sentence input</param>
            public static string CollectSUMOWordSenses(string sentence)
            {
                return _wn.collectSUMOWordSenses(sentence);
            }
            /// <summary>
            /// Determine the mapped SUMO term for this word
            /// </summary>
            /// <param name="word">Input word</param>
            public static string GetSUMOTerm(string word)
            {
                return _wn.getBestDefaultSense(word);
            }
            /// <summary>
            /// Determine the mapped SUMO term for this word
            /// </summary>
            /// <param name="word">Input word</param>
            /// <param name="type">Word type</param>
            public static string GetSUMOTerm(string word, SpeechTypes type)
            {
                string term = _wn.getSUMOterm(word, (int)type);
                if(term == "") return null;
                return term;
            }
            /// <summary>
            /// Retrieve all the senses that contain this word
            /// </summary>
            public static Hashtable GetSensesFromWord(string word)
            {
                java.util.TreeMap tmap = _wn.getSensesFromWord(word);
                java.util.Iterator it = tmap.keySet().iterator();
                Hashtable table = new Hashtable();
                while(it.hasNext())
                {
                    string key = (string)it.next();
                    java.util.ArrayList jlist = (java.util.ArrayList)tmap.get(key);
                    table.Add(key, HelperUtils.ToArrayList(jlist));
                }
                return table;
            }
            
            public static ArrayList GetSUMOTerm(Synset synset)
            {
            	ArrayList list = new ArrayList();
            	list.Add(_wn.getSUMOMapping((int)SpeechTypes.Noun + synset.ID));
            	list.Add(_wn.getSUMOMapping((int)SpeechTypes.Verb + synset.ID));
            	list.Add(_wn.getSUMOMapping((int)SpeechTypes.Adjective + synset.ID));
            	list.Add(_wn.getSUMOMapping((int)SpeechTypes.Adverb + synset.ID));
            	return list;
            }

            public static ArrayList GetWordsFromTerm(string sumoTerm)
            {
            	ArrayList list = new ArrayList();
            	if(sumoTerm == null || sumoTerm == "")
            	{
            		return list;
            	}
                java.util.TreeMap tmap = _wn.getWordsFromTerm(sumoTerm);
                if(tmap != null)
                {
                	java.util.Iterator it = tmap.keySet().iterator();
                	while(it.hasNext())
                	{
                		string w = it.next().ToString();
                		string syn = tmap.get(w).ToString();
                		Synset synObj = new Synset(syn);
                		Word word = new Word(synObj, w);
                		list.Add(word);
                	}
                }
                return list;
            }
            
            public static string GetNounRootForm(string mixedCase, string input)
            {
            	return _wn.nounRootForm(mixedCase, input);
            }
            
            public static string GetVerbRootForm(string mixedCase, string input)
            {
            	return _wn.verbRootForm(mixedCase, input);
            }
            
            #region Public Properties
            
            public static SynsetCollection Synsets
            {
            	get
            	{
            		if(_synsets == null)
            		{
            			_synsets = new SynsetCollection();
            		}
            		return _synsets;
            	}
            }
            
            #endregion

        }
		
        #endregion
    }
}
