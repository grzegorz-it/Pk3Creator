Namespace My
    ' Następujące zdarzenia są dostępne dla MyApplication:
    ' Startup: występuje podczas uruchamiania aplikacji, przed utworzeniem formularza początkowego.
    ' Shutdown: występuje po zamknięciu wszystkich formularzy aplikacji.  To zdarzenie nie jest wywoływane, jeśli aplikacja nieprawidłowo kończy działanie.
    ' UnhandledException: wyjątek wywoływany, gdy aplikacja napotka nieobsługiwany wyjątek.
    ' StartupNextInstance: występuje podczas uruchamiania pojedynczego wystąpienia aplikacji i gdy aplikacja jest już aktywna. 
    ' NetworkAvailabilityChanged: wyjątek wywoływany, gdy połączenie sieciowe jest połączone lub rozłączone.
    Partial Friend Class MyApplication
        <System.Runtime.InteropServices.DllImport("user32.dll")>
        Private Shared Function SetProcessDPIAware() As Boolean

        End Function

        Protected Overrides Sub OnRun()
            If Environment.OSVersion.Version.Major >= 6 Then
                SetProcessDPIAware()
            End If
            MyBase.OnRun()
        End Sub
    End Class
End Namespace
