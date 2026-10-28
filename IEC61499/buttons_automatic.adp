<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="01156b0a-8f45-424d-ad42-50ed62df3231" Name="buttons_automatic" Comment="Adapter Interface" Namespace="Main">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author="macie" Date="10/22/2026" />
  <InterfaceList>
    <EventOutputs>
      <Event Name="INIT">
        <With Var="start" />
        <With Var="reset" />
        <With Var="ack" />
        <With Var="manual" />
        <With Var="stop" />
      </Event>
      <Event Name="REQ">
        <With Var="start" />
        <With Var="reset" />
        <With Var="ack" />
        <With Var="manual" />
        <With Var="stop" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration Name="start" Type="BOOL" />
      <VarDeclaration Name="reset" Type="BOOL" />
      <VarDeclaration Name="ack" Type="BOOL" />
      <VarDeclaration Name="manual" Type="BOOL" />
      <VarDeclaration Name="stop" Type="BOOL" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="start" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="start" />
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
        <InputPrimitive Interface="SOCKET" Event="RSP" Parameters="reset" />
        <OutputPrimitive Interface="PLUG" Event="RSP" Parameters="reset" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>