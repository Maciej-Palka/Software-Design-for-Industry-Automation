/*
 * Created by nxtSTUDIO.
 * User: Andrei
 * Date: 5/29/2016
 * Time: 12:01 AM
 * 
 */
using System;
using NxtControl.GuiFramework;
using NxtControl.Services;

#region Definitions;
#region #CylinderVSensValve_HMI;

namespace HMI.Main.Symbols.CylinderVSensValve
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
    public bool Get_FWD_IN(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? FWD_IN
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,0, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }

    public bool Get_BKWD_IN(ref System.Boolean value)
    {
      if (accessorService == null)
        return false;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (ret) value = (System.Boolean) var;
      return ret;
    }

    public System.Boolean? BKWD_IN
    { get {
      if (accessorService == null)
        return null;
      bool var = false;
      bool ret = accessorService.GetBoolValue(channelId, cookie, eventIndex, true,1, ref var);
      if (!ret) return null;
      return (System.Boolean) var;
    }  }


  }

}

namespace HMI.Main.Symbols.CylinderVSensValve
{

  public class CNFEventArgs : System.EventArgs
  {
    public CNFEventArgs()
    {
    }
    private System.Boolean? FWD_OUT_field = null;
    public System.Boolean? FWD_OUT
    {
       get { return FWD_OUT_field; }
       set { FWD_OUT_field = value; }
    }
    private System.Boolean? BKWD_OUT_field = null;
    public System.Boolean? BKWD_OUT
    {
       get { return BKWD_OUT_field; }
       set { BKWD_OUT_field = value; }
    }

  }

}

namespace HMI.Main.Symbols.CylinderVSensValve
{
  partial class sDefault
  {

    private event EventHandler<HMI.Main.Symbols.CylinderVSensValve.REQEventArgs> REQ_Fired;

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
              REQ_Fired(this, new HMI.Main.Symbols.CylinderVSensValve.REQEventArgs(channelId, cookie, eventIndex));
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
    public bool FireEvent_CNF(System.Boolean FWD_OUT, System.Boolean BKWD_OUT)
    {
      return ((IHMIAccessorOutput)this).FireEvent(0, new object[] {FWD_OUT, BKWD_OUT});
    }
    public bool FireEvent_CNF(HMI.Main.Symbols.CylinderVSensValve.CNFEventArgs ea)
    {
      object[] _values_ = new object[2];
      if (ea.FWD_OUT.HasValue) _values_[0] = ea.FWD_OUT.Value;
      if (ea.BKWD_OUT.HasValue) _values_[1] = ea.BKWD_OUT.Value;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }
    public bool FireEvent_CNF(System.Boolean FWD_OUT, bool ignore_FWD_OUT, System.Boolean BKWD_OUT, bool ignore_BKWD_OUT)
    {
      object[] _values_ = new object[2];
      if (!ignore_FWD_OUT) _values_[0] = FWD_OUT;
      if (!ignore_BKWD_OUT) _values_[1] = BKWD_OUT;
      return ((IHMIAccessorOutput)this).FireEvent(0, _values_);
    }

  }
}
#endregion #CylinderVSensValve_HMI;

#endregion Definitions;
