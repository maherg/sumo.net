using System;
using System.Collections;

namespace SumoNET
{
    public class FormulaCollection
    {
        private com.articulate.sigma.KB _kb;

        #region Constructors
        
        public FormulaCollection(KnowledgeBase kb)
        {
            _kb = kb.Intern;
        }

        #endregion

        #region Indexers

        public Formula this[string formula]
        {
            get
            {
                return new Formula((com.articulate.sigma.Formula)_kb.formulaMap.get(formula));
            }
        }

        #endregion

        #region Public Properties
        
        public int Count
        {
            get
            {
                return _kb.getCountAxioms();
            }
        }

        #endregion

        #region Public Methods

        public bool Contains(String formula)
        {
            return _kb.containsFormula(formula);
        }

        #endregion
    }
}
