/*
 * Created by nxtSTUDIO.
 * User: prana
 * Date: 12/30/2019
 * Time: 10:58 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.pump_slider
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}
		
		void LabelValueChanged(object sender, ValueChangedEventArgs e)
		{
			
		}
		
		void FreeText_11ValueChanged(object sender, ValueChangedEventArgs e)
		{
			
		}
	}
}
