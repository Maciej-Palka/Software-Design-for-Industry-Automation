/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/29/2016
 * Time: 2:00 AM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Luggage
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

		void REQ_Fired_EventHandler(object sender, HMI.Main.Symbols.Luggage.REQEventArgs ea)
		{
      NxtControl.Drawing.PointF newPos = luggage.Location;
      newPos.X = (double)ea.PositionX;
      newPos.Y = (double)ea.PositionY;
			luggage.Location = newPos;
		}
	}
}
