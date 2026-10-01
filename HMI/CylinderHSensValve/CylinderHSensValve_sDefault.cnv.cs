/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/28/2016
 * Time: 11:50 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.CylinderHSensValve
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

		void REQ_Fired_EventHandler(object sender, REQEventArgs e)
		{
			bool output = e.FWD_IN.Value;
			this.FireEvent_CNF(output);
		}
	}
}
