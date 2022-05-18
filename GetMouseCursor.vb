'Add to variables section
<DllImport(""user32.dll"")> _
    Public Shared Function GetCursorPos(<Out> ByRef lpPoint As POINT) As Boolean
    End Function

<System.Runtime.InteropServices.StructLayout(Runtime.InteropServices.LayoutKind.Sequential)> _
    Public Structure POINT
              Public X As Integer
              Public Y As Integer
              Public Sub New(ByVal X As Integer, ByVal Y As Integer)
                     Me.X = X
                     Me.Y = Y
              End Sub
    End Structure"				
					
					
					
					
					
					
					
					
					
					
'Add to button code
Dim lpPoint As POINT
GetCursorPos(lpPoint)
MsgBox(""Cursor Position: "" & CStr(lpPoint.X) & "","" & CStr(lpPoint.Y))
