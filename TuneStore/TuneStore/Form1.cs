using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TuneStore
{
    public partial class TuneStore : Form
    {
        csAddMusic[] obNewSong = new csAddMusic[1000];
        int nr = 0;

        public TuneStore()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool m_textAvailable = true;

            tbSongName.BackColor = Color.Red;
            tbArtist.BackColor = Color.Red;
            tbAlbum.BackColor = Color.Red;
            tbLocation.BackColor = Color.Red;

            if (tbSongName.Text.Trim() == "")
            {
                m_textAvailable = false;
            }
            else
            {
                tbSongName.BackColor = Color.White;
            }

            if (tbArtist.Text.Trim() == "" && m_textAvailable == true)
            {
                m_textAvailable = false;
            }
            else
            {
                tbArtist.BackColor = Color.White;
            }

            if (tbAlbum.Text.Trim() == "" && m_textAvailable == true)
            {
                m_textAvailable = false;
            }
            else
            {
                tbAlbum.BackColor = Color.White;
            }

            if (tbLocation.Text.Trim() == "" && m_textAvailable == true)
            {
                m_textAvailable = false;
            }
            else
            {
                tbLocation.BackColor = Color.White;
            }

            if (m_textAvailable == true)
            {
                addObject();
            }
            else
            {
                MessageBox.Show("NOT CORRECT");
            }
        }

        private void addObject()
        {
            obNewSong[nr] = new csAddMusic();

            obNewSong[nr].song = tbSongName.Text;
            obNewSong[nr].artist = tbArtist.Text;
            obNewSong[nr].album = tbAlbum.Text;
            obNewSong[nr].location = tbLocation.Text;

            nr++;

            tbSongName.Text = "";
            tbArtist.Text = "";
            tbAlbum.Text = "";
            tbLocation.Text = "";
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            rtbMusic.Clear();
            for (int m_nr = 0; m_nr < nr; m_nr++)
            {
                rtbMusic.AppendText(obNewSong[m_nr].song + " - " +
                                    obNewSong[m_nr].artist + " - " +
                                    obNewSong[m_nr].album + " \n");
            }
        }

        private void miSaveAs_Click(object sender, EventArgs e)
        {
            string m_FileNameAndLocation;

            sfdMusic.ShowDialog();
            m_FileNameAndLocation = sfdMusic.FileName;
            StreamWriter saveMusic = new StreamWriter(m_FileNameAndLocation);

            for (int m_nr = 0; m_nr < nr; m_nr++)
            {
                saveMusic.WriteLine(obNewSong[m_nr].song);
                saveMusic.WriteLine(obNewSong[m_nr].artist);
                saveMusic.WriteLine(obNewSong[m_nr].album);
                saveMusic.WriteLine(obNewSong[m_nr].location);
            }

            saveMusic.Close();
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            string m_FileNameAndLocation;

            ofdMusic.ShowDialog();
            m_FileNameAndLocation = ofdMusic.FileName;
            StreamReader openMusic = new StreamReader(m_FileNameAndLocation);

            while (openMusic.EndOfStream == false)
            {
                tbSongName.Text = openMusic.ReadLine();
                tbArtist.Text = openMusic.ReadLine();
                tbAlbum.Text = openMusic.ReadLine();
                tbLocation.Text = openMusic.ReadLine();

                addObject();
            }

            openMusic.Close();
        }

        private void miClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Tune Store is made by; \nRens Weerts and Daan van de Weijer");
        }
    }
}
