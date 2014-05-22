using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace CommonLib
{
    class WinAPI
    {
        [DllImport("kernel32")]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int Beep(int frequency, int duration);



        //Public Declare Function GetWindowThreadProcessId Lib "user32" (ByVal hwnd As Integer, ByRef lpdwProcessId As Integer) As Integer

        //Public Enum BeepType As Long
        //    OK = &H0
        //    Hand = &H10
        //    Question = &H20
        //    Exclamation = &H30
        //    Asterisk = &H40
        //    Simple = &HFFFFFFFF
        //End Enum

        //Public Module FWWin

        //'Menu item constants.
        //Private Const SC_CLOSE As Integer = &HF060
        //Private Const SC_MINIMIZE As Integer = &HF020
        //'SetMenuItemInfo fMask constants.
        //Private Const MIIM_STATE As Integer = &H1
        //Private Const MIIM_ID As Integer = &H2
        //'SetMenuItemInfo fState constants.
        //Private Const MFS_GRAYED As Integer = &H3
        //Private Const MFS_CHECKED As Integer = &H8
        //'SendMessage constants.
        //Private Const WM_NCACTIVATE As Integer = &H86S
        //'Application-specific constants and variables.
        //Private Const xSC_CLOSE As Integer = -10
        //Private Const SwapID As Integer = 1
        //Private Const ResetID As Integer = 2

        //Private Declare Function GetSystemMenu Lib "user32" (ByVal hwnd As Integer, ByVal bRevert As Integer) As Integer
        //Private Declare Function GetMenuItemInfo Lib "user32" Alias "GetMenuItemInfoA" (ByVal hMenu As Integer, ByVal un As Integer, ByVal b As Boolean, ByRef lpMenuItemInfo As MENUITEMINFO) As Integer
        //Private Declare Function SetMenuItemInfo Lib "user32" Alias "SetMenuItemInfoA" (ByVal hMenu As Integer, ByVal un As Integer, ByVal bool As Boolean, ByRef lpcMenuItemInfo As MENUITEMINFO) As Integer

        //<StructLayout(LayoutKind.Sequential)> _
        //Public Structure MENUITEMINFO
        //    Dim cbSize As Integer
        //    Dim fMask As Integer
        //    Dim fType As Integer
        //    Dim fState As Integer
        //    Dim wID As Integer
        //    Dim hSubMenu As Integer
        //    Dim hbmpChecked As Integer
        //    Dim hbmpUnchecked As Integer
        //    Dim dwItemData As Integer
        //    Dim dwTypeData As String
        //    Dim cch As Integer
        //    Private Shared Sub InitStruct(ByRef result As MENUITEMINFO, ByVal init As Boolean)
        //        If init Then
        //            result.dwTypeData = String.Empty
        //        End If
        //    End Sub
        //    Public Shared Function CreateInstance() As MENUITEMINFO
        //        Dim result As New MENUITEMINFO
        //        InitStruct(result, True)
        //        Return result
        //    End Function
        //    Public Function Clone() As MENUITEMINFO
        //        Dim result As MENUITEMINFO = Me
        //        InitStruct(result, False)
        //        Return result
        //    End Function
        //End Structure

        //Public Function WinDisableClose(ByRef frm As Form) As Boolean
        //    Dim oErr As FWErrorHandler.FWError = FWErrorHandler.FWError.CreateInstance()
        //    Dim lngRet As Integer
        //    Dim MII As MENUITEMINFO = MENUITEMINFO.CreateInstance()
        //    Dim hMenu As Integer
        //    Try
        //        hMenu = GetSystemMenu(frm.Handle.ToInt32(), 0)
        //        'UPGRADE_WARNING: (2081) Len has a new behavior. More Information: http://www.vbtonet.com/ewis/ewi2081.aspx
        //        MII.cbSize = Marshal.SizeOf(MII)
        //        MII.dwTypeData = New String(Strings.Chr(0), 80)
        //        MII.cch = MII.dwTypeData.Length
        //        MII.fMask = MIIM_STATE
        //        MII.wID = SC_CLOSE
        //        lngRet = GetMenuItemInfo(hMenu, MII.wID, False, MII)
        //        lngRet = SetId(hMenu, MII, SwapID)
        //        If lngRet <> 0 Then
        //            MII.fState = (MII.fState Or MFS_GRAYED)
        //            MII.fMask = MIIM_STATE
        //            lngRet = SetMenuItemInfo(hMenu, MII.wID, False, MII)
        //            If lngRet = 0 Then
        //                lngRet = SetId(hMenu, MII, ResetID)
        //            End If
        //            '                                      SendMessage(Of T As Structure)(ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As T) As Integer
        //            lngRet = PIWDPInvoke.SafeNative.user32.SendMessage(frm.Handle.ToInt32(), WM_NCACTIVATE, CType(True, Integer), 0)
        //        End If
        //    Catch e As System.Exception
        //        If Information.Err().Number <> 0 Then oErr = FWErrorHandler.CreateFWError(Information.Err().Number, e.Source, e.Message)
        //    Finally
        //        If oErr.Number <> 0 Then FWErrorHandler.RaiseFWError(oErr, FWErrorHandler.ComponentName("WinDisableClose", "FWNBCommon.modXMLRoutines"))
        //    End Try
        //End Function

        //Public Function WinEnableClose(ByRef frm As Form) As Boolean
        //    Dim oErr As FWErrorHandler.FWError = FWErrorHandler.FWError.CreateInstance()
        //    Dim lngRet As Integer
        //    Dim MII As MENUITEMINFO = MENUITEMINFO.CreateInstance()
        //    Dim hMenu As Integer
        //    Try
        //        hMenu = PIWDPInvoke.SafeNative.user32.GetSystemMenu(frm.Handle.ToInt32(), 0)
        //        'UPGRADE_WARNING: (2081) Len has a new behavior. More Information: http://www.vbtonet.com/ewis/ewi2081.aspx
        //        MII.cbSize = Marshal.SizeOf(MII)
        //        MII.dwTypeData = New String(Strings.Chr(0), 80)
        //        MII.cch = MII.dwTypeData.Length
        //        MII.fMask = MIIM_STATE
        //        MII.wID = xSC_CLOSE
        //        MII.fState = MFS_GRAYED
        //        lngRet = SetId(hMenu, MII, SwapID)
        //        If lngRet <> 0 Then
        //            MII.fState -= MFS_GRAYED
        //            MII.fMask = MIIM_STATE
        //            MII.wID = SC_CLOSE
        //            lngRet = SetMenuItemInfo(hMenu, MII.wID, False, MII)
        //            If lngRet = 0 Then
        //                lngRet = SetId(hMenu, MII, ResetID)
        //            End If
        //            lngRet = PIWDPInvoke.SafeNative.user32.SendMessage(frm.Handle.ToInt32(), WM_NCACTIVATE, CType(True, Integer), 0)
        //        End If
        //    Catch e As System.Exception
        //        If Information.Err().Number <> 0 Then oErr = FWErrorHandler.CreateFWError(Information.Err().Number, e.Source, e.Message)
        //    Finally
        //        If oErr.Number <> 0 Then FWErrorHandler.RaiseFWError(oErr, FWErrorHandler.ComponentName("WinEnableClose", "FWNBCommon.modXMLRoutines"))
        //    End Try
        //End Function

        //Private Function SetId(ByRef hMenu As Integer, ByRef MII As MENUITEMINFO, ByRef Action As Integer) As Integer

        //    Dim result As Integer = 0
        //    Dim oErr As FWErrorHandler.FWError = FWErrorHandler.FWError.CreateInstance()
        //    Dim MenuID, blnRet As Integer
        //    Try
        //        MenuID = MII.wID
        //        If MII.fState = (MII.fState Or MFS_GRAYED) Then
        //            If Action = SwapID Then
        //                MII.wID = SC_CLOSE
        //            Else
        //                MII.wID = xSC_CLOSE
        //            End If
        //        Else
        //            If Action = SwapID Then
        //                MII.wID = xSC_CLOSE
        //            Else
        //                MII.wID = SC_CLOSE
        //            End If
        //        End If
        //        MII.fMask = MIIM_ID
        //        blnRet = SetMenuItemInfo(hMenu, MenuID, False, MII)
        //        If blnRet = 0 Then
        //            MII.wID = MenuID
        //        End If
        //    Catch e As System.Exception
        //        If Information.Err().Number <> 0 Then oErr = FWErrorHandler.CreateFWError(Information.Err().Number, e.Source, e.Message)
        //    Finally
        //        result = blnRet
        //        If oErr.Number <> 0 Then FWErrorHandler.RaiseFWError(oErr, FWErrorHandler.ComponentName("SetId", "FWNBCommon.modXMLRoutines"))
        //    End Try
        //    Return result

        //End Function

        //Public Function WinDisableMinimize(ByRef frm As Form) As Boolean
        //    Dim oErr As FWErrorHandler.FWError = FWErrorHandler.FWError.CreateInstance()
        //    Dim lngRet As Integer
        //    Dim MII As MENUITEMINFO = MENUITEMINFO.CreateInstance()
        //    Dim hMenu As Integer
        //    Try
        //        hMenu = PIWDPInvoke.SafeNative.user32.GetSystemMenu(frm.Handle.ToInt32(), 0)
        //        'UPGRADE_WARNING: (2081) Len has a new behavior. More Information: http://www.vbtonet.com/ewis/ewi2081.aspx
        //        MII.cbSize = Marshal.SizeOf(MII)
        //        MII.dwTypeData = New String(Strings.Chr(0), 80)
        //        MII.cch = MII.dwTypeData.Length
        //        MII.fMask = MIIM_STATE
        //        MII.wID = SC_MINIMIZE
        //        lngRet = GetMenuItemInfo(hMenu, MII.wID, False, MII)
        //        lngRet = SetId(hMenu, MII, SwapID)
        //        If lngRet <> 0 Then
        //            MII.fState = (MII.fState Or MFS_GRAYED)
        //            MII.fMask = MIIM_STATE
        //            lngRet = SetMenuItemInfo(hMenu, MII.wID, False, MII)
        //            If lngRet = 0 Then
        //                lngRet = SetId(hMenu, MII, ResetID)
        //            End If
        //            'lngRet = SendMessage(frm.hwnd, WM_NCACTIVATE, True, 0)
        //        End If
        //    Catch e As System.Exception
        //        If Information.Err().Number <> 0 Then oErr = FWErrorHandler.CreateFWError(Information.Err().Number, e.Source, e.Message)
        //    Finally
        //        If oErr.Number <> 0 Then FWErrorHandler.RaiseFWError(oErr, FWErrorHandler.ComponentName("WinDisableMinimize", "FWNBCommon.modXMLRoutines"))
        //    End Try
        //End Function
    }
}

