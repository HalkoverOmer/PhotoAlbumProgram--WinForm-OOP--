using System.Text.Json;
using System.Windows.Forms;

namespace PhotoAlbumProgram
{
    public partial class Form1 : Form
    {
        List<Album> Albums = new List<Album>();
        string[] multiPaths = new string[0];
        List<string> multiPathList = new List<string>();
        string pathAlbum = Application.StartupPath + "Albums.json";

        private void CreatePicturebox(string[] paths)
        {
            foreach (string item in paths)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(283, 278);
                pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                flpAlbumPhotos.Controls.Add(pictureBox);
                pictureBox.ImageLocation = item;
                multiPathList.Add(item);
            }
        }
        private void CreatePicturebox(List<string> paths)
        {
            foreach (string item in paths)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(283, 278);
                pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                //pictureBox.Controls.Add(ContextMenuStrip= contextMenuStrip2);
                flpAlbumPhotos.Controls.Add(pictureBox);
                pictureBox.ImageLocation = item;
            }
        }

        // json ile albümleri kaydet ve oku.

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (File.Exists(Application.StartupPath + "\\" + "Albums"))
            //{
            //    return;
            //}

            //else
            //{
            //    Directory.CreateDirectory($"{Application.StartupPath}\\Albums");
            //}

            if (File.Exists(pathAlbum))
            {
                string json = File.ReadAllText(pathAlbum);
                Albums = JsonSerializer.Deserialize<List<Album>>(json);
                lstAlbums.DataSource = null;
                lstAlbums.DataSource = Albums;
            }
            lstAlbums.SelectedIndex = -1;
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Albüme Eklenecek Resimleri Seç";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = true;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Filter = "Resim Dosyalarý| *.jpeg; *.jpg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                multiPaths = openFileDialog.FileNames;
                CreatePicturebox(multiPaths);
            }
        }

        private void btnSaveAlbum_Click(object sender, EventArgs e)
        {
            Album album = new Album();
            album.Name = txtAlbumName.Text;
            album.Description = txtAlbumDescription.Text;
            foreach (string item in multiPathList)
            {
                album.ImagePath.Add(item);
            }

            Albums.Add(album);

            lstAlbums.DataSource = null;
            lstAlbums.DataSource = Albums;

            string json = JsonSerializer.Serialize(Albums, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(pathAlbum, json);

            txtAlbumName.Clear();
            txtAlbumDescription.Clear();
            flpAlbumPhotos.Controls.Clear();
            Array.Clear(multiPaths);
            multiPathList.Clear();
        }

        private void btnDeleteAlbums_Click(object sender, EventArgs e)
        {
            Albums.RemoveAt(lstAlbums.SelectedIndex);
            lstAlbums.DataSource = null;
            lstAlbums.DataSource = Albums;

            string json = JsonSerializer.Serialize(Albums, new JsonSerializerOptions() { WriteIndented = true });
            File.WriteAllText(pathAlbum, json);
        }

        private void lstAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAlbums.SelectedIndex != -1)
            {
                flpAlbumPhotos.Controls.Clear();
                //Albums[lstAlbums.SelectedIndex].ImagePath;
                CreatePicturebox(Albums[lstAlbums.SelectedIndex].ImagePath);
            }

            else
            {
                flpAlbumPhotos.Controls.Clear();
            }
        }

        private void btnAddNewAlbum_Click(object sender, EventArgs e)
        {
            lstAlbums.SelectedIndex = -1;
        }
    }
}