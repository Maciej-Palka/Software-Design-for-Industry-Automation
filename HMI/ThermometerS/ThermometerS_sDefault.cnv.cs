/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/21/2016
 * Time: 11:18 AM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.ThermometerS
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
		
		
		
		void REQ_Fired_EventHandler(object sender, HMI.Main.Symbols.ThermometerS.REQEventArgs ea)
		{
		  temperature.FillPercent = (float)((ea.Temperature-20.0)*1.25);
		}
	}
}
