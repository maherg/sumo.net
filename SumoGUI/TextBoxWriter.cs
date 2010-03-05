/*
 * Created by SharpDevelop.
 * User: pc
 * Date: 12/30/2007
 * Time: 8:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Text;
using System.Windows.Forms;

namespace SumoGUI
{
	/// <summary>
	/// Description of TextBoxWriter.
	/// </summary>
	public class TextBoxWriter : System.IO.TextWriter
	{
		private TextBoxBase _control;
		private StringBuilder _builder;
		
		public TextBoxWriter(TextBox control)
		{
			_control = control;
			_control.HandleCreated += new EventHandler(OnHandleCreated);
		}
		
		public void OnHandleCreated(object sender, EventArgs args)
		{
			if(_builder != null)
			{
				_control.AppendText(_builder.ToString());
				_builder = null;
			}
		}
		
		public override void Write(char value)
		{
			Write(value.ToString());
		}
		
		public override void Write(string value)
		{
			if(_control.IsHandleCreated)
			{
				AppendText(value);
			}
			else
			{
				BufferText(value);
			}
		}
		
		public override void WriteLine(string value)
		{
			Write(value + Environment.NewLine);
		}
		
		public override Encoding Encoding
		{
			get
			{
				return Encoding.Default;
			}
		}
		
		private void BufferText(string s)
		{
			if(_builder == null)
			{
				_builder = new StringBuilder();
			}
			_builder.Append(s);
		}
		
		private void AppendText(string s)
		{
			if(_builder != null)
			{
				_control.AppendText(_builder.ToString());
				_builder = null;
			}
			_control.AppendText(s);
		}
	}
}
