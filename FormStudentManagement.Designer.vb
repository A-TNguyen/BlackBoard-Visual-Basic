<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStudentManagement
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
        Dim Enroll_CountLabel As System.Windows.Forms.Label
        Dim StudentIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim Class1Label As System.Windows.Forms.Label
        Dim Class2Label As System.Windows.Forms.Label
        Dim Class3Label As System.Windows.Forms.Label
        Dim Class4Label As System.Windows.Forms.Label
        Dim Class1_MidtermLabel As System.Windows.Forms.Label
        Dim Class2_MidtermLabel As System.Windows.Forms.Label
        Dim Class3_MidtermLabel As System.Windows.Forms.Label
        Dim Class4_MidtermLabel As System.Windows.Forms.Label
        Dim Class1_FinalLabel As System.Windows.Forms.Label
        Dim Class2_FinalLabel As System.Windows.Forms.Label
        Dim Class3_FinalLabel As System.Windows.Forms.Label
        Dim Class4_FinalLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStudentManagement))
        Me.StudentDatabaseDataSet = New VBConnectAccessDb2.StudentDatabaseDataSet()
        Me.Student_DataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Student_DataTableAdapter = New VBConnectAccessDb2.StudentDatabaseDataSetTableAdapters.Student_DataTableAdapter()
        Me.TableAdapterManager = New VBConnectAccessDb2.StudentDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.Student_DataBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Student_DataBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Enroll_CountTextBox = New System.Windows.Forms.TextBox()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.Class1TextBox = New System.Windows.Forms.TextBox()
        Me.Class2TextBox = New System.Windows.Forms.TextBox()
        Me.Class3TextBox = New System.Windows.Forms.TextBox()
        Me.Class4TextBox = New System.Windows.Forms.TextBox()
        Me.Class1_MidtermTextBox = New System.Windows.Forms.TextBox()
        Me.Class2_MidtermTextBox = New System.Windows.Forms.TextBox()
        Me.Class3_MidtermTextBox = New System.Windows.Forms.TextBox()
        Me.Class4_MidtermTextBox = New System.Windows.Forms.TextBox()
        Me.Class1_FinalTextBox = New System.Windows.Forms.TextBox()
        Me.Class2_FinalTextBox = New System.Windows.Forms.TextBox()
        Me.Class3_FinalTextBox = New System.Windows.Forms.TextBox()
        Me.Class4_FinalTextBox = New System.Windows.Forms.TextBox()
        Me.Student_DataDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.AddNewButton = New System.Windows.Forms.Button()
        Enroll_CountLabel = New System.Windows.Forms.Label()
        StudentIDLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        Class1Label = New System.Windows.Forms.Label()
        Class2Label = New System.Windows.Forms.Label()
        Class3Label = New System.Windows.Forms.Label()
        Class4Label = New System.Windows.Forms.Label()
        Class1_MidtermLabel = New System.Windows.Forms.Label()
        Class2_MidtermLabel = New System.Windows.Forms.Label()
        Class3_MidtermLabel = New System.Windows.Forms.Label()
        Class4_MidtermLabel = New System.Windows.Forms.Label()
        Class1_FinalLabel = New System.Windows.Forms.Label()
        Class2_FinalLabel = New System.Windows.Forms.Label()
        Class3_FinalLabel = New System.Windows.Forms.Label()
        Class4_FinalLabel = New System.Windows.Forms.Label()
        CType(Me.StudentDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_DataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Student_DataBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Student_DataBindingNavigator.SuspendLayout()
        CType(Me.Student_DataDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Enroll_CountLabel
        '
        Enroll_CountLabel.AutoSize = True
        Enroll_CountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Enroll_CountLabel.Location = New System.Drawing.Point(24, 57)
        Enroll_CountLabel.Name = "Enroll_CountLabel"
        Enroll_CountLabel.Size = New System.Drawing.Size(80, 13)
        Enroll_CountLabel.TabIndex = 1
        Enroll_CountLabel.Text = "Enroll Count:"
        AddHandler Enroll_CountLabel.Click, AddressOf Me.Enroll_CountLabel_Click_1
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StudentIDLabel.Location = New System.Drawing.Point(24, 83)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(72, 13)
        StudentIDLabel.TabIndex = 3
        StudentIDLabel.Text = "Student ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstNameLabel.Location = New System.Drawing.Point(24, 109)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(71, 13)
        FirstNameLabel.TabIndex = 5
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.Location = New System.Drawing.Point(24, 135)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(71, 13)
        LastNameLabel.TabIndex = 7
        LastNameLabel.Text = "Last Name:"
        '
        'Class1Label
        '
        Class1Label.AutoSize = True
        Class1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Class1Label.Location = New System.Drawing.Point(24, 161)
        Class1Label.Name = "Class1Label"
        Class1Label.Size = New System.Drawing.Size(48, 13)
        Class1Label.TabIndex = 9
        Class1Label.Text = "Class1:"
        '
        'Class2Label
        '
        Class2Label.AutoSize = True
        Class2Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Class2Label.Location = New System.Drawing.Point(24, 187)
        Class2Label.Name = "Class2Label"
        Class2Label.Size = New System.Drawing.Size(48, 13)
        Class2Label.TabIndex = 11
        Class2Label.Text = "Class2:"
        '
        'Class3Label
        '
        Class3Label.AutoSize = True
        Class3Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Class3Label.Location = New System.Drawing.Point(24, 213)
        Class3Label.Name = "Class3Label"
        Class3Label.Size = New System.Drawing.Size(48, 13)
        Class3Label.TabIndex = 13
        Class3Label.Text = "Class3:"
        '
        'Class4Label
        '
        Class4Label.AutoSize = True
        Class4Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Class4Label.Location = New System.Drawing.Point(24, 241)
        Class4Label.Name = "Class4Label"
        Class4Label.Size = New System.Drawing.Size(48, 13)
        Class4Label.TabIndex = 15
        Class4Label.Text = "Class4:"
        '
        'Class1_MidtermLabel
        '
        Class1_MidtermLabel.AutoSize = True
        Class1_MidtermLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Class1_MidtermLabel.Location = New System.Drawing.Point(267, 60)
        Class1_MidtermLabel.Name = "Class1_MidtermLabel"
        Class1_MidtermLabel.Size = New System.Drawing.Size(96, 13)
        Class1_MidtermLabel.TabIndex = 17
        Class1_MidtermLabel.Text = "Class1 Midterm:"
        '
        'Class2_MidtermLabel
        '
        Class2_MidtermLabel.AutoSize = True
        Class2_MidtermLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Class2_MidtermLabel.Location = New System.Drawing.Point(267, 86)
        Class2_MidtermLabel.Name = "Class2_MidtermLabel"
        Class2_MidtermLabel.Size = New System.Drawing.Size(96, 13)
        Class2_MidtermLabel.TabIndex = 19
        Class2_MidtermLabel.Text = "Class2 Midterm:"
        '
        'Class3_MidtermLabel
        '
        Class3_MidtermLabel.AutoSize = True
        Class3_MidtermLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Class3_MidtermLabel.Location = New System.Drawing.Point(267, 112)
        Class3_MidtermLabel.Name = "Class3_MidtermLabel"
        Class3_MidtermLabel.Size = New System.Drawing.Size(96, 13)
        Class3_MidtermLabel.TabIndex = 21
        Class3_MidtermLabel.Text = "Class3 Midterm:"
        '
        'Class4_MidtermLabel
        '
        Class4_MidtermLabel.AutoSize = True
        Class4_MidtermLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Class4_MidtermLabel.Location = New System.Drawing.Point(267, 138)
        Class4_MidtermLabel.Name = "Class4_MidtermLabel"
        Class4_MidtermLabel.Size = New System.Drawing.Size(96, 13)
        Class4_MidtermLabel.TabIndex = 23
        Class4_MidtermLabel.Text = "Class4 Midterm:"
        '
        'Class1_FinalLabel
        '
        Class1_FinalLabel.AutoSize = True
        Class1_FinalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Class1_FinalLabel.Location = New System.Drawing.Point(267, 164)
        Class1_FinalLabel.Name = "Class1_FinalLabel"
        Class1_FinalLabel.Size = New System.Drawing.Size(79, 13)
        Class1_FinalLabel.TabIndex = 25
        Class1_FinalLabel.Text = "Class1 Final:"
        '
        'Class2_FinalLabel
        '
        Class2_FinalLabel.AutoSize = True
        Class2_FinalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Class2_FinalLabel.Location = New System.Drawing.Point(267, 190)
        Class2_FinalLabel.Name = "Class2_FinalLabel"
        Class2_FinalLabel.Size = New System.Drawing.Size(79, 13)
        Class2_FinalLabel.TabIndex = 27
        Class2_FinalLabel.Text = "Class2 Final:"
        '
        'Class3_FinalLabel
        '
        Class3_FinalLabel.AutoSize = True
        Class3_FinalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Class3_FinalLabel.Location = New System.Drawing.Point(267, 216)
        Class3_FinalLabel.Name = "Class3_FinalLabel"
        Class3_FinalLabel.Size = New System.Drawing.Size(79, 13)
        Class3_FinalLabel.TabIndex = 29
        Class3_FinalLabel.Text = "Class3 Final:"
        '
        'Class4_FinalLabel
        '
        Class4_FinalLabel.AutoSize = True
        Class4_FinalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Class4_FinalLabel.Location = New System.Drawing.Point(267, 242)
        Class4_FinalLabel.Name = "Class4_FinalLabel"
        Class4_FinalLabel.Size = New System.Drawing.Size(79, 13)
        Class4_FinalLabel.TabIndex = 31
        Class4_FinalLabel.Text = "Class4 Final:"
        '
        'StudentDatabaseDataSet
        '
        Me.StudentDatabaseDataSet.DataSetName = "StudentDatabaseDataSet"
        Me.StudentDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Student_DataBindingSource
        '
        Me.Student_DataBindingSource.DataMember = "Student_Data"
        Me.Student_DataBindingSource.DataSource = Me.StudentDatabaseDataSet
        '
        'Student_DataTableAdapter
        '
        Me.Student_DataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Student_DataTableAdapter = Me.Student_DataTableAdapter
        Me.TableAdapterManager.UpdateOrder = VBConnectAccessDb2.StudentDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Student_DataBindingNavigator
        '
        Me.Student_DataBindingNavigator.AddNewItem = Nothing
        Me.Student_DataBindingNavigator.BindingSource = Me.Student_DataBindingSource
        Me.Student_DataBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Student_DataBindingNavigator.DeleteItem = Nothing
        Me.Student_DataBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Student_DataBindingNavigatorSaveItem})
        Me.Student_DataBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Student_DataBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Student_DataBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Student_DataBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Student_DataBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Student_DataBindingNavigator.Name = "Student_DataBindingNavigator"
        Me.Student_DataBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Student_DataBindingNavigator.Size = New System.Drawing.Size(844, 25)
        Me.Student_DataBindingNavigator.TabIndex = 0
        Me.Student_DataBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'Student_DataBindingNavigatorSaveItem
        '
        Me.Student_DataBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Student_DataBindingNavigatorSaveItem.Image = CType(resources.GetObject("Student_DataBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Student_DataBindingNavigatorSaveItem.Name = "Student_DataBindingNavigatorSaveItem"
        Me.Student_DataBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Student_DataBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Enroll_CountTextBox
        '
        Me.Enroll_CountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Enroll_Count", True))
        Me.Enroll_CountTextBox.Location = New System.Drawing.Point(111, 54)
        Me.Enroll_CountTextBox.Name = "Enroll_CountTextBox"
        Me.Enroll_CountTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Enroll_CountTextBox.TabIndex = 2
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "StudentID", True))
        Me.StudentIDTextBox.Location = New System.Drawing.Point(111, 80)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentIDTextBox.TabIndex = 4
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(111, 106)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 6
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(111, 132)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 8
        '
        'Class1TextBox
        '
        Me.Class1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Class1", True))
        Me.Class1TextBox.Location = New System.Drawing.Point(111, 158)
        Me.Class1TextBox.Name = "Class1TextBox"
        Me.Class1TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Class1TextBox.TabIndex = 10
        '
        'Class2TextBox
        '
        Me.Class2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Class2", True))
        Me.Class2TextBox.Location = New System.Drawing.Point(111, 184)
        Me.Class2TextBox.Name = "Class2TextBox"
        Me.Class2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Class2TextBox.TabIndex = 12
        '
        'Class3TextBox
        '
        Me.Class3TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Class3", True))
        Me.Class3TextBox.Location = New System.Drawing.Point(111, 210)
        Me.Class3TextBox.Name = "Class3TextBox"
        Me.Class3TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Class3TextBox.TabIndex = 14
        '
        'Class4TextBox
        '
        Me.Class4TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Class4", True))
        Me.Class4TextBox.Location = New System.Drawing.Point(111, 238)
        Me.Class4TextBox.Name = "Class4TextBox"
        Me.Class4TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Class4TextBox.TabIndex = 16
        '
        'Class1_MidtermTextBox
        '
        Me.Class1_MidtermTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Class1 Midterm", True))
        Me.Class1_MidtermTextBox.Location = New System.Drawing.Point(110, 19)
        Me.Class1_MidtermTextBox.Name = "Class1_MidtermTextBox"
        Me.Class1_MidtermTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Class1_MidtermTextBox.TabIndex = 18
        '
        'Class2_MidtermTextBox
        '
        Me.Class2_MidtermTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Class2 Midterm", True))
        Me.Class2_MidtermTextBox.Location = New System.Drawing.Point(110, 45)
        Me.Class2_MidtermTextBox.Name = "Class2_MidtermTextBox"
        Me.Class2_MidtermTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Class2_MidtermTextBox.TabIndex = 20
        '
        'Class3_MidtermTextBox
        '
        Me.Class3_MidtermTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Class3 Midterm", True))
        Me.Class3_MidtermTextBox.Location = New System.Drawing.Point(110, 71)
        Me.Class3_MidtermTextBox.Name = "Class3_MidtermTextBox"
        Me.Class3_MidtermTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Class3_MidtermTextBox.TabIndex = 22
        '
        'Class4_MidtermTextBox
        '
        Me.Class4_MidtermTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Class4 Midterm", True))
        Me.Class4_MidtermTextBox.Location = New System.Drawing.Point(110, 97)
        Me.Class4_MidtermTextBox.Name = "Class4_MidtermTextBox"
        Me.Class4_MidtermTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Class4_MidtermTextBox.TabIndex = 24
        '
        'Class1_FinalTextBox
        '
        Me.Class1_FinalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Class1 Final", True))
        Me.Class1_FinalTextBox.Location = New System.Drawing.Point(110, 123)
        Me.Class1_FinalTextBox.Name = "Class1_FinalTextBox"
        Me.Class1_FinalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Class1_FinalTextBox.TabIndex = 26
        '
        'Class2_FinalTextBox
        '
        Me.Class2_FinalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Class2 Final", True))
        Me.Class2_FinalTextBox.Location = New System.Drawing.Point(110, 149)
        Me.Class2_FinalTextBox.Name = "Class2_FinalTextBox"
        Me.Class2_FinalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Class2_FinalTextBox.TabIndex = 28
        '
        'Class3_FinalTextBox
        '
        Me.Class3_FinalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Class3 Final", True))
        Me.Class3_FinalTextBox.Location = New System.Drawing.Point(110, 175)
        Me.Class3_FinalTextBox.Name = "Class3_FinalTextBox"
        Me.Class3_FinalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Class3_FinalTextBox.TabIndex = 30
        '
        'Class4_FinalTextBox
        '
        Me.Class4_FinalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Student_DataBindingSource, "Class4 Final", True))
        Me.Class4_FinalTextBox.Location = New System.Drawing.Point(110, 204)
        Me.Class4_FinalTextBox.Name = "Class4_FinalTextBox"
        Me.Class4_FinalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Class4_FinalTextBox.TabIndex = 32
        '
        'Student_DataDataGridView
        '
        Me.Student_DataDataGridView.AutoGenerateColumns = False
        Me.Student_DataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Student_DataDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.Student_DataDataGridView.DataSource = Me.Student_DataBindingSource
        Me.Student_DataDataGridView.Location = New System.Drawing.Point(12, 281)
        Me.Student_DataDataGridView.Name = "Student_DataDataGridView"
        Me.Student_DataDataGridView.Size = New System.Drawing.Size(823, 220)
        Me.Student_DataDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Enroll_Count"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Enroll_Count"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StudentID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StudentID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Class1"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Class1"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Class2"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Class2"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Class3"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Class3"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Class4"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Class4"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Class1 Midterm"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Class1 Midterm"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Class2 Midterm"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Class2 Midterm"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Class3 Midterm"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Class3 Midterm"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Class4 Midterm"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Class4 Midterm"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Class1 Final"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Class1 Final"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Class2 Final"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Class2 Final"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Class3 Final"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Class3 Final"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Class4 Final"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Class4 Final"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 237)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student Info:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Class1_MidtermTextBox)
        Me.GroupBox2.Controls.Add(Me.Class2_MidtermTextBox)
        Me.GroupBox2.Controls.Add(Me.Class3_MidtermTextBox)
        Me.GroupBox2.Controls.Add(Me.Class4_MidtermTextBox)
        Me.GroupBox2.Controls.Add(Me.Class1_FinalTextBox)
        Me.GroupBox2.Controls.Add(Me.Class2_FinalTextBox)
        Me.GroupBox2.Controls.Add(Me.Class3_FinalTextBox)
        Me.GroupBox2.Controls.Add(Me.Class4_FinalTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(259, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 237)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Grades:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ExitButton)
        Me.GroupBox3.Controls.Add(Me.DeleteButton)
        Me.GroupBox3.Controls.Add(Me.SaveButton)
        Me.GroupBox3.Controls.Add(Me.AddNewButton)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(507, 38)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 237)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Options"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(25, 157)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(194, 38)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Log out"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(25, 113)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(194, 38)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.Text = "Delete Student Data"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(25, 68)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(194, 38)
        Me.SaveButton.TabIndex = 1
        Me.SaveButton.Text = "Save Student Data"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'AddNewButton
        '
        Me.AddNewButton.Location = New System.Drawing.Point(25, 22)
        Me.AddNewButton.Name = "AddNewButton"
        Me.AddNewButton.Size = New System.Drawing.Size(194, 38)
        Me.AddNewButton.TabIndex = 0
        Me.AddNewButton.Text = "Add New Student"
        Me.AddNewButton.UseVisualStyleBackColor = True
        '
        'FormStudentManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Desktop
        Me.ClientSize = New System.Drawing.Size(844, 605)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Student_DataDataGridView)
        Me.Controls.Add(Enroll_CountLabel)
        Me.Controls.Add(Me.Enroll_CountTextBox)
        Me.Controls.Add(StudentIDLabel)
        Me.Controls.Add(Me.StudentIDTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Class1Label)
        Me.Controls.Add(Me.Class1TextBox)
        Me.Controls.Add(Class2Label)
        Me.Controls.Add(Me.Class2TextBox)
        Me.Controls.Add(Class3Label)
        Me.Controls.Add(Me.Class3TextBox)
        Me.Controls.Add(Class4Label)
        Me.Controls.Add(Me.Class4TextBox)
        Me.Controls.Add(Class1_MidtermLabel)
        Me.Controls.Add(Class2_MidtermLabel)
        Me.Controls.Add(Class3_MidtermLabel)
        Me.Controls.Add(Class4_MidtermLabel)
        Me.Controls.Add(Class1_FinalLabel)
        Me.Controls.Add(Class2_FinalLabel)
        Me.Controls.Add(Class3_FinalLabel)
        Me.Controls.Add(Class4_FinalLabel)
        Me.Controls.Add(Me.Student_DataBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FormStudentManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Management"
        CType(Me.StudentDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_DataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Student_DataBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Student_DataBindingNavigator.ResumeLayout(False)
        Me.Student_DataBindingNavigator.PerformLayout()
        CType(Me.Student_DataDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentDatabaseDataSet As StudentDatabaseDataSet
    Friend WithEvents Student_DataBindingSource As BindingSource
    Friend WithEvents Student_DataTableAdapter As StudentDatabaseDataSetTableAdapters.Student_DataTableAdapter
    Friend WithEvents TableAdapterManager As StudentDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Student_DataBindingNavigator As BindingNavigator
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
    Friend WithEvents Student_DataBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Enroll_CountTextBox As TextBox
    Friend WithEvents StudentIDTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents Class1TextBox As TextBox
    Friend WithEvents Class2TextBox As TextBox
    Friend WithEvents Class3TextBox As TextBox
    Friend WithEvents Class4TextBox As TextBox
    Friend WithEvents Class1_MidtermTextBox As TextBox
    Friend WithEvents Class2_MidtermTextBox As TextBox
    Friend WithEvents Class3_MidtermTextBox As TextBox
    Friend WithEvents Class4_MidtermTextBox As TextBox
    Friend WithEvents Class1_FinalTextBox As TextBox
    Friend WithEvents Class2_FinalTextBox As TextBox
    Friend WithEvents Class3_FinalTextBox As TextBox
    Friend WithEvents Class4_FinalTextBox As TextBox
    Friend WithEvents Student_DataDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents AddNewButton As Button
End Class
