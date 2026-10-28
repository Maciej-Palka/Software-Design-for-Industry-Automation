<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="eec4fa65-57fb-456d-873a-d847d9c35190" Name="control_IMC" Comment="Adapter Interface" Namespace="Main">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author="macie" Date="10/23/2026" />
  <InterfaceList>
    <EventOutputs>
      <Event Name="ACTIVATE" Comment="Indication from Plug">
        <With Var="mode" />
        <With Var="stop_flag" />
      </Event>
      <Event Name="CNF" Comment="Confirmation from Plug">
        <With Var="mode" />
        <With Var="stop_flag" />
      </Event>
      <Event Name="CHECK_POS" />
    </EventOutputs>
    <OutputVars>
      <VarDeclaration Name="mode" Type="USINT" Comment="Confirmation Data from Plug" />
      <VarDeclaration Name="stop_flag" Type="BOOL" Comment="Indication Data from Plug" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF" Parameters="mode" />
        <OutputPrimitive Interface="SOCKET" Event="CNF" Parameters="mode" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="ACTIVATE" Parameters="stop_flag" />
        <OutputPrimitive Interface="SOCKET" Event="ACTIVATE" Parameters="stop_flag" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="RSP" Parameters="RSPD" />
        <OutputPrimitive Interface="PLUG" Event="RSP" Parameters="RSPD" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>