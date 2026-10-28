<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="4f7c84d2-d421-4cb5-a8c7-a9a63c569806" Name="system_info" Comment="Adapter Interface" Namespace="Main">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author="macie" Date="10/23/2026" />
  <InterfaceList>
    <EventOutputs>
      <Event Name="INIT">
        <With Var="vmon" />
        <With Var="empty" />
      </Event>
      <Event Name="CNF" Comment="Confirmation from Plug">
        <With Var="vmon" />
        <With Var="empty" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration Name="empty" Type="BOOL" Comment="Indication Data from Plug" />
      <VarDeclaration Name="vmon" Type="BOOL" Comment="Confirmation Data from Plug" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF" Parameters="vmon" />
        <OutputPrimitive Interface="SOCKET" Event="CNF" Parameters="vmon" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="IND" Parameters="empty" />
        <OutputPrimitive Interface="SOCKET" Event="IND" Parameters="empty" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="RSP" Parameters="RSPD" />
        <OutputPrimitive Interface="PLUG" Event="RSP" Parameters="RSPD" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>