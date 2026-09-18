/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/3/2016
 * Time: 12:05 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.ReqPanelLift
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
      led0.Visible = false;
      led1.Visible = false;
      led2.Visible = false;
		}
		
		
		
		void REQ_Fired_EventHandler(object sender, HMI.Main.Symbols.ReqPanelLift.REQEventArgs ea)
		{
		  led0.Visible = (bool)ea.LightON0;
		  led1.Visible = (bool)ea.LightON1;
		  led2.Visible = (bool)ea.LightON2;
		}
		
		
		void Button0MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		  this.FireEvent_CHG(true,false,true,true,true,true);
		}
		
		void Button0MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		  this.FireEvent_CHG(false,false,true,true,true,true);
		}
		
		
		void Button1MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		  this.FireEvent_CHG(true,true,true,false,true,true);
		}
		
		
		void Button1MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		  this.FireEvent_CHG(true,true,false,false,true,true);
		}
		
		
		void Button2MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		  this.FireEvent_CHG(true,true,true,true,true,false);
		}
		
		
		void Button2MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		  this.FireEvent_CHG(true,true,true,true,false,false);
		}
		
		void Button0MouseLeave(object sender, EventArgs e)
		{
			this.FireEvent_CHG(false,false,true,true,true,true);
		}
		
		void Button1MouseLeave(object sender, EventArgs e)
		{
			this.FireEvent_CHG(true,true,false,false,true,true);
		}
		
		void Button2MouseLeave(object sender, EventArgs e)
		{
			this.FireEvent_CHG(true,true,true,true,false,false);
		}
	}
}
