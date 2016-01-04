﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.IO;
using System.Collections;

namespace cs511_g11
{
	public partial class MainForm : MetroForm
    {
		RichTextBoxSynchronizedScroll Textbox_left = new RichTextBoxSynchronizedScroll();
		RichTextBoxSynchronizedScroll Textbox_right = new RichTextBoxSynchronizedScroll();

		public MainForm()
		{
			InitializeComponent();
			SetupRichTextbox();

			FileCompareUtils.m_controllerFileLeft = new TextController();
			FileCompareUtils.m_controllerFileRight = new TextController();

			FileCompareUtils.m_controllerFileLeft.Clear();
			FileCompareUtils.m_controllerFileRight.Clear();
		}

		private void SetupRichTextbox()
		{
			Textbox_left.AcceptsTab = true;
			Textbox_left.EnableAutoDragDrop = true;
			Textbox_left.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			Textbox_left.Location = new System.Drawing.Point(0, 60);
			Textbox_left.Margin = new System.Windows.Forms.Padding(5);
			Textbox_left.Name = "Textbox_left";
			Textbox_left.Size = new System.Drawing.Size(475, 418);
			Textbox_left.TabIndex = 9;
			Textbox_left.Text = "";
			Textbox_left.WordWrap = false;
			Textbox_left.TextChanged += new System.EventHandler(this.Textbox_left_TextChanged);
			Textbox_left.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_left_KeyPress);
			Textbox_left.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Textbox_left_KeyUp);
			Textbox_left.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_left_KeyDown);

			Textbox_right.AcceptsTab = true;
			Textbox_right.EnableAutoDragDrop = true;
			Textbox_right.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			Textbox_right.Location = new System.Drawing.Point(496, 60);
			Textbox_right.Margin = new System.Windows.Forms.Padding(5);
			Textbox_right.Name = "Textbox_right";
			Textbox_right.Size = new System.Drawing.Size(475, 418);
			Textbox_right.TabIndex = 10;
			Textbox_right.Text = "";
			Textbox_right.WordWrap = false;
			Textbox_right.TextChanged += new System.EventHandler(this.Textbox_right_TextChanged);
			Textbox_right.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textbox_right_KeyPress);
			Textbox_right.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Textbox_right_KeyUp);
			Textbox_right.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Textbox_right_KeyDown);

			Textbox_left.Parent = Textbox_right.Parent = this.metroTabPage2;
			Textbox_left.BindScroll(Textbox_right);
		}

		private void metroTile2_Click(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(metroTabPage3);
        }

        private void metroTile1_MouseMove(object sender, MouseEventArgs e)
        {
            metroTile1.Style = (MetroColorStyle)5;
        }

        private void metroTile1_MouseLeave(object sender, EventArgs e)
        {
            metroTile1.Style = (MetroColorStyle)0;
        }

        private void metroTile2_MouseLeave(object sender, EventArgs e)
        {
            metroTile2.Style = (MetroColorStyle)0;
        }

        private void metroTile2_MouseMove(object sender, MouseEventArgs e)
        {
            metroTile2.Style = (MetroColorStyle)5;
        }

        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            metroContextMenu2.Show(metroButton2, new Point(0, metroButton2.Height));
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            if (White.Checked == true)
            {
                this.Theme = MetroThemeStyle.Light;
                metroStyleManager.Theme = MetroThemeStyle.Light;
                metroUserControl1.BackColor = this.BackColor;
                metroTrackBar2.BackColor = this.BackColor;
                treeView1.BackColor = this.BackColor;
                treeView2.BackColor = this.BackColor;

            }
            else
            {
                this.Theme = MetroThemeStyle.Dark;
                metroStyleManager.Theme = MetroThemeStyle.Dark;
                metroUserControl1.BackColor = this.BackColor;
                metroTrackBar2.BackColor = this.BackColor;
                treeView1.BackColor = this.BackColor;
                treeView2.BackColor = this.BackColor;

            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Style = (MetroColorStyle)metroTrackBar2.Value;
            metroStyleManager.Style = (MetroColorStyle)metroTrackBar2.Value;
           
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void metroUserControl1_Load_1(object sender, EventArgs e)
        {

        }

 

        private void metroTrackBar2_ValueChanged(object sender, EventArgs e)
        {
            int valuecolor= metroTrackBar2.Value;
            if (valuecolor == 0)
                metroTrackBar2.BackColor = Color.Blue;
            else if(valuecolor == 1)
                metroTrackBar2.BackColor = Color.Black;
            else if (valuecolor == 2)
                metroTrackBar2.BackColor = Color.White;
            else if (valuecolor == 3)
                metroTrackBar2.BackColor = Color.Silver;
            else if (valuecolor == 4)
                metroTrackBar2.BackColor = Color.Blue;
            else if (valuecolor == 5)
                metroTrackBar2.BackColor = Color.Green;
            else if (valuecolor == 6)
                metroTrackBar2.BackColor = Color.Lime;
            else if (valuecolor == 7)
                metroTrackBar2.BackColor = Color.Teal;
            else if (valuecolor == 8)
                metroTrackBar2.BackColor = Color.Orange;
            else if (valuecolor == 9)
                metroTrackBar2.BackColor = Color.Brown;
            else if (valuecolor == 10)
                metroTrackBar2.BackColor = Color.Pink;
            else if (valuecolor == 11)
                metroTrackBar2.BackColor = Color.Magenta;
            else if (valuecolor == 12)
                metroTrackBar2.BackColor = Color.Purple;
            else
                metroTrackBar2.BackColor = Color.Red;
        }

        private void metroTrackBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

       

        private void addFolderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
        private void show_folder(string path,TreeNode node)//ham liet ket dic
        {
            DirectoryInfo direcinfo = new DirectoryInfo(path);
            DirectoryInfo[] dics = direcinfo.GetDirectories();
            int i = 0;
            foreach (DirectoryInfo dic in dics)
            {

                node.Nodes.Add(dic.Name);
                TreeNode nodes = node.Nodes[i];
                show_folder(path + '/' + dic.Name, nodes);
                i++;

            }
            FileInfo[] files = direcinfo.GetFiles();
            foreach (FileInfo file in files)
            {
                node.Nodes.Add(file.Name);
            }
        }
        private void show_treenode(TreeView x)
        {
            try
            {
                FolderBrowserDialog fd = new FolderBrowserDialog();
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    x.Nodes.Clear();
                    if (x == treeView1)
                    {
                        metroLabel3.Text = fd.SelectedPath;
                    }
                    else { metroLabel4.Text = fd.SelectedPath; }
                    DirectoryInfo direcinfo = new DirectoryInfo(fd.SelectedPath);
                    DirectoryInfo[] dics = direcinfo.GetDirectories();
                    int i = 0;
                    foreach (DirectoryInfo dic in dics)
                    {
                        x.Nodes.Add(dic.Name);
                        TreeNode node = x.Nodes[i];
                        show_folder(fd.SelectedPath + '/' + dic.Name, node);
                        i++;

                    }
                    FileInfo[] files = direcinfo.GetFiles();
                    foreach (FileInfo file in files)
                    {
                        x.Nodes.Add(file.Name);
                    }
                }
            }
            catch
            {
                
            }
        }
        private void addFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count == 0)
            {
                show_treenode(treeView1);
            }
            else
                show_treenode(treeView2);
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroContextMenu2_Opening(object sender, CancelEventArgs e)
        {

        }
        int checkfile(string path)
        {
            int kq = 1;
            return kq;
        }
        private string listname(TreeNode node)
        {

            int k = 0;
            string name = "";
        nhaylai:
            try
            {

                while (k != 1)
                {
                    name = '\\' + name + node.Text + "\\";
                    node = node.NextNode;

                }
            }
            catch
            {
                k = 1;
                goto nhaylai;
            }
            return name;
        }
        private void tomau(TreeNode Node, TreeView xx)
        {
            string[] arrListStr = Node.FullPath.Split('\\');
            string t = arrListStr[0];
            TreeNode X;
            X = xx.Nodes[0];
            while (X.Text != t)
            {
                X = X.NextNode;
            }
            for (int i = 1; i <= arrListStr.Length - 1; i++)
            {
                X.ForeColor = Color.Red;
                X = X.Nodes[0];
                while (X.Text != arrListStr[i])
                {
                    X = X.NextNode;
                }
            }
        }
        private void kiemtradisc(TreeNode Node,TreeView x,TreeView y)
        {
            string[] arrListStr = Node.FullPath.Split('\\');
            string firstnode;
            firstnode = arrListStr[0];

            TreeNode Node2 = y.Nodes[0];
            while (firstnode != Node2.Text)
            {
                Node2 = Node2.NextNode;
            }
            Node = Node.Nodes[0];
            string nodetxt = Node.FullPath;


            int j = 0;
        trl:
            try
            {
                while (j != 1)
                {
                    for (int i = 0; i <= nodetxt.Length - 1; i++)
                    {
                        if (nodetxt[i] == '\\')
                        {
                            Node2 = Node2.Nodes[0];
                        }

                    }
                repeat:
                    string t1 = '\\' + Node.Text;
                    string t2 = Node.Text + '\\';
                    if ((listname(Node2).Contains(t1) == false) || (listname(Node2).Contains(t2) == false))
                    {
                        tomau(Node,x);
                        Node.ForeColor = Color.Blue;
                    }
                    else
                    {
                        string te;
                        if (x == treeView1)
                            te = metroLabel3.Text;
                        else
                            te = metroLabel4.Text;
                        FileAttributes attr = File.GetAttributes(te + '\\' + Node.FullPath);

                        //detect whether its a directory or file
                        if (attr.HasFlag(FileAttributes.Directory))
                        {
                            kiemtradisc(Node,x,y);
                        }
                        else
                        {

                            if (checkfile(Node.FullPath) == 1)
                            {
                                tomau(Node,x);
                                Node.ForeColor = Color.Red;
                            }
                        }

                    }
                    Node = Node.NextNode;
                    goto repeat;
                }
            }
            catch
            {
                j = 1;
                goto trl;
            }

        }
        private void compare(TreeView x,TreeView y)
        {
            int j = 0;
        trolai:
            try
            {
                TreeNode knode;
                knode = x.Nodes[0];
                while (j != 1)
                {
                    
                    TreeNode knodes = y.Nodes[0];
                    string t1 = '\\' + knode.Text;
                    string t2 = knode.Text + '\\';
                    if ((listname(knodes).Contains(t1) == false) || (listname(knodes).Contains(t2) == false))
                    {
                        knode.ForeColor = Color.Blue;
                    }
                    else
                    {
                        string te;
                        if (x == treeView1)
                            te = metroLabel3.Text;
                        else
                            te = metroLabel4.Text;
                        FileAttributes attr = File.GetAttributes(te + '\\' + knode.FullPath);

                        //detect whether its a directory or file
                        if (attr.HasFlag(FileAttributes.Directory))
                        {
                            kiemtradisc(knode, x, y);
                        }
                        else
                        {

                            if (checkfile(knode.FullPath) == 1)
                            {
                                knode.ForeColor = Color.Red;
                            }
                        }
                    }

                    knode = knode.NextNode;
                }
            }
            catch
            {
                j = 1;
                goto trolai;
            }
        }
        private void compareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((treeView1.Nodes.Count == 0) || (treeView2.Nodes.Count == 0))
            {
                MetroMessageBox.Show(this, "Please Add Folder first.", "Folder Not Found", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
            }
            else
            {
                compare(treeView1, treeView2);
                compare(treeView2, treeView1);
            }

            // get history when compare text
            
            string ngay = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            string hour = DateTime.Now.Hour.ToString();
            string min = DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second.ToString();
            string result = ngay + "/" + thang + "/" + year + "........" + hour + ":" + min + ":" + second + " Compare folder";
            string path = @"../../Datas/History.txt";
            StreamWriter sw = new StreamWriter(path,true);
            sw.WriteLine(result);
            sw.Close();
         
        }

		///////////////////////////////////////////////////////////////////////////////
		// File Compare
		private void FileCompareToolbox_Click(object sender, EventArgs e)
		{
			TextCompareMenu.Show(FileCompareToolbox, new Point(0, FileCompareToolbox.Height));
		}

		private void FileCompare()
		{
			ArrayList _result = FileCompareUtils.CompareFile();

			TextController _leftController = FileCompareUtils.m_controllerFileLeft;
			TextController _rightController = FileCompareUtils.m_controllerFileRight;

			Textbox_left.Clear();
			Textbox_right.Clear();
            // get history when compare
            string ngay = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string year = DateTime.Now.Year.ToString();
            string hour = DateTime.Now.Hour.ToString();
            string min = DateTime.Now.Minute.ToString();
            string second = DateTime.Now.Second.ToString();
            string result = ngay + "/" + thang + "/" + year + "........" + hour + ":" + min + ":" + second + " Compare Text";
            string path = @"../../Datas/History.txt";
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(result);
            sw.Close();

			for (int i = 0; i < _result.Count; i++)
			{
				DiffResultSpan _item = ((DiffResultSpan)_result[i]);

				switch (_item.Status)
				{
					case DiffResultSpanStatus.SameText:
						for(int j = 0; j < _item.Length; j++)
						{
							string _contentLeft = ((TextLine)_leftController.GetLineByIndex(_item.SourceIndex + j)).m_content;
							string _contentRight = ((TextLine)_rightController.GetLineByIndex(_item.DestIndex + j)).m_content;

							FileCompareUtils.AppendText(Textbox_left, _contentLeft, Color.Black, Color.White);
							FileCompareUtils.AppendText(Textbox_right, _contentRight, Color.Black, Color.White);
						}
						break;
					case DiffResultSpanStatus.DiffrenentText:
						for (int j = 0; j < _item.Length; j++)
						{
							string _contentLeft = ((TextLine)_leftController.GetLineByIndex(_item.SourceIndex + j)).m_content;
							string _contentRight = ((TextLine)_rightController.GetLineByIndex(_item.DestIndex + j)).m_content;

							FileCompareUtils.AppendText(Textbox_left, _contentLeft, Color.Red, Color.LightPink);
							FileCompareUtils.AppendText(Textbox_right, _contentRight, Color.Red, Color.LightPink);
						}
						break;
					case DiffResultSpanStatus.LeftNotExist:
						for (int j = 0; j < _item.Length; j++)
						{
							//string _contentLeft = ((TextLine)_leftController.GetByIndex(_item.SourceIndex + j)).m_content;
							string _contentRight = ((TextLine)_rightController.GetLineByIndex(_item.DestIndex + j)).m_content;

							FileCompareUtils.AppendText(Textbox_left, "", Color.Red, Color.LightPink);
							FileCompareUtils.AppendText(Textbox_right, _contentRight, Color.Red, Color.LightPink);
						}

						if (FileCompareUtils.m_controllerFileLeft.Lines.Count > 0)
							((TextLine)FileCompareUtils.m_controllerFileLeft.GetLineByIndex(((DiffResultSpan)_result[i - 1]).SourceIndex)).m_ignoredLine += _item.Length;
						break;
					case DiffResultSpanStatus.RightNotExist:
						for (int j = 0; j < _item.Length; j++)
						{
							string _contentLeft = ((TextLine)_leftController.GetLineByIndex(_item.SourceIndex + j)).m_content;
							//String _contentRight = ((TextLine)_rightController.GetByIndex(_item.DestIndex + j)).m_content;

							FileCompareUtils.AppendText(Textbox_left, _contentLeft, Color.Red, Color.LightPink);
							FileCompareUtils.AppendText(Textbox_right, "", Color.Red, Color.LightPink);
						}

						if(FileCompareUtils.m_controllerFileRight.Lines.Count > 0)
							((TextLine)FileCompareUtils.m_controllerFileRight.GetLineByIndex(((DiffResultSpan)_result[i - 1]).DestIndex)).m_ignoredLine += _item.Length;
						break;
				}
			}
		}

        

		private void Add_LeftFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog _dialog = new OpenFileDialog();
			Stream _readStream = null;

			if (_dialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					if ((_readStream = _dialog.OpenFile()) != null)
					{
						using (_readStream)
						{
							FileCompareUtils.m_controllerFileLeft.Clear();
							FileCompareUtils.m_controllerFileLeft.Setup(File.ReadAllText(_dialog.FileName));
							FileCompare();
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}
		}

		private void Add_RightFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog _dialog = new OpenFileDialog();
			Stream _readStream = null;

			if (_dialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					if ((_readStream = _dialog.OpenFile()) != null)
					{
						using (_readStream)
						{
							FileCompareUtils.m_controllerFileRight.Clear();
							FileCompareUtils.m_controllerFileRight.Setup(File.ReadAllText(_dialog.FileName));
							FileCompare();
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
				}
			}
		}

		private void TextCompare_Save_Click(object sender, EventArgs e)
		{

		}

		private void TextCompare_Compare_Click(object sender, EventArgs e)
		{
           

            
		}

		private void Textbox_left_TextChanged(object sender, EventArgs e)
		{
			//FileCompare();
		}

		private void Textbox_right_TextChanged(object sender, EventArgs e)
		{
			//FileCompare();
		}

		private void Textbox_left_KeyPress(object sender, KeyPressEventArgs e)
		{
			int _index = Textbox_left.SelectionStart;
			int _currentLine = Textbox_left.GetLineFromCharIndex(_index);

			int _firstCharIndex = Textbox_left.GetFirstCharIndexFromLine(_currentLine);

			if (e.KeyChar == Convert.ToChar(Keys.Return))
			{
				string _content = Textbox_left.Lines[_currentLine];
				string _previousLineContent = Textbox_left.Lines[_currentLine - 1];
				FileCompareUtils.m_controllerFileLeft.UpdateLinesWithEnter(FileCompareUtils.m_controllerFileLeft.GetLine(_currentLine), _content, _previousLineContent);
			}
			else if (e.KeyChar == Convert.ToChar(Keys.Back))
			{
				string _content = Textbox_left.Lines[_currentLine];
				FileCompareUtils.m_controllerFileLeft.UpdateLinesWithDelete(FileCompareUtils.m_controllerFileLeft.GetLine(_currentLine), _content);
			}
		}

		private void Textbox_right_KeyPress(object sender, KeyPressEventArgs e)
		{
			int _index = Textbox_right.SelectionStart;
			int _currentLine = Textbox_right.GetLineFromCharIndex(_index);

			int _firstCharIndex = Textbox_right.GetFirstCharIndexFromLine(_currentLine);

			if (e.KeyChar == Convert.ToChar(Keys.Return))
			{
				string _content = Textbox_right.Lines[_currentLine];
				string _previousLineContent = Textbox_right.Lines[_currentLine - 1];
				FileCompareUtils.m_controllerFileRight.UpdateLinesWithEnter(FileCompareUtils.m_controllerFileRight.GetLine(_currentLine), _content, _previousLineContent);
			}
			else if (e.KeyChar == Convert.ToChar(Keys.Back))
			{
				string _content = Textbox_right.Lines[_currentLine];
				FileCompareUtils.m_controllerFileRight.UpdateLinesWithDelete(FileCompareUtils.m_controllerFileRight.GetLine(_currentLine), _content);
			}
		}

		private void Textbox_left_KeyUp(object sender, KeyEventArgs e)
		{
			int _index = Textbox_left.SelectionStart;
			int _currentLine = Textbox_left.GetLineFromCharIndex(_index);

			string _newContent = Textbox_left.Lines[_currentLine];
			FileCompareUtils.m_controllerFileLeft.UpdateLine(FileCompareUtils.m_controllerFileLeft.GetLine(_currentLine), _newContent);
		}

		private void Textbox_right_KeyUp(object sender, KeyEventArgs e)
		{
			int _index = Textbox_right.SelectionStart;
			int _currentLine = Textbox_right.GetLineFromCharIndex(_index);

			string _newContent = Textbox_right.Lines[_currentLine];
			FileCompareUtils.m_controllerFileRight.UpdateLine(FileCompareUtils.m_controllerFileRight.GetLine(_currentLine), _newContent);
		}

		private void Textbox_left_KeyDown(object sender, KeyEventArgs e)
		{
			int _index = Textbox_left.SelectionStart;
			int _currentLine = Textbox_left.GetLineFromCharIndex(_index);

			if (e.KeyCode == Keys.Delete)
			{
				string _content = Textbox_left.Lines[_currentLine];
				string _previousContent = Textbox_left.Lines[_currentLine + 1];
				FileCompareUtils.m_controllerFileLeft.UpdateLinesWithDelete(FileCompareUtils.m_controllerFileLeft.GetLine(_currentLine), _content + _previousContent);
			}
		}

		private void Textbox_right_KeyDown(object sender, KeyEventArgs e)
		{
			int _index = Textbox_right.SelectionStart;
			int _currentLine = Textbox_right.GetLineFromCharIndex(_index);

			if (e.KeyCode == Keys.Delete)
			{
				string _content = Textbox_right.Lines[_currentLine];
				string _previousContent = Textbox_right.Lines[_currentLine + 1];
				FileCompareUtils.m_controllerFileRight.UpdateLinesWithDelete(FileCompareUtils.m_controllerFileRight.GetLine(_currentLine), _content + _previousContent);
			}
		}

        /*private void leftFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                
                    StreamWriter sw = new StreamWriter(File_1.Text.Trim());
                    sw.WriteLine(Textbox_left.Text);
                    sw.Close();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MainForm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rightFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                StreamWriter sw = new StreamWriter(File_2.Text.Trim());
                sw.Write(Textbox_left.Text);
                sw.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MainForm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

       

        private void history_btn_Click(object sender, EventArgs e)
        {
            string path = @"../../Datas/History.txt";
            StreamReader a = new StreamReader(path);
            History.Text = a.ReadToEnd();
            a.Close();
        }
	}
}
