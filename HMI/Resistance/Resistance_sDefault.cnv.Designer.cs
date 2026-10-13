/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/21/2016
 * Time: 5:39 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Resistance
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sDefault));
			this.resistBlack = new NxtControl.GuiFramework.Rectangle();
			this.resistRed = new NxtControl.GuiFramework.Rectangle();
			this.resistBroken = new NxtControl.GuiFramework.Rectangle();
			this.resistWhite = new NxtControl.GuiFramework.Rectangle();
			// 
			// resistBlack
			// 
			this.resistBlack.Bounds = new NxtControl.Drawing.RectF(((float)(55)), ((float)(21)), ((float)(85)), ((float)(94)));
			this.resistBlack.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.resistBlack.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.resistBlack.ImageStream = ((System.IO.MemoryStream)(resources.GetObject("resistBlack.ImageStream")));
			this.resistBlack.Name = "resistBlack";
			this.resistBlack.Pen = new NxtControl.Drawing.Pen("Transparent");
			this.resistBlack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			// 
			// resistRed
			// 
			this.resistRed.Bounds = new NxtControl.Drawing.RectF(((float)(54)), ((float)(24)), ((float)(90)), ((float)(91)));
			this.resistRed.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.resistRed.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.resistRed.ImageStream = ((System.IO.MemoryStream)(resources.GetObject("resistRed.ImageStream")));
			this.resistRed.Name = "resistRed";
			this.resistRed.Pen = new NxtControl.Drawing.Pen("Transparent");
			this.resistRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			// 
			// resistBroken
			// 
			this.resistBroken.Bounds = new NxtControl.Drawing.RectF(((float)(17)), ((float)(26)), ((float)(149)), ((float)(89)));
			this.resistBroken.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.resistBroken.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.resistBroken.ImageStream = ((System.IO.MemoryStream)(resources.GetObject("resistBroken.ImageStream")));
			this.resistBroken.Name = "resistBroken";
			this.resistBroken.Pen = new NxtControl.Drawing.Pen("Transparent");
			this.resistBroken.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			// 
			// resistWhite
			// 
			this.resistWhite.Bounds = new NxtControl.Drawing.RectF(((float)(54)), ((float)(24)), ((float)(90)), ((float)(91)));
			this.resistWhite.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.resistWhite.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.resistWhite.ImageStream = ((System.IO.MemoryStream)(resources.GetObject("resistWhite.ImageStream")));
			this.resistWhite.Name = "resistWhite";
			this.resistWhite.Pen = new NxtControl.Drawing.Pen("Transparent");
			this.resistWhite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.resistBroken,
									this.resistBlack,
									this.resistRed,
									this.resistWhite});
			this.SymbolSize = new System.Drawing.Size(600, 400);
		}
		private NxtControl.GuiFramework.Rectangle resistWhite;
		private NxtControl.GuiFramework.Rectangle resistBroken;
		private NxtControl.GuiFramework.Rectangle resistRed;
		private NxtControl.GuiFramework.Rectangle resistBlack;
		#endregion
	}
}
