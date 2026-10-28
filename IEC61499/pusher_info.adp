<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="ef5dab25-7a0c-4fd5-aec0-17594899233c" Name="pusher_info" Comment="Adapter Interface" Namespace="Main">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author="macie" Date="10/22/2026" />
  <InterfaceList>
    <EventOutputs>
      <Event Name="CNF" Comment="Confirmation from Plug">
        <With Var="retracted" />
        <With Var="extended" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration Name="retracted" Type="BOOL" Comment="Confirmation Data from Plug" />
      <VarDeclaration Name="extended" Type="BOOL" Comment="Indication Data from Plug" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF" Parameters="retracted" />
        <OutputPrimitive Interface="SOCKET" Event="CNF" Parameters="retracted" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="IND" Parameters="extended" />
        <OutputPrimitive Interface="SOCKET" Event="IND" Parameters="extended" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="RSP" Parameters="RSPD" />
        <OutputPrimitive Interface="PLUG" Event="RSP" Parameters="RSPD" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>