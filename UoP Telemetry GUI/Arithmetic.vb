Public Class Arithmetic
    Public Shared Function ParseSingle(ByRef Bytes As Byte(), ByRef StartIndex As Integer, ByVal Optional BigEndian As Boolean = True) As Single
        Dim Result As Single
        If BigEndian Then
            Result = BitConverter.ToSingle({Bytes(StartIndex + 3), Bytes(StartIndex + 2), Bytes(StartIndex + 1), Bytes(StartIndex)}, 0)
            StartIndex += 4
        Else
            Result = BitConverter.ToSingle(Bytes, StartIndex)
            StartIndex += 4
        End If
        Return Result
    End Function

    Public Shared Function ParseInt16(ByRef Bytes As Byte(), ByRef StartIndex As Integer, ByVal Optional BigEndian As Boolean = True) As Int16
        Dim Result As UInt16
        If BigEndian Then
            Result = BitConverter.ToInt16({Bytes(StartIndex + 1), Bytes(StartIndex)}, 0)
            StartIndex += 2
        Else
            Result = BitConverter.ToInt16(Bytes, StartIndex)
            StartIndex += 2
        End If
        Return Result
    End Function

    Public Shared Function ParseUInt16(ByRef Bytes As Byte(), ByRef StartIndex As Integer, ByVal Optional BigEndian As Boolean = True) As UInt16
        Dim Result As UInt16
        If BigEndian Then
            Result = BitConverter.ToUInt16({Bytes(StartIndex + 1), Bytes(StartIndex)}, 0)
            StartIndex += 2
        Else
            Result = BitConverter.ToUInt16(Bytes, StartIndex)
            StartIndex += 2
        End If
        Return Result
    End Function

    Public Shared Function ParseInt32(ByRef Bytes As Byte(), ByRef StartIndex As Integer, ByVal Optional BigEndian As Boolean = True) As Int32
        Dim Result As Int32
        If BigEndian Then
            Result = BitConverter.ToInt32({Bytes(StartIndex + 3), Bytes(StartIndex + 2), Bytes(StartIndex + 1), Bytes(StartIndex)}, 0)
            StartIndex += 4
        Else
            Result = BitConverter.ToInt32(Bytes, StartIndex)
            StartIndex += 4
        End If
        Return Result
    End Function

    Public Shared Function ParseUInt32(ByRef Bytes As Byte(), ByRef StartIndex As Integer, ByVal Optional BigEndian As Boolean = True) As UInt32
        Dim Result As UInt32
        If BigEndian Then
            Result = BitConverter.ToUInt32({Bytes(StartIndex + 3), Bytes(StartIndex + 2), Bytes(StartIndex + 1), Bytes(StartIndex)}, 0)
            StartIndex += 4
        Else
            Result = BitConverter.ToUInt32(Bytes, StartIndex)
            StartIndex += 4
        End If
        Return Result
    End Function

    Public Shared Function ParseByte(ByRef Bytes As Byte(), ByRef StartIndex As Integer) As Byte
        Dim Result As Byte = Bytes(StartIndex)
        StartIndex += 1
        Return Result
    End Function

    Public Shared Function ToDegrees(ByVal TemperatureVoltage As UInt16) As Single
        Dim Voltage As Double = TemperatureVoltage * 0.0001
        Const Rdiv As Double = 10000.0F
        Const Rref As Double = 10000.0F
        Const Vref As Double = 3.0F
        Dim Rtherm As Double = (Voltage * Rdiv) / (Vref - Voltage)
        Const A As Double = 0.003354016F
        Const B As Double = 0.000256985F
        Const C As Double = 0.000002620131F
        Const D As Double = 0.00000006383091F
        Dim LN As Double = Math.Log(Rtherm / Rref)
        Dim T As Double = 1.0 / (A + B * LN + C * Math.Pow(LN, 2) + D * Math.Pow(LN, 3))
        Return TemperatureVoltage - 273.15F
    End Function

    Public Shared Function Constrain(ByVal Value, ByVal Min, ByVal Max)
        If Value < Min Then
            Return Min
        ElseIf Value > Max Then
            Return Max
        Else
            Return Value
        End If
    End Function
End Class