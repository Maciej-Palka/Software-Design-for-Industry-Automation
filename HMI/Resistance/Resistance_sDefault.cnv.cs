/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/21/2016
 * Time: 5:39 PM
 * 
 */

using System;
//using System.Drawing;
using NxtControl.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Resistance
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
			ImageAttributes attr = new ImageAttributes();
			attr.Equals(NxtControl.Drawing.Color.FromName("Magenta"));
  		//attr.SetColorKey(System.Drawing.Color.FromArgb(0xFF00FF), System.Drawing.Color.FromArgb(0xFF00FF));
  		resistBlack.ImageAttributes = attr; 
  		resistRed.ImageAttributes = attr;
  		resistBroken.ImageAttributes = attr;
  		resistWhite.ImageAttributes = attr;
      this.REQ_Fired += REQ_Fired_EventHandler;
      resistRed.Visible = false;
      resistBroken.Visible = false;
      resistBlack.Visible = true;
      resistWhite.Visible = false;
		}
		
		void REQ_Fired_EventHandler(object sender, HMI.Main.Symbols.Resistance.REQEventArgs ea)
		{
		  if ((bool)ea.HeatON && !(bool)ea.Overheating && !(bool)ea.ResistBroken)
		  {
		    resistRed.Visible = true;
		    resistWhite.Visible = false;
		    resistBlack.Visible = false;
        resistBroken.Visible = false;
		  }
		  else if ((!(bool)ea.HeatON && !(bool)ea.Overheating && !(bool)ea.ResistBroken))
      {
        resistRed.Visible = false;
        resistBlack.Visible = true;
        resistBroken.Visible = false;
        resistWhite.Visible = false;
      }
		  else if ((bool)ea.Overheating && !(bool)ea.ResistBroken)
		  {
		    resistRed.Visible = false;
        resistBlack.Visible = false;
        resistBroken.Visible = false;
        resistWhite.Visible = true;
		  }
		  else
		  {
				resistRed.Visible = false;
		    resistBlack.Visible = false;
		    resistWhite.Visible = false;
		    resistBroken.Visible = true;
		  }
		  
		}
		

	}
}
