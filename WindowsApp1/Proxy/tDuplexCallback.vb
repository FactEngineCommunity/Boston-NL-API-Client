Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading

Imports System.ComponentModel
Imports System.Diagnostics
Imports System.ServiceModel

<CallbackBehavior(UseSynchronizationContext:=False)>
Friend Class DuplexCallback
    Implements IDuplexServiceCallback


    Private _syncContext As SynchronizationContext = AsyncOperationManager.SynchronizationContext

    ''' <summary>
    ''' See prDuplexServiceClient.HandleBroadcastReceived
    ''' See also frmMain where: AddHandler DuplexCallback.BroadcastEventReceived, AddressOf prDuplexServiceClient.HandleBroadcastReceived
    ''' </summary>
    Public Event BroadcastEventReceived As EventHandler(Of Viev.FBM.Interface.Broadcast)


    Public Sub ReceiveBroadcast(aiBroadcastType As Viev.FBM.Interface.publicConstantspcenumBroadcastType, ByRef arObject As Viev.FBM.Interface.Broadcast) Implements IDuplexServiceCallback.ReceiveBroadcast

        Dim lrBroadcast As Viev.FBM.Interface.Broadcast = arObject
        '20220327-VM-Was _syncContext.Post(New SendOrPostCallback(AddressOf OnBroadcastEvent), lrBroadcast)
        'To send data back to client, must use Send.
        _syncContext.Send(New SendOrPostCallback(AddressOf OnBroadcastEvent), lrBroadcast)
        arObject.Model.Namespace = lrBroadcast.Model.Namespace

    End Sub

    Private Sub OnBroadcastEvent(ByVal State As Viev.FBM.Interface.Broadcast)

        Dim e As Viev.FBM.Interface.Broadcast = TryCast(State, Viev.FBM.Interface.Broadcast)
        RaiseEvent BroadcastEventReceived(Me, e)
    End Sub

End Class
