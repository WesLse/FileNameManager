namespace ChangeName
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
			this.FileList = new System.Windows.Forms.ListBox();
			this.OldName = new System.Windows.Forms.TextBox();
			this.NewName = new System.Windows.Forms.TextBox();
			this.ApplyButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// FileList
			// 
			this.FileList.AllowDrop = true;
			this.FileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FileList.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FileList.FormattingEnabled = true;
			this.FileList.ItemHeight = 17;
			this.FileList.Location = new System.Drawing.Point(9, 129);
			this.FileList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.FileList.Name = "FileList";
			this.FileList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.FileList.Size = new System.Drawing.Size(743, 208);
			this.FileList.TabIndex = 0;
			this.FileList.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDropFiles);
			this.FileList.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
			// 
			// OldName
			// 
			this.OldName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.OldName.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OldName.Location = new System.Drawing.Point(9, 28);
			this.OldName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.OldName.Name = "OldName";
			this.OldName.Size = new System.Drawing.Size(743, 25);
			this.OldName.TabIndex = 1;
			// 
			// NewName
			// 
			this.NewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NewName.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NewName.Location = new System.Drawing.Point(9, 78);
			this.NewName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.NewName.Name = "NewName";
			this.NewName.Size = new System.Drawing.Size(743, 25);
			this.NewName.TabIndex = 2;
			// 
			// ApplyButton
			// 
			this.ApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ApplyButton.Font = new System.Drawing.Font("a몬스터", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ApplyButton.Location = new System.Drawing.Point(414, 355);
			this.ApplyButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.ApplyButton.Name = "ApplyButton";
			this.ApplyButton.Size = new System.Drawing.Size(111, 54);
			this.ApplyButton.TabIndex = 3;
			this.ApplyButton.Text = "적용";
			this.ApplyButton.UseVisualStyleBackColor = true;
			this.ApplyButton.Click += new System.EventHandler(this.OnApplyButtonClick);
			// 
			// ExitButton
			// 
			this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ExitButton.Font = new System.Drawing.Font("a몬스터", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ExitButton.Location = new System.Drawing.Point(644, 355);
			this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(111, 54);
			this.ExitButton.TabIndex = 5;
			this.ExitButton.Text = "종료";
			this.ExitButton.UseVisualStyleBackColor = true;
			this.ExitButton.Click += new System.EventHandler(this.OnExitButtonClick);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteButton.Font = new System.Drawing.Font("a몬스터", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.DeleteButton.Location = new System.Drawing.Point(529, 355);
			this.DeleteButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(111, 54);
			this.DeleteButton.TabIndex = 3;
			this.DeleteButton.Text = "삭제";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.OnDeleteButtonClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("a찐빵B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 15);
			this.label1.TabIndex = 6;
			this.label1.Text = "바꾸려는 이름";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("a찐빵B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label2.Location = new System.Drawing.Point(12, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "바꿀 이름";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("a찐빵B", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.label3.Location = new System.Drawing.Point(12, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "파일 목록";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(779, 528);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.ApplyButton);
			this.Controls.Add(this.NewName);
			this.Controls.Add(this.OldName);
			this.Controls.Add(this.FileList);
			this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.MinimumSize = new System.Drawing.Size(394, 519);
			this.Name = "Form1";
			this.Text = "ChangeName";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FileList;
        private System.Windows.Forms.TextBox OldName;
        private System.Windows.Forms.TextBox NewName;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
	}
}

