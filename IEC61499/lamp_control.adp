<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="a5107313-15d4-463d-ad4c-a8d2574e5a38" Name="lamp_control" Comment="Adapter Interface" Namespace="Main">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author="macie" Date="10/23/2026" />
  <InterfaceList>
    <EventOutputs>
      <Event Name="CNF_P" Comment="Confirmation from Plug">
        <With Var="start_led" />
        <With Var="reset_led" />
        <With Var="ack_led" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration Name="start_led" Type="BOOL" Comment="Confirmation Data from Plug" />
      <VarDeclaration Name="reset_led" Type="BOOL" Comment="Indication Data from Plug" />
      <VarDeclaration Name="ack_led" Type="BOOL" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF_P" Parameters="start_led" />
        <OutputPrimitive Interface="SOCKET" Event="CNF_P" Parameters="start_led" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="IND" Parameters="reset_led" />
        <OutputPrimitive Interface="SOCKET" Event="IND" Parameters="reset_led" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="RSP" Parameters="RSPD" />
        <OutputPrimitive Interface="PLUG" Event="RSP" Parameters="RSPD" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>