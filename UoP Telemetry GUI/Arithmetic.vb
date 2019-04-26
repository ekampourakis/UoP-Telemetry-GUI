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

    Public Shared Function HexDump(ByVal Data As Byte(), ByVal Len As Integer) As String
        If Data Is Nothing Then
            Return ""
        End If
        Dim Res As String = ""
        For Index As Integer = 0 To Len - 1
            Res &= Hex(Data(Index)) & " "
        Next
        Return Res.Substring(0, Res.Length - 1)
    End Function

    Public Shared Function Map(ByVal x As Single, ByVal x1 As Single, ByVal x2 As Single, ByVal y1 As Single, ByVal y2 As Single) As Single
        Return (x - x1) * (y2 - y1) / (x2 - x1) + y1
    End Function

    Public Shared Function InterpolateColor(ByVal firstcolor As Color, ByVal secondcolor As Color, ByVal alpha As Double) As Color
        Dim R As Double = ((1 - alpha) * Convert.ToInt32(firstcolor.R)) + (alpha * Convert.ToInt32(secondcolor.R))
        Dim B As Double = ((1 - alpha) * Convert.ToInt32(firstcolor.B)) + (alpha * Convert.ToInt32(secondcolor.B))
        Dim G As Double = ((1 - alpha) * Convert.ToInt32(firstcolor.G)) + (alpha * Convert.ToInt32(secondcolor.G))
        Dim A As Byte = 255
        Return Color.FromArgb(A, Convert.ToByte(R), Convert.ToByte(G), Convert.ToByte(B))
    End Function

    Public Shared Function Constrain(ByRef Value As Single, ByVal Min As Single, ByVal Max As Single) As Single
        Value = Math.Max(Value, Min)
        Value = Math.min(Value, Max)
        Return Value
    End Function

    Public Shared Function BinToDec(ByVal Bin As String) As Byte
        Dim dec As Byte = Nothing
        Dim length As Integer = Len(Bin)
        Dim temp As Integer = Nothing
        Dim x As Integer = Nothing
        For x = 1 To length
            temp = Val(Mid(Bin, length, 1))
            length = length - 1
            If temp <> "0" Then
                dec += (2 ^ (x - 1))
            End If
        Next
        Return dec
    End Function

    Public Shared Function BinToHex(ByVal Bin As String) As Byte
        Dim Dec As Byte = BinToDec(Bin)
        Return Convert.ToString(Dec, 16).PadLeft(2, "0")
    End Function

    Public Shared Function DecToBin(ByVal Dec As Byte) As String
        Return Convert.ToString(Dec, 2).PadLeft(8, "0")
    End Function

    Public Shared Function DecToHex(ByVal Dec As Byte) As String
        Return Convert.ToString(Dec, 16).PadLeft(2, "0")
    End Function

    Public Shared Function HexToBin(ByVal Hex As String) As String
        Return DecToBin(HexToDec(Hex))
    End Function

    Public Shared Function HexToDec(ByVal Hex As String) As Byte
        Return CByte("&H" & Hex)
    End Function

End Class