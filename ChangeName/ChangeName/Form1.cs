using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeName
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//적용 버튼
		private void OnApplyButtonClick(object sender, EventArgs e)
		{
			var buffer = new List<string>(); //바뀐 이름 저장용 리스트

			foreach (var file in FileList.Items) //파일리스트의 내용을 하나하나 꺼냄
			{
				string filename = (string)file; //파일 이름

				if (File.Exists(filename)) //파일 존재!
				{

					//바뀔 이름이 이미 없다면 정상실행
					if (!File.Exists(filename.Replace(OldName.Text, NewName.Text)))
					{
						//파일 이름 변경
						File.Move(filename, filename.Replace(OldName.Text, NewName.Text));

						//바뀐 이름 저장
						buffer.Add(filename.Replace(OldName.Text, NewName.Text));
					}

					else //바뀔 이름이 이미 있다면
					{
						buffer.Add(filename); //파일 이름 저장
						MessageBox.Show("이름 충돌!");
					}
				}
			}

			FileList.Items.Clear(); //파일리스트	비우기

			//바뀐 이름으로 변경
			foreach (var file in buffer)
				FileList.Items.Add(file);
		}


		//종료 버튼
		private void OnExitButtonClick(object sender, EventArgs e)
		{
			Application.Exit(); //종료
		}



		//파일리스트안에 드랍
		private void OnDropFiles(object sender, DragEventArgs e)
		{
			//파일리스트에 드랍되는 파일
			var files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

			//파일리스트에 파일 추가
			foreach (var file in files)
				FileList.Items.Add(file);
		}



		//파일리스트안에 드래그 되었을 때
		private void OnDragEnter(object sender, DragEventArgs e)
		{
			//드롭되는 파일이 있다면
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.All; //ㅇㅋㄷㅋ
		}



		//제거 버튼
		private void OnDeleteButtonClick(object sender, EventArgs e)
		{
			var buffer = new List<string>(); //제거할 파일리스트 내용 담을 리스트

			//제거할 파일리스트 내용 리스트에 저장
			foreach (var file in FileList.SelectedItems)
				buffer.Add((string)file);

			//파일리스트에서 제거
			foreach (var file in buffer)
				FileList.Items.Remove(file);
		}

	}
}