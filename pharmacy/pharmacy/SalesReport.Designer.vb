<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BillidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PetientnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MeddoseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MednameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtofsaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmaDataSet9 = New WindowsApplication1.pharmaDataSet9()
        Me.SalesTableAdapter = New WindowsApplication1.pharmaDataSet9TableAdapters.salesTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmaDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.BillidDataGridViewTextBoxColumn, Me.PetientnameDataGridViewTextBoxColumn, Me.MeddoseDataGridViewTextBoxColumn, Me.MednameDataGridViewTextBoxColumn, Me.DtofsaleDataGridViewTextBoxColumn, Me.MedpriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SalesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 48)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(644, 232)
        Me.DataGridView1.TabIndex = 0
        '
        'BillidDataGridViewTextBoxColumn
        '
        Me.BillidDataGridViewTextBoxColumn.DataPropertyName = "bill_id"
        Me.BillidDataGridViewTextBoxColumn.HeaderText = "bill_id"
        Me.BillidDataGridViewTextBoxColumn.Name = "BillidDataGridViewTextBoxColumn"
        '
        'PetientnameDataGridViewTextBoxColumn
        '
        Me.PetientnameDataGridViewTextBoxColumn.DataPropertyName = "petient_name"
        Me.PetientnameDataGridViewTextBoxColumn.HeaderText = "petient_name"
        Me.PetientnameDataGridViewTextBoxColumn.Name = "PetientnameDataGridViewTextBoxColumn"
        '
        'MeddoseDataGridViewTextBoxColumn
        '
        Me.MeddoseDataGridViewTextBoxColumn.DataPropertyName = "med_dose"
        Me.MeddoseDataGridViewTextBoxColumn.HeaderText = "med_dose"
        Me.MeddoseDataGridViewTextBoxColumn.Name = "MeddoseDataGridViewTextBoxColumn"
        '
        'MednameDataGridViewTextBoxColumn
        '
        Me.MednameDataGridViewTextBoxColumn.DataPropertyName = "med_name"
        Me.MednameDataGridViewTextBoxColumn.HeaderText = "med_name"
        Me.MednameDataGridViewTextBoxColumn.Name = "MednameDataGridViewTextBoxColumn"
        '
        'DtofsaleDataGridViewTextBoxColumn
        '
        Me.DtofsaleDataGridViewTextBoxColumn.DataPropertyName = "dt_of_sale"
        Me.DtofsaleDataGridViewTextBoxColumn.HeaderText = "dt_of_sale"
        Me.DtofsaleDataGridViewTextBoxColumn.Name = "DtofsaleDataGridViewTextBoxColumn"
        '
        'MedpriceDataGridViewTextBoxColumn
        '
        Me.MedpriceDataGridViewTextBoxColumn.DataPropertyName = "med_price"
        Me.MedpriceDataGridViewTextBoxColumn.HeaderText = "med_price"
        Me.MedpriceDataGridViewTextBoxColumn.Name = "MedpriceDataGridViewTextBoxColumn"
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "sales"
        Me.SalesBindingSource.DataSource = Me.PharmaDataSet9
        '
        'PharmaDataSet9
        '
        Me.PharmaDataSet9.DataSetName = "pharmaDataSet9"
        Me.PharmaDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(293, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._1450186023_g_different_medicines_171626219
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(668, 452)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "SalesReport"
        Me.Text = "SalesReport"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmaDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PharmaDataSet9 As WindowsApplication1.pharmaDataSet9
    Friend WithEvents SalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SalesTableAdapter As WindowsApplication1.pharmaDataSet9TableAdapters.salesTableAdapter
    Friend WithEvents BillidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PetientnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MeddoseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MednameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtofsaleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
