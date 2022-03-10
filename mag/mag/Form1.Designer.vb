<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CodArtLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim TituloArtLabel As System.Windows.Forms.Label
        Dim Nome_AutorLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim MesAnoRevLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Me.DBFinalDataSet = New revistas.DBFinalDataSet()
        Me.ListaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListaTableAdapter = New revistas.DBFinalDataSetTableAdapters.ListaTableAdapter()
        Me.TableAdapterManager = New revistas.DBFinalDataSetTableAdapters.TableAdapterManager()
        Me.ListaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CodArtTextBox = New System.Windows.Forms.TextBox()
        Me.TituloArtTextBox = New System.Windows.Forms.TextBox()
        Me.Nome_AutorTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.MesAnoRevTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CodArtLabel = New System.Windows.Forms.Label()
        TituloArtLabel = New System.Windows.Forms.Label()
        Nome_AutorLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        MesAnoRevLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CType(Me.DBFinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListaBindingNavigator.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodArtLabel
        '
        CodArtLabel.AutoSize = True
        CodArtLabel.BackColor = System.Drawing.Color.White
        CodArtLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        CodArtLabel.ForeColor = System.Drawing.Color.MidnightBlue
        CodArtLabel.Image = CType(resources.GetObject("CodArtLabel.Image"), System.Drawing.Image)
        CodArtLabel.Location = New System.Drawing.Point(486, 204)
        CodArtLabel.Name = "CodArtLabel"
        CodArtLabel.Size = New System.Drawing.Size(65, 19)
        CodArtLabel.TabIndex = 1
        CodArtLabel.Text = "Cod Art:"
        AddHandler CodArtLabel.Click, AddressOf Me.CodArtLabel_Click
        '
        'TituloArtLabel
        '
        TituloArtLabel.AutoSize = True
        TituloArtLabel.BackColor = System.Drawing.Color.White
        TituloArtLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        TituloArtLabel.ForeColor = System.Drawing.Color.MidnightBlue
        TituloArtLabel.Image = CType(resources.GetObject("TituloArtLabel.Image"), System.Drawing.Image)
        TituloArtLabel.Location = New System.Drawing.Point(485, 254)
        TituloArtLabel.Name = "TituloArtLabel"
        TituloArtLabel.Size = New System.Drawing.Size(76, 19)
        TituloArtLabel.TabIndex = 3
        TituloArtLabel.Text = "Titulo Art:"
        AddHandler TituloArtLabel.Click, AddressOf Me.TituloArtLabel_Click
        '
        'Nome_AutorLabel
        '
        Nome_AutorLabel.AutoSize = True
        Nome_AutorLabel.BackColor = System.Drawing.Color.White
        Nome_AutorLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Nome_AutorLabel.ForeColor = System.Drawing.Color.MidnightBlue
        Nome_AutorLabel.Image = CType(resources.GetObject("Nome_AutorLabel.Image"), System.Drawing.Image)
        Nome_AutorLabel.Location = New System.Drawing.Point(485, 305)
        Nome_AutorLabel.Name = "Nome_AutorLabel"
        Nome_AutorLabel.Size = New System.Drawing.Size(97, 19)
        Nome_AutorLabel.TabIndex = 5
        Nome_AutorLabel.Text = "Nome Autor:"
        AddHandler Nome_AutorLabel.Click, AddressOf Me.Nome_AutorLabel_Click
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.BackColor = System.Drawing.Color.White
        TipoLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        TipoLabel.ForeColor = System.Drawing.Color.MidnightBlue
        TipoLabel.Image = CType(resources.GetObject("TipoLabel.Image"), System.Drawing.Image)
        TipoLabel.Location = New System.Drawing.Point(486, 358)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(43, 19)
        TipoLabel.TabIndex = 7
        TipoLabel.Text = "Tipo:"
        AddHandler TipoLabel.Click, AddressOf Me.TipoLabel_Click
        '
        'MesAnoRevLabel
        '
        MesAnoRevLabel.AutoSize = True
        MesAnoRevLabel.BackColor = System.Drawing.Color.White
        MesAnoRevLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        MesAnoRevLabel.ForeColor = System.Drawing.Color.MidnightBlue
        MesAnoRevLabel.Image = CType(resources.GetObject("MesAnoRevLabel.Image"), System.Drawing.Image)
        MesAnoRevLabel.Location = New System.Drawing.Point(485, 410)
        MesAnoRevLabel.Name = "MesAnoRevLabel"
        MesAnoRevLabel.Size = New System.Drawing.Size(100, 19)
        MesAnoRevLabel.TabIndex = 9
        MesAnoRevLabel.Text = "Mes Ano Rev:"
        AddHandler MesAnoRevLabel.Click, AddressOf Me.MesAnoRevLabel_Click
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.BackColor = System.Drawing.Color.White
        NomeLabel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        NomeLabel.ForeColor = System.Drawing.Color.MidnightBlue
        NomeLabel.Image = CType(resources.GetObject("NomeLabel.Image"), System.Drawing.Image)
        NomeLabel.Location = New System.Drawing.Point(486, 467)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(54, 19)
        NomeLabel.TabIndex = 11
        NomeLabel.Text = "Nome:"
        AddHandler NomeLabel.Click, AddressOf Me.NomeLabel_Click
        '
        'DBFinalDataSet
        '
        Me.DBFinalDataSet.DataSetName = "DBFinalDataSet"
        Me.DBFinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListaBindingSource
        '
        Me.ListaBindingSource.DataMember = "Lista"
        Me.ListaBindingSource.DataSource = Me.DBFinalDataSet
        '
        'ListaTableAdapter
        '
        Me.ListaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ListaTableAdapter = Me.ListaTableAdapter
        Me.TableAdapterManager.UpdateOrder = revistas.DBFinalDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ListaBindingNavigator
        '
        Me.ListaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ListaBindingNavigator.BindingSource = Me.ListaBindingSource
        Me.ListaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ListaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ListaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ListaBindingNavigatorSaveItem})
        Me.ListaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ListaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ListaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ListaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ListaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ListaBindingNavigator.Name = "ListaBindingNavigator"
        Me.ListaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ListaBindingNavigator.Size = New System.Drawing.Size(861, 25)
        Me.ListaBindingNavigator.TabIndex = 0
        Me.ListaBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ListaBindingNavigatorSaveItem
        '
        Me.ListaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ListaBindingNavigatorSaveItem.Image = CType(resources.GetObject("ListaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ListaBindingNavigatorSaveItem.Name = "ListaBindingNavigatorSaveItem"
        Me.ListaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ListaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CodArtTextBox
        '
        Me.CodArtTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.CodArtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaBindingSource, "CodArt", True))
        Me.CodArtTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodArtTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.CodArtTextBox.Location = New System.Drawing.Point(596, 204)
        Me.CodArtTextBox.Name = "CodArtTextBox"
        Me.CodArtTextBox.Size = New System.Drawing.Size(191, 23)
        Me.CodArtTextBox.TabIndex = 2
        '
        'TituloArtTextBox
        '
        Me.TituloArtTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TituloArtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaBindingSource, "TituloArt", True))
        Me.TituloArtTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloArtTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TituloArtTextBox.Location = New System.Drawing.Point(596, 254)
        Me.TituloArtTextBox.Name = "TituloArtTextBox"
        Me.TituloArtTextBox.Size = New System.Drawing.Size(191, 23)
        Me.TituloArtTextBox.TabIndex = 4
        '
        'Nome_AutorTextBox
        '
        Me.Nome_AutorTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Nome_AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaBindingSource, "Nome_Autor", True))
        Me.Nome_AutorTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nome_AutorTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Nome_AutorTextBox.Location = New System.Drawing.Point(598, 305)
        Me.Nome_AutorTextBox.Name = "Nome_AutorTextBox"
        Me.Nome_AutorTextBox.Size = New System.Drawing.Size(189, 23)
        Me.Nome_AutorTextBox.TabIndex = 6
        '
        'TipoTextBox
        '
        Me.TipoTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaBindingSource, "Tipo", True))
        Me.TipoTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.TipoTextBox.Location = New System.Drawing.Point(598, 358)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(189, 23)
        Me.TipoTextBox.TabIndex = 8
        '
        'MesAnoRevTextBox
        '
        Me.MesAnoRevTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.MesAnoRevTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaBindingSource, "MesAnoRev", True))
        Me.MesAnoRevTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MesAnoRevTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.MesAnoRevTextBox.Location = New System.Drawing.Point(598, 410)
        Me.MesAnoRevTextBox.Name = "MesAnoRevTextBox"
        Me.MesAnoRevTextBox.Size = New System.Drawing.Size(189, 23)
        Me.MesAnoRevTextBox.TabIndex = 10
        '
        'NomeTextBox
        '
        Me.NomeTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ListaBindingSource, "Nome", True))
        Me.NomeTextBox.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.ForeColor = System.Drawing.Color.MidnightBlue
        Me.NomeTextBox.Location = New System.Drawing.Point(596, 464)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(189, 23)
        Me.NomeTextBox.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Image = Global.revistas.My.Resources.Resources.ESRS1
        Me.Label2.Location = New System.Drawing.Point(485, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Serviço de Alojamento de Revistas "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Image = Global.revistas.My.Resources.Resources.ESRS1
        Me.Label1.Location = New System.Drawing.Point(484, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 32)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Repositório de Revistas"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.revistas.My.Resources.Resources.books1
        Me.PictureBox2.Location = New System.Drawing.Point(-373, 91)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(195, 202)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.revistas.My.Resources.Resources.NOVO
        Me.PictureBox1.Location = New System.Drawing.Point(-25, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(903, 575)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Image = Global.revistas.My.Resources.Resources.ESRS1
        Me.Button1.Location = New System.Drawing.Point(48, 75)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 39)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "✖"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(861, 547)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(MesAnoRevLabel)
        Me.Controls.Add(Me.MesAnoRevTextBox)
        Me.Controls.Add(TipoLabel)
        Me.Controls.Add(Me.TipoTextBox)
        Me.Controls.Add(Nome_AutorLabel)
        Me.Controls.Add(Me.Nome_AutorTextBox)
        Me.Controls.Add(TituloArtLabel)
        Me.Controls.Add(Me.TituloArtTextBox)
        Me.Controls.Add(CodArtLabel)
        Me.Controls.Add(Me.CodArtTextBox)
        Me.Controls.Add(Me.ListaBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DBFinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListaBindingNavigator.ResumeLayout(False)
        Me.ListaBindingNavigator.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBFinalDataSet As DBFinalDataSet
    Friend WithEvents ListaBindingSource As BindingSource
    Friend WithEvents ListaTableAdapter As DBFinalDataSetTableAdapters.ListaTableAdapter
    Friend WithEvents TableAdapterManager As DBFinalDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ListaBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ListaBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents CodArtTextBox As TextBox
    Friend WithEvents TituloArtTextBox As TextBox
    Friend WithEvents Nome_AutorTextBox As TextBox
    Friend WithEvents TipoTextBox As TextBox
    Friend WithEvents MesAnoRevTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
