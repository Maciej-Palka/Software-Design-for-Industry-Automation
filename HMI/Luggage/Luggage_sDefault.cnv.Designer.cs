/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/29/2016
 * Time: 2:00 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Luggage
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
			this.luggage = new NxtControl.GuiFramework.Rectangle();
			// 
			// luggage
			// 
			this.luggage.Bounds = new NxtControl.Drawing.RectF(((float)(0)), ((float)(0)), ((float)(60)), ((float)(30)));
			this.luggage.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(183)), ((byte)(117)), ((byte)(64))));
			this.luggage.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.luggage.Name = "luggage";
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.luggage});
			this.SymbolSize = new System.Drawing.Size(294, 217);
		}
		private NxtControl.GuiFramework.Rectangle luggage;
		#endregion
	}
}
