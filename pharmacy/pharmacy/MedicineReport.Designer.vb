<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicineReport
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
        Me.MeddoseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedqtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SideefctsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedtypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MedicinesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PharmaDataSet11 = New WindowsApplication1.pharmaDataSet11()
        Me.MedicinesTableAdapter = New WindowsApplication1.pharmaDataSet11TableAdapters.medicinesTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MedicinesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmaDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MedidDataGridViewTextBoxColumn, Me.MednameDataGridViewTextBoxColumn, Me.MeddoseDataGridViewTextBoxColumn, Me.MedpriceDataGridViewTextBoxColumn, Me.MedqtyDataGridViewTextBoxColumn, Me.SideefctsDataGridViewTextBoxColumn, Me.MedtypeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.MedicinesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(31, 51)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(775, 234)
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
        'MeddoseDataGridViewTextBoxColumn
        '
        Me.MeddoseDataGridViewTextBoxColumn.DataPropertyName = "med_dose"
        Me.MeddoseDataGridViewTextBoxColumn.HeaderText = "med_dose"
        Me.MeddoseDataGridViewTextBoxColumn.Name = "MeddoseDataGridViewTextBoxColumn"
        '
        'MedpriceDataGridViewTextBoxColumn
        '
        Me.MedpriceDataGridViewTextBoxColumn.DataPropertyName = "med_price"
        Me.MedpriceDataGridViewTextBoxColumn.HeaderText = "med_price"
        Me.MedpriceDataGridViewTextBoxColumn.Name = "MedpriceDataGridViewTextBoxColumn"
        '
        'MedqtyDataGridViewTextBoxColumn
        '
        Me.MedqtyDataGridViewTextBoxColumn.DataPropertyName = "med_qty"
        Me.MedqtyDataGridViewTextBoxColumn.HeaderText = "med_qty"
        Me.MedqtyDataGridViewTextBoxColumn.Name = "MedqtyDataGridViewTextBoxColumn"
        '
        'SideefctsDataGridViewTextBoxColumn
        '
        Me.SideefctsDataGridViewTextBoxColumn.DataPropertyName = "side_efcts"
        Me.SideefctsDataGridViewTextBoxColumn.HeaderText = "side_efcts"
        Me.SideefctsDataGridViewTextBoxColumn.Name = "SideefctsDataGridViewTextBoxColumn"
        '
        'MedtypeDataGridViewTextBoxColumn
        '
        Me.MedtypeDataGridViewTextBoxColumn.DataPropertyName = "med_type"
        Me.MedtypeDataGridViewTextBoxColumn.HeaderText = "med_type"
        Me.MedtypeDataGridViewTextBoxColumn.Name = "MedtypeDataGridViewTextBoxColumn"
        '
        'MedicinesBindingSource
        '
        Me.MedicinesBindingSource.DataMember = "medicines"
        Me.MedicinesBindingSource.DataSource = Me.PharmaDataSet11
        '
        'PharmaDataSet11
        '
        Me.PharmaDataSet11.DataSetName = "pharmaDataSet11"
        Me.PharmaDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MedicinesTableAdapter
        '
        Me.MedicinesTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(355, 340)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MedicineReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._1450186023_g_different_medicines_171626219
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(818, 494)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "MedicineReport"
        Me.Text = "MedicineReport"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MedicinesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmaDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PharmaDataSet11 As WindowsApplication1.pharmaDataSet11
    Friend WithEvents MedicinesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MedicinesTableAdapter As WindowsApplication1.pharmaDataSet11TableAdapters.medicinesTableAdapter
    Friend WithEvents MedidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MednameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MeddoseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedpriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedqtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SideefctsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MedtypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
