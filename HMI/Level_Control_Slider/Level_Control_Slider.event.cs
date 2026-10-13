/*
 * Created by nxtSTUDIO.
 * User: prana
 * Date: 12/30/2019
 * Time: 10:58 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #Level_Control_Slider_HMI;

namespace HMI.Main.Symbols.Level_Control_Slider
{

  public class REQEventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public REQEventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }
    public bool Get_Label(ref System.String value)
    {
      if (accessorService == null)
        return false;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.String) var;
      return ret;
    }

    public System.String Label
    { get {
      if (accessorService == null)
        return null;
      string var = null;
      bool ret = accessorService.GetStringValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.String) var;
    }  }


  }

}

namespace HMI.Main.Symbols.Level_Control_Slider
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.Single? Level_Value_field = null;
    public System.Single? Level_Value
    {
       get { return Level_Value_field; }
       set { Level_Value_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.Level_Control_Slider
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.Level_Control_Slider.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (REQ_Fired != null)
        AttachEventInput(0);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new HMI.Main.Symbols.Level_Control_Slider.REQEventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","REQ_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 

      }
    }
    public bool FireEvent_CNF(System.Single Level_Value)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {Level_Value});
    }
    public bool FireEvent_CNF(HMI.Main.Symbols.Level_Control_Slider.CNFEventArgs ea)
    {
      object[] _values_ = new object[1];
      if (ea.Level_Value.HasValue) _values_[0] = ea.Level_Value.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Single Level_Value, bool ignore_Level_Value)
    {
      object[] _values_ = new object[1];
      if (!ignore_Level_Value) _values_[0] = Level_Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #Level_Control_Slider_HMI;

#endregion Definitions;
