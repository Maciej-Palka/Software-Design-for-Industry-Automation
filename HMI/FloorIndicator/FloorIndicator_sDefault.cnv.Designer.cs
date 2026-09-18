/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/3/2016
 * Time: 3:18 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.FloorIndicator
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
			this.floor = new NxtControl.GuiFramework.Label();
			// 
			// floor
			// 
			this.floor.AngleIgnore = true;
			this.floor.Bounds = new NxtControl.Drawing.RectF(((float)(34)), ((float)(21)), ((float)(31)), ((float)(25)));
			this.floor.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.floor.Font = new NxtControl.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold);
			this.floor.Name = "floor";
			this.floor.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.floor.Text = "0";
			this.floor.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.floor.TextAutoSizeHorizontalOffset = 10;
			this.floor.TextColor = new NxtControl.Drawing.Color("Red");
			this.floor.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.floor});
			this.SymbolSize = new System.Drawing.Size(600, 400);
		}
		private NxtControl.GuiFramework.Label floor;
		#endregion
	}
}
