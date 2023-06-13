<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RG_StockReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RG_StockReport))
        Me.RestockingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FMSDataSet1 = New FruitManagemenrtSystem2.FMSDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.RestockingTableAdapter = New FruitManagemenrtSystem2.FMSDataSet1TableAdapters.RestockingTableAdapter()
        CType(Me.RestockingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FMSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RestockingBindingSource
        '
        Me.RestockingBindingSource.DataMember = "Restocking"
        Me.RestockingBindingSource.DataSource = Me.FMSDataSet1
        '
        'FMSDataSet1
        '
        Me.FMSDataSet1.DataSetName = "FMSDataSet1"
        Me.FMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.RestockingBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "FruitManagemenrtSystem2.StockReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(902, 576)
        Me.ReportViewer1.TabIndex = 0
        '
        'RestockingTableAdapter
        '
        Me.RestockingTableAdapter.ClearBeforeFill = True
        '
        'RG_StockReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 576)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RG_StockReport"
        Me.Text = "Stock Report"
        CType(Me.RestockingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FMSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents RestockingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FMSDataSet1 As FruitManagemenrtSystem2.FMSDataSet1
    Friend WithEvents RestockingTableAdapter As FruitManagemenrtSystem2.FMSDataSet1TableAdapters.RestockingTableAdapter
End Class
