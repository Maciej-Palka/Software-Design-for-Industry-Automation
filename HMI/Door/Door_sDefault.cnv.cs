/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/3/2016
 * Time: 10:37 AM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Door
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

      Color newColor = new Color();
      newColor = Color.FromArgb(165,2,178,238);
		  DoorLeft.BrushColor.SetColor(newColor);
		  DoorRight.BrushColor.SetColor(newColor);
		}

		void DoorPositionValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.PointF newPosRight = DoorRight.Location;
			NxtControl.Drawing.PointF newPosLeft = DoorLeft.Location;
		  float position = (float)e.Value;
		  double relPosRight = position + 123.0d;
		  double relPosLeft = -position + 70.0d;
			newPosRight.X = relPosRight;
			newPosLeft.X = relPosLeft;
		  DoorRight.Location = newPosRight;
		  DoorLeft.Location = newPosLeft;
		}
		

	}
}
