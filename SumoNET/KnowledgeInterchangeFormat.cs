/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 1/5/2008
 * Time: 1:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SumoNET
{
	/// <summary>
	/// Description of KnowledgeInterchangeFormat.
	/// </summary>
	public class KnowledgeInterchangeFormat
	{
		private com.articulate.sigma.KIF _kif;
		
		public KnowledgeInterchangeFormat()
		{
			_kif = new com.articulate.sigma.KIF();
		}
		
		#region Public Methods
		
		public string Parse(string formula)
		{
			return _kif.parseStatement(formula);
		}
		
		#endregion
	}
}
