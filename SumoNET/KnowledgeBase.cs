using System;
using System.Collections;

namespace SumoNET
{
    /// <summary>
    /// Represents a Knowledge base in SUMO (Wraps the com.articulate.sigma.KB)
    /// </summary>
    public class KnowledgeBase
    {
        private com.articulate.sigma.KB _kb;

        #region Constructors
        /// <summary>
        /// This constructor is usually not called by the user
        /// </summary>
        public KnowledgeBase(com.articulate.sigma.KB kb)
        {
            _kb = kb;
        }

        #endregion

        #region Properties
        
        public com.articulate.sigma.KB Intern
        {
        	get
        	{
        		return _kb;
        	}
        }
        
        /// <summary>
        /// The name of the knowledge base
        /// </summary>
        public string Name
        {
            get
            {
                return _kb.name;
            }
        }
        /// <summary>
        /// The languages available in this knowledge base
        /// </summary>
        public ArrayList Languages
        {
            get
            {
                return HelperUtils.ToArrayList(_kb.availableLanguages());
            }
        }
        /// <summary>
        /// The files that make up this knowledge base
        /// </summary>
        public ConstituentCollection Constituents
        {
            get
            {
            	return new ConstituentCollection(this);
            }
        }
        /// <summary>
        /// All terms available in this knowledge base
        /// </summary>
        public TermCollection Terms
        {
            get
            {
            	return new TermCollection(this);
            }
        }
        /// <summary>
        /// All terms available in this knowledge base
        /// </summary>
        public FormulaCollection Formulas
        {
            get
            {
            	return new FormulaCollection(this);
            }
        }
        /// <summary>
        /// All rules available in this knowledge base
        /// </summary>
        public RuleCollection Rules
        {
            get
            {
            	return new RuleCollection(this);
            }
        }
        /// <summary>
        /// All predicates available in this knowledge base
        /// </summary>
        public PredicateCollection Predicates
        {
            get
            {
            	return new PredicateCollection(this);
            }
        }
        
        public AxiomCollection Axioms
        {
        	get
        	{
        		return new AxiomCollection(this);
        	}
        }
        
        public RelationCollection Relations
        {
        	get
        	{
        		return new RelationCollection(this);
        	}
        }

        #endregion

        #region Public Methods
        /// <summary>
        /// Launch the inference engine (Vampire) to parse the constituents
        /// </summary>
        public void LoadInferenceEngine()
        {
            _kb.loadVampire();
        }
        /// <summary>
        /// Precache the constituents (Probably not needed)
        /// </summary>
        public void Cache()
        {
            _kb.cache();
        }
        /// <summary>
        /// Discard the current cache and reload the constituents again
        /// </summary>
        public void Reload()
        {
            _kb.reload();
        }
        // TODO : Document the XML structure returned here
        // TODO : Probably encapsulate the XML with a collection
        /// <summary>
        /// Infer the knowledge base using a SUO-KIF formula
        /// </summary>
        public string Ask(string suoKifFormula, int timeOut, int maxAnswers)
        {
            return _kb.ask(suoKifFormula, timeOut, maxAnswers);
        }

        // TODO : Document the kind variable 'ant' , 'cons' , 'stmt' , 'arg'
        public ArrayList Ask(string kind, int argNum, string term)
        {
            ArrayList result = new ArrayList();
            java.util.ArrayList jres = _kb.ask(kind, argNum, term);
            if(jres == null) return result;
            java.util.Iterator it = jres.iterator();
            while(it.hasNext())
            {
            	com.articulate.sigma.Formula jform = (com.articulate.sigma.Formula)it.next();
            	Formula f = new Formula(jform);
                result.Add(f);
            }
            return result;
        }

        public ArrayList Ask(int argNum1, string term1, int argNum2, string term2)
        {
            ArrayList result = new ArrayList();
            java.util.ArrayList jres = _kb.askWithRestriction(argNum1, term1, argNum2, term2);
            if(jres == null) return result;
            java.util.Iterator it = jres.iterator();
            while(it.hasNext())
            {
            	com.articulate.sigma.Formula jform = (com.articulate.sigma.Formula)it.next();
            	Formula f = new Formula(jform);
                result.Add(f);
            }
            return result;
        }
        
        public string Tell(string input)
        {
            return _kb.tell(input);
        }

        public bool IsChild(string child, string parent)
        {
            return _kb.childOf(child, parent);
        }

        public ArrayList GetInstancesOf(string term)
        {
            return HelperUtils.ToArrayList(_kb.instancesOf(term));
        }
        
        public ArrayList GetInstancesOf(Term term)
        {
            return HelperUtils.ToArrayList(_kb.instancesOf(term.Text));
        }
        
        public ArrayList GetNearestRelations(string term)
        {
        	ArrayList list = new ArrayList();
    		java.util.Iterator it = _kb.getNearestRelations(term).iterator();
    		while(it.hasNext())
    		{
    			Term t = new Term( this, it.next().ToString() );
    			list.Add(t);
    		}
    		return list;
        }
        
        public ArrayList GetNearestNonRelations(string term)
	    {
    		ArrayList list = new ArrayList();
    		java.util.Iterator it = _kb.getNearestNonRelations(term).iterator();
    		while(it.hasNext())
    		{
    			Term t = new Term( this, it.next().ToString() );
    			list.Add(t);
    		}
    		return list;
	    }
		
        public bool IsSubclass(string c1, string c2)
        {
            return _kb.isSubclass(c1, c2);
        }

        public void SaveAsKIF(string filepath)
        {
            _kb.writeFile(filepath);
        }

        public void SaveAsProlog(string filepath)
        {
            _kb.writePrologFile(filepath);
        }

        // TODO : Conjecture & onlyPlainFOL
        public void SaveAsTptp(string filepath)
        {
            _kb.writeTPTPFile(filepath, null, false, "");
        }

        public void SaveAsOwl(string filepath)
        {
            com.articulate.sigma.OWLtranslator owt = new com.articulate.sigma.OWLtranslator();
            owt.kb = _kb;
            owt.write(filepath);
        }

        #endregion
    }
}
