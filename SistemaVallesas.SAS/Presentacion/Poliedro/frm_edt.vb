Public Class frm_edt
    Public poliedro As String
    Private Sub frm_edt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        iniciar()
        Me.btn_n0.Visible = False
        Me.btn_n1.Visible = False
        Me.btn_n2.Visible = False
        Me.btn_n3.Visible = False
        Me.btn_n4.Visible = False
        Me.gb_1.Visible = False
        Me.gb_2.Visible = False
    End Sub
    Sub iniciar()
        With dtg_preliminares
            .Visible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .AllowUserToAddRows = False
        End With
        Me.lbl_descripcion.Visible = False
        Me.gb_1.Visible = False
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If btn_n0.Visible = False Then
            Me.btn_n0.Visible = True
        Else
            Me.btn_n0.Visible = False
        End If

        If Me.btn_n1.Visible = False Then
            Me.btn_n1.Visible = True
        Else
            Me.btn_n1.Visible = False
        End If
        If Me.btn_n2.Visible = False Then
            Me.btn_n2.Visible = True
        Else
            Me.btn_n2.Visible = False
        End If
        If Me.btn_n3.Visible = False Then
            Me.btn_n3.Visible = True
        Else
            Me.btn_n3.Visible = False
        End If
        If Me.btn_n4.Visible = False Then
            Me.btn_n4.Visible = True
        Else
            Me.btn_n4.Visible = False
        End If
    End Sub

    Private Sub btn_n0_Click(sender As Object, e As EventArgs) Handles btn_n0.Click
        iniciar()
        Me.gb_1.Visible = True
        Me.gb_2.Visible = False

    End Sub

    Private Sub dtg_preliminares_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtg_preliminares.CellContentClick
        With Me.dtg_preliminares
            If .CurrentCell.ColumnIndex = 1 And Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Zapatas" Then
                reset_dtg()
                .Columns(1).Width = "100"
                .Columns(2).Width = "200"
                .Rows.Add("1", "Zapatas", "Trazo y excavacion de la zapata")
                .Rows.Add("2", "", "Colocacion del hormigon de limpieza")
                .Rows.Add("3", "", "Postura del acero inferior de la zapata")
                .Rows.Add("4", "", "Colocacion del acero vertical del pilar ")
                .Rows.Add("5", "", "Vibrado del hormigon")
                .Rows.Add("6", "", "Curado del hormigon")
                .Columns(2).Visible = True
                .Cursor = Cursors.Hand
                poliedro = "d"
            End If

            If .CurrentCell.ColumnIndex = 1 And Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Cimentacion" Then
                reset_dtg()
                .Columns(1).Width = "100"
                .Columns(2).Width = "200"
                .Rows.Add("1", "Cimentacion", "Excavaciones")
                .Rows.Add("2", "", "Armado y figurado de acero")
                .Rows.Add("3", "", "Formaleteado")
                .Rows.Add("4", "", "Vaciado de concreto")
                .Rows.Add("5", "", "Desencofrado y curado")
                .Columns(2).Visible = True
                .Cursor = Cursors.Hand
            End If
            If .CurrentCell.ColumnIndex = 1 And Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Vigas de cimentacion" Then
                reset_dtg()
                .Columns(1).Width = "100"
                .Columns(2).Width = "500"
                .Rows.Add("1", "Vigas de cimentacion", "Localizar la ubicación, las dimensiones y características de armado de la viga")
                .Rows.Add("2", "", "Medir, figurar y cortar el hierro principal de la viga y de los flejes")
                .Rows.Add("3", "", "Figurar los estribos teniendo en cuenta el recubrimiento del hierro con el hormigón")
                .Rows.Add("4", "", "Armar la canasta con las varillas en extremos diferentes")
                .Rows.Add("5", "", "Marcar los niveles estableciendo la altura de la viga")
                .Rows.Add("6", "", "Vibrar con una maceta de caucho mediante golpes suaves sobre la formaleta")
                .Rows.Add("7", "", "Se nivela la corona de la viga colocando uno hilo entre los clavos de nivelación")
                .Rows.Add("8", "", "Vibrar con una maceta de caucho mediante golpes suaves sobre la formaletaClavar y arriostrar el encofrado en las orillas para la resistencia del empuje lateral ")
                .Columns(2).Visible = True
                .Cursor = Cursors.Hand
            End If
            If .CurrentCell.ColumnIndex = 1 And Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Columnas" Then
                reset_dtg()
                .Columns(1).Width = "100"
                .Columns(2).Width = "200"
                .Rows.Add("1", "Columnas", "Corte, figurarado y armado de acero")
                .Rows.Add("2", "", "Formaletas en madera o metalicas")
                .Rows.Add("3", "", "Vaciado del concreto")
                .Rows.Add("4", "", "Desencofrado y curado")
                .Columns(2).Visible = True
                .Cursor = Cursors.Hand
            End If
            If .CurrentCell.ColumnIndex = 1 And Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Losa de entrepiso" Then
                reset_dtg()
                .Columns(1).Width = "100"
                .Columns(2).Width = "200"
                .Rows.Add("1", "Losa de entrepiso", "Entablado y armado de elementos verticales")
                .Rows.Add("2", "", "Malla electrosoldada")
                .Rows.Add("3", "", "Armado del acero de refuerzo")
                .Rows.Add("4", "", "Colocacion del aligerante")
                .Rows.Add("5", "", "Vaciado de concreto")
                .Rows.Add("6", "", "Curado y desencofrado")
                .Columns(2).Visible = True
                .Cursor = Cursors.Hand
            End If
            If .CurrentCell.ColumnIndex = 1 And Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Mamposteria" Then
                reset_dtg()
                .Columns(1).Width = "100"
                .Columns(2).Width = "200"
                .Rows.Add("1", "Mamposteria", "Pañete de muros exteriores e interiores")
                .Rows.Add("2", "", "Aplicación del Estuco plastico en vigas y columnas")
                .Rows.Add("3", "", "Se procede a ejecutar el Antepiso")
                .Rows.Add("4", "", "Ejecucion del Piso en baldosa")
                .Columns(2).Visible = True
                .Cursor = Cursors.Hand
            End If
            If .CurrentCell.ColumnIndex = 1 And Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Escaleras" Then
                reset_dtg()
                .Columns(1).Width = "100"
                .Columns(2).Width = "200"
                .Rows.Add("1", "Escaleras", "Encofrado y armado")
                .Rows.Add("2", "", "Armadura de acero")
                .Rows.Add("3", "", "Vaciado del concreto")
                .Rows.Add("4", "", "Compactacion con vibrador")
                .Columns(2).Visible = True
                .Cursor = Cursors.Hand
            End If
            If .CurrentCell.ColumnIndex = 1 And Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Puertas" Then
                reset_dtg()
                .Columns(1).Width = "100"
                .Columns(2).Width = "200"
                .Rows.Add("1", "Puertas", "Taladrar los Tornillos con taco fisher")
                .Rows.Add("2", "", "Ajuste del Vano en el marco")
                .Rows.Add("3", "", "Aplicación del Mortero de pega")
                .Rows.Add("4", "", "Colocacion de bisagras")
                .Rows.Add("5", "", "Instalaion de Puerta corrediza en vidrio templado")
                .Columns(2).Visible = True
                .Cursor = Cursors.Hand
            End If
            If .CurrentCell.ColumnIndex = 1 And Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Ventanas" Then
                reset_dtg()
                .Columns(1).Width = "100"
                .Columns(2).Width = "200"
                .Rows.Add("1", "Ventanas", "Localizacion del vano de la ventana")
                .Rows.Add("2", "", "Limpieza de los filos, caras y exceso de mortero")
                .Rows.Add("3", "", "Rectificacion con cinta metrica de las distancias del claro")
                .Rows.Add("4", "", "Taladrar los orificios del marco y el muro")
                .Rows.Add("5", "", "Instalacion de ventana en aluminio natural mate con impermeabilizacion")
                .Columns(2).Visible = True
                .Cursor = Cursors.Hand
                End
            End If
            If .CurrentCell.ColumnIndex = 1 And Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Pisos" Then
                reset_dtg()
                .Columns(1).Width = "100"
                .Columns(2).Width = "200"
                .Rows.Add("1", "Pisos", "Nivelacion de la superficie")
                .Rows.Add("2", "", "Epaciadores en las lineas para cortes")
                .Rows.Add("3", "", "Aplicación de mortero adhesivo")
                .Rows.Add("4", "", "Alineacion y nivelacion de las baldosas")
                .Rows.Add("5", "", "Instalacion de piso en loseta tipo Deck de indural 4*12*100")
                .Rows.Add("6", "", "Instalacion de piso en baldosa de granito #1 pulido 30*30 cms")
                .Rows.Add("7", "", "Instalacion de piso de baño en baldosa de granito pulido 30*30 ")
                .Columns(2).Visible = True
                .Cursor = Cursors.Hand
                End
            End If
            If .CurrentCell.ColumnIndex = 1 And Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Pinturas" Then
                reset_dtg()
                .Columns(1).Width = "100"
                .Columns(2).Width = "200"
                .Rows.Add("1", "Pinturas", "Preparacion del soporte y la pintura")
                .Rows.Add("2", "", "Aplicación de capas de fondo")
                .Rows.Add("3", "", "Uso de los Tapaporos y selladores de fisuras en la superficie")
                .Rows.Add("4", "", "Imprimaciones del vinilo escojido")
                .Rows.Add("5", "", "Aplicación Barnices y pinturas de acabado")
                .Columns(2).Visible = True
                .Cursor = Cursors.Hand
                End
            End If
            If .CurrentCell.ColumnIndex = 1 And Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Vidrios" Then
                reset_dtg()
                .Columns(1).Width = "100"
                .Columns(2).Width = "200"
                .Rows.Add("1", "Vidrios", "Alineamiento con el marco de ventana")
                .Rows.Add("2", "", "Ajuste general del templado ")
                .Rows.Add("3", "", "Limpieza y adecuacion de la superficie")
                .Rows.Add("4", "", "Pegado del vidrio con silicona")
                .Rows.Add("5", "", "Instalacion del vidrio traslucido para exterior")
                .Columns(2).Visible = True
                .Cursor = Cursors.Hand
                End
            End If
        End With
    End Sub
    Sub reset_dtg()
        Dim resetdtg As New CapaNegocio.ClassReset(Me.dtg_preliminares)
    End Sub
    Private Sub btn_n1_Click(sender As Object, e As EventArgs) Handles btn_n1.Click
        Me.dtg_preliminares.Visible = False
        Me.gb_1.Visible = False
        Me.gb_2.Visible = True
        iniciar()
    End Sub

    Private Sub btn_n2_Click(sender As Object, e As EventArgs) Handles btn_n2.Click
        Me.dtg_preliminares.Visible = False
        Me.gb_1.Visible = False
        Me.gb_2.Visible = False

    End Sub

    Private Sub btn_n3_Click(sender As Object, e As EventArgs) Handles btn_n3.Click
        Me.dtg_preliminares.Visible = False
        Me.gb_1.Visible = False
    End Sub

    Private Sub btn_n4_Click(sender As Object, e As EventArgs) Handles btn_n4.Click
        Me.dtg_preliminares.Visible = False
        Me.gb_1.Visible = False
    End Sub

    Private Sub btn_preliminares_Click(sender As Object, e As EventArgs) Handles btn_preliminares.Click
        Me.lbl_descripcion.Visible = True
        With Me.dtg_preliminares
            Dim resetdtg As New CapaNegocio.ClassReset(Me.dtg_preliminares)
            .Visible = True
            .Rows.Add("1", "Localizacion y replanteo")
            .Rows.Add("2", "Campamento, almacen y oficina")
            .Rows.Add("3", "Centro de acopio para materiales")
            .Rows.Add("4", "Cerramientos provisionales  ")
            .Rows.Add("5", "Servicios provisionales de acueducto, alcantarillado y energia")
            .Rows.Add("6", "Señalizacion")
            .Columns(2).Visible = False
            .Columns(1).Width = "300"
        End With
    End Sub

    Private Sub btn_movimiento_de_tierra_Click(sender As Object, e As EventArgs) Handles btn_movimiento_de_tierra.Click
        With Me.dtg_preliminares
            Me.lbl_descripcion.Visible = True
            Dim resetdtg As New CapaNegocio.ClassReset(Me.dtg_preliminares)
            .Visible = True
            .Rows.Add("1", "Retiro de vegetacion")
            .Rows.Add("2", "Explanacion y nivelacion del terreno")
            .Rows.Add("3", "Corte en material comun")
            .Rows.Add("4", "Remocion de derrumbes")
            .Rows.Add("5", "Terraplenes")
            .Rows.Add("6", "Excavaciones")
            .Columns(2).Visible = False
            .Columns(1).Width = "300"
        End With
    End Sub

    Private Sub btn_est_concreto_Click(sender As Object, e As EventArgs) Handles btn_est_concreto.Click
        Estructuras_en_concreto()
    End Sub
    Sub Estructuras_en_concreto()
        With Me.dtg_preliminares
            Dim resetdtg As New CapaNegocio.ClassReset(Me.dtg_preliminares)
            .Visible = True
            .Columns(1).Width = "200"
            .Columns(2).Width = "350"
            .Rows.Add("1", "Zapatas", "")
            .Rows.Add("2", "Cimentacion", "")
            .Rows.Add("3", "Vigas de cimentacion", "")
            .Columns(2).Visible = False
        End With
    End Sub

    Private Sub dtg_preliminares_SelectionChanged(sender As Object, e As EventArgs) Handles dtg_preliminares.SelectionChanged
        Me.lbl_descripcion.Visible = True
        With Me.dtg_preliminares
            If Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Localizacion y replanteo" Then
                Me.lbl_descripcion.Text = "Localizacion y replanteo"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Campamento, almacen y oficina" Then
                Me.lbl_descripcion.Text = "Campamento, almacen y oficina"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Centro de acopio para materiales" Then
                Me.lbl_descripcion.Text = "Centro de acopio para materiales"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Cerramientos provisionales" Then
                Me.lbl_descripcion.Text = "Cerramientos provisionales"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Servicios provisionales de acueducto, alcantarillado y energia" Then
                Me.lbl_descripcion.Text = "Servicios provisionales de acueducto, alcantarillado y energia"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Retiro de vegetacion" Then
                Me.lbl_descripcion.Text = "Retiro de vegetacion"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Explanacion y nivelacion del terreno" Then
                Me.lbl_descripcion.Text = "Explanacion y nivelacion del terreno"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Corte en material comun" Then
                Me.lbl_descripcion.Text = "Corte en material comun"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Remocion de derrumbes" Then
                Me.lbl_descripcion.Text = "Remocion de derrumbes"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Terraplenes" Then
                Me.lbl_descripcion.Text = "Terraplenes"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(1).Value) = "Excavaciones" Then
                Me.lbl_descripcion.Text = "Excavaciones"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(2).Value) = "Trazo y excavacion de la zapata" Then
                Me.lbl_descripcion.Text = "Trazo y excavacion de la zapata"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(2).Value) = "Colocacion del hormigon de limpieza" Then
                Me.lbl_descripcion.Text = "Colocacion del hormigon de limpieza"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(2).Value) = "Postura del acero inferior de la zapata" Then
                Me.lbl_descripcion.Text = "Postura del acero inferior de la zapata"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(2).Value) = "Colocacion del acero vertical del pilar" Then
                Me.lbl_descripcion.Text = "Colocacion del acero vertical del pilar"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(2).Value) = "Vibrado del hormigon" Then
                Me.lbl_descripcion.Text = "Vibrado del hormigon"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(2).Value) = "Curado del hormigon" Then
                Me.lbl_descripcion.Text = "Curado del hormigon"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(2).Value) = "Excavaciones" Then
                Me.lbl_descripcion.Text = "Excavaciones"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(2).Value) = "Armado y figurado de acero" Then
                Me.lbl_descripcion.Text = "Armado y figurado de acero"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(2).Value) = "Formaleteado" Then
                Me.lbl_descripcion.Text = "Formaleteado"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(2).Value) = "Vaciado de concreto" Then
                Me.lbl_descripcion.Text = "Vaciado de concreto"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(2).Value) = "Desencofrado y curado" Then
                Me.lbl_descripcion.Text = "Desencofrado y curado"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(2).Value) = "Localizar la ubicación, las dimensiones y características de armado de la viga" Then
                Me.lbl_descripcion.Text = "Localizar la ubicación, las dimensiones y características de armado de la viga"
            End If
            If Convert.ToString(.CurrentRow.Cells.Item(2).Value) = "Medir, figurar y cortar el hierro principal de la viga y de los flejes" Then
                Me.lbl_descripcion.Text = "Medir, figurar y cortar el hierro principal de la viga y de los flejes"
            End If

        End With

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles gb_1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reset_dtg()
        With Me.dtg_preliminares
            .Visible = True
            .Columns(1).Width = "200"
            .Columns(2).Width = "350"
            .Rows.Add("1", "Columnas", "")
            .Rows.Add("2", "Losa de entrepiso", "")
            .Rows.Add("3", "Sillar en concreto", "")
            .Columns(2).Visible = False
        End With
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        reset_dtg()
        With Me.dtg_preliminares
            .Visible = True
            .Columns(1).Width = "200"
            .Columns(2).Width = "100"
            .Rows.Add("1", "Mamposteria", "")
            .Rows.Add("2", "Escaleras", "")
            .Rows.Add("3", "Puertas", "")
            .Rows.Add("4", "Ventanas", "")
            .Rows.Add("5", "Pisos", "")
            .Rows.Add("6", "Pinturas", "")
            .Rows.Add("7", "Vidrios", "")
            .Columns(2).Visible = False
        End With
    End Sub
End Class