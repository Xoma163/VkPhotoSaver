using CsQuery;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace VkPhotoSaver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region consts  

        private static string HTML_FILE = ".html";
        private static string LOG_FILE = ".logs";

        private static bool PRINT_GOOD_LINKS;
        private static bool PRINT_BAD_LINKS;
        private static bool PRINT_ALL_LOGS;
        //Dirs and files
        private static string HTML_DIR;
        private static string IMAGES_DIR;
        //Setting what to find
        private static string[] includes;
        private static string[] excludes;
        #endregion

        private void Init()
        {
            PRINT_GOOD_LINKS = checkBoxPrintGoodLinks.Checked;
            PRINT_BAD_LINKS = checkBoxPrintBadLinks.Checked;
            PRINT_ALL_LOGS = checkBoxPrintLogs.Checked;
            HTML_DIR = textBoxHtmlDir.Text+ '\\';
            IMAGES_DIR = textBoxImagesDir.Text+ '\\';
            includes = textBoxIncludes.Text.Split(' ');
            excludes = textBoxExcludes.Text.Split(' ');

            buttonCopyToClipboard.Enabled = true;
            buttonSaveToFile.Enabled = true;
            Directory.CreateDirectory(HTML_DIR);
            Directory.CreateDirectory(IMAGES_DIR);
        }

        //Main
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            Init();
           
            rtbLinks.Clear();
            DirectoryInfo dir = new DirectoryInfo(HTML_DIR);
            foreach (var item in dir.GetFiles())
            {
                if (!item.Name.ToLower().Contains(HTML_FILE))
                    break;

                string htmlFileName = item.Name.Substring(0, item.Name.LastIndexOf('.'));
                string htmlFile = GetHtmlPageText(dir + item.Name);

                Directory.CreateDirectory(IMAGES_DIR + htmlFileName);

                List<string> links = new List<string>();
                List<string> dates = new List<string>();
                List<string> badLinks = new List<string>();
                List<string> distinctLinks;

                CQ cq = CQ.Create(htmlFile);

                string imageLink = "";
                string dateTime = "";

                foreach (IDomObject obj in cq.Find("div"))
                {
                    if (obj.ClassName == "msg_item")
                    {
                        for (int j = 0; j < obj.ChildNodes.Count; j++)
                        {
                            if (obj.ChildNodes[j].ClassName == "from")
                            {
                                for (int k = 0; k < obj.ChildNodes[j].ChildNodes.Count; k++)
                                {
                                    if (obj.ChildNodes[j].ChildNodes[k].HasAttribute("href"))
                                    {
                                        if (obj.ChildNodes[j].ChildNodes[k].GetAttribute("href").Contains('#'))
                                        {
                                            dateTime = obj.ChildNodes[j].ChildNodes[k].InnerHTML;
                                            dateTime = dateTime.Replace(' ', '_');
                                            dateTime = dateTime.Replace('.', '-');
                                            dateTime = dateTime.Replace(':', '-');
                                        }
                                    }
                                }
                            }
                            if (obj.ChildNodes[j].ClassName == "msg_body" || obj.ChildNodes[j].ClassName == "attacment")
                            {
                                for (int k = 0; k < obj.ChildNodes[j].ChildNodes.Count; k++)
                                {
                                    if (obj.ChildNodes[j].ChildNodes[k].HasAttribute("href"))
                                    {
                                        imageLink = obj.ChildNodes[j].ChildNodes[k].GetAttribute("href");
                                        if (CheckRow(imageLink))
                                        {
                                            links.Add(imageLink);
                                            dates.Add(dateTime);
                                        }

                                    }
                                    if (obj.ChildNodes[j].ChildNodes[k].HasChildren)
                                    {
                                        for (int l = 0; l < obj.ChildNodes[j].ChildNodes[k].ChildNodes.Count; l++)
                                        {
                                            if (obj.ChildNodes[j].ChildNodes[k].ChildNodes[l].HasAttribute("href"))
                                            {
                                                imageLink = obj.ChildNodes[j].ChildNodes[k].ChildNodes[l].GetAttribute("href");
                                                if (CheckRow(imageLink))
                                                {
                                                    links.Add(imageLink);
                                                    dates.Add(dateTime);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                distinctLinks = links.Distinct().ToList();
                WebClient webClient = new WebClient();

                //max
                int discharge = distinctLinks.Count.ToString().Length;
                for (int i = 0; i < distinctLinks.Count; i++)
                {
                                                                                       //HTMLFilename_MessageDateWith0000_FileFormat
                    SavePhoto(webClient, distinctLinks[i], htmlFileName, String.Format("{0}_{1}_{2}_{3}", htmlFileName, dates[i], ToN(i, discharge), distinctLinks[i].Substring(distinctLinks[i].LastIndexOf('.'))), badLinks);
                }
                if (PRINT_ALL_LOGS)
                {
                    Logging(htmlFileName, links, distinctLinks, distinctLinks, badLinks);
                }
            }
            WriteText("End");
        }
        
        //Method save photos into dir
        private void SavePhoto(WebClient webClient, string URL, string foldername, string filename, List<string> badLinks)
        {
            try
            {
                Uri URI = new Uri(URL, UriKind.Absolute);
                webClient.DownloadFile(URI, IMAGES_DIR + foldername + "\\" + filename);
            }
            catch
            {
                badLinks.Add(URL);
            }
        }

        //Method return HTMLPageText in str
        private string GetHtmlPageText(string url)
        {
            WebClient client = new WebClient();
            using (Stream data = client.OpenRead(url))
            using (StreamReader reader = new StreamReader(data))
            {
                return reader.ReadToEnd();
            }
        }

        //Method check row on includes and excludes
        private bool CheckRow(string text)
        {

            for (int i = 0; i < excludes.Length; i++)
            {
                if (text.ToLower().Contains(excludes[i].ToLower()))
                {
                    return false;
                }
            }
            for (int i = 0; i < includes.Length; i++)
            {
                if (text.ToLower().Contains(includes[i].ToLower()))
                {
                    return true;
                }
            }
            return false;
        }

        //Print all info in richTextBox
        private void Logging(string filename, List<string> links, List<string> distinctLinks, List<string> goodLinks, List<string> badLinks)
        {
            WriteText(String.Format("Statistics on file {0}", filename));
            WriteText(String.Format("Photos found: {0}", links.Count));
            WriteText(String.Format("Distinct links: {0}", distinctLinks.Count));
            WriteText(String.Format("Cant download: {0}", badLinks.Count));
        
            if (PRINT_GOOD_LINKS && distinctLinks.Count > 0)
            {
                WriteText("Good links:");
                foreach (string elem in goodLinks)
                    WriteText(elem);
            }
            if (PRINT_BAD_LINKS && badLinks.Count > 0)
            {
                WriteText("Bad links:");
                foreach (string elem in badLinks)
                    WriteText(elem);
            }
            WriteText("------------------------------------------------------------");
        }

        //Method for easy print
        private void WriteText(string text)
        {
            rtbLinks.AppendText(text + Environment.NewLine);
        }

        //Save text to clipboard
        private void ButtonCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtbLinks.Text);
        }

        //Save text to file
        private void ButtonSaveToFile_Click(object sender, EventArgs e)
        {
            string dir = IMAGES_DIR + DateTime.Now.ToString("dd-MM-yyyy_hh-mm-ss") + LOG_FILE;
            using (File.Create(dir)) 
                rtbLinks.SaveFile(dir, RichTextBoxStreamType.PlainText);
        }

        //Method make makes "0001" from "1"
        private string ToN(int i, int N)
        {
            string s = Convert.ToString(i);
            while (s.Length != N)
            {
                s = "0" + s;
            }
            return s;
        }

        //Selectors
        private void ButtonSelectHTMLDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select HTML folder";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxHtmlDir.Text = fbd.SelectedPath;
            }
        }

        private void ButtonSelectImagesDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Select images folder";

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxImagesDir.Text = fbd.SelectedPath;
            }
        }

        //Save settings
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("main.conf"))
            {
                sw.WriteLine(checkBoxPrintGoodLinks.Checked);
                sw.WriteLine(checkBoxPrintBadLinks.Checked);
                sw.WriteLine(checkBoxPrintLogs.Checked);
                sw.WriteLine(textBoxHtmlDir.Text);
                sw.WriteLine(textBoxImagesDir.Text);
                sw.WriteLine(textBoxIncludes.Text);
                sw.WriteLine(textBoxExcludes.Text);
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("main.conf"))
                {
                    checkBoxPrintGoodLinks.Checked = Convert.ToBoolean(sr.ReadLine());
                    checkBoxPrintBadLinks.Checked = Convert.ToBoolean(sr.ReadLine());
                    checkBoxPrintLogs.Checked = Convert.ToBoolean(sr.ReadLine());
                    textBoxHtmlDir.Text = sr.ReadLine();
                    textBoxImagesDir.Text = sr.ReadLine();
                    textBoxIncludes.Text = sr.ReadLine();
                    textBoxExcludes.Text = sr.ReadLine();
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                // Nothing
            }
            catch
            {

            }
        }
    }
}