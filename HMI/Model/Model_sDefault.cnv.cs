/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 7/13/2016
 * Time: 4:20 PM
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Model
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
      newColor = Color.FromArgb(100,2,178,238);
      rectangle5.BrushColor.SetColor(newColor);
      rectangle4.BrushColor.SetColor(newColor);
      
      Color redColor = Color.FromArgb(234,22,30);
		  Color blackColor = Color.FromArgb(1,1,1);
		  Color greyColor = Color.FromArgb(102,102,102);
		  Random rnd = new Random(DateTime.Now.Millisecond);
		  int material = rnd.Next(1,4);
		  switch (material)
			{
		    case 1:
		      wp1.BrushColor.SetColor(blackColor);
		      break;
		    case 2:
		      wp1.BrushColor.SetColor(redColor);
		      break;
		    case 3:
		      wp1.BrushColor.SetColor(greyColor);
		      break;
			}
		  material = rnd.Next(1,4);
		  switch (material)
			{
		    case 1:
		      wp2.BrushColor.SetColor(blackColor);
		      break;
		    case 2:
		      wp2.BrushColor.SetColor(redColor);
		      break;
		    case 3:
		      wp2.BrushColor.SetColor(greyColor);
		      break;
			}
		  material = rnd.Next(1,4);
		  switch (material)
			{
		    case 1:
		      wp3.BrushColor.SetColor(blackColor);
		      break;
		    case 2:
		      wp3.BrushColor.SetColor(redColor);
		      break;
		    case 3:
		      wp3.BrushColor.SetColor(greyColor);
		      break;
			}
		  material = rnd.Next(1,4);
		  switch (material)
			{
		    case 1:
		      wp4.BrushColor.SetColor(blackColor);
		      break;
		    case 2:
		      wp4.BrushColor.SetColor(redColor);
		      break;
		    case 3:
		      wp4.BrushColor.SetColor(greyColor);
		      break;
			}
		  material = rnd.Next(1,4);
		  switch (material)
			{
		    case 1:
		      wp5.BrushColor.SetColor(blackColor);
		      break;
		    case 2:
		      wp5.BrushColor.SetColor(redColor);
		      break;
		    case 3:
		      wp5.BrushColor.SetColor(greyColor);
		      break;
			}
		  material = rnd.Next(1,4);
		  switch (material)
			{
		    case 1:
		      wp6.BrushColor.SetColor(blackColor);
		      break;
		    case 2:
		      wp6.BrushColor.SetColor(redColor);
		      break;
		    case 3:
		      wp6.BrushColor.SetColor(greyColor);
		      break;
			}
		}
		
		
		void PosPusherValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.PointF newPos = pusher.Location;
			newPos.X = (double)((float)e.Value + 137.0);
			pusher.Location = newPos;
		}
		
		void PosTransUnitValueChanged(object sender, ValueChangedEventArgs e)
		{
		  TransArm.Angle = (float)e.Value;
		  NxtControl.Drawing.PointF newPos = vacum.Location;
		  newPos.X = (477 + (double)((Math.Cos((float)e.Value * Math.PI / 180))*170.0))-11;
		  newPos.Y = 196 - (double)((Math.Sin((float)e.Value * Math.PI / 180))*170.0);
		  vacum.Location = newPos;
		}
		
		void Wp1YValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.PointF newPos = wp1.Location;
			newPos.Y = (double)(float)e.Value;
			wp1.Location = newPos;
		}
		
		void Wp1XValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.PointF newPos = wp1.Location;
			newPos.X = (double)(float)e.Value;
			wp1.Location = newPos;
		}
		
		void Wp2XValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.PointF newPos = wp2.Location;
			newPos.X = (double)(float)e.Value;
			wp2.Location = newPos;
		}
		
		void Wp2YValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.PointF newPos = wp2.Location;
			newPos.Y = (double)(float)e.Value;
			wp2.Location = newPos;
		}
		
		void Wp3XValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.PointF newPos = wp3.Location;
			newPos.X = (double)(float)e.Value;
			wp3.Location = newPos;
		}
		
		void Wp3YValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.PointF newPos = wp3.Location;
			newPos.Y = (double)(float)e.Value;
			wp3.Location = newPos;
		}
		
		void Wp4XValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.PointF newPos = wp4.Location;
			newPos.X = (double)(float)e.Value;
			wp4.Location = newPos;
		}
		
		void Wp4YValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.PointF newPos = wp4.Location;
			newPos.Y = (double)(float)e.Value;
			wp4.Location = newPos;
		}
		
		void Wp5XValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.PointF newPos = wp5.Location;
			newPos.X = (double)(float)e.Value;
			wp5.Location = newPos;
		}
		
		void Wp5YValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.PointF newPos = wp5.Location;
			newPos.Y = (double)(float)e.Value;
			wp5.Location = newPos;
		}
		
		void Wp6XValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.PointF newPos = wp6.Location;
			newPos.X = (double)(float)e.Value;
			wp6.Location = newPos;
		}
		
		void Wp6YValueChanged(object sender, ValueChangedEventArgs e)
		{
			NxtControl.Drawing.PointF newPos = wp6.Location;
			newPos.Y = (double)(float)e.Value;
			wp6.Location = newPos;
		}
	}
}
