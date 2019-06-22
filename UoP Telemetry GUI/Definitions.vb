Public Class Definitions

    Public Structure GPS
        Private Speed As Single
        Private Latitude, Longitude As Single
        Private Accel_X, Accel_Y, Accel_Z As Single
        Private Gyro_X, Gyro_Y, Gyro_Z As Single
    End Structure

    Public Structure Car_Raw
        'Private DateTime As PCAN_DateTime
        Private Throttle_12 As UInt16
        Private Throttle_5 As UInt16
        Private Brake_Travel As UInt16
        Private Brake_Front As UInt16
        Private Brake_Rear As UInt16
        Private Suspension_Front_Right As UInt16
        Private Suspension_Front_Left As UInt16
        Private Suspension_Rear_Right As UInt16
        Private Suspension_Rear_Left As UInt16
        Private Transmission_Front_Right As UInt16
        Private Transmission_Front_Left As UInt16
        Private Transmission_Rear_Right As UInt16
        Private Transmission_Rear_Left As UInt16
        Private Coolant_In_1 As UInt16
        Private Coolant_Out_1 As UInt16
        Private Coolant_In_2 As UInt16
        Private Coolant_Out_2 As UInt16
        Private Steering_Angle As UInt16
        Private Strain_Front_Right As UInt16
        Private Strain_Front_Left As UInt16
        Private Strain_Rear_Right As UInt16
        Private Strain_Rear_Left As UInt16
        Private GPS_1 As GPS
        Private GPS_2 As GPS
        Private RPM_Front_Right As UInt16
        Private RPM_Front_Left As UInt16
        Private RPM_Rear_Right As UInt16
        Private RPM_Rear_Left As UInt16
        Private Motor_Front_Right As UInt16
        Private Motor_Front_Left As UInt16
        Private Motor_Rear_Right As UInt16
        Private Motor_Rear_Left As UInt16
        Private IGBT_Front_Right As UInt16
        Private IGBT_Front_Left As UInt16
        Private IGBT_Rear_Right As UInt16
        Private IGBT_Rear_Left As UInt16
        Private Plate_Front_Right As UInt16
        Private Plate_Front_Left As UInt16
        Private Plate_Rear_Right As UInt16
        Private Plate_Rear_Left As UInt16
        Private Demanded_Front_Right As UInt16
        Private Demanded_Front_Left As UInt16
        Private Demanded_Rear_Right As UInt16
        Private Demanded_Rear_Left As UInt16
        Private Actual_Front_Right As UInt16
        Private Actual_Front_Left As UInt16
        Private Actual_Rear_Right As UInt16
        Private Actual_Rear_Left As UInt16
        Private InverterVoltage As UInt16
        Private ErrorCode_1, ErrorCode_2, ErrorCode_3, ErrorCode_4 As Byte
        Private IVT_Voltage, IVT_Current As Single
        Private Stack_Voltage As Single
        Private Voltage_BMS_Min As UInt16
        Private Voltage_BMS_Max As UInt16
        Private Temp_BMS_Min As UInt16
        Private Temp_BMS_Max As UInt16
        Private SOC As Byte
    End Structure


    Public Structure Car_Processed
        Public RPM As UInt16
        Public Torque As Int16
        Public RPM_Front_Left As UInt16
        Public RPM_Front_Right As UInt16
        Public RPM_Rear_Left As UInt16
        Public RPM_Rear_Right As UInt16
        Public Temp_IGBT As Single
        Public Temp_Motor As Single
        Public Throttle As Byte
        Public Brake_Front As Byte
        Public Brake_Rear As Byte
        Public Current_IVT As Single
        Public Voltage_IVT As Single
        Public VCU_ETD As Byte
        Public VCU_BMSA As Byte
        Public VCU_MCMS As Byte
        Public VCU_CPS As Byte
        Public VCU_EMA As UInt16
        Public VCU_PLS As UInt16
        Public Temp_Coolant_In As Single
        Public Temp_Gearbox As Single
        Public Temp_Coolant_Out As Single
        Public Voltage_BMS_Min_Left As Single
        Public Voltage_BMS_Min_Right As Single
        Public Voltage_BMS_Max_Left As Single
        Public Voltage_BMS_Max_Right As Single
        Public Temp_BMS_Min_Left As Single
        Public Temp_BMS_Max_Left As Single
        Public Temp_BMS_Min_Right As Single
        Public Temp_BMS_Max_Right As Single
        Public Current_Low_Battery As Single
    End Structure

    Public Const MASK_PERF = &B1000000
    Public Const MASK_BMS = &B100000
    Public Const MASK_TEMPS = &B10000
    Public Const MASK_PEDALS = &B1000
    Public Const MASK_WHEELS = &B100
    Public Const MASK_VCU = &B10
    Public Const MASK_IMU = &B1

    Public Structure Packet_Timestamp
        Public IndexMSB As Byte
        Public IndexMMSB As Byte
        Public IndexLSB As Byte
        Public TimestampMSB As Byte
        Public TimestampMMSB As Byte
        Public TimestampLSB As Byte
    End Structure

    Public Structure Packet_Performance
        Public RPM As UInt16
        Public Torque As Int16
        Public IVT_Current As Int16
        Public IVT_Voltage As UInt16
    End Structure

    Public Structure Packet_BMS
        Public Faults As Byte
        Public Voltage_Min_Left As Byte
        Public Voltage_Min_Right As Byte
        Public Voltage_Max_Left As Byte
        Public Voltage_Max_Right As Byte
        Public Temp_Min_Left As Byte
        Public Temp_Max_Left As Byte
        Public Temp_Min_Right As Byte
        Public Temp_Max_Right As Byte
    End Structure

    Public Structure Packet_Temps
        Public IGBT As Byte
        Public Motor As Byte
        Public Coolant_In As Byte
        Public Coolant_Out As Byte
        Public Gearbox As Byte
        Public BrakeLeft As Byte
        Public BrakeRight As Byte
    End Structure

    Public Structure Packet_Pedals
        Public Throttle_12 As Byte
        Public Brake_Front As Byte
        Public Brake_Rear As Byte
    End Structure

    Public Structure Packet_Wheels
        Public RPM_Front_Left As Byte
        Public RPM_Front_Right As Byte
        Public RPM_Rear_Left As Byte
        Public RPM_Rear_Right As Byte
    End Structure

    Public Structure Packet_VCU
        Public ETD As Boolean
        Public BMSA As Boolean
        Public MCMS As Byte
        Public EMA As UInt16
        Public CDS As Byte
        Public PLS As UInt16
        Public Current_Low_Battery As UInt16
    End Structure

    Public Structure Packet_IMU
        Public X As Single
        Public Y As Single
        Public Z As Single
    End Structure

    Public Structure Car_Mixed
        Public Raw As Car_Raw
        Public Processed As Car_Processed
    End Structure

    Public Structure Car_Telemetry
        Public Settings As Byte
        Public Timestamp As Packet_Timestamp
        Public Performance As Packet_Performance
        Public BMS As Packet_BMS
        Public Temps As Packet_Temps
        Public Pedals As Packet_Pedals
        Public Wheels As Packet_Wheels
        Public VCU As Packet_VCU
        Public IMU As Packet_IMU
        Public LeftBox As Byte()
        Public RightBox As Byte()

        Public Sub New(ByVal Optional Size As Byte = 96)
            ReDim LeftBox(Size)
            ReDim RightBox(Size)
            For Index As Integer = 0 To Size
                LeftBox(Index) = 0
                RightBox(Index) = 0
            Next
        End Sub

    End Structure

    Public Structure CAN_Message
        Public ID As UInt16
        Public Length As Byte
        Public Data As Byte()
        Public CycleTime As UInt16
        Public Count As UInt32
        Public Sub New(ByVal Optional DataSize As Byte = 8)
            ReDim Data(DataSize)
            For Index As Integer = 0 To DataSize
                Data(DataSize) = 0
            Next
        End Sub
    End Structure

    Public Enum NumberRepresentation
        Bin
        Dec
        Hex
    End Enum

    Public Structure Configuration_Fusebox
        Public TelemetryEnabled As Boolean
        Public CANForward As Boolean
        Public CANForwardInterval As Byte
        Public SelectiveSampling As Byte
        Public TelemetryTX As Byte
        Public Telemetry2TX As Byte
        Public BAUD As UInt32
    End Structure

End Class