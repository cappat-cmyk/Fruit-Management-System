<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RG_ProductReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RG_ProductReport))
        Me.ProductDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FMSDataSet = New FruitManagemenrtSystem2.FMSDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ProductDetailsTableAdapter = New FruitManagemenrtSystem2.FMSDataSetTableAdapters.ProductDetailsTableAdapter()
        CType(Me.ProductDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductDetailsBindingSource
        '
        Me.ProductDetailsBindingSource.DataMember = "ProductDetails"
        Me.ProductDetailsBindingSource.DataSource = Me.FMSDataSet
        '
        'FMSDataSet
        '
        Me.FMSDataSet.DataSetName = "FMSDataSet"
        Me.FMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ProductDetailsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "FruitManagemenrtSystem2.ProductReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(895, 564)
        Me.ReportViewer1.TabIndex = 65
        '
        'ProductDetailsTableAdapter
        '
        Me.ProductDetailsTableAdapter.ClearBeforeFill = True
        '
        'RG_ProductReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(895, 564)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RG_ProductReport"
        Me.Text = "Product Report"
        CType(Me.ProductDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProductDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FMSDataSet As FruitManagemenrtSystem2.FMSDataSet
    Friend WithEvents ProductDetailsTableAdapter As FruitManagemenrtSystem2.FMSDataSetTableAdapters.ProductDetailsTableAdapter
End Class
