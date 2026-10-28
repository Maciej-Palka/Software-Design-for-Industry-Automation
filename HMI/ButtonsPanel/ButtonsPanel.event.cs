/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 7/13/2016
 * Time: 4:28 PM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #ButtonsPanel_HMI;

namespace HMI.Main.Symbols.ButtonsPanel
{

  public class INIT1EventArgs : System.EventArgs
  {
    IHMIAccessorService accessorService;
    int channelId;
    int cookie; 
    int eventIndex;

    public INIT1EventArgs(int channelId, int cookie, int eventIndex)
    {
      this.accessorService = (IHMIAccessorService)ServiceProvider.GetService(typeof(IHMIAccessorService));
      this.channelId = channelId;
      this.cookie = cookie;
      this.eventIndex = eventIndex;
    }

  }

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
    public bool Get_start_led(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? start_led
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_reset_led(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? reset_led
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_ack_led(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? ack_led
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,2, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace HMI.Main.Symbols.ButtonsPanel
{

  public class INITO1EventArgs : System.EventArgs
  {
    public INITO1EventArgs()
    {
    }
    private System.Boolean? start_field = null;
    public System.Boolean? start
    {
       get { return start_field; }
       set { start_field = value; }
    }
    private System.Boolean? reset_field = null;
    public System.Boolean? reset
    {
       get { return reset_field; }
       set { reset_field = value; }
    }
    private System.Boolean? ack_field = null;
    public System.Boolean? ack
    {
       get { return ack_field; }
       set { ack_field = value; }
    }
    private System.Boolean? manual_field = null;
    public System.Boolean? manual
    {
       get { return manual_field; }
       set { manual_field = value; }
    }
    private System.Boolean? stop_field = null;
    public System.Boolean? stop
    {
       get { return stop_field; }
       set { stop_field = value; }
    }

  }

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.Boolean? start_field = null;
    public System.Boolean? start
    {
       get { return start_field; }
       set { start_field = value; }
    }
    private System.Boolean? reset_field = null;
    public System.Boolean? reset
    {
       get { return reset_field; }
       set { reset_field = value; }
    }
    private System.Boolean? ack_field = null;
    public System.Boolean? ack
    {
       get { return ack_field; }
       set { ack_field = value; }
    }
    private System.Boolean? manual_field = null;
    public System.Boolean? manual
    {
       get { return manual_field; }
       set { manual_field = value; }
    }
    private System.Boolean? stop_field = null;
    public System.Boolean? stop
    {
       get { return stop_field; }
       set { stop_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.ButtonsPanel
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.ButtonsPanel.INIT1EventArgs> INIT1_Fired;

    private event EventHandler<HMI.Main.Symbols.ButtonsPanel.REQEventArgs> REQ_Fired;

    protected override void OnEndInit()
    {
      if (INIT1_Fired != null)
        AttachEventInput(0);
      if (REQ_Fired != null)
        AttachEventInput(1);

    }

    protected override void FireEventCallback(int channelId, int cookie, int eventIndex)
    {
      switch(eventIndex)
      {
        default:
          break;
        case 0:
          if (INIT1_Fired != null)
          {
            try
            {
              INIT1_Fired(this, new HMI.Main.Symbols.ButtonsPanel.INIT1EventArgs(channelId, cookie, eventIndex));
            }
            catch (System.Exception e)
            {
              NxtControl.Services.LoggingService.ErrorFormatted(@"In Event Callback for event:'{0}' Type:'{1}' CAT:'{2}' came exception:{3}
stack Trace:
{4}","INIT1_Fired", this.GetType().Name, this.CATName, e.Message, e.StackTrace);
            }
          }
        break; 
        case 1:
          if (REQ_Fired != null)
          {
            try
            {
              REQ_Fired(this, new HMI.Main.Symbols.ButtonsPanel.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_INITO1(System.Boolean start, System.Boolean reset, System.Boolean ack, System.Boolean manual, System.Boolean stop)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {start, reset, ack, manual, stop});
    }
    public bool FireEvent_INITO1(HMI.Main.Symbols.ButtonsPanel.INITO1EventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.start.HasValue) _values_[0] = ea.start.Value;
      if (ea.reset.HasValue) _values_[1] = ea.reset.Value;
      if (ea.ack.HasValue) _values_[2] = ea.ack.Value;
      if (ea.manual.HasValue) _values_[3] = ea.manual.Value;
      if (ea.stop.HasValue) _values_[4] = ea.stop.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_INITO1(System.Boolean start, bool ignore_start, System.Boolean reset, bool ignore_reset, System.Boolean ack, bool ignore_ack, System.Boolean manual, bool ignore_manual, System.Boolean stop, bool ignore_stop)
    {
      object[] _values_ = new object[5];
      if (!ignore_start) _values_[0] = start;
      if (!ignore_reset) _values_[1] = reset;
      if (!ignore_ack) _values_[2] = ack;
      if (!ignore_manual) _values_[3] = manual;
      if (!ignore_stop) _values_[4] = stop;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Boolean start, System.Boolean reset, System.Boolean ack, System.Boolean manual, System.Boolean stop)
    {
      return ((IHMIAccessorOutput)this).FireEvent(1, new object[] {start, reset, ack, manual, stop});
    }
    public bool FireEvent_CNF(HMI.Main.Symbols.ButtonsPanel.CNFEventArgs ea)
    {
      object[] _values_ = new object[5];
      if (ea.start.HasValue) _values_[0] = ea.start.Value;
      if (ea.reset.HasValue) _values_[1] = ea.reset.Value;
      if (ea.ack.HasValue) _values_[2] = ea.ack.Value;
      if (ea.manual.HasValue) _values_[3] = ea.manual.Value;
      if (ea.stop.HasValue) _values_[4] = ea.stop.Value;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }
    public bool FireEvent_CNF(System.Boolean start, bool ignore_start, System.Boolean reset, bool ignore_reset, System.Boolean ack, bool ignore_ack, System.Boolean manual, bool ignore_manual, System.Boolean stop, bool ignore_stop)
    {
      object[] _values_ = new object[5];
      if (!ignore_start) _values_[0] = start;
      if (!ignore_reset) _values_[1] = reset;
      if (!ignore_ack) _values_[2] = ack;
      if (!ignore_manual) _values_[3] = manual;
      if (!ignore_stop) _values_[4] = stop;
      return ((IHMIAccessorOutput)this).FireEvent(1, _values_);
    }

  }
}
#endregion #ButtonsPanel_HMI;

#endregion Definitions;
