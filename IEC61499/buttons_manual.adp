<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="6a9a4b91-e855-4b98-8f21-d338867e1291" Name="buttons_manual" Comment="Adapter Interface" Namespace="Main">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author="macie" Date="10/22/2026" />
  <InterfaceList>
    <EventOutputs>
      <Event Name="INIT">
        <With Var="retract" />
        <With Var="to_mgz" />
        <With Var="to_nxt" />
        <With Var="vcm_on" />
        <With Var="vcm_off" />
      </Event>
      <Event Name="REQ">
        <With Var="retract" />
        <With Var="to_mgz" />
        <With Var="to_nxt" />
        <With Var="vcm_on" />
        <With Var="vcm_off" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration Name="retract" Type="BOOL" />
      <VarDeclaration Name="to_mgz" Type="BOOL" />
      <VarDeclaration Name="to_nxt" Type="BOOL" />
      <VarDeclaration Name="vcm_on" Type="BOOL" />
      <VarDeclaration Name="vcm_off" Type="BOOL" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="retract" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="retract" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF" Parameters="CNFD" />
        <OutputPrimitive Interface="SOCKET" Event="CNF" Parameters="CNFD" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="IND" Parameters="INDD" />
        <OutputPrimitive Interface="SOCKET" Event="IND" Parameters="INDD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="RSP" Parameters="to_mgz" />
        <OutputPrimitive Interface="PLUG" Event="RSP" Parameters="to_mgz" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>