using Microsoft.Win32;//registry
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Windows.Forms;

namespace MossGradingSystem
{
	public partial class Form1 : Form
	{
		private string language;
		private string topLabel;
		private string currentUser;
		private System.Collections.ArrayList fileList = new System.Collections.ArrayList();

		public Form1()
		{
			InitializeComponent();
			language = "";
			currentUser = registryGetLastUserID();

			if (currentUser == null)
				topLabel = "MOSS - Not logged in";
			else
				topLabel = "MOSS - " + currentUser;
			Text = topLabel;
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Language_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Language.SelectedItem != null)
				language = Language.SelectedItem.ToString();
			else
				language = "";

			for (int i = baseCodeFiles.Items.Count - 1; i >= 0; --i)
			{
				if (!isFileBaseCodeCompatible(baseCodeFiles.Items[i].ToString()))
					baseCodeFiles.Items.RemoveAt(i);

			}
		}

		private void addFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.RestoreDirectory = true;
			openFileDialog1.Multiselect = true;
			// openFileDialog1.Title = "My Image Browser";

			if (language == "C")
			{
				openFileDialog1.Filter = "C files (*.c, *.h)|*.c;*.h";
			}
			else if (language == "C++")
			{
				openFileDialog1.Filter = "C++ files (*.cc, *.cpp, *.h, *.hpp)|*.cc;*.cpp;*.h;*.hpp";
			}
			else if (language == "Python")
			{
				openFileDialog1.Filter = "Python files (*.py)|*.py";
			}
			else if (language == "C#")
			{
				openFileDialog1.Filter = "C# files (*.cs)|*.cs";
			}
			else if (language == "Java")
			{
				openFileDialog1.Filter = "Java files (*.java)|*.java";
			}
			else
			{
				MessageBox.Show("Please select a language type first.", topLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			openFileDialog1.ShowDialog();

			foreach (String file in openFileDialog1.FileNames)
			{
				if (!baseCodeFiles.Items.Contains(file))
					baseCodeFiles.Items.Add(file);
			}
		}

		private void removeSelectedFile_Click(object sender, EventArgs e)
		{
			removeSelectedFileFunction();
		}

		private void baseCodeFiles_DragDrop(object sender, DragEventArgs e)
		{
			string[] draggedFiles = (string[])e.Data.GetData(DataFormats.FileDrop);
			foreach (String file in draggedFiles)
			{
				if (!baseCodeFiles.Items.Contains(file))
				{
					if (isFileBaseCodeCompatible(file))
						baseCodeFiles.Items.Add(file);
					else if (language == "")
					{
						MessageBox.Show("Please select a language type first.", topLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
			}
		}

		private void baseCodeFiles_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private bool isFileBaseCodeCompatible(String file)
		{
			if (language == "C")
			{
				if (file.EndsWith(".c") || file.EndsWith(".h"))
					return true;
			}
			else if (language == "C++")
			{
				if (file.EndsWith(".cc") || file.EndsWith(".cpp") || file.EndsWith(".h") || file.EndsWith(".hpp"))
					return true;
			}
			else if (language == "Python")
			{
				if (file.EndsWith(".py"))
					return true;
			}
			else if (language == "C#")
			{
				if (file.EndsWith(".cs"))
					return true;
			}
			else if (language == "Java")
			{
				if (file.EndsWith(".java"))
					return true;
			}
			//else    
			return false;
		}

		private void removeSelectedFileFunction()
		{
			if (baseCodeFiles.SelectedIndex != -1)
			{
				for (int i = baseCodeFiles.SelectedItems.Count - 1; i >= 0; --i)
					baseCodeFiles.Items.Remove(baseCodeFiles.SelectedItems[i]);
			}
		}

		private void baseCodeFiles_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
				removeSelectedFileFunction();
		}

		private void addFolder_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog1;
			folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			folderBrowserDialog1.Description = "Select the directory of a student";
			folderBrowserDialog1.ShowDialog();

			String folder = folderBrowserDialog1.SelectedPath;

			if (!foldersOfCode.Items.Contains(folder))
			{
				if (System.IO.Directory.Exists(folder))
					foldersOfCode.Items.Add(folder);
			}
		}

		private void folderBox_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void folderBox_DragDrop(object sender, DragEventArgs e)
		{
			string[] draggedfolder = (string[])e.Data.GetData(DataFormats.FileDrop);
			foreach (String folder in draggedfolder)
			{
				if (!foldersOfCode.Items.Contains(folder))
				{
					if (System.IO.Directory.Exists(folder))
						foldersOfCode.Items.Add(folder);
				}
			}
		}

		private void removeSelectedFolder_Click(object sender, EventArgs e)
		{
			if (foldersOfCode.SelectedIndex != -1)
			{
				for (int i = foldersOfCode.SelectedItems.Count - 1; i >= 0; --i)
					foldersOfCode.Items.Remove(foldersOfCode.SelectedItems[i]);
			}
		}

		private void foldersOfCode_KeyUp(object sender, KeyEventArgs e)
		{
			if (foldersOfCode.SelectedIndex != -1 && e.KeyCode == Keys.Delete)
			{
				for (int i = foldersOfCode.SelectedItems.Count - 1; i >= 0; --i)
					foldersOfCode.Items.Remove(foldersOfCode.SelectedItems[i]);
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("COMP 322 - Dr. Boatright\nFall 2015\n\nGUI for MOSS created by:\n   Aaron Rosenberger\n   Garth Murray\n   Jonathan Worobey", "About " + topLabel, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foldersOfCode.Items.Clear();
			baseCodeFiles.Items.Clear();
			Language.SelectedIndex = -1;
			language = "";
			sensitivity.Value = 1;
			anonymize.Checked = false;
		}

		private void changeUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string s;
			s = promptID();
			if (s == "Cancel")
				return;

			while (!s.All(Char.IsDigit) || s.Length != 6)
			{
				MessageBox.Show("Please enter a six digit ID number.", topLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
				s = promptID();
				if (s == "Cancel")
					return;
			}
			int newID = Int32.Parse(s);
			registrySetUserID(newID);

			currentUser = registryGetLastUserID();

			if (currentUser == null)
				topLabel = "MOSS - Not logged in";
			else
				topLabel = "MOSS - " + currentUser;
			Text = topLabel;
		}

		private string registryGetLastUserID()
		{
			RegistryKey rk = Registry.CurrentUser;
			RegistryKey sk1 = rk.OpenSubKey("SOFTWARE\\" + Application.ProductName);
			if (sk1 == null)
				return null;
			else
			{
				try
				{
					return sk1.GetValue("USER_ID").ToString();
				}
				catch (Exception e)
				{
					MessageBox.Show(e.ToString() + " reading registry USER_ID", topLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
					return null;
				}
			}
		}

		private void registrySetUserID(int i)
		{
			try
			{
				RegistryKey rk = Registry.CurrentUser;
				RegistryKey sk1 = rk.CreateSubKey("SOFTWARE\\" + Application.ProductName);
				sk1.SetValue("USER_ID", i);
			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString() + " writing registry USER_ID", topLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private string promptID()
		{
			Form inputForm = new Form();
			inputForm.ClientSize = new Size(200, 95);
			inputForm.Text = "Change User";
			inputForm.FormBorderStyle = FormBorderStyle.FixedDialog;
			inputForm.StartPosition = FormStartPosition.CenterParent;
			inputForm.MaximizeBox = false;
			inputForm.MinimizeBox = false;

			Label label1 = new Label();
			label1.Text = "Please enter your ID:";

			TextBox textInputBox = new TextBox();
			textInputBox.Text = "Your ID here";

			Button ok = new Button();
			ok.Text = "OK";
			ok.DialogResult = DialogResult.OK;

			Button cancel = new Button();
			cancel.Text = "Cancel";
			cancel.DialogResult = DialogResult.Cancel;

			label1.SetBounds(5, 10, 195, 15);//(x,y,width,height)
			textInputBox.SetBounds(10, 30, 180, 20);
			ok.SetBounds(25, 60, 75, 25);
			cancel.SetBounds(105, 60, 75, 25);

			inputForm.Controls.AddRange(new Control[] { label1, textInputBox, ok, cancel });
			inputForm.AcceptButton = ok;
			inputForm.CancelButton = cancel;

			DialogResult dialogResult = inputForm.ShowDialog();

			if (dialogResult == DialogResult.OK)
				return textInputBox.Text;
			else
				return "Cancel";//It's a feature.
		}

		private void upload_Click(object sender, EventArgs e)
		{
			//validation
			string problems = "";
			if (!currentUser.All(char.IsDigit))
				problems += "   Please enter your User ID first.\n";
			if (language == "")
				problems += "   Please enter a language first.\n";
			if (baseCodeFiles.Items.Count == 0)
				problems += "   Please add at least one base code file.\n";
			if (foldersOfCode.Items.Count == 0)
				problems += "   Please add at least one folder to check against.\n";
			if (problems != "")
			{
				MessageBox.Show("Could not complete your request please fix the following problems:\n" + problems, topLabel, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			///else everything is validated. The only thing that might happen is the user deletes files or folders between opening them in the gui and component 2 reading them in.
			///useful data:
			///string language = "C" or "C++" or etc
			///baseCodeFiles.Items = List of strings of the base code file addresses
			///foldersOfCode.Items = same
			///baseCodeFile.Items.Count = number of files in the list
			///string currentUser = "123456", this is a number of length 6. validated in GUI.
			///anonymize.Checked - get or set checked.
			///sensitivity.Value - get or set value;
			///

			string[] anonymizedNames = new string[1000];
			int anonymousNumber = 1;

			if (!upload.Text.Equals("Upload"))
			{
				// User clicked on the button after clicking Upload
				// Reset
				upload.Text = "Upload";
			}


			///component 2

			// Create folder in TEMP
			DirectoryInfo temp = new DirectoryInfo("C:\\Windows\\TEMP");
			DirectoryInfo moss = temp.CreateSubdirectory("Moss");



			upload.Text = "Looking for files...";
			foreach (string folder in foldersOfCode.Items)
			{
				string folderName;
				if (anonymize.Checked == false)
					folderName = folder.Split('\\')[folder.Split('\\').Length - 1];
				else
				{
					anonymizedNames[anonymousNumber] = folder.Split('\\')[folder.Split('\\').Length - 1];
					folderName = anonymousNumber.ToString();
				}

				DirectoryInfo tempFolder = moss.CreateSubdirectory(folderName);
				DirectoryInfo currentFolder = new DirectoryInfo(folder);
				//FileInfo[] currentFiles = currentFolder.GetFiles();
				fileList = dirSearch(currentFolder.FullName, fileList);
				foreach (string filename in fileList)
				{
					FileInfo file = new FileInfo(filename);
					System.Collections.ArrayList possibleExtensions = getFileExtensionPossibilities((string)Language.SelectedItem);
					// For each file in the directories specified
					foreach (string ext in possibleExtensions)
					{
						if (file.Extension.Equals(ext))
						{
							// If the extension matches the one we want
							string newPath = tempFolder.FullName + "\\" + file.Name;
							file.CopyTo(newPath, true);
						}
					}
				}
				anonymousNumber++;
			}

			upload.Text = "Concatenating files...";

			// Header string
			string data = "";
			data += "moss " + currentUser + "\n" +
				"directory 1\n" +
				"X 0\n" +
				"maxmatches " + sensitivity.Value + "\n" +
				"show 250\n" +
				"language " + language + "\n";

			string baseCodeString = "";
			long baseCodeLength = 0;
			foreach (string file in baseCodeFiles.Items)
			{
				baseCodeString += File.ReadAllText(file) + "\n";
				FileInfo baseCode = new FileInfo(file);
				baseCodeLength += baseCode.Length;
			}

			// Header line for base code (file 0)
			data += "file 0 " + language + " " + baseCodeLength + "\n";
			data += baseCodeString;

			DirectoryInfo[] subdirectories = moss.GetDirectories();
			int number = 1;
			foreach (DirectoryInfo folder in subdirectories)
			{
				FileInfo[] files = folder.GetFiles();
				foreach (FileInfo file in files)
				{
					// Add header for file: number, language, charcount, relative path
					data += "file " + number.ToString() + " " + language + " " + file.Length + " " + folder.Name + "/" + file.Name + "\n";

					// Add file contents
					StreamReader fstream = new StreamReader(file.FullName);
					string text = fstream.ReadToEnd();
					fstream.Close();
					data += text + "\n";

					number++;
				}
			}
			data += "query 0\n";
			FileInfo concatenatedFile = new FileInfo(moss.FullName + "\\" + "moss");
			StreamWriter writeStream = concatenatedFile.AppendText();
			writeStream.Write(data);
			writeStream.Close();

			// delete files
			System.Collections.ArrayList filesToDelete = new System.Collections.ArrayList();
			filesToDelete = dirSearch(moss.FullName, filesToDelete);
			foreach (string s in filesToDelete)
			{
				if (File.Exists(s) && !s.Equals("C:\\Windows\\TEMP\\Moss\\moss"))
				{
					System.Diagnostics.Debug.WriteLine("Deleting file " + s + "\n");
					File.Delete(s);
				}
			}
			foreach (string a in filesToDelete)
			{
				if (Directory.Exists(a))
				{
					System.Diagnostics.Debug.WriteLine("Deleting directory " + a + "\n");
					Directory.Delete(a);
				}
			}

			upload.Text = "Preparing connection...";
			///component 3
			TcpClient socket = new TcpClient();
			socket.Connect("172.11.137.159", 16127);
			if (!socket.Connected)
			{
				System.Diagnostics.Debug.WriteLine("Socket failed to connect!\n");
				return;
			}

			NetworkStream serverStream = socket.GetStream();
			StreamReader fileStream = new StreamReader(concatenatedFile.FullName);
			string fileText = fileStream.ReadToEnd();
			fileStream.Close();

			upload.Text = "Waiting for response...\nCancel";
			byte[] inStream = new byte[socket.ReceiveBufferSize];
			serverStream.Read(inStream, 0, socket.ReceiveBufferSize);
			string returnData = System.Text.Encoding.ASCII.GetString(inStream);
			System.Diagnostics.Debug.WriteLine(returnData);

            upload.Text = "Upload";
            string textOut = "";
            returnData = returnData.Trim('\0');
            textOut += returnData;
            textOut += "\n";
            if (anonymize.Checked)
            {
                for(int i = 1; i < anonymousNumber; ++i)
                {
                    String integer = Convert.ToString(i);
                    String name = anonymizedNames[i];
                    textOut += name;
                    textOut += " - ";
                    textOut += integer;
                    textOut += "\n";
                }
            }
            MessageBox.Show(textOut, topLabel, MessageBoxButtons.OK, MessageBoxIcon.Information);



			byte[] end = System.Text.Encoding.ASCII.GetBytes("end\n");
			serverStream.Write(end, 0, end.Length);
			serverStream.Flush();
			serverStream.Close();
			socket.Close();

			if (File.Exists("C:\\Windows\\TEMP\\Moss\\moss"))
			{
				File.Delete("C:\\Windows\\TEMP\\Moss\\moss");
				Directory.Delete("C:\\Windows\\TEMP\\Moss");
			}

		}

		public System.Collections.ArrayList dirSearch(string dir, System.Collections.ArrayList myList)
		{
			foreach (string s in Directory.GetFiles(dir, "*"))
			{
				myList.Add(s);
			}
			foreach (string d in Directory.GetDirectories(dir))
			{
				myList.Add(d);
				dirSearch(d, myList);
			}
			return myList;
		}

		public System.Collections.ArrayList getFileExtensionPossibilities(string language)
		{
			System.Collections.ArrayList possibilities = new System.Collections.ArrayList();
			if (language == "C")
			{
				possibilities.Add(".c");
				possibilities.Add(".h");
			}
			else if (language == "C++")
			{
				possibilities.Add(".cpp");
				possibilities.Add(".cc");
				possibilities.Add(".h");
				possibilities.Add(".hpp");
			}
			else if (language == "Python")
			{
				possibilities.Add(".py");
			}
			else if (language == "C#")
			{
				possibilities.Add(".cs");
			}
			else if (language == "Java")
			{
				possibilities.Add(".java");
			}
			return possibilities;
		}
	}
}
