using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VediospliterTest
{
    public partial class Form1 : Form
    {
        List<String> list = new List<String>();
        public Form1()
        {
            InitializeComponent();

            progressBar.Visible = false;
        }

        private void btn_SaveFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                lb_savePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btn_OpenCSV_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog fd = new OpenFileDialog())//파일 선택 창 열기
            {
                fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // 초기화면
                fd.Filter = "CSV Files (*.csv)|*.csv";    // 필터
                fd.FilterIndex = 1;

                if (fd.ShowDialog() == DialogResult.OK)//확인 버튼 누르면
                {
                    filePath = fd.FileName;
                    StreamReader sr = new StreamReader(filePath);//선택된 파일 읽기

                    while (!sr.EndOfStream)//줄이 끝날 때까지
                    {
                        // 한 줄씩 읽어온다.
                        string line = sr.ReadLine(); //한 줄 읽음) 1,11/01/2021,06:31:02 PM,1,1

                        // 쉼표( , )를 기준으로 데이터를 분리한다.
                        string[] data = line.Split(',');//한 줄을 배열로 분리해서 data 배열에 저장
                                                        //1
                                                        //11/01/2021
                                                        //06:31:02 PM
                                                        //1
                                                        //1
                       

                        for (int i = 0; i < data.Length; i++)
                        {
                            if (i == 2)
                            {
                                list.Add((data[i]).ToString());
                            }
                        }
                    }
                }


            }
        }

        private void btn_Splite_Click(object sender, EventArgs e)
        {
            var filePathVedio = string.Empty;

            progressBar.Minimum = 0;
            progressBar.Maximum = list.Count;
            progressBar.Step = 1;
            progressBar.Value = 0;

            using (OpenFileDialog fdVedio = new OpenFileDialog())
            {
                fdVedio.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); // 초기화면
                fdVedio.Filter = "Video Files | *.mp4; *.wmv; *.avi";    // 필터
                fdVedio.FilterIndex = 1;

                if (fdVedio.ShowDialog() == DialogResult.OK)
                {
                    filePathVedio = fdVedio.FileName;
                    progressBar.Visible = true;
                    progressBar.PerformStep();

                    //여기 for
                    DateTime excel = Convert.ToDateTime(list[1]);//엑셀에서공 던지는 시간
                    DateTime video = Convert.ToDateTime(textBox1.Text + "PM");//비디오에서 공 던지는 시간   

                    TimeSpan dateDiff = excel - video;

                    int realvideohour = dateDiff.Hours;//6
                    int realvideomin = dateDiff.Minutes;//25
                    int realvideosec = dateDiff.Seconds;//34
                    
                    //int total = (realvideohour*60*60) + (realvideomin*60) + realvideosec;

                    //MessageBox.Show(total.ToString());

                    DateTime finalvideo = Convert.ToDateTime(realvideohour + ":" + realvideomin + ":" + realvideosec + "PM");

                    for (int i = 1; i < list.Count; i++)
                    {
                        DateTime excel2 = Convert.ToDateTime(list[i]);

                        TimeSpan realvideo = excel2 - finalvideo;

                        int totalhour = realvideo.Hours * 60 * 60;
                        int totalmin = realvideo.Minutes * 60;
                        int totalsec = realvideo.Seconds;

                        int total = totalhour + totalmin + totalsec;

                        int start = Convert.ToInt16(total);
                        int end = Convert.ToInt16(txt_spliteTime.Text);

                        string outputFilename = $@"{lb_savePath.Text}\{start}.mp4";
                        string command = $"-i \"{filePathVedio}\" -ss {start} -t {end} \"{outputFilename}\"";

                        Process process = new Process();

                        process.StartInfo.FileName = @"cmd.exe";
                        process.StartInfo.Arguments = $@"/k ffmpeg.dll {command} & exit";

                        process.StartInfo.CreateNoWindow = false;
                        process.StartInfo.UseShellExecute = false;

                        process.Start();
                        process.WaitForExit();

                        progressBar.PerformStep();
                        lb_progressText.Text = $"{i}/{list.Count-1}";    
                    }
                    lb_progressText.Text = "Done";
                    Process.Start("explorer.exe", "/select, \"" + $@"{lb_savePath.Text}");
                }
            }
        }
    }
}
