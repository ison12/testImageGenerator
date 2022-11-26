using System.Drawing.Imaging;

namespace TestImageGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            var dirPath = string.Empty;
            if (string.IsNullOrEmpty(txtOutputDirPath.Text))
            {
                MessageBox.Show("出力ディレクトリパスは必須です", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                dirPath = txtOutputDirPath.Text;
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }
            }

            if (!int.TryParse(txtWidth.Text, out var width) ||
                width <= 0)
            {
                MessageBox.Show("解像度（幅）は1～9999の数値を入力してください", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtHeight.Text, out var height) ||
                height <= 0)
            {
                MessageBox.Show("解像度（高）は1～9999の数値を入力してください", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(txtFiles.Text))
            {
                MessageBox.Show("生成するファイル名は必須です", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var files = txtFiles.Text.Replace("\r\n", "\n").Split("\n");

            var preCursor = Cursor.Current;
            try
            {
                Enabled = false;
                Cursor.Current = Cursors.WaitCursor;

                GenerateImages(dirPath, files, width, height);
            }
            finally
            {
                Cursor.Current = preCursor;
                Enabled = true;
            }
        }

        private async void GenerateImages(string dirPath, string[] files, int width, int height)
        {
            var imageFormat = DecideImageFormat();

            try
            {
                await Task.Run(() =>
                {

                    foreach (var fileName in files)
                    {
                        if (string.IsNullOrEmpty(fileName))
                        {
                            continue;
                        }
                        var a = new TestImageGenerator();
                        a.Generate(dirPath, fileName, imageFormat, width, height);
                    }

                    return true;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("ファイルの生成に失敗しました。\n\n" + ex.ToString(), "TestImageGenerator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("ファイルの生成が完了しました", "TestImageGenerator");
        }

        /// <summary>
        /// 画像フォーマットの決定
        /// </summary>
        /// <returns>画像フォーマット</returns>
        private ImageFormat DecideImageFormat()
        {
            var imageFormat = ImageFormat.Jpeg;
            if (rdoFileTypeJpeg.Checked)
            {
                imageFormat = ImageFormat.Jpeg;
            }
            else if (rdoFileTypePng.Checked)
            {
                imageFormat = ImageFormat.Png;
            }
            else if (rdoFileTypeGif.Checked)
            {
                imageFormat = ImageFormat.Gif;
            }
            else if (rdoFileTypeBmp.Checked)
            {
                imageFormat = ImageFormat.Bmp;
            }
            else if (rdoFileTypeTiff.Checked)
            {
                imageFormat = ImageFormat.Tiff;
            }

            return imageFormat;
        }
    }
}