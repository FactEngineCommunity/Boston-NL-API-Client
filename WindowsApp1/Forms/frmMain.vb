Imports System.ServiceModel

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call Me.SetupForm()

        'Dim lsServiceEndpointUri As String = "http://131.176.82.134:8080/WCFServices/DuplexService"


        'Dim DuplexCallback As New DuplexCallback

        'Dim instanceContext As New InstanceContext(DuplexCallback)

        'Dim dualHttpBinding As New WSDualHttpBinding(WSDualHttpSecurityMode.None)
        'dualHttpBinding.OpenTimeout = New TimeSpan(0, 0, 10)
        'Dim endpointAddress As New EndpointAddress(lsServiceEndpointUri)
        'Dim lrDuplexServiceClient As New DuplexServiceClient(instanceContext, dualHttpBinding, endpointAddress)
        'lrDuplexServiceClient.Open()
        'lrDuplexServiceClient.Connect()

        'Dim lrBroadcast As New Viev.FBM.Interface.Broadcast
        'lrBroadcast.Model = New Viev.FBM.Interface.Model
        'lrBroadcast.Model.Name = "Test-Model"

        'lrDuplexServiceClient.SendBroadcast(Viev.FBM.Interface.publicConstantspcenumBroadcastType.ModelGetModelIdByModelName, lrBroadcast)

        'Debugger.Break()

    End Sub

    Private Sub SetupForm()


    End Sub

End Class