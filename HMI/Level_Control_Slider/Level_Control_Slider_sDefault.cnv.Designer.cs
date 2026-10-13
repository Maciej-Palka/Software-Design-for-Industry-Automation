/*
 * Created by nxtSTUDIO.
 * User: prana
 * Date: 12/30/2019
 * Time: 10:58 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.Level_Control_Slider
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.Level_Value = new System.HMI.Symbols.Base.TrackerVertical<float>();
			this.Label = new System.HMI.Symbols.Base.Label();
			this.freeText_11 = new System.HMI.Symbols.Base.FreeText<float>();
			// 
			// Level_Value
			// 
			this.Level_Value.BeginInit();
			this.Level_Value.AngleIgnore = false;
			this.Level_Value.Brush = new NxtControl.Drawing.Brush("TrackerBrush");
			this.Level_Value.DesignTransformation = new NxtControl.Drawing.Matrix(0.92592592592592593D, 0D, 0D, 0.68333333333333335D, 104D, 42D);
			this.Level_Value.Font = new NxtControl.Drawing.Font("TrackerFont");
			this.Level_Value.Maximum = 380F;
			this.Level_Value.MaximumTag = null;
			this.Level_Value.Minimum = 120F;
			this.Level_Value.MinimumTag = null;
			this.Level_Value.MouseMoveValueThreshold = 0D;
			this.Level_Value.Name = "Level_Value";
			this.Level_Value.Pen = new NxtControl.Drawing.Pen("TrackerPen");
			this.Level_Value.Radius = 20D;
			this.Level_Value.TagName = "Level_Value";
			this.Level_Value.TickLength = 5;
			this.Level_Value.TrackHandleSize = 28;
			this.Level_Value.TrackLineDisabledBrush = new NxtControl.Drawing.Brush("TrackerLineDisabledBrush");
			this.Level_Value.EndInit();
			// 
			// Label
			// 
			this.Label.BeginInit();
			this.Label.AngleIgnore = false;
			this.Label.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Label.DesignTransformation = new NxtControl.Drawing.Matrix(0.86D, 0D, 0D, 0.80952380952380953D, 64D, 262D);
			this.Label.FontScale = false;
			this.Label.IsOnlyInput = true;
			this.Label.Name = "Label";
			this.Label.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.Label.TagName = "Label";
			this.Label.EndInit();
			// 
			// freeText_11
			// 
			this.freeText_11.BeginInit();
			this.freeText_11.AngleIgnore = false;
			this.freeText_11.DecimalPlacesCount = ((uint)(2u));
			this.freeText_11.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 205D, 137D);
			this.freeText_11.Name = "freeText_11";
			this.freeText_11.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			this.freeText_11.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.freeText_11.TagName = "Level_Value";
			this.freeText_11.TextAngle = 0F;
			this.freeText_11.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
									this.Level_Value,
									this.Label,
									this.freeText_11});
			this.SymbolSize = new System.Drawing.Size(600, 400);
		}
		private System.HMI.Symbols.Base.FreeText<float> freeText_11;
		private System.HMI.Symbols.Base.Label Label;
		private System.HMI.Symbols.Base.TrackerVertical<float> Level_Value;
		#endregion
	}
}
