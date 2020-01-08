Imports System.Threading

Public Class ToolTipper
    Inherits Form

    Private tooltipDurationCtr As Integer = 0
    Private Property Duration As Integer
    Private Property followMouse As Integer

    Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As Point) As Boolean

    Public Sub New(ByVal message As String,
                   ByVal Optional durationSeconds As Integer = 3,
                   ByVal Optional followMouse As Boolean = True,
                   ByVal Optional x As Integer = 0,
                   ByVal Optional y As Integer = 0,
                   ByVal Optional width As Integer = 0,
                   ByVal Optional height As Integer = 0)

        Me.FormBorderStyle = FormBorderStyle.None
        Me.ShowInTaskbar = False

        ' If width and height weren't specified, then use defaults.
        If width <= 0 Then
            Me.Width = message.Length() * 5
        Else
            Me.Width = width
        End If

        If height <= 0 Then
            Me.Height = 20
        Else
            Me.Height = height
        End If

        If durationSeconds <= 0 Then
            Me.Duration = 3
        Else
            Me.Duration = durationSeconds
        End If

        Me.Location = New Point(x, y)
        Me.StartPosition = FormStartPosition.Manual
        Me.BackColor = Color.LightYellow
        Me.followMouse = followMouse

        Dim label As Label = New Label With {
            .Text = message,
            .TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
            .Dock = DockStyle.Fill
        }

        Me.Padding = New Padding(5)
        Me.Controls.Add(label)
    End Sub

    Protected Overrides Sub OnShown(ByVal e As System.EventArgs)
        MyBase.OnShown(e)
        Dim ui As TaskScheduler = TaskScheduler.FromCurrentSynchronizationContext()
        Task.Factory.StartNew(Function() DuringTimeout(Me.Duration, ui))
    End Sub

    Private Function DuringTimeout(ByVal duration As Integer, ByVal ui As TaskScheduler)

        Dim durationTimeFixed As Integer = 0

        durationTimeFixed = duration * 1000

        Do
            'Let's not use more resources than we need to. Kill this loop if it's not visible.
            If Me.Visible = False Then
                Return 0
            End If

            If Me.followMouse = True Then
                Task.Factory.StartNew(Function() MoveToCursor(), CancellationToken.None, TaskCreationOptions.None, ui)
                Thread.Sleep(5)
                tooltipDurationCtr += 6
            Else
                Thread.Sleep(50)
                tooltipDurationCtr += 50
            End If

            If tooltipDurationCtr > durationTimeFixed Then
                Task.Factory.StartNew(Function() CloseForm(), CancellationToken.None, TaskCreationOptions.None, ui)

                Return 0
            End If

        Loop

    End Function

    Private Function CloseForm()
        Me.Close()

        Return 0
    End Function

    Private Function MoveToCursor()
        Dim cursorPoint As Point
        GetCursorPos(cursorPoint)

        'Move it so it's not dead under the cursor
        cursorPoint.X += 10
        cursorPoint.Y += 5

        Me.Location = New Point(cursorPoint)
        Me.Update()

        Return 0
    End Function

End Class