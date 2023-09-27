using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPIntro_ClassesAndObjects
{
    class CollezioneVideo
    {
        private List<Video> elenco;

        public CollezioneVideo()
        {
            elenco = new List<Video>();
        }

        public void Aggiungi(Video unVideo)
        {
            elenco.Add(unVideo);
        }

        public List<Video> LeggiTutte()
        {
            return elenco;
        }

        public void LeggiDaFile()
        {
            FileStream flusso = new FileStream("TrendingVideos.csv", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(flusso);

            while (!reader.EndOfStream)
            {
                string linea = reader.ReadLine();
                string[] campi = linea.Split(',');

                Video unVideo = new Video
                {
                    Position = campi[0],
                    ChannelId = campi[1],
                    ChannelTitle = campi[2],
                    VideoId = campi[3],
                    PublishedAt = campi[4],
                    VideoTitle = campi[5],
                    VideoDescription = campi[6],
                    VideoCategoryId = campi[7],
                    VideoCategoryLabel = campi[8],
                    Duration = campi[9],
                    DurationSec = campi[10],
                    Definition = campi[11],
                    Caption = campi[12],
                    ViewCount = campi[13],
                    LikeCount = campi[14],
                    DislikeCount = campi[15],
                    CommentCount = campi[16]
                };

                Aggiungi(unVideo);
            }
        }

        public void ScriviSuFile()
        {
            using (FileStream flusso = new FileStream("dati.txt", FileMode.Open, FileAccess.Write))
            {
                StreamWriter scrittore = new StreamWriter(flusso);
                foreach (Video unVideo in elenco)
                {
                    string contenuto = unVideo.TuttiValori();
                    scrittore.WriteLine(contenuto);
                }
                scrittore.Flush();
            }
        }

    }
}
