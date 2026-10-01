/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/25/2016
 * Time: 10:19 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.CylinderV
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

		void POSValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.PointF newPos = GrpInnerPart.Location;
		  float position = -(float)e.Value;
		  double relpos = position + 70.0d;
			newPos.Y = relpos;
			GrpInnerPart.Location = newPos;
		}
	}
}
