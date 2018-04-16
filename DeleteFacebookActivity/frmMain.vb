Imports System.Threading
Public Class frmMain
  Dim strActivityURL As String = ""
  Dim blnIsBrowsing As Boolean = False
  Dim blnFoundLinks As Boolean = False
  Dim strURLList As String = ""
  Dim strDeleteURLs As String = ""
  Dim blnFoundDeeper As Boolean = False
  Dim intLoadMoreLevels As Integer = 0
  Dim blnStop As Boolean = True
  Dim txtAppTitle As String = "Facebook Activity Erase Tool"
  Dim strFacebookUserID As String = ""

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.Show()
    Application.DoEvents()
    With Me.TextBox2
      .Height = 14
      .Left = 0
      .Top = Me.ClientSize.Height - .Height
      .Width = Me.ClientSize.Width
      .BackColor = Color.LightPink
    End With
    ToggleButtons(True)
    ShowWarning()

    BrowseTo("https://mbasic.facebook.com/")
    If Me.WebBrowser1.DocumentTitle.ToString.ToLower.Contains("log in") Then
      Log("Please Login to Facebook via the 'Web View'.")
      Log("Then:")
      Log("1. Click on the 'Profile' button via the 'Web View'")
      Log("2. Click on the 'Activity Log' link via the 'Web View'")
      Log("3. Click on the button of the activity content you want to Erase.")
      Log("")
    Else
      Log("Please Wait a moment...")
      NavToActivityPage()
      Log("")
      Log("Ok! Now click on the button of the activity content you want to Erase.")
    End If


  End Sub
  Sub ShowWarning()
    Dim strText As String = ""
    strText = strText & "WARNING!\n\n"
    strText = strText & "This tool will DELETE all activities you have performed on Facebook.\n\n"
    strText = strText & "You will NOT be able to restore them once they are gone!\n\n"
    strText = strText & "You run this tool AT YOUR OWN RISK.\n\n"
    strText = strText & "Use of this tool MAY result in Facebook banning your account.\n\n"
    strText = strText & "I [Matt Owen/Jaruzel] am NOT LIABLE for any and all issues encountered due to the use of this tool against your Facebook account, or against other persons Facebook account.\n\n"
    strText = strText & "Click on the OK button to proceed, ONLY if you AGREE TO and UNDERSTAND the above.\n\n"
    strText = strText.Replace("\n", vbCrLf)

    Dim dlgResult As DialogResult = MsgBox(strText, MsgBoxStyle.OkCancel + MsgBoxStyle.Exclamation, txtAppTitle)
    If dlgResult = DialogResult.Cancel Then End

  End Sub
  Sub ToggleButtons(blnToggle As Boolean)
    Me.Button1.Enabled = blnToggle
    Me.Button2.Enabled = blnToggle
    Me.Button3.Enabled = blnToggle
    Me.Button4.Enabled = blnToggle
    Me.Button5.Enabled = blnToggle
    Me.Button6.Enabled = blnToggle

    Me.CheckBox1.Enabled = blnToggle

    If blnToggle = True Then btnStop.Enabled = False Else btnStop.Enabled = True

  End Sub
  Sub LetsGo(strID As String)
    If strFacebookUserID = "" Then
      MsgBox("No Facebook User ID detected, please manually navigate to your Activity Log page in the 'Web View' first.")
      Exit Sub
    End If

    Dim dlgRes As DialogResult = MsgBox("About to Erase Facebook Activity." & vbCrLf & vbCrLf & "Do not click on anything in the 'Web View' whilst the tool is running!", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, txtAppTitle)
    If dlgRes = DialogResult.Cancel Then Exit Sub

    Me.PictureBox1.Image = My.Resources.cry
    Me.Icon = My.Resources.ICON2
    Me.TextBox2.BackColor = Color.LightGreen
    ToggleButtons(False)
    StartErase(strID)
    ToggleButtons(True)
    Me.PictureBox1.Image = My.Resources.happy
    Me.Icon = My.Resources.ICON
    Me.TextBox2.BackColor = Color.LightPink
    Me.TextBox1.Focus()

  End Sub
  Sub StartErase(strActivityID As String)
    Dim blnDoDelete As Boolean = False
    blnStop = False
    Dim strFilter As String = "?log_filter=" & strActivityID
    Do
      blnDoDelete = False
      strURLList = ""
      strDeleteURLs = ""

      BrowseTo(strActivityURL & strFilter)
      Log("Top Level Scan...")
      CollectURLs()

      Dim strList As String = strURLList

      Log("Month Level Scan...")
      Dim arrURLs() As String = strList.Split(vbTab)
      For Each uURL As String In arrURLs
        BrowseTo(uURL)
        CollectURLs()
        If blnStop = True Then Exit Sub
      Next

      strList = strURLList
      Log("Looking for 'Load More'...")
      arrURLs = strList.Split(vbTab)
      For Each uURL As String In arrURLs
        intLoadMoreLevels = 1
        LookForLM(uURL)
        If blnStop = True Then Exit Sub
      Next

      strList = strURLList
      Log("Delete Items Scan...")
      arrURLs = strList.Split(vbTab)
      For Each uURL As String In arrURLs
        BrowseTo(uURL)
        DeleteActivity()
        If blnStop = True Then Exit Sub
      Next

      arrURLs = strDeleteURLs.Split(vbTab)
      For Each uURL As String In arrURLs
        If uURL.Trim <> "" Then
          Thread.Sleep(500)
          Log("Deleting..." & uURL)
          BrowseTo(uURL)
          blnDoDelete = True
          If blnStop = True Then Exit Sub
        End If
      Next
      If Me.CheckBox1.Checked = False Then Exit Do
      Log("Starting over to ensure all items deleted...")
    Loop Until blnDoDelete = False

    Log("All Done - nothing left to delete (Hopefully!)")
    WebBrowser1.Navigate(strActivityURL & strFilter)

  End Sub
  Sub BrowseTo(strURL As String)
    blnIsBrowsing = True
    WebBrowser1.Navigate(strURL)

    Do
      Application.DoEvents()
    Loop Until blnIsBrowsing = False

  End Sub
  Sub DeleteActivity()
    Thread.Sleep(1000)
    Dim strHref As String = ""


    If WebBrowser1.Url.ToString.ToLower.StartsWith(strActivityURL.ToLower) Then
      Dim colTags As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("a")
      For Each uTag As HtmlElement In colTags
        strHref = uTag.GetAttribute("href")
        If strHref.ToLower.Contains("/allactivity/removecontent/") Or strHref.ToLower.Contains("/allactivity/delete/") Then
          If strDeleteURLs.Contains(strHref) = False Then
            Log("-Delete Link: " & strHref)
            strDeleteURLs = strDeleteURLs & strHref & vbTab
          End If
        End If
      Next
    End If

  End Sub

  Sub CollectURLs()
    Thread.Sleep(1000)
    Dim strHref As String = ""
    If WebBrowser1.Url.ToString.ToLower.StartsWith(strActivityURL.ToLower) Then
      Dim colTags As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("a")
      For Each uTag As HtmlElement In colTags
        strHref = uTag.GetAttribute("href")
        If strHref.ToLower.Contains("/allactivity?timeend=") Then
          Dim strLinkText As String = ""
          Try
            strLinkText = uTag.InnerText
          Catch ex As Exception
            strLinkText = ""
          End Try
          'And strLinkText.ToLower.Contains("load more") = False
          If strLinkText Is Nothing Then strLinkText = ""
          If strURLList.Contains(strHref) = False And strLinkText <> "" And strLinkText.ToLower <> "back to top" Then
            Log("# " & strLinkText.Replace(vbCr, "").Replace(vbLf, "") & "-> " & strHref)
            strURLList = strURLList & strHref & vbTab
            blnFoundLinks = True
            blnFoundDeeper = True
          End If
        End If
      Next
    End If


  End Sub
  Sub LookForLM(strURL As String)
    Thread.Sleep(1000)
    BrowseTo(strURL)
    Dim strHref As String = ""

    If WebBrowser1.Url.ToString.ToLower.StartsWith(strActivityURL.ToLower) Then
      Dim colTags As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("a")
      For Each uTag As HtmlElement In colTags
        Try
          strHref = uTag.GetAttribute("href")
          If strHref.ToLower.Contains("/allactivity?timeend=") Then
            Dim strLinkText As String = ""
            Try
              strLinkText = uTag.InnerText
            Catch ex As Exception
              strLinkText = ""
            End Try
            'And strLinkText.ToLower.Contains("load more") = False
            If strLinkText Is Nothing Then strLinkText = ""
            If strLinkText.ToLower.Contains("load more") = True And strURLList.Contains(strHref) = False Then
              Log("# " & strLinkText.Replace(vbCr, "").Replace(vbLf, "") & " (" & intLoadMoreLevels & ")-> " & strHref)
              strURLList = strURLList & strHref & vbTab
              intLoadMoreLevels = intLoadMoreLevels + 1
              BrowseTo("about:blank")
              LookForLM(strHref)
              blnFoundLinks = True
              blnFoundDeeper = True
            End If
          End If
        Catch ex As Exception
          'Log("# Bad <a> tag hit!")
        End Try

      Next
    End If

  End Sub


  Sub Log(strText As String)
    TextBox1.Text = TextBox1.Text & strText & vbCrLf
    TextBox1.SelectionStart = TextBox1.Text.Length
    TextBox1.ScrollToCaret()
    TextBox1.Refresh()
  End Sub

  Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
    Me.TextBox2.Text = "Current Page: " & WebBrowser1.Url.ToString
    Me.Text = txtAppTitle & " - " & Me.WebBrowser1.DocumentTitle
    blnIsBrowsing = False

    If Me.WebBrowser1.Url.ToString.ToLower.Contains("/login/device-based/password/") = True Then
      'NavToActivityPage()
    End If

    If Me.WebBrowser1.Url.ToString.ToLower.Contains("/allactivity") = True And strFacebookUserID = "" Then
      Dim arrParts() As String = Me.WebBrowser1.Url.ToString.Split("/")
      strFacebookUserID = arrParts(3)
      Log("Facebook User ID: " & strFacebookUserID)
      strActivityURL = "https://mbasic.facebook.com/" & strFacebookUserID.Trim & "/allactivity"
    End If

  End Sub

  Sub NavToActivityPage()
    Dim colTags As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("a")
    Dim strHref As String = ""
    For Each uTag As HtmlElement In colTags
      Try
        If uTag.InnerText.ToLower = "profile" Then
          Dim uHref As String = uTag.GetAttribute("href")
          BrowseTo(uHref)
          Dim colTagsB As HtmlElementCollection = WebBrowser1.Document.GetElementsByTagName("a")
          For Each zTag As HtmlElement In colTagsB
            Try
              uHref = zTag.GetAttribute("href")
              If uHref.ToLower.Contains("/allactivity") = True Then
                BrowseTo(uHref)

                Exit For
              End If
            Catch ex As Exception
            End Try
          Next
          Exit For
        End If
      Catch ex As Exception

      End Try
    Next
  End Sub
  Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
    End
  End Sub
  Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
    blnStop = True
    MsgBox("Aborted!", MsgBoxStyle.Exclamation, Me.Text)
  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    LetsGo("cluster_116")
  End Sub

  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    LetsGo("likes")
  End Sub
  Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
    LetsGo("cluster_11")
  End Sub

  Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    LetsGo("friends")
  End Sub

  Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    LetsGo("cluster_202")
  End Sub

  Private Sub Button6_Click(sender As Object, e As EventArgs)
    LetsGo("search")
  End Sub

  Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
    Dim strFilterName As String = InputBox("Enter the 'log_filter' value for the Activity you want to delete." & vbCrLf & vbCrLf & "(Depending on the activity, this may not work!)", "ADVANCED OPTION", "")
    If strFilterName <> "" Then
      LetsGo(strFilterName)
    End If
  End Sub
  Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
    e.Handled = True
    e.KeyChar = Nothing
  End Sub
End Class
