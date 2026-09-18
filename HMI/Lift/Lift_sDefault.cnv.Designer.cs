/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/3/2016
 * Time: 12:04 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Lift
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.car = new NxtControl.GuiFramework.Rectangle();
			// 
			// car
			// 
			this.car.Bounds = new NxtControl.Drawing.RectF(((float)(0)), ((float)(1)), ((float)(97)), ((float)(120)));
			this.car.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.VerticalTop));
			this.car.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.car.Name = "car";
			this.car.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.car});
			this.SymbolSize = new System.Drawing.Size(228, 248);
		}
		private NxtControl.GuiFramework.Rectangle car;
		#endregion
	}
}
