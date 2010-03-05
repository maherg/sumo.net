/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 1/1/2008
 * Time: 2:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

namespace SumoNET
{
	/// <summary>
	/// Description of Word.
	/// </summary>
	public class Word
	{
		private string _text;
		private Synset _synset;
		
		public Word(Synset synset, string text)
		{
			_synset = synset;
			_text = text;
		}
		
		#region Public Properties
		
		public string Text
		{
			get
			{
				return _text;
			}
		}
		
		public Synset Synset
		{
			get
			{
				return _synset;
			}
		}
		
		#endregion
	}
}
