namespace A1_game
{
    public partial class MemGame : Form
    {

        // List of all img in a game, img loaded into resx with name in list
        List<int> resxList = new List<int> {0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9 };
        

        List<PictureBox> imgList = new List<PictureBox>();
        string click1;
        string click2;
        int turns;
        
        PictureBox imgA;
        PictureBox imgB;
        bool gameOver = false;
        bool gameStart = false;

        public MemGame()
        {
            InitializeComponent();
            loadPictures();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            gameStart = true;
            lbl_status.Text = "To play: Click two squares \nFind all matching images";
            NewGame();
            
        }

        private void loadPictures()
        {
            // load empty PictureBox on screen and into imgList

            int MarginLeft = 80;
            int MarginTop = 250;
            int CellMargin = 15;
            int CellSize = 160;
            int MaxCol = 5;

            for (int i = 0; i < resxList.Count; i++)
            {
                PictureBox newPic = new PictureBox();
                newPic.Height = CellSize;
                newPic.Width = CellSize;
                newPic.BackColor = Color.DarkOrange;
                newPic.SizeMode = PictureBoxSizeMode.StretchImage;
                newPic.Click += NewPic_Click; // add click event
                imgList.Add(newPic);

                // calc PictureBox position
                // row = i/MaxCol (integer division), col = i%MaxCol
                newPic.Left = MarginLeft + (i % MaxCol) * (CellSize + CellMargin);
                newPic.Top = MarginTop + (i / MaxCol) * (CellSize + CellMargin);
                this.Controls.Add(newPic);
            }
            NewGame();
        }
        private void NewPic_Click(object sender, EventArgs e)
        {
            // Click event for created PictureBox
            // If click valid, compare after 2 clicks

            if (gameOver || !gameStart)
            {
                // dont register a click if the game is over
                //MessageBox.Show("Game Over or Not started");
                return;
            }
            else if (click1 == null)
            {
                lbl_status.Text = "";
                imgA = sender as PictureBox;
                
                if (imgA.Tag != null && imgA.Image == null)
                {
                    imgA.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject((string)imgA.Tag);
                    click1 = (string)imgA.Tag;
                }
            }
            else if (click2 == null)
            {
                imgB = sender as PictureBox;
                if (imgB.Tag != null && imgB.Image == null)
                {
                    imgB.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject((string)imgB.Tag);
                    click2 = (string)imgB.Tag;

                    this.Refresh();
                    System.Threading.Thread.Sleep(1000);
                    CheckPictures(imgA, imgB);
                }
            }
            else
            {
                // should not happen
                CheckPictures(imgA, imgB);
            }
        }
        private void NewGame()
        {
            // randomise the original list
            var rnd = new Random();
            var randomList = resxList.OrderBy(x => rnd.Next()).ToList();
            // save the random list to the original
            resxList = randomList;

            for (int i = 0; i < imgList.Count; i++)
            {
                // "hide" the image
                imgList[i].Image = null;
                // set Tag with the randomized list to load when click 
                imgList[i].Tag = resxList[i].ToString();
            }
            click1 = null;
            click2 = null;
            turns = 0;
            lbl_turns.Text = turns + " turns used";
            gameOver = false;

        }
        private void CheckPictures(PictureBox A, PictureBox B)
        {
            lbl_status.Text = "Not a match";
            if (click1 == click2)
            {
                // remove pic tag if matched
                A.Tag = null;
                B.Tag = null;
                lbl_status.Text = "This is a match!";
            }
            
            turns++;
            lbl_turns.Text = turns + " turns used";
            
            //reset click
            click1 = null;
            click2 = null;
            foreach (PictureBox pics in imgList.ToList())
            {
                // If pic tag not null (not matched), clear the pic
                if (pics.Tag != null)
                {
                    pics.Image = null;
                }
            }
            // now lets check if all of the items have been solved
            if (imgList.All(o => o.Tag == imgList[0].Tag))
            {
                GameOver("You Won in " + turns + " turns");
            }
        }
        private void GameOver(string msg)
        {
            //GameTimer.Stop();
            gameOver = true;
            lbl_status.Text = "Click 'New Game' to play again";
            MessageBox.Show(msg + "\n\nClick 'New Game' to Play Again.", "Game Over");
        }
    }
}
