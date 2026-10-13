/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/20/2016
 * Time: 3:36 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Tank
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
			attentionSign.Visible = false;
      label1.Visible = false;
      this.REQ2_Fired += REQ2_Fired_EventHandler;
      this.REQ_Fired += REQ_Fired_EventHandler;
		}
		
		void REQ2_Fired_EventHandler(object sender, HMI.Main.Symbols.Tank.REQ2EventArgs ea)
		{
		  svLedOFF.Visible = !(bool)ea.InletSlow;
		  fvLedOFF.Visible = !(bool)ea.InletFast;
		  outLedOFF.Visible = !(bool)ea.Outlet;
		}
		
		void REQ_Fired_EventHandler(object sender, HMI.Main.Symbols.Tank.REQEventArgs ea)
		{
		  water.FillPercent = (float)(ea.Position/4.5);
		  attentionSign.Visible = (bool)ea.Attention;
		  label1.Visible = !(bool)ea.TankRupture;
		}
	}
}
