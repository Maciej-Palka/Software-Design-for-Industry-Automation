/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/3/2016
 * Time: 3:38 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.CallButton
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
      ledON.Visible = false;
		}
		

		
		void REQ_Fired_EventHandler(object sender, HMI.Main.Symbols.CallButton.REQEventArgs ea)
		{
		  ledON.Visible = (bool)ea.LightON;
		}
		
		
		void Ellipse3MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		  this.FireEvent_CHG(true);
		}
		
		void Ellipse3MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		  this.FireEvent_CHG(false);
		}
		
		void Ellipse3MouseLeave(object sender, EventArgs e)
		{
		  this.FireEvent_CHG(false);
		}
	}
}
