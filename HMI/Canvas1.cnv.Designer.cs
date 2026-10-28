/*
 * Created by EcoStruxure Automation Expert.
 * User: Cheyan
 * Date: 7/14/2023
 * Time: 1:08 PM
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
	/// Summary description for Canvas1.
	/// </summary>
	partial class Canvas1
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DistributionStation = new HMI.Main.Symbols.Model.sDefault();
			this.PanelButtons = new HMI.Main.Symbols.ButtonsPanel.sDefault();
			this.TestPanel = new HMI.Main.Symbols.Test.sDefault();
			// 
			// DistributionStation
			// 
			this.DistributionStation.BeginInit();
			this.DistributionStation.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 34D, 74D);
			this.DistributionStation.Name = "DistributionStation";
			this.DistributionStation.SecurityToken = ((uint)(4294967295u));
			this.DistributionStation.TagName = "D12900462E398B6B";
			this.DistributionStation.EndInit();
			// 
			// PanelButtons
			// 
			this.PanelButtons.BeginInit();
			this.PanelButtons.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 187D, 437D);
			this.PanelButtons.Name = "PanelButtons";
			this.PanelButtons.SecurityToken = ((uint)(4294967295u));
			this.PanelButtons.TagName = "BF2619D5BC968C4A";
			this.PanelButtons.EndInit();
			// 
			// TestPanel
			// 
			this.TestPanel.BeginInit();
			this.TestPanel.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 112D, 352D);
			this.TestPanel.Name = "TestPanel";
			this.TestPanel.SecurityToken = ((uint)(4294967295u));
			this.TestPanel.TagName = "776930EB9E584B2B";
			this.TestPanel.EndInit();
			// 
			// Canvas1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1024D)), ((float)(530D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "Canvas1";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.DistributionStation,
			this.PanelButtons,
			this.TestPanel});
			this.Size = new System.Drawing.Size(1024, 530);

		}
		private HMI.Main.Symbols.Model.sDefault DistributionStation;
		private HMI.Main.Symbols.ButtonsPanel.sDefault PanelButtons;
		private HMI.Main.Symbols.Test.sDefault TestPanel;
		#endregion
	}
}
