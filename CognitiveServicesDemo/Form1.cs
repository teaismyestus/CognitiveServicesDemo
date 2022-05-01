using Microsoft.Azure.CognitiveServices.Vision.Face;
using Microsoft.Azure.CognitiveServices.Vision.Face.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CognitiveServicesDemo
{
    public partial class Form1 : Form
    {
        

        public Image Image;
        private string ApiEndPoint = "";
        private string ApiKey = "";
        private DetectedImage SourceImg;
        private DetectedImage DestinationImg;
        const string RECOGNITION_MODEL4 = RecognitionModel.Recognition04;



        public Form1()
        {
            InitializeComponent();
            

        }

        public DetectedImage CreateDetectedImg (Image img, PictureBox pb)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();

            
              img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
              ms.Position = 0;
              var byteData = ms.ToArray();

            return new DetectedImage { ByteData = byteData, StreamData = ms, ImageID = new Guid() };
            


        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult dr = dialog.ShowDialog();
            if(dr  == DialogResult.OK)
            {
                sourcePictureBox.BackgroundImage = Image.FromFile(dialog.FileName);
                sourcePictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                SourceImg = CreateDetectedImg(sourcePictureBox.BackgroundImage, sourcePictureBox);
                var client = Authenticate(ApiEndPoint, ApiKey);
                Task<IList<DetectedFace>> face = client.Face.DetectWithStreamAsync(SourceImg.StreamData, true, false, null, RECOGNITION_MODEL4,true);

                try
                {
                    var id = face.Result[0].FaceId;
                    SourceImg.ImageID = (Guid)id;
                    uploadDestination.Visible = true;



                }
                catch
                {
                    sourcePictureBox.BackgroundImage = null;
                    MessageBox.Show(" Yüz algılanamadı, lütfen daha net bir görsel yükleyerek tekrar deneyiniz.");

                }

            }

            
        }

        public static IFaceClient Authenticate(string endpoint, string key)
        {
            return new FaceClient(new ApiKeyServiceClientCredentials(key)) { Endpoint = endpoint };
        }


        private void uploadDestination_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult dr = dialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                destinationPictureBox.BackgroundImage = Image.FromFile(dialog.FileName);
                destinationPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                DestinationImg = CreateDetectedImg(sourcePictureBox.BackgroundImage, sourcePictureBox);
                var client = Authenticate(ApiEndPoint, ApiKey);
                Task<IList<DetectedFace>> face = client.Face.DetectWithStreamAsync(DestinationImg.StreamData, true, false, null, RECOGNITION_MODEL4, true);

                try
                {
                    var id = face.Result[0].FaceId;
                    DestinationImg.ImageID = (Guid)id;
                }
                catch
                {
                    destinationPictureBox.BackgroundImage = null;
                    MessageBox.Show(" Yüz algılanamadı, lütfen daha net bir görsel yükleyerek tekrar deneyiniz.");
                }

            }
        }

       

       

        private async void compareButton_ClickAsync(object sender, EventArgs e)
        {
            if (SourceImg != null && SourceImg.ImageID != null && DestinationImg != null && DestinationImg.ImageID != null && destinationPictureBox.BackgroundImage != null && sourcePictureBox.BackgroundImage != null)
            {
                try
                {
                    var client = Authenticate(ApiEndPoint, ApiKey);
                    VerifyResult verifyResult = await client.Face.VerifyFaceToFaceAsync(SourceImg.ImageID, DestinationImg.ImageID);
                    var matchingResult = verifyResult;
                    MessageBox.Show(matchingResult.Confidence.ToString());

                }
                catch
                {
                    MessageBox.Show("Karşılaştırma işleminde bir hata meydana geldi.");
                }

            }
            else
            {
                MessageBox.Show("Lütfen karşılaştırmak istediğiniz görselleri yükleyiniz.");
            }

        }
    }
}
