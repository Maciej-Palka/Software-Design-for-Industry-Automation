/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/3/2016
 * Time: 3:18 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.FloorIndicator
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
      this.REQ_Fired += REQ_Fired_EventHandler;
		}
		
		void REQ_Fired_EventHandler(object sender, HMI.Main.Symbols.FloorIndicator.REQEventArgs ea)
		{
		  floor.Text = ea.FloorNr.ToString();
		}
	}
}
