/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 1/5/2008
 * Time: 11:32 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections;

namespace SumoNET
{
	/// <summary>
	/// Description of RelationCollection.
	/// </summary>
	public class RelationCollection
	{
		private KnowledgeBase _kb;

		public RelationCollection(KnowledgeBase kb)
		{
			_kb = kb;
		}
		
		#region Public Properties
		
		public int Count
		{
			get
			{
				// this calls in java : getAllInstances("Relation").size();
				return _kb.Intern.getCountRelations();
			}
		}
		
		#endregion
	}
}
