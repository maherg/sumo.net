using System;
using System.Collections;

namespace SumoNET
{
    public class Formula
    {
        private com.articulate.sigma.Formula _formula;

        #region Constructors
        
        public Formula(com.articulate.sigma.Formula formula)
        {
            _formula = formula;
        }
        
        #endregion
        
        #region Static Methods
        
        public static string Parse(string formula)
        {
        	string msg = new com.articulate.sigma.KIF().parseStatement(formula);
        	return msg;
        }
        
        #endregion

        #region Public Properties

        public com.articulate.sigma.Formula Intern
        {
        	get
        	{
        		return _formula;
        	}
        }
        
        public string SourceFile
        {
            get
            {
                return _formula.sourceFile;
            }
        }
        
        public int StartLine
        {
            get
            {
                return _formula.startLine;
            }
        }

        public int EndLine
        {
            get
            {
                return _formula.endLine;
            }
        }

        public string Text
        {
            get
            {
                return _formula.theFormula;
            }
        }

        public TptpCollection Tptp
        {
            get
            {
                return new TptpCollection(this);
            }
        }

        public ClauseCollection Clauses
        {
            get
            {
                return new ClauseCollection(this);
            }
        }
        
        public bool IsEmpty
        {
        	get
        	{
        		return _formula.empty();
        	}
        }
        
        public bool IsList
        {
        	get
        	{
        		return _formula.listP();
        	}
        }
        
        #endregion
        
        #region Public Methods
        
        public string GetArgument(int argNum)
        {
        	return _formula.getArgument(argNum);
        }
        
        #endregion
    }
}
