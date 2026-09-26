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
        lblTitulo = New System.Windows.Forms.Label()
        grpDatos = New System.Windows.Forms.GroupBox()
        txtCodigo = New System.Windows.Forms.TextBox()
        lblExistencia = New System.Windows.Forms.Label()
        lblPrecio = New System.Windows.Forms.Label()
        lblUnidad = New System.Windows.Forms.Label()
        lblCategoria = New System.Windows.Forms.Label()
        lblNombre = New System.Windows.Forms.Label()
        lblCodigo = New System.Windows.Forms.Label()
        lblIdValor = New System.Windows.Forms.Label()
        lblId = New System.Windows.Forms.Label()
        txtNombre = New System.Windows.Forms.TextBox()
        cboCategoria = New System.Windows.Forms.ComboBox()
        ComboBox1 = New System.Windows.Forms.ComboBox()
        nudPrecio = New System.Windows.Forms.NumericUpDown()
        nudExistencia = New System.Windows.Forms.NumericUpDown()
        chkActivo = New System.Windows.Forms.CheckBox()
        grpDatos.SuspendLayout()
        CType(nudPrecio, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudExistencia, ComponentModel.ISupportInitialize).BeginInit()
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
        grpDatos.Controls.Add(ComboBox1)
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
        lblIdValor.Location = New System.Drawing.Point(120, 32)
        lblIdValor.Name = "lblIdValor"
        lblIdValor.Size = New System.Drawing.Size(50, 15)
        lblIdValor.TabIndex = 3
        lblIdValor.Text = "(nuevo)"
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Location = New System.Drawing.Point(26, 32)
        lblId.Name = "lblId"
        lblId.Size = New System.Drawing.Size(21, 15)
        lblId.TabIndex = 2
        lblId.Text = "ID:"
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
        ' cboCategoria
        ' 
        cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cboCategoria.FormattingEnabled = True
        cboCategoria.Location = New System.Drawing.Point(111, 124)
        cboCategoria.Name = "cboCategoria"
        cboCategoria.Size = New System.Drawing.Size(200, 23)
        cboCategoria.TabIndex = 3
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Unidad", "", "Libra", "", "Galón", "", "Metro", "", "Bolsa", "", "Caja", "", "Rollo"})
        ComboBox1.Location = New System.Drawing.Point(111, 153)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New System.Drawing.Size(200, 23)
        ComboBox1.TabIndex = 4
        ' 
        ' nudPrecio
        ' 
        nudPrecio.DecimalPlaces = 2
        nudPrecio.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        nudPrecio.Location = New System.Drawing.Point(111, 185)
        nudPrecio.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        nudPrecio.Minimum = New Decimal(New Integer() {1000000, 0, 0, 0})
        nudPrecio.Name = "nudPrecio"
        nudPrecio.Size = New System.Drawing.Size(133, 23)
        nudPrecio.TabIndex = 5
        nudPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        nudPrecio.ThousandsSeparator = True
        nudPrecio.Value = New Decimal(New Integer() {1000000, 0, 0, 0})
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
        ' FrmProductos
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(1000, 530)
        Controls.Add(grpDatos)
        Controls.Add(lblTitulo)
        MinimumSize = New System.Drawing.Size(1016, 569)
        Name = "FrmProductos"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Ferreteria Los Robles . Inventario"
        grpDatos.ResumeLayout(False)
        grpDatos.PerformLayout()
        CType(nudPrecio, ComponentModel.ISupportInitialize).EndInit()
        CType(nudExistencia, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents nudPrecio As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudExistencia As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
End Class
