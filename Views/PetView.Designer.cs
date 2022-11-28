
namespace MVPPattern
{
  partial class PetView
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
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.tab = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnEdit = new System.Windows.Forms.Button();
      this.btnAddNew = new System.Windows.Forms.Button();
      this.dataGridView = new System.Windows.Forms.DataGridView();
      this.btnSearch = new System.Windows.Forms.Button();
      this.txtSearch = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.tabPagePetDetail = new System.Windows.Forms.TabPage();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.txtPetColour = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtPetType = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txtPetName = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtPetId = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.tab.SuspendLayout();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
      this.tabPagePetDetail.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 16);
      this.label1.TabIndex = 0;
      this.label1.Text = "PETS";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.White;
      this.panel1.Controls.Add(this.label1);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 37);
      this.panel1.TabIndex = 1;
      // 
      // tab
      // 
      this.tab.Controls.Add(this.tabPage1);
      this.tab.Controls.Add(this.tabPagePetDetail);
      this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tab.Location = new System.Drawing.Point(0, 37);
      this.tab.Name = "tab";
      this.tab.SelectedIndex = 0;
      this.tab.Size = new System.Drawing.Size(800, 413);
      this.tab.TabIndex = 2;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.btnDelete);
      this.tabPage1.Controls.Add(this.btnEdit);
      this.tabPage1.Controls.Add(this.btnAddNew);
      this.tabPage1.Controls.Add(this.dataGridView);
      this.tabPage1.Controls.Add(this.btnSearch);
      this.tabPage1.Controls.Add(this.txtSearch);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(792, 387);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Pet List";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // btnDelete
      // 
      this.btnDelete.Location = new System.Drawing.Point(589, 91);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 21);
      this.btnDelete.TabIndex = 7;
      this.btnDelete.Text = "Delete";
      this.btnDelete.UseVisualStyleBackColor = true;
      // 
      // btnEdit
      // 
      this.btnEdit.Location = new System.Drawing.Point(589, 64);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(75, 21);
      this.btnEdit.TabIndex = 6;
      this.btnEdit.Text = "Edit";
      this.btnEdit.UseVisualStyleBackColor = true;
      // 
      // btnAddNew
      // 
      this.btnAddNew.Location = new System.Drawing.Point(589, 37);
      this.btnAddNew.Name = "btnAddNew";
      this.btnAddNew.Size = new System.Drawing.Size(75, 21);
      this.btnAddNew.TabIndex = 5;
      this.btnAddNew.Text = "Add new";
      this.btnAddNew.UseVisualStyleBackColor = true;
      // 
      // dataGridView
      // 
      this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView.Location = new System.Drawing.Point(9, 37);
      this.dataGridView.Name = "dataGridView";
      this.dataGridView.RowTemplate.Height = 23;
      this.dataGridView.Size = new System.Drawing.Size(574, 342);
      this.dataGridView.TabIndex = 4;
      // 
      // btnSearch
      // 
      this.btnSearch.Location = new System.Drawing.Point(589, 10);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 21);
      this.btnSearch.TabIndex = 3;
      this.btnSearch.Text = "조회";
      this.btnSearch.UseVisualStyleBackColor = true;
      // 
      // txtSearch
      // 
      this.txtSearch.Location = new System.Drawing.Point(85, 10);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new System.Drawing.Size(498, 21);
      this.txtSearch.TabIndex = 2;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
      this.label2.Location = new System.Drawing.Point(6, 12);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 14);
      this.label2.TabIndex = 1;
      this.label2.Text = "PET 조회";
      // 
      // tabPagePetDetail
      // 
      this.tabPagePetDetail.Controls.Add(this.btnCancel);
      this.tabPagePetDetail.Controls.Add(this.btnSave);
      this.tabPagePetDetail.Controls.Add(this.txtPetColour);
      this.tabPagePetDetail.Controls.Add(this.label6);
      this.tabPagePetDetail.Controls.Add(this.txtPetType);
      this.tabPagePetDetail.Controls.Add(this.label5);
      this.tabPagePetDetail.Controls.Add(this.txtPetName);
      this.tabPagePetDetail.Controls.Add(this.label4);
      this.tabPagePetDetail.Controls.Add(this.txtPetId);
      this.tabPagePetDetail.Controls.Add(this.label3);
      this.tabPagePetDetail.Location = new System.Drawing.Point(4, 22);
      this.tabPagePetDetail.Name = "tabPagePetDetail";
      this.tabPagePetDetail.Padding = new System.Windows.Forms.Padding(3);
      this.tabPagePetDetail.Size = new System.Drawing.Size(792, 387);
      this.tabPagePetDetail.TabIndex = 1;
      this.tabPagePetDetail.Text = "Pet Detail";
      this.tabPagePetDetail.UseVisualStyleBackColor = true;
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(92, 138);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 11;
      this.btnCancel.Text = "취소";
      this.btnCancel.UseVisualStyleBackColor = true;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(11, 138);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 10;
      this.btnSave.Text = "저장";
      this.btnSave.UseVisualStyleBackColor = true;
      // 
      // txtPetColour
      // 
      this.txtPetColour.Location = new System.Drawing.Point(11, 111);
      this.txtPetColour.Name = "txtPetColour";
      this.txtPetColour.Size = new System.Drawing.Size(221, 21);
      this.txtPetColour.TabIndex = 9;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
      this.label6.Location = new System.Drawing.Point(8, 94);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(87, 14);
      this.label6.TabIndex = 8;
      this.label6.Text = "Pet Colour";
      // 
      // txtPetType
      // 
      this.txtPetType.Location = new System.Drawing.Point(132, 70);
      this.txtPetType.Name = "txtPetType";
      this.txtPetType.Size = new System.Drawing.Size(100, 21);
      this.txtPetType.TabIndex = 7;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
      this.label5.Location = new System.Drawing.Point(129, 53);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(74, 14);
      this.label5.TabIndex = 6;
      this.label5.Text = "Pet Type";
      // 
      // txtPetName
      // 
      this.txtPetName.Location = new System.Drawing.Point(11, 70);
      this.txtPetName.Name = "txtPetName";
      this.txtPetName.Size = new System.Drawing.Size(100, 21);
      this.txtPetName.TabIndex = 5;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
      this.label4.Location = new System.Drawing.Point(8, 53);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(78, 14);
      this.label4.TabIndex = 4;
      this.label4.Text = "Pet Name";
      // 
      // txtPetId
      // 
      this.txtPetId.Location = new System.Drawing.Point(11, 29);
      this.txtPetId.Name = "txtPetId";
      this.txtPetId.Size = new System.Drawing.Size(100, 21);
      this.txtPetId.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold);
      this.label3.Location = new System.Drawing.Point(8, 12);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(53, 14);
      this.label3.TabIndex = 2;
      this.label3.Text = "Pet ID";
      // 
      // PetView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.tab);
      this.Controls.Add(this.panel1);
      this.Name = "PetView";
      this.Text = "Form1";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tab.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
      this.tabPagePetDetail.ResumeLayout(false);
      this.tabPagePetDetail.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TabControl tab;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.DataGridView dataGridView;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TabPage tabPagePetDetail;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnAddNew;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.TextBox txtPetColour;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtPetType;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtPetName;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtPetId;
    private System.Windows.Forms.Label label3;
  }
}

