# ToolTipper
 VB .NET tooltip class for making tooltips that can appear anywhere, independent of your forms or controls.

If you want examples of how to use it, open the solution and look in the main form.

If you want to use it in your own project, just add ToolTipper.vb to your project.

Currently available parameters are:

Public Sub New(ByVal message As String,
               ByVal Optional durationSeconds As Integer = 3,
               ByVal Optional followMouse As Boolean = True,
               ByVal Optional x As Integer = 0,
               ByVal Optional y As Integer = 0,
               ByVal Optional width As Integer = 0,
               ByVal Optional height As Integer = 0)
               
Note that followMouse and x and y are exclusive. If you don't turn followMouse to False, it will start at the specified x and y and then immediately jump to following the mouse.

Feel free to improve it!