/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 1/16/2008
 * Time: 6:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SumoNET
{
	/// <summary>
	/// Description of SumoMapping.
	/// </summary>
	public enum SumoMapping
	{
		Synonym = '=', 	// = means equivalence
		Hypernym = '+',	// + means concept is a hypernym of the synset
		Instance = '@',	// @ means instance
	}
}
