/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 6/20/2016
 * Time: 4:32 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.ButtonM
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
			this.Button = new System.HMI.Symbols.Base.CheckButton();
			this.Label = new System.HMI.Symbols.Base.Label();
			// 
			// Button
			// 
			this.Button.BeginInit();
			this.Button.AngleIgnore = false;
			this.Button.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 29D, 31D);
			this.Button.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Button.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Button.Name = "Button";
			this.Button.TagName = "Button";
			this.Button.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Button.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Button.Value = false;
			this.Button.EndInit();
			// 
			// Label
			// 
			this.Label.BeginInit();
			this.Label.AngleIgnore = false;
			this.Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label.DesignTransformation = new NxtControl.Drawing.Matrix(0.6333333333333333D, 0D, 0D, 0.95238095238095233D, 22D, 67D);
			this.Label.FontScale = false;
			this.Label.IsOnlyInput = true;
			this.Label.Name = "Label";
			this.Label.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.Label.TagName = "Label";
			this.Label.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.Button,
									this.Label});
			this.SymbolSize = new System.Drawing.Size(600, 400);
		}
		private System.HMI.Symbols.Base.Label Label;
		private System.HMI.Symbols.Base.CheckButton Button;
		#endregion
	}
}
