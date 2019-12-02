namespace WinFormDBProject
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelConnectionState = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lTable = new System.Windows.Forms.Label();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lPrice1_1 = new System.Windows.Forms.Label();
            this.lPrice1_2 = new System.Windows.Forms.Label();
            this.lID1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPublisher1 = new System.Windows.Forms.ComboBox();
            this.tbPrice1 = new System.Windows.Forms.TextBox();
            this.tbID1 = new System.Windows.Forms.TextBox();
            this.lName1 = new System.Windows.Forms.Label();
            this.tbPriceMax1 = new System.Windows.Forms.TextBox();
            this.tbName1 = new System.Windows.Forms.TextBox();
            this.lPublisher1 = new System.Windows.Forms.Label();
            this.tbPriceMin1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lPhone2 = new System.Windows.Forms.Label();
            this.lID2 = new System.Windows.Forms.Label();
            this.cbAddress2 = new System.Windows.Forms.ComboBox();
            this.tbID2 = new System.Windows.Forms.TextBox();
            this.lName2 = new System.Windows.Forms.Label();
            this.tbName2 = new System.Windows.Forms.TextBox();
            this.lAddress2 = new System.Windows.Forms.Label();
            this.tbPhone2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lSalePrice3_1 = new System.Windows.Forms.Label();
            this.lOrderDate3_2 = new System.Windows.Forms.Label();
            this.lSalePrice3_2 = new System.Windows.Forms.Label();
            this.lBookID3 = new System.Windows.Forms.Label();
            this.cbOrderDate3 = new System.Windows.Forms.ComboBox();
            this.lCustID3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbSalePrice3 = new System.Windows.Forms.TextBox();
            this.tbBookID3 = new System.Windows.Forms.TextBox();
            this.tbCustID3 = new System.Windows.Forms.TextBox();
            this.tbOrderID3 = new System.Windows.Forms.TextBox();
            this.tbSalePriceMax3 = new System.Windows.Forms.TextBox();
            this.tbSalePriceMin3 = new System.Windows.Forms.TextBox();
            this.lOrderID3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(921, 662);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // labelConnectionState
            // 
            this.labelConnectionState.Location = new System.Drawing.Point(87, 107);
            this.labelConnectionState.Name = "labelConnectionState";
            this.labelConnectionState.Size = new System.Drawing.Size(100, 21);
            this.labelConnectionState.TabIndex = 1;
            this.labelConnectionState.Text = "DB 연결 상태";
            this.labelConnectionState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(949, 336);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(133, 31);
            this.btnSelect.TabIndex = 40;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1091, 336);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(133, 31);
            this.btnInsert.TabIndex = 41;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(949, 413);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(275, 31);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lTable
            // 
            this.lTable.AutoSize = true;
            this.lTable.Location = new System.Drawing.Point(946, 54);
            this.lTable.Name = "lTable";
            this.lTable.Size = new System.Drawing.Size(51, 15);
            this.lTable.TabIndex = 2;
            this.lTable.Text = "TABLE";
            // 
            // cbTable
            // 
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Location = new System.Drawing.Point(1003, 51);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(221, 23);
            this.cbTable.TabIndex = 3;
            this.cbTable.SelectedIndexChanged += new System.EventHandler(this.cbTable_SelectedIndexChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(949, 375);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 31);
            this.btnUpdate.TabIndex = 42;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1091, 375);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 31);
            this.btnDelete.TabIndex = 43;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lPrice1_1);
            this.groupBox1.Controls.Add(this.lPrice1_2);
            this.groupBox1.Controls.Add(this.lID1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbPublisher1);
            this.groupBox1.Controls.Add(this.tbPrice1);
            this.groupBox1.Controls.Add(this.tbID1);
            this.groupBox1.Controls.Add(this.lName1);
            this.groupBox1.Controls.Add(this.tbPriceMax1);
            this.groupBox1.Controls.Add(this.tbName1);
            this.groupBox1.Controls.Add(this.lPublisher1);
            this.groupBox1.Controls.Add(this.tbPriceMin1);
            this.groupBox1.Location = new System.Drawing.Point(949, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 206);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            // 
            // lPrice1_1
            // 
            this.lPrice1_1.AutoSize = true;
            this.lPrice1_1.Location = new System.Drawing.Point(26, 137);
            this.lPrice1_1.Name = "lPrice1_1";
            this.lPrice1_1.Size = new System.Drawing.Size(72, 15);
            this.lPrice1_1.TabIndex = 11;
            this.lPrice1_1.Text = "가격 검색";
            this.lPrice1_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lPrice1_2
            // 
            this.lPrice1_2.AutoSize = true;
            this.lPrice1_2.Location = new System.Drawing.Point(61, 174);
            this.lPrice1_2.Name = "lPrice1_2";
            this.lPrice1_2.Size = new System.Drawing.Size(37, 15);
            this.lPrice1_2.TabIndex = 15;
            this.lPrice1_2.Text = "가격";
            this.lPrice1_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lID1
            // 
            this.lID1.AutoSize = true;
            this.lID1.Location = new System.Drawing.Point(31, 27);
            this.lID1.Name = "lID1";
            this.lID1.Size = new System.Drawing.Size(67, 15);
            this.lID1.TabIndex = 5;
            this.lID1.Text = "도서번호";
            this.lID1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "~";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbPublisher1
            // 
            this.cbPublisher1.FormattingEnabled = true;
            this.cbPublisher1.Location = new System.Drawing.Point(104, 98);
            this.cbPublisher1.Name = "cbPublisher1";
            this.cbPublisher1.Size = new System.Drawing.Size(160, 23);
            this.cbPublisher1.TabIndex = 10;
            // 
            // tbPrice1
            // 
            this.tbPrice1.Location = new System.Drawing.Point(104, 170);
            this.tbPrice1.Name = "tbPrice1";
            this.tbPrice1.Size = new System.Drawing.Size(160, 25);
            this.tbPrice1.TabIndex = 16;
            // 
            // tbID1
            // 
            this.tbID1.Location = new System.Drawing.Point(104, 23);
            this.tbID1.Name = "tbID1";
            this.tbID1.Size = new System.Drawing.Size(160, 25);
            this.tbID1.TabIndex = 6;
            // 
            // lName1
            // 
            this.lName1.AutoSize = true;
            this.lName1.Location = new System.Drawing.Point(31, 63);
            this.lName1.Name = "lName1";
            this.lName1.Size = new System.Drawing.Size(67, 15);
            this.lName1.TabIndex = 7;
            this.lName1.Text = "도서이름";
            this.lName1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPriceMax1
            // 
            this.tbPriceMax1.Location = new System.Drawing.Point(194, 133);
            this.tbPriceMax1.Name = "tbPriceMax1";
            this.tbPriceMax1.Size = new System.Drawing.Size(70, 25);
            this.tbPriceMax1.TabIndex = 14;
            // 
            // tbName1
            // 
            this.tbName1.Location = new System.Drawing.Point(104, 59);
            this.tbName1.Name = "tbName1";
            this.tbName1.Size = new System.Drawing.Size(160, 25);
            this.tbName1.TabIndex = 8;
            // 
            // lPublisher1
            // 
            this.lPublisher1.AutoSize = true;
            this.lPublisher1.Location = new System.Drawing.Point(46, 102);
            this.lPublisher1.Name = "lPublisher1";
            this.lPublisher1.Size = new System.Drawing.Size(52, 15);
            this.lPublisher1.TabIndex = 9;
            this.lPublisher1.Text = "출판사";
            this.lPublisher1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPriceMin1
            // 
            this.tbPriceMin1.Location = new System.Drawing.Point(104, 133);
            this.tbPriceMin1.Name = "tbPriceMin1";
            this.tbPriceMin1.Size = new System.Drawing.Size(70, 25);
            this.tbPriceMin1.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lPhone2);
            this.groupBox2.Controls.Add(this.lID2);
            this.groupBox2.Controls.Add(this.cbAddress2);
            this.groupBox2.Controls.Add(this.tbID2);
            this.groupBox2.Controls.Add(this.lName2);
            this.groupBox2.Controls.Add(this.tbName2);
            this.groupBox2.Controls.Add(this.lAddress2);
            this.groupBox2.Controls.Add(this.tbPhone2);
            this.groupBox2.Location = new System.Drawing.Point(949, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 174);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Visible = false;
            // 
            // lPhone2
            // 
            this.lPhone2.AutoSize = true;
            this.lPhone2.Location = new System.Drawing.Point(46, 139);
            this.lPhone2.Name = "lPhone2";
            this.lPhone2.Size = new System.Drawing.Size(52, 15);
            this.lPhone2.TabIndex = 24;
            this.lPhone2.Text = "연락처";
            this.lPhone2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lID2
            // 
            this.lID2.AutoSize = true;
            this.lID2.Location = new System.Drawing.Point(31, 27);
            this.lID2.Name = "lID2";
            this.lID2.Size = new System.Drawing.Size(67, 15);
            this.lID2.TabIndex = 18;
            this.lID2.Text = "회원번호";
            this.lID2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbAddress2
            // 
            this.cbAddress2.FormattingEnabled = true;
            this.cbAddress2.Location = new System.Drawing.Point(104, 100);
            this.cbAddress2.Name = "cbAddress2";
            this.cbAddress2.Size = new System.Drawing.Size(160, 23);
            this.cbAddress2.TabIndex = 23;
            // 
            // tbID2
            // 
            this.tbID2.Location = new System.Drawing.Point(104, 23);
            this.tbID2.Name = "tbID2";
            this.tbID2.Size = new System.Drawing.Size(160, 25);
            this.tbID2.TabIndex = 19;
            // 
            // lName2
            // 
            this.lName2.AutoSize = true;
            this.lName2.Location = new System.Drawing.Point(31, 65);
            this.lName2.Name = "lName2";
            this.lName2.Size = new System.Drawing.Size(67, 15);
            this.lName2.TabIndex = 20;
            this.lName2.Text = "회원이름";
            this.lName2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbName2
            // 
            this.tbName2.Location = new System.Drawing.Point(104, 61);
            this.tbName2.Name = "tbName2";
            this.tbName2.Size = new System.Drawing.Size(160, 25);
            this.tbName2.TabIndex = 21;
            // 
            // lAddress2
            // 
            this.lAddress2.AutoSize = true;
            this.lAddress2.Location = new System.Drawing.Point(61, 104);
            this.lAddress2.Name = "lAddress2";
            this.lAddress2.Size = new System.Drawing.Size(37, 15);
            this.lAddress2.TabIndex = 22;
            this.lAddress2.Text = "주소";
            this.lAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbPhone2
            // 
            this.tbPhone2.Location = new System.Drawing.Point(104, 134);
            this.tbPhone2.Name = "tbPhone2";
            this.tbPhone2.Size = new System.Drawing.Size(160, 25);
            this.tbPhone2.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lSalePrice3_1);
            this.groupBox3.Controls.Add(this.lOrderDate3_2);
            this.groupBox3.Controls.Add(this.lSalePrice3_2);
            this.groupBox3.Controls.Add(this.lBookID3);
            this.groupBox3.Controls.Add(this.cbOrderDate3);
            this.groupBox3.Controls.Add(this.lCustID3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.tbSalePrice3);
            this.groupBox3.Controls.Add(this.tbBookID3);
            this.groupBox3.Controls.Add(this.tbCustID3);
            this.groupBox3.Controls.Add(this.tbOrderID3);
            this.groupBox3.Controls.Add(this.tbSalePriceMax3);
            this.groupBox3.Controls.Add(this.tbSalePriceMin3);
            this.groupBox3.Controls.Add(this.lOrderID3);
            this.groupBox3.Location = new System.Drawing.Point(949, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 235);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            this.groupBox3.Visible = false;
            // 
            // lSalePrice3_1
            // 
            this.lSalePrice3_1.AutoSize = true;
            this.lSalePrice3_1.Location = new System.Drawing.Point(11, 136);
            this.lSalePrice3_1.Name = "lSalePrice3_1";
            this.lSalePrice3_1.Size = new System.Drawing.Size(87, 15);
            this.lSalePrice3_1.TabIndex = 14;
            this.lSalePrice3_1.Text = "판매가 검색";
            this.lSalePrice3_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lOrderDate3_2
            // 
            this.lOrderDate3_2.AutoSize = true;
            this.lOrderDate3_2.Location = new System.Drawing.Point(46, 205);
            this.lOrderDate3_2.Name = "lOrderDate3_2";
            this.lOrderDate3_2.Size = new System.Drawing.Size(52, 15);
            this.lOrderDate3_2.TabIndex = 38;
            this.lOrderDate3_2.Text = "주문일";
            this.lOrderDate3_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lSalePrice3_2
            // 
            this.lSalePrice3_2.AutoSize = true;
            this.lSalePrice3_2.Location = new System.Drawing.Point(46, 169);
            this.lSalePrice3_2.Name = "lSalePrice3_2";
            this.lSalePrice3_2.Size = new System.Drawing.Size(52, 15);
            this.lSalePrice3_2.TabIndex = 36;
            this.lSalePrice3_2.Text = "판매가";
            this.lSalePrice3_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lBookID3
            // 
            this.lBookID3.AutoSize = true;
            this.lBookID3.Location = new System.Drawing.Point(31, 100);
            this.lBookID3.Name = "lBookID3";
            this.lBookID3.Size = new System.Drawing.Size(67, 15);
            this.lBookID3.TabIndex = 31;
            this.lBookID3.Text = "도서번호";
            this.lBookID3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbOrderDate3
            // 
            this.cbOrderDate3.FormattingEnabled = true;
            this.cbOrderDate3.Location = new System.Drawing.Point(104, 201);
            this.cbOrderDate3.Name = "cbOrderDate3";
            this.cbOrderDate3.Size = new System.Drawing.Size(160, 23);
            this.cbOrderDate3.TabIndex = 44;
            // 
            // lCustID3
            // 
            this.lCustID3.AutoSize = true;
            this.lCustID3.Location = new System.Drawing.Point(31, 66);
            this.lCustID3.Name = "lCustID3";
            this.lCustID3.Size = new System.Drawing.Size(67, 15);
            this.lCustID3.TabIndex = 29;
            this.lCustID3.Text = "회원번호";
            this.lCustID3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(177, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "~";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSalePrice3
            // 
            this.tbSalePrice3.Location = new System.Drawing.Point(104, 165);
            this.tbSalePrice3.Name = "tbSalePrice3";
            this.tbSalePrice3.Size = new System.Drawing.Size(160, 25);
            this.tbSalePrice3.TabIndex = 37;
            // 
            // tbBookID3
            // 
            this.tbBookID3.Location = new System.Drawing.Point(104, 97);
            this.tbBookID3.Name = "tbBookID3";
            this.tbBookID3.Size = new System.Drawing.Size(160, 25);
            this.tbBookID3.TabIndex = 32;
            // 
            // tbCustID3
            // 
            this.tbCustID3.Location = new System.Drawing.Point(104, 63);
            this.tbCustID3.Name = "tbCustID3";
            this.tbCustID3.Size = new System.Drawing.Size(160, 25);
            this.tbCustID3.TabIndex = 30;
            // 
            // tbOrderID3
            // 
            this.tbOrderID3.Location = new System.Drawing.Point(104, 29);
            this.tbOrderID3.Name = "tbOrderID3";
            this.tbOrderID3.Size = new System.Drawing.Size(160, 25);
            this.tbOrderID3.TabIndex = 28;
            // 
            // tbSalePriceMax3
            // 
            this.tbSalePriceMax3.Location = new System.Drawing.Point(194, 131);
            this.tbSalePriceMax3.Name = "tbSalePriceMax3";
            this.tbSalePriceMax3.Size = new System.Drawing.Size(70, 25);
            this.tbSalePriceMax3.TabIndex = 35;
            // 
            // tbSalePriceMin3
            // 
            this.tbSalePriceMin3.Location = new System.Drawing.Point(104, 131);
            this.tbSalePriceMin3.Name = "tbSalePriceMin3";
            this.tbSalePriceMin3.Size = new System.Drawing.Size(70, 25);
            this.tbSalePriceMin3.TabIndex = 33;
            // 
            // lOrderID3
            // 
            this.lOrderID3.AutoSize = true;
            this.lOrderID3.Location = new System.Drawing.Point(31, 33);
            this.lOrderID3.Name = "lOrderID3";
            this.lOrderID3.Size = new System.Drawing.Size(67, 15);
            this.lOrderID3.TabIndex = 27;
            this.lOrderID3.Text = "주문번호";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelConnectionState);
            this.groupBox4.Location = new System.Drawing.Point(949, 84);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(275, 235);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("나눔고딕", 14F);
            this.lTitle.Location = new System.Drawing.Point(7, 17);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(75, 28);
            this.lTitle.TabIndex = 46;
            this.lTitle.Text = "mydb";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 725);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.lTable);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelConnectionState;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lTable;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lPrice1_1;
        private System.Windows.Forms.Label lID1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPublisher1;
        private System.Windows.Forms.TextBox tbID1;
        private System.Windows.Forms.Label lName1;
        private System.Windows.Forms.TextBox tbPriceMax1;
        private System.Windows.Forms.TextBox tbName1;
        private System.Windows.Forms.Label lPublisher1;
        private System.Windows.Forms.TextBox tbPriceMin1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lPhone2;
        private System.Windows.Forms.Label lID2;
        private System.Windows.Forms.ComboBox cbAddress2;
        private System.Windows.Forms.TextBox tbID2;
        private System.Windows.Forms.Label lName2;
        private System.Windows.Forms.TextBox tbName2;
        private System.Windows.Forms.Label lAddress2;
        private System.Windows.Forms.TextBox tbPhone2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lSalePrice3_1;
        private System.Windows.Forms.Label lCustID3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbSalePriceMax3;
        private System.Windows.Forms.TextBox tbSalePriceMin3;
        private System.Windows.Forms.Label lOrderID3;
        private System.Windows.Forms.Label lPrice1_2;
        private System.Windows.Forms.TextBox tbPrice1;
        private System.Windows.Forms.Label lOrderDate3_2;
        private System.Windows.Forms.Label lSalePrice3_2;
        private System.Windows.Forms.TextBox tbSalePrice3;
        private System.Windows.Forms.TextBox tbOrderID3;
        private System.Windows.Forms.Label lBookID3;
        private System.Windows.Forms.ComboBox cbOrderDate3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.TextBox tbBookID3;
        private System.Windows.Forms.TextBox tbCustID3;
    }
}

