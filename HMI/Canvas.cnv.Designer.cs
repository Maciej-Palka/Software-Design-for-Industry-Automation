/*
 * Created by UAPExpert.
 * User: Sandeep Patil
 * Date: 15/04/2020
 * Time: 9:30 pm
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for Canvas.
	/// </summary>
	partial class Canvas
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Model = new HMI.Main.Symbols.Model.sDefault();
			this.ControlPanel = new HMI.Main.Symbols.ControlPanel.sDefault();
			// 
			// Model
			// 
			this.Model.BeginInit();
			this.Model.AngleIgnore = false;
			this.Model.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, -8D, 0D);
			this.Model.Name = "Model";
			this.Model.SecurityToken = ((uint)(4294967295u));
			this.Model.TagName = "147B4E8B79BBFA44";
			this.Model.EndInit();
			// 
			// ControlPanel
			// 
			this.ControlPanel.BeginInit();
			this.ControlPanel.AngleIgnore = false;
			this.ControlPanel.DesignTransformation = new NxtControl.Drawing.Matrix(1D, 0D, 0D, 1D, 64D, 544D);
			this.ControlPanel.Name = "ControlPanel";
			this.ControlPanel.SecurityToken = ((uint)(4294967295u));
			this.ControlPanel.TagName = "BD83EAFE134E8405";
			this.ControlPanel.EndInit();
			// 
			// Canvas
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(590D)), ((float)(600D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Model,
			this.ControlPanel});
			this.Size = new System.Drawing.Size(590, 600);

		}
		private HMI.Main.Symbols.Model.sDefault Model;
		private HMI.Main.Symbols.ControlPanel.sDefault ControlPanel;
		#endregion
	}
}
