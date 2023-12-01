Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class Main_Form
#Region "Left Side Navbar Function"

    Dim masterFileMenu As String = "Close"
    Dim transactionMenu As String = "Close"
    Dim queriesMenu As String = "Close"
    Dim reportsMenu As String = "Close"
    Dim costingMenu As String = "Close"
    Dim utilitiesMenu As String = "Close"
    Private transitionStep As Integer = 200


    REM ============================================ TIMERS ==========================================================
    Private Sub MasterfileMenuTransition_Tick(sender As Object, e As EventArgs) Handles MasterfileMenuTransition.Tick
        If masterFileMenu = "Open" Then
            PanelMasterfileMenu.Height += transitionStep
            If PanelMasterfileMenu.Height >= 280 Then
                masterFileMenu = "Close"
                MasterfileMenuTransition.Stop()
            End If

        Else
            PanelMasterfileMenu.Height -= transitionStep
            If PanelMasterfileMenu.Height <= 70 Then
                masterFileMenu = "Open"
                MasterfileMenuTransition.Stop()

            End If
        End If
    End Sub

    Private Sub TransactionMenuTransition_Tick(sender As Object, e As EventArgs) Handles TransactionMenuTransition.Tick
        If transactionMenu = "Open" Then
            PanelTransactionMenu.Height += transitionStep
            If PanelTransactionMenu.Height >= 665 Then
                transactionMenu = "Close"
                TransactionMenuTransition.Stop()
            End If

        Else
            PanelTransactionMenu.Height -= transitionStep
            If PanelTransactionMenu.Height <= 70 Then
                transactionMenu = "Open"
                TransactionMenuTransition.Stop()

            End If
        End If
    End Sub

    Private Sub QueriesMenuTransition_Tick(sender As Object, e As EventArgs) Handles QueriesMenuTransition.Tick
        If queriesMenu = "Open" Then
            PanelQueriesMenu.Height += transitionStep
            If PanelQueriesMenu.Height >= 315 Then
                queriesMenu = "Close"
                QueriesMenuTransition.Stop()
            End If

        Else
            PanelQueriesMenu.Height -= transitionStep
            If PanelQueriesMenu.Height <= 70 Then
                queriesMenu = "Open"
                QueriesMenuTransition.Stop()

            End If
        End If
    End Sub

    Private Sub ReportsMenuTransition_Tick(sender As Object, e As EventArgs) Handles ReportsMenuTransition.Tick
        If reportsMenu = "Open" Then
            PanelReportsMenu.Height += transitionStep
            If PanelReportsMenu.Height >= 560 Then
                reportsMenu = "Close"
                ReportsMenuTransition.Stop()
            End If

        Else
            PanelReportsMenu.Height -= transitionStep
            If PanelReportsMenu.Height <= 70 Then
                reportsMenu = "Open"
                ReportsMenuTransition.Stop()
            End If
        End If
    End Sub

    Private Sub CostingMenuTransition_Tick(sender As Object, e As EventArgs) Handles CostingMenuTransition.Tick
        If costingMenu = "Open" Then
            PanelCostingMenu.Height += transitionStep
            If PanelCostingMenu.Height >= 595 Then
                costingMenu = "Close"
                CostingMenuTransition.Stop()
            End If

        Else
            PanelCostingMenu.Height -= transitionStep
            If PanelCostingMenu.Height <= 70 Then
                costingMenu = "Open"
                CostingMenuTransition.Stop()
            End If
        End If
    End Sub

    Private Sub UtilitiesMenuTransition_Tick(sender As Object, e As EventArgs) Handles UtilitiesMenuTransition.Tick
        If utilitiesMenu = "Open" Then
            PanelUtilitiesMenu.Height += transitionStep
            If PanelUtilitiesMenu.Height >= 280 Then
                utilitiesMenu = "Close"
                UtilitiesMenuTransition.Stop()
            End If
        Else
            PanelUtilitiesMenu.Height -= transitionStep
            If PanelUtilitiesMenu.Height <= 70 Then
                utilitiesMenu = "Open"
                UtilitiesMenuTransition.Stop()
            End If
        End If
    End Sub
    REM ============================================ TIMERS ==========================================================

    REM ========================================= MENU BUTTONS =======================================================
    Private Sub BtnMasterfileMenu_Click(sender As Object, e As EventArgs) Handles BtnMasterfileMenu.Click
        MasterfileMenuTransition.Start()

        If transactionMenu = "Close" AndAlso PanelTransactionMenu.ClientRectangle.Contains(PanelTransactionMenu.PointToClient(Cursor.Position)) = False Then
            TransactionMenuTransition.Start()
        End If

        If queriesMenu = "Close" AndAlso PanelQueriesMenu.ClientRectangle.Contains(PanelQueriesMenu.PointToClient(Cursor.Position)) = False Then
            QueriesMenuTransition.Start()
        End If

        If reportsMenu = "Close" AndAlso PanelReportsMenu.ClientRectangle.Contains(PanelReportsMenu.PointToClient(Cursor.Position)) = False Then
            ReportsMenuTransition.Start()
        End If

        If costingMenu = "Close" AndAlso PanelCostingMenu.ClientRectangle.Contains(PanelCostingMenu.PointToClient(Cursor.Position)) = False Then
            CostingMenuTransition.Start()
        End If

        If utilitiesMenu = "Close" AndAlso PanelUtilitiesMenu.ClientRectangle.Contains(PanelUtilitiesMenu.PointToClient(Cursor.Position)) = False Then
            UtilitiesMenuTransition.Start()
        End If

    End Sub

    Private Sub BtnTransactionMenu_Click(sender As Object, e As EventArgs) Handles BtnTransactionMenu.Click
        TransactionMenuTransition.Start()

        If masterFileMenu = "Close" AndAlso PanelMasterfileMenu.ClientRectangle.Contains(PanelMasterfileMenu.PointToClient(Cursor.Position)) = False Then
            MasterfileMenuTransition.Start()
        End If

        If queriesMenu = "Close" AndAlso PanelQueriesMenu.ClientRectangle.Contains(PanelQueriesMenu.PointToClient(Cursor.Position)) = False Then
            QueriesMenuTransition.Start()
        End If

        If reportsMenu = "Close" AndAlso PanelReportsMenu.ClientRectangle.Contains(PanelReportsMenu.PointToClient(Cursor.Position)) = False Then
            ReportsMenuTransition.Start()
        End If

        If costingMenu = "Close" AndAlso PanelCostingMenu.ClientRectangle.Contains(PanelCostingMenu.PointToClient(Cursor.Position)) = False Then
            CostingMenuTransition.Start()
        End If

        If utilitiesMenu = "Close" AndAlso PanelUtilitiesMenu.ClientRectangle.Contains(PanelUtilitiesMenu.PointToClient(Cursor.Position)) = False Then
            UtilitiesMenuTransition.Start()
        End If
    End Sub

    Private Sub BtnQueriesMenu_Click(sender As Object, e As EventArgs) Handles BtnQueriesMenu.Click
        QueriesMenuTransition.Start()

        If masterFileMenu = "Close" AndAlso PanelMasterfileMenu.ClientRectangle.Contains(PanelMasterfileMenu.PointToClient(Cursor.Position)) = False Then
            MasterfileMenuTransition.Start()
        End If

        If transactionMenu = "Close" AndAlso PanelTransactionMenu.ClientRectangle.Contains(PanelTransactionMenu.PointToClient(Cursor.Position)) = False Then
            TransactionMenuTransition.Start()
        End If

        If reportsMenu = "Close" AndAlso PanelReportsMenu.ClientRectangle.Contains(PanelReportsMenu.PointToClient(Cursor.Position)) = False Then
            ReportsMenuTransition.Start()
        End If

        If costingMenu = "Close" AndAlso PanelCostingMenu.ClientRectangle.Contains(PanelCostingMenu.PointToClient(Cursor.Position)) = False Then
            CostingMenuTransition.Start()
        End If

        If utilitiesMenu = "Close" AndAlso PanelUtilitiesMenu.ClientRectangle.Contains(PanelUtilitiesMenu.PointToClient(Cursor.Position)) = False Then
            UtilitiesMenuTransition.Start()
        End If
    End Sub

    Private Sub BtnReportsMenu_Click(sender As Object, e As EventArgs) Handles BtnReportsMenu.Click
        ReportsMenuTransition.Start()

        If masterFileMenu = "Close" AndAlso PanelMasterfileMenu.ClientRectangle.Contains(PanelMasterfileMenu.PointToClient(Cursor.Position)) = False Then
            MasterfileMenuTransition.Start()
        End If

        If transactionMenu = "Close" AndAlso PanelTransactionMenu.ClientRectangle.Contains(PanelTransactionMenu.PointToClient(Cursor.Position)) = False Then
            TransactionMenuTransition.Start()
        End If

        If queriesMenu = "Close" AndAlso PanelQueriesMenu.ClientRectangle.Contains(PanelQueriesMenu.PointToClient(Cursor.Position)) = False Then
            QueriesMenuTransition.Start()
        End If

        If costingMenu = "Close" AndAlso PanelCostingMenu.ClientRectangle.Contains(PanelCostingMenu.PointToClient(Cursor.Position)) = False Then
            CostingMenuTransition.Start()
        End If

        If utilitiesMenu = "Close" AndAlso PanelUtilitiesMenu.ClientRectangle.Contains(PanelUtilitiesMenu.PointToClient(Cursor.Position)) = False Then
            UtilitiesMenuTransition.Start()
        End If
    End Sub

    Private Sub BtnCostingMenu_Click(sender As Object, e As EventArgs) Handles BtnCostingMenu.Click
        CostingMenuTransition.Start()

        If masterFileMenu = "Close" AndAlso PanelMasterfileMenu.ClientRectangle.Contains(PanelMasterfileMenu.PointToClient(Cursor.Position)) = False Then
            MasterfileMenuTransition.Start()
        End If

        If transactionMenu = "Close" AndAlso PanelTransactionMenu.ClientRectangle.Contains(PanelTransactionMenu.PointToClient(Cursor.Position)) = False Then
            TransactionMenuTransition.Start()
        End If

        If queriesMenu = "Close" AndAlso PanelQueriesMenu.ClientRectangle.Contains(PanelQueriesMenu.PointToClient(Cursor.Position)) = False Then
            QueriesMenuTransition.Start()
        End If

        If reportsMenu = "Close" AndAlso PanelReportsMenu.ClientRectangle.Contains(PanelReportsMenu.PointToClient(Cursor.Position)) = False Then
            ReportsMenuTransition.Start()
        End If

        If utilitiesMenu = "Close" AndAlso PanelUtilitiesMenu.ClientRectangle.Contains(PanelUtilitiesMenu.PointToClient(Cursor.Position)) = False Then
            UtilitiesMenuTransition.Start()
        End If
    End Sub

    Private Sub BtnUtilitiesMenu_Click(sender As Object, e As EventArgs) Handles BtnUtilitiesMenu.Click
        UtilitiesMenuTransition.Start()

        If masterFileMenu = "Close" AndAlso PanelMasterfileMenu.ClientRectangle.Contains(PanelMasterfileMenu.PointToClient(Cursor.Position)) = False Then
            MasterfileMenuTransition.Start()
        End If

        If transactionMenu = "Close" AndAlso PanelTransactionMenu.ClientRectangle.Contains(PanelTransactionMenu.PointToClient(Cursor.Position)) = False Then
            TransactionMenuTransition.Start()
        End If

        If queriesMenu = "Close" AndAlso PanelQueriesMenu.ClientRectangle.Contains(PanelQueriesMenu.PointToClient(Cursor.Position)) = False Then
            QueriesMenuTransition.Start()
        End If

        If reportsMenu = "Close" AndAlso PanelReportsMenu.ClientRectangle.Contains(PanelReportsMenu.PointToClient(Cursor.Position)) = False Then
            ReportsMenuTransition.Start()
        End If

        If costingMenu = "Close" AndAlso PanelCostingMenu.ClientRectangle.Contains(PanelCostingMenu.PointToClient(Cursor.Position)) = False Then
            CostingMenuTransition.Start()
        End If
    End Sub
    REM ========================================= MENU BUTTONS =======================================================
#End Region


End Class