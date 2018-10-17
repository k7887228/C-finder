using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace finder_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int id_name = 1;
        string dirpath = "";
        private void choise_dir_Click(object sender, EventArgs e)
        {
            listboxpanel.Controls.Clear(); //to remove all controls
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            dirpath = path.SelectedPath;
            auto_listbox("folder_box"+ id_name, dirpath);
        }
        public void auto_listbox(string list_box_name,string paths)
        {
            ListBox listBox = new ListBox();
            foreach (string fname in System.IO.Directory.GetFileSystemEntries(paths))
            {
                listBox.Items.Add(fname.Replace(paths, ""));
            }
            listBox.Name = list_box_name;
            listBox.Dock = DockStyle.Right;
            listBox.Width = 150;
            listBox.ScrollAlwaysVisible = true;
            listBox.HorizontalScrollbar = true;
            //add SelectedIndexChanged even
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            listboxpanel.Controls.Add(listBox);
        }
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox filename = (ListBox)sender;
            //listboxNames.SelectedItem.ToString()
            if (Directory.Exists(dirpath + filename.SelectedItem.ToString()))
            {
                dirpath = dirpath + filename.SelectedItem.ToString();
                id_name += 1;
                auto_listbox("folder_box"+ id_name, dirpath );
            }
            else
            {
                //利用for迴圈改路徑
                //並刪除listbox
                string name = filename.Name;
                int gap = id_name -int.Parse(name.Replace("folder_box", ""));
                if (gap != 0)
                {
                    string[] splite = dirpath.Split('\\');
                    for(int k=id_name;k> int.Parse(name.Replace("folder_box", "")); k--)
                    {
                        foreach (Control item in listboxpanel.Controls.OfType<ListBox>())
                        {
                            if (item.Name == "folder_box" + k)
                            {
                                listboxpanel.Controls.Remove(item);
                                break;
                            }
                        }
                    }
                    //更新路徑
                    string new_p = "";
                    for(int i = 0; i < splite.Length-gap; i++)
                    {
                        new_p += splite[i]+"\\";
                    }
                    id_name = int.Parse(name.Replace("folder_box", ""));
                    dirpath = new_p;
                    listBox_SelectedIndexChanged(sender, e);
                }
            }
        }

    }
}
