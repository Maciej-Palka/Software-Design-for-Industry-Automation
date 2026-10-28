/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 7/13/2016
 * Time: 4:28 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;
using System.Windows.Forms;

namespace HMI.Main.Symbols.ButtonsPanel
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
	  bool ManualMode = true;	  
	  bool ack = false;
	  bool reset = false;
	  bool start = false;
		
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			startLed.Visible = false;
			resetLed.Visible = false;
			ackLed.Visible = false;
			polygon2.Visible = false; // manual mode is enabled
						
			this.INIT1_Fired += new EventHandler<HMI.Main.Symbols.ButtonsPanel.INIT1EventArgs>(onINIT1);
			
			
		}
		
		void onINIT1(object sender, HMI.Main.Symbols.ButtonsPanel.INIT1EventArgs e)
		{
		  this.FireEvent_INITO1(true,true,true,true,true,true,ManualMode,false,false,false);
		}
		
		void Start_ledValueChanged(object sender, ValueChangedEventArgs e)
		{
		  startLed.Visible = (bool)e.Value;
		}
		
		void Reset_ledValueChanged(object sender, ValueChangedEventArgs e)
		{
		  resetLed.Visible = (bool)e.Value;
		}
		
		void Ack_ledValueChanged(object sender, ValueChangedEventArgs e)
		{
		  ackLed.Visible = (bool)e.Value;
		}
		
		void StartButtonMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.FireEvent_CNF(true,false,true,true,true,true,ManualMode,false,false,true);
			start = true; 
		}
		
		void StartButtonMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		  this.FireEvent_CNF(false,false,true,true,true,true,ManualMode,false,false,true);
		  start = false;
		}
		
		void StartButtonMouseLeave(object sender, EventArgs e)
		{
		  if (start)
		  {
		  this.FireEvent_CNF(false,false,true,true,true,true,ManualMode,false,false,true);
		  }
		}
		
		void ResetButtonMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.FireEvent_CNF(true,true,true,false,true,true,ManualMode,false,false,true);
			reset = true;
		}
		
		void ResetButtonMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.FireEvent_CNF(true,true,false,false,true,true,ManualMode,false,false,true);
			reset = false;
		}
		
		void ResetButtonMouseLeave(object sender, EventArgs e)
		{
		  if (reset)
		  {
			this.FireEvent_CNF(true,true,false,false,true,true,ManualMode,false,false,true);
		  }
		}
		
		void AckButtonMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.FireEvent_CNF(true,true,true,true,true,false,ManualMode,false,false,true);
			ack = true;
		}
		
		void AckButtonMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.FireEvent_CNF(true,true,true,true,false,false,ManualMode,false,false,true);
			ack = false;
		}
		
		void AckButtonMouseLeave(object sender, EventArgs e)
		{
		  if (ack)
		  {
		    this.FireEvent_CNF(true,true,true,true,false,false,ManualMode,false,false,true);
		  }
		}
		
		void StopButtonMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
		  this.FireEvent_CNF(true,true,true,true,true,true,true,true,true,false);
		}
		
		void StopButtonMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.FireEvent_CNF(true,true,true,true,true,true,true,true,false,false);
		}
		
		void StopButtonMouseLeave(object sender, System.EventArgs e)
		{
      this.FireEvent_CNF(true,true,true,true,true,true,true,true,true,false);
		}
		
		void ManualSwitchClick(object sender, EventArgs e)
		{
			bool temp1 = polygon1.Visible; // polygon 1 is manual mode
			bool temp2 = polygon2.Visible; // polygon 2 is automatic mode
			polygon1.Visible = !temp1;
			polygon2.Visible = !temp2;
			ManualMode = polygon1.Visible;
			this.FireEvent_CNF(true,true,true,true,true,true,ManualMode,false,true,true);
			if (ManualMode) {
			  label5.Text="Manual";
			}
			else label5.Text = "Automatic";
			
		}
	}
}
