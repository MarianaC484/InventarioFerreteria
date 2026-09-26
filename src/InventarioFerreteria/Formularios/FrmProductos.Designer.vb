<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblTitulo = New System.Windows.Forms.Label()
        grpDatos = New System.Windows.Forms.GroupBox()
        chkActivo = New System.Windows.Forms.CheckBox()
        nudExistencia = New System.Windows.Forms.NumericUpDown()
        nudPrecio = New System.Windows.Forms.NumericUpDown()
        cboUnidad = New System.Windows.Forms.ComboBox()
        cboCategoria = New System.Windows.Forms.ComboBox()
        txtNombre = New System.Windows.Forms.TextBox()
        txtCodigo = New System.Windows.Forms.TextBox()
        lblExistencia = New System.Windows.Forms.Label()
        lblPrecio = New System.Windows.Forms.Label()
        lblUnidad = New System.Windows.Forms.Label()
        lblCategoria = New System.Windows.Forms.Label()
        lblNombre = New System.Windows.Forms.Label()
        lblCodigo = New System.Windows.Forms.Label()
        lblIdValor = New System.Windows.Forms.Label()
        lblId = New System.Windows.Forms.Label()
        grpAcciones = New System.Windows.Forms.GroupBox()
        btnEliminar = New System.Windows.Forms.Button()
        btnActualizar = New System.Windows.Forms.Button()
        btnAgregar = New System.Windows.Forms.Button()
        btnNuevo = New System.Windows.Forms.Button()
        lblBuscar = New System.Windows.Forms.Label()
        txtBuscar = New System.Windows.Forms.TextBox()
        btnBuscar = New System.Windows.Forms.Button()
        dgvProductos = New System.Windows.Forms.DataGridView()
        ssEstado = New System.Windows.Forms.StatusStrip()
        lblEstado = New System.Windows.Forms.ToolStripStatusLabel()
        lblTotal = New System.Windows.Forms.ToolStripStatusLabel()
        errValidacion = New System.Windows.Forms.ErrorProvider(components)
        ttAyuda = New System.Windows.Forms.ToolTip(components)
        grpDatos.SuspendLayout()
        CType(nudExistencia, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPrecio, ComponentModel.ISupportInitialize).BeginInit()
        grpAcciones.SuspendLayout()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        ssEstado.SuspendLayout()
        CType(errValidacion, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New System.Drawing.Font("Segoe UI", 14.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, CByte(0))
        lblTitulo.Location = New System.Drawing.Point(16, 12)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New System.Drawing.Size(228, 25)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Inventario de productos"
        ' 
        ' grpDatos
        ' 
        grpDatos.Controls.Add(chkActivo)
        grpDatos.Controls.Add(nudExistencia)
        grpDatos.Controls.Add(nudPrecio)
        grpDatos.Controls.Add(cboUnidad)
        grpDatos.Controls.Add(cboCategoria)
        grpDatos.Controls.Add(txtNombre)
        grpDatos.Controls.Add(txtCodigo)
        grpDatos.Controls.Add(lblExistencia)
        grpDatos.Controls.Add(lblPrecio)
        grpDatos.Controls.Add(lblUnidad)
        grpDatos.Controls.Add(lblCategoria)
        grpDatos.Controls.Add(lblNombre)
        grpDatos.Controls.Add(lblCodigo)
        grpDatos.Controls.Add(lblIdValor)
        grpDatos.Controls.Add(lblId)
        grpDatos.Location = New System.Drawing.Point(16, 52)
        grpDatos.Name = "grpDatos"
        grpDatos.Size = New System.Drawing.Size(340, 306)
        grpDatos.TabIndex = 1
        grpDatos.TabStop = False
        grpDatos.Text = "Datos del producto"
        ' 
        ' chkActivo
        ' 
        chkActivo.AutoSize = True
        chkActivo.Checked = True
        chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        chkActivo.Location = New System.Drawing.Point(111, 263)
        chkActivo.Name = "chkActivo"
        chkActivo.Size = New System.Drawing.Size(110, 19)
        chkActivo.TabIndex = 7
        chkActivo.Text = "Producto activo"
        chkActivo.UseVisualStyleBackColor = True
        ' 
        ' nudExistencia
        ' 
        nudExistencia.Location = New System.Drawing.Point(111, 220)
        nudExistencia.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        nudExistencia.Name = "nudExistencia"
        nudExistencia.Size = New System.Drawing.Size(133, 23)
        nudExistencia.TabIndex = 6
        nudExistencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        nudExistencia.ThousandsSeparator = True
        ' 
        ' nudPrecio
        ' 
        nudPrecio.DecimalPlaces = 2
        nudPrecio.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        nudPrecio.Location = New System.Drawing.Point(111, 185)
        nudPrecio.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        nudPrecio.Name = "nudPrecio"
        nudPrecio.Size = New System.Drawing.Size(133, 23)
        nudPrecio.TabIndex = 5
        nudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        nudPrecio.ThousandsSeparator = True
        ' 
        ' cboUnidad
        ' 
        cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboUnidad.FormattingEnabled = True
        cboUnidad.Items.AddRange(New Object() {"Unidad", "", "Libra", "", "Galón", "", "Metro", "", "Bolsa", "", "Caja", "", "Rollo"})
        cboUnidad.Location = New System.Drawing.Point(111, 153)
        cboUnidad.Name = "cboUnidad"
        cboUnidad.Size = New System.Drawing.Size(200, 23)
        cboUnidad.TabIndex = 4
        ' 
        ' cboCategoria
        ' 
        cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboCategoria.FormattingEnabled = True
        cboCategoria.Location = New System.Drawing.Point(111, 124)
        cboCategoria.Name = "cboCategoria"
        cboCategoria.Size = New System.Drawing.Size(200, 23)
        cboCategoria.TabIndex = 3
        ' 
        ' txtNombre
        ' 
        txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        txtNombre.Location = New System.Drawing.Point(111, 95)
        txtNombre.MaxLength = 100
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New System.Drawing.Size(200, 23)
        txtNombre.TabIndex = 2
        ' 
        ' txtCodigo
        ' 
        txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        txtCodigo.Location = New System.Drawing.Point(111, 66)
        txtCodigo.MaxLength = 15
        txtCodigo.Name = "txtCodigo"
        txtCodigo.Size = New System.Drawing.Size(200, 23)
        txtCodigo.TabIndex = 1
        ' 
        ' lblExistencia
        ' 
        lblExistencia.AutoSize = True
        lblExistencia.Location = New System.Drawing.Point(36, 222)
        lblExistencia.Name = "lblExistencia"
        lblExistencia.Size = New System.Drawing.Size(61, 15)
        lblExistencia.TabIndex = 9
        lblExistencia.Text = "Existencia:"
        ' 
        ' lblPrecio
        ' 
        lblPrecio.AutoSize = True
        lblPrecio.Location = New System.Drawing.Point(36, 187)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New System.Drawing.Size(68, 15)
        lblPrecio.TabIndex = 8
        lblPrecio.Text = "Precio (C$):"
        ' 
        ' lblUnidad
        ' 
        lblUnidad.AutoSize = True
        lblUnidad.Location = New System.Drawing.Point(36, 156)
        lblUnidad.Name = "lblUnidad"
        lblUnidad.Size = New System.Drawing.Size(48, 15)
        lblUnidad.TabIndex = 7
        lblUnidad.Text = "Unidad:"
        ' 
        ' lblCategoria
        ' 
        lblCategoria.AutoSize = True
        lblCategoria.Location = New System.Drawing.Point(36, 127)
        lblCategoria.Name = "lblCategoria"
        lblCategoria.Size = New System.Drawing.Size(61, 15)
        lblCategoria.TabIndex = 6
        lblCategoria.Text = "Categoría:"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New System.Drawing.Point(36, 98)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New System.Drawing.Size(54, 15)
        lblNombre.TabIndex = 5
        lblNombre.Text = "Nombre:"
        ' 
        ' lblCodigo
        ' 
        lblCodigo.AutoSize = True
        lblCodigo.Location = New System.Drawing.Point(36, 69)
        lblCodigo.Name = "lblCodigo"
        lblCodigo.Size = New System.Drawing.Size(49, 15)
        lblCodigo.TabIndex = 4
        lblCodigo.Text = "Código:"
        ' 
        ' lblIdValor
        ' 
        lblIdValor.AutoSize = True
        lblIdValor.Font = New System.Drawing.Font("Segoe UI", 9F, Drawing.FontStyle.Bold)
        lblIdValor.Location = New System.Drawing.Point(111, 32)
        lblIdValor.Name = "lblIdValor"
        lblIdValor.Size = New System.Drawing.Size(50, 15)
        lblIdValor.TabIndex = 3
        lblIdValor.Text = "(nuevo)"
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Location = New System.Drawing.Point(36, 32)
        lblId.Name = "lblId"
        lblId.Size = New System.Drawing.Size(21, 15)
        lblId.TabIndex = 2
        lblId.Text = "ID:"
        ' 
        ' grpAcciones
        ' 
        grpAcciones.Controls.Add(btnEliminar)
        grpAcciones.Controls.Add(btnActualizar)
        grpAcciones.Controls.Add(btnAgregar)
        grpAcciones.Controls.Add(btnNuevo)
        grpAcciones.Location = New System.Drawing.Point(16, 368)
        grpAcciones.Name = "grpAcciones"
        grpAcciones.Size = New System.Drawing.Size(340, 124)
        grpAcciones.TabIndex = 2
        grpAcciones.TabStop = False
        grpAcciones.Text = "Operaciones"
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Enabled = False
        btnEliminar.Location = New System.Drawing.Point(176, 73)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New System.Drawing.Size(148, 36)
        btnEliminar.TabIndex = 5
        btnEliminar.Text = "&Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Enabled = False
        btnActualizar.Location = New System.Drawing.Point(22, 73)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New System.Drawing.Size(148, 36)
        btnActualizar.TabIndex = 3
        btnActualizar.Text = "A&ctualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New System.Drawing.Point(176, 31)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New System.Drawing.Size(148, 36)
        btnAgregar.TabIndex = 4
        btnAgregar.Text = "&Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New System.Drawing.Point(22, 31)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New System.Drawing.Size(148, 36)
        btnNuevo.TabIndex = 3
        btnNuevo.Text = "&Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New System.Drawing.Point(383, 64)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New System.Drawing.Size(45, 15)
        lblBuscar.TabIndex = 3
        lblBuscar.Text = "Buscar:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        txtBuscar.Location = New System.Drawing.Point(434, 59)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.PlaceholderText = "Código o nombre del producto"
        txtBuscar.Size = New System.Drawing.Size(420, 23)
        txtBuscar.TabIndex = 4
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right
        btnBuscar.Location = New System.Drawing.Point(860, 59)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New System.Drawing.Size(118, 25)
        btnBuscar.TabIndex = 5
        btnBuscar.Text = "&Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' dgvProductos
        ' 
        dgvProductos.AllowUserToAddRows = False
        dgvProductos.AllowUserToDeleteRows = False
        dgvProductos.Anchor = System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right
        dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        dgvProductos.BackgroundColor = Drawing.SystemColors.ButtonHighlight
        dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProductos.Location = New System.Drawing.Point(383, 108)
        dgvProductos.MultiSelect = False
        dgvProductos.Name = "dgvProductos"
        dgvProductos.ReadOnly = True
        dgvProductos.RowHeadersVisible = False
        dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvProductos.Size = New System.Drawing.Size(595, 384)
        dgvProductos.TabIndex = 6
        ' 
        ' ssEstado
        ' 
        ssEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {lblEstado, lblTotal})
        ssEstado.Location = New System.Drawing.Point(0, 508)
        ssEstado.Name = "ssEstado"
        ssEstado.Size = New System.Drawing.Size(1000, 22)
        ssEstado.TabIndex = 7
        ssEstado.Text = "StatusStrip1"
        ' 
        ' lblEstado
        ' 
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New System.Drawing.Size(865, 17)
        lblEstado.Spring = True
        lblEstado.Text = "ToolStripStatusLabel1"
        lblEstado.TextAlign = Drawing.ContentAlignment.MiddleLeft
        ' 
        ' lblTotal
        ' 
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New System.Drawing.Size(120, 17)
        lblTotal.Text = "ToolStripStatusLabel2"
        ' 
        ' errValidacion
        ' 
        errValidacion.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        errValidacion.ContainerControl = Me
        ' 
        ' FrmProductos
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(1000, 530)
        Controls.Add(ssEstado)
        Controls.Add(dgvProductos)
        Controls.Add(btnBuscar)
        Controls.Add(txtBuscar)
        Controls.Add(lblBuscar)
        Controls.Add(grpAcciones)
        Controls.Add(grpDatos)
        Controls.Add(lblTitulo)
        MinimumSize = New System.Drawing.Size(1016, 569)
        Name = "FrmProductos"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Ferreteria Los Robles . Inventario"
        grpDatos.ResumeLayout(False)
        grpDatos.PerformLayout()
        CType(nudExistencia, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPrecio, ComponentModel.ISupportInitialize).EndInit()
        grpAcciones.ResumeLayout(False)
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        ssEstado.ResumeLayout(False)
        ssEstado.PerformLayout()
        CType(errValidacion, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblIdValor As System.Windows.Forms.Label
    Friend WithEvents lblExistencia As System.Windows.Forms.Label
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents lblUnidad As System.Windows.Forms.Label
    Friend WithEvents lblCategoria As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents cboCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents cboUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents nudPrecio As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudExistencia As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents grpAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents ssEstado As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTotal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents errValidacion As System.Windows.Forms.ErrorProvider
    Friend WithEvents ttAyuda As System.Windows.Forms.ToolTip
End Class
