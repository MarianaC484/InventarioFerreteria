<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedores
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
        lblId = New System.Windows.Forms.Label()
        lblIdValor = New System.Windows.Forms.Label()
        lblNombre = New System.Windows.Forms.Label()
        lblRuc = New System.Windows.Forms.Label()
        lblTelefono = New System.Windows.Forms.Label()
        txtNombre = New System.Windows.Forms.TextBox()
        txtRuc = New System.Windows.Forms.TextBox()
        txtTelefono = New System.Windows.Forms.TextBox()
        txtCorreo = New System.Windows.Forms.TextBox()
        lblCorreo = New System.Windows.Forms.Label()
        grpAcciones = New System.Windows.Forms.GroupBox()
        btnNuevo = New System.Windows.Forms.Button()
        btnAgregar = New System.Windows.Forms.Button()
        btnActualizar = New System.Windows.Forms.Button()
        btnEliminar = New System.Windows.Forms.Button()
        lblBuscar = New System.Windows.Forms.Label()
        txtBuscar = New System.Windows.Forms.TextBox()
        btnBuscar = New System.Windows.Forms.Button()
        dgvProveedores = New System.Windows.Forms.DataGridView()
        StatusStrip1 = New System.Windows.Forms.StatusStrip()
        lblEstado = New System.Windows.Forms.ToolStripStatusLabel()
        lblTotal = New System.Windows.Forms.ToolStripStatusLabel()
        errValidacion = New System.Windows.Forms.ErrorProvider(components)
        ttAyuda = New System.Windows.Forms.ToolTip(components)
        grpDatos.SuspendLayout()
        grpAcciones.SuspendLayout()
        CType(dgvProveedores, ComponentModel.ISupportInitialize).BeginInit()
        StatusStrip1.SuspendLayout()
        CType(errValidacion, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Location = New System.Drawing.Point(24, 21)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New System.Drawing.Size(153, 15)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "GESTIÓN DE PROVEEDORES"
        ' 
        ' grpDatos
        ' 
        grpDatos.Controls.Add(lblCorreo)
        grpDatos.Controls.Add(txtCorreo)
        grpDatos.Controls.Add(txtTelefono)
        grpDatos.Controls.Add(txtRuc)
        grpDatos.Controls.Add(txtNombre)
        grpDatos.Controls.Add(lblTelefono)
        grpDatos.Controls.Add(lblRuc)
        grpDatos.Controls.Add(lblNombre)
        grpDatos.Controls.Add(lblIdValor)
        grpDatos.Controls.Add(lblId)
        grpDatos.Location = New System.Drawing.Point(24, 55)
        grpDatos.Name = "grpDatos"
        grpDatos.Size = New System.Drawing.Size(272, 199)
        grpDatos.TabIndex = 1
        grpDatos.TabStop = False
        grpDatos.Text = " Datos del proveedor"
        ' 
        ' lblId
        ' 
        lblId.AutoSize = True
        lblId.Location = New System.Drawing.Point(22, 36)
        lblId.Name = "lblId"
        lblId.Size = New System.Drawing.Size(21, 15)
        lblId.TabIndex = 2
        lblId.Text = "ID:"
        ' 
        ' lblIdValor
        ' 
        lblIdValor.AutoSize = True
        lblIdValor.Location = New System.Drawing.Point(112, 36)
        lblIdValor.Name = "lblIdValor"
        lblIdValor.Size = New System.Drawing.Size(48, 15)
        lblIdValor.TabIndex = 3
        lblIdValor.Text = "(nuevo)"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New System.Drawing.Point(22, 69)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New System.Drawing.Size(54, 15)
        lblNombre.TabIndex = 4
        lblNombre.Text = "Nombre:"
        ' 
        ' lblRuc
        ' 
        lblRuc.AutoSize = True
        lblRuc.Location = New System.Drawing.Point(22, 102)
        lblRuc.Name = "lblRuc"
        lblRuc.Size = New System.Drawing.Size(36, 15)
        lblRuc.TabIndex = 5
        lblRuc.Text = " RUC:"
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Location = New System.Drawing.Point(17, 129)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New System.Drawing.Size(56, 15)
        lblTelefono.TabIndex = 6
        lblTelefono.Text = "Teléfono:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New System.Drawing.Point(91, 66)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New System.Drawing.Size(153, 23)
        txtNombre.TabIndex = 7
        ' 
        ' txtRuc
        ' 
        txtRuc.Location = New System.Drawing.Point(91, 95)
        txtRuc.Name = "txtRuc"
        txtRuc.Size = New System.Drawing.Size(153, 23)
        txtRuc.TabIndex = 8
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New System.Drawing.Point(91, 129)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New System.Drawing.Size(153, 23)
        txtTelefono.TabIndex = 9
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Location = New System.Drawing.Point(91, 158)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New System.Drawing.Size(153, 23)
        txtCorreo.TabIndex = 10
        ' 
        ' lblCorreo
        ' 
        lblCorreo.AutoSize = True
        lblCorreo.Location = New System.Drawing.Point(22, 166)
        lblCorreo.Name = "lblCorreo"
        lblCorreo.Size = New System.Drawing.Size(46, 15)
        lblCorreo.TabIndex = 11
        lblCorreo.Text = "Correo:"
        ' 
        ' grpAcciones
        ' 
        grpAcciones.Controls.Add(btnEliminar)
        grpAcciones.Controls.Add(btnActualizar)
        grpAcciones.Controls.Add(btnAgregar)
        grpAcciones.Controls.Add(btnNuevo)
        grpAcciones.Location = New System.Drawing.Point(24, 272)
        grpAcciones.Name = "grpAcciones"
        grpAcciones.Size = New System.Drawing.Size(272, 144)
        grpAcciones.TabIndex = 2
        grpAcciones.TabStop = False
        grpAcciones.Text = "Acciones"
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New System.Drawing.Point(28, 36)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New System.Drawing.Size(100, 30)
        btnNuevo.TabIndex = 0
        btnNuevo.Text = "Nuevo"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' btnAgregar
        ' 
        btnAgregar.Location = New System.Drawing.Point(144, 36)
        btnAgregar.Name = "btnAgregar"
        btnAgregar.Size = New System.Drawing.Size(100, 30)
        btnAgregar.TabIndex = 1
        btnAgregar.Text = "Agregar"
        btnAgregar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New System.Drawing.Point(28, 84)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New System.Drawing.Size(100, 30)
        btnActualizar.TabIndex = 2
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New System.Drawing.Point(144, 84)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New System.Drawing.Size(100, 30)
        btnEliminar.TabIndex = 3
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' lblBuscar
        ' 
        lblBuscar.AutoSize = True
        lblBuscar.Location = New System.Drawing.Point(331, 50)
        lblBuscar.Name = "lblBuscar"
        lblBuscar.Size = New System.Drawing.Size(102, 15)
        lblBuscar.TabIndex = 3
        lblBuscar.Text = "Buscar proveedor:"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New System.Drawing.Point(439, 47)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New System.Drawing.Size(439, 23)
        txtBuscar.TabIndex = 4
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New System.Drawing.Point(884, 44)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New System.Drawing.Size(93, 26)
        btnBuscar.TabIndex = 5
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' dgvProveedores
        ' 
        dgvProveedores.AllowUserToAddRows = False
        dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProveedores.Location = New System.Drawing.Point(333, 82)
        dgvProveedores.MultiSelect = False
        dgvProveedores.Name = "dgvProveedores"
        dgvProveedores.ReadOnly = True
        dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        dgvProveedores.Size = New System.Drawing.Size(642, 334)
        dgvProveedores.TabIndex = 6
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {lblEstado, lblTotal})
        StatusStrip1.Location = New System.Drawing.Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New System.Drawing.Size(996, 22)
        StatusStrip1.TabIndex = 7
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblEstado
        ' 
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New System.Drawing.Size(32, 17)
        lblEstado.Text = "Listo"
        ' 
        ' lblTotal
        ' 
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New System.Drawing.Size(89, 17)
        lblTotal.Text = "0 proveedor(es)"
        ' 
        ' errValidacion
        ' 
        errValidacion.ContainerControl = Me
        ' 
        ' FrmProveedores
        ' 
        AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(996, 450)
        Controls.Add(StatusStrip1)
        Controls.Add(dgvProveedores)
        Controls.Add(btnBuscar)
        Controls.Add(txtBuscar)
        Controls.Add(lblBuscar)
        Controls.Add(grpAcciones)
        Controls.Add(grpDatos)
        Controls.Add(lblTitulo)
        Name = "FrmProveedores"
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Text = "Gestión de Proveedores"
        grpDatos.ResumeLayout(False)
        grpDatos.PerformLayout()
        grpAcciones.ResumeLayout(False)
        CType(dgvProveedores, ComponentModel.ISupportInitialize).EndInit()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        CType(errValidacion, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents grpDatos As System.Windows.Forms.GroupBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents lblTelefono As System.Windows.Forms.Label
    Friend WithEvents lblRuc As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblIdValor As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtRuc As System.Windows.Forms.TextBox
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents grpAcciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents dgvProveedores As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblEstado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTotal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents errValidacion As System.Windows.Forms.ErrorProvider
    Friend WithEvents ttAyuda As System.Windows.Forms.ToolTip
End Class
