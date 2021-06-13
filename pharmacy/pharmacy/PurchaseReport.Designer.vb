<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseReport
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
        Me.MedidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MednameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmpnyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtofprchseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotamtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmaDataSet10 = New WindowsApplication1.pharmaDataSet10()
        Me.PurchaseTableAdapter = New WindowsApplication1.pharmaDataSet10TableAdapters.purchaseTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmaDataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedidDataGridViewTextBoxColumn, Me.MednameDataGridViewTextBoxColumn, Me.MedqtyDataGridViewTextBoxColumn, Me.CmpnyDataGridViewTextBoxColumn, Me.DtofprchseDataGridViewTextBoxColumn, Me.TotamtDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PurchaseBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(42, 47)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(648, 241)
        Me.DataGridView1.TabIndex = 0
        '
        'MedidDataGridViewTextBoxColumn
        '
        Me.MedidDataGridViewTextBoxColumn.DataPropertyName = "med_id"
        Me.MedidDataGridViewTextBoxColumn.HeaderText = "med_id"
        Me.MedidDataGridViewTextBoxColumn.Name = "MedidDataGridViewTextBoxColumn"
        '
        'MednameDataGridViewTextBoxColumn
        '
        Me.MednameDataGridViewTextBoxColumn.DataPropertyName = "med_name"
        Me.MednameDataGridViewTextBoxColumn.HeaderText = "med_name"
        Me.MednameDataGridViewTextBoxColumn.Name = "MednameDataGridViewTextBoxColumn"
        '
        'MedqtyDataGridViewTextBoxColumn
        '
        Me.MedqtyDataGridViewTextBoxColumn.DataPropertyName = "med_qty"
        Me.MedqtyDataGridViewTextBoxColumn.HeaderText = "med_qty"
        Me.MedqtyDataGridViewTextBoxColumn.Name = "MedqtyDataGridViewTextBoxColumn"
        '
        'CmpnyDataGridViewTextBoxColumn
        '
        Me.CmpnyDataGridViewTextBoxColumn.DataPropertyName = "cmpny"
        Me.CmpnyDataGridViewTextBoxColumn.HeaderText = "cmpny"
        Me.CmpnyDataGridViewTextBoxColumn.Name = "CmpnyDataGridViewTextBoxColumn"
        '
        'DtofprchseDataGridViewTextBoxColumn
        '
        Me.DtofprchseDataGridViewTextBoxColumn.DataPropertyName = "dt_of_prchse"
        Me.DtofprchseDataGridViewTextBoxColumn.HeaderText = "dt_of_prchse"
        Me.DtofprchseDataGridViewTextBoxColumn.Name = "DtofprchseDataGridViewTextBoxColumn"
        '
        'TotamtDataGridViewTextBoxColumn
        '
        Me.TotamtDataGridViewTextBoxColumn.DataPropertyName = "tot_amt"
        Me.TotamtDataGridViewTextBoxColumn.HeaderText = "tot_amt"
        Me.TotamtDataGridViewTextBoxColumn.Name = "TotamtDataGridViewTextBoxColumn"
        '
        'PurchaseBindingSource
        '
        Me.PurchaseBindingSource.DataMember = "purchase"
        Me.PurchaseBindingSource.DataSource = Me.PharmaDataSet10
        '
        'PharmaDataSet10
        '
        Me.PharmaDataSet10.DataSetName = "pharmaDataSet10"
        Me.PharmaDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurchaseTableAdapter
        '
        Me.PurchaseTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(318, 327)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PurchaseReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._1450186023_g_different_medicines_171626219
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(799, 475)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "PurchaseReport"
        Me.Text = "PurchaseReport"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmaDataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PharmaDataSet10 As WindowsApplication1.pharmaDataSet10
    Friend WithEvents PurchaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurchaseTableAdapter As WindowsApplication1.pharmaDataSet10TableAdapters.purchaseTableAdapter
    Friend WithEvents MedidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MednameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedqtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CmpnyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtofprchseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotamtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
