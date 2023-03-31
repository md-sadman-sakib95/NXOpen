Imports NXOpenUI
Imports NXOpen.UF
Imports NXOpen
Imports NXOpen.UF.UFUi

Module NXJournal
    Sub main()
        Dim Session = Session.GetSession
        Dim uFSession = uFSession.GetUFSession


        Dim selFilterFnT = New UFUi.SelInitFnT(Selectionparams)
        Dim scope As Integer = UFConstants.UF_UI_SEL_SCOPE_WORK_PART
        Dim intPtr As System.IntPtr.Zero
        Dim outPut As Integer
        Dim position As New Double
        Dim value = uFSession.Ui.

    End Sub

    Function Selectionparams() As int

        Dim num_triples As int = 1
        Dim masks = New UFUi.Mask[1]
            Dim value.object_type = UFConstants.UF_face_type
            Dim value1.object_subtype = 0
            Dim value2.solid_type = 0

            UFSession.Ui.SetSelMask(select, UFUi.SelMaskAction.SelMaskClearAndEnableSpecific, num_triples, masks)
        Return UFConstants.UF_UI_SEL_SUCCESS

    End Function

End Module
