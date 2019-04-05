Public Class Logger

    Private _Writer As IO.StreamWriter
    Private _Reader As IO.StreamReader

    Public Sub New(ByVal LogPath As String, ByVal Optional Read As Boolean = False)
        If IO.File.Exists(LogPath) And Read Then
            _Reader = New IO.StreamReader(LogPath)
            _Writer = Nothing
        Else
            _Writer = New IO.StreamWriter(LogPath & "\Telemetry " & Now.ToString("dd_mm_yyyy HH_mm") & ".csv")
            _Writer.WriteLine("Timestamp,Throttle,Brake Front,Brake Rear,Coolant In, Coolant Out, Motor Temp,IGBT Temp, Gearbox Temp, RPM, Torque, IVT Voltage, IVT Current")
            _Reader = Nothing
        End If
    End Sub

    Public Sub Close()
        If _Writer IsNot Nothing Then
            _Writer.Close()
            _Writer.Dispose()
        End If
        If _Reader IsNot Nothing Then
            _Reader.Close()
            _Reader.Dispose()
        End If
    End Sub

    Public Sub Write(ByVal Telemetry As Definitions.Car_Telemetry)
        If _Writer IsNot Nothing Then
            With Telemetry
                Dim Index As UInt32 = Main.ParseUInt32({0, .Timestamp.IndexMSB, .Timestamp.IndexMMSB, .Timestamp.IndexLSB}, 0)
                _Writer.WriteLine("{0},{1:d},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12:F},{13:F}", Now.ToString("dd/MM/yyyy HH:mm:ss.fff"),
                                  Index, .Pedals.Throttle_12, .Pedals.Brake_Front, .Pedals.Brake_Rear,
                                  .Temps.Coolant_In, .Temps.Coolant_Out, .Temps.Motor, .Temps.IGBT, .Temps.Gearbox,
                                  .Performance.RPM, .Performance.Torque, .Performance.IVT_Voltage, .Performance.IVT_Current)
            End With
        End If
    End Sub

End Class