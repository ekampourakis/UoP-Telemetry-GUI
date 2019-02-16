Public Class Definitions
    Public Structure Car_Raw
        Public RPM As UInt16
        Public Torque As Int16
        Public RPM_Front_Left As UInt16
        Public RPM_Front_Right As UInt16
        Public RPM_Rear_Left As UInt16
        Public RPM_Rear_Right As UInt16
        Public Temp_IGBT As UInt16
        Public Temp_Motor As UInt16
        Public Throttle_12 As UInt16
        Public Throttle_5 As UInt16
        Public Brake_Front As UInt16
        Public Brake_Rear As UInt16
        Public Current_IVT As Int32
        Public Voltage_IVT As UInt32
        Public VCU_ETD As Byte
        Public VCU_BMSA As Byte
        Public VCU_MCMS As Byte
        Public VCU_CPS As Byte
        Public VCU_EMA As UInt16
        Public VCU_PLS As UInt16
        Public Temp_Coolant_In As UInt16
        Public Temp_Gearbox As UInt16
        Public Temp_Coolant_Out As UInt16
        Public Voltage_BMS_Min_Left As UInt16
        Public Voltage_BMS_Min_Right As UInt16
        Public Voltage_BMS_Max_Left As UInt16
        Public Voltage_BMS_Max_Right As UInt16
        Public Temp_BMS_Min_Left As UInt16
        Public Temp_BMS_Max_Left As UInt16
        Public Temp_BMS_Min_Right As UInt16
        Public Temp_BMS_Max_Right As UInt16
        Public Current_Low_Battery As UInt16
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

    Public Structure Packet_Performance
        Public RPM As Int16
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
End Class