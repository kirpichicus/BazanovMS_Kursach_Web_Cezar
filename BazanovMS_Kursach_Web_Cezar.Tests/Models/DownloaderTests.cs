using Microsoft.VisualStudio.TestTools.UnitTesting;
using BazanovMS_Kursach_Web_Cezar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazanovMS_Kursach_Web_Cezar.Models.Tests
{
    [TestClass()]
    public class DownloaderTests
    {
        [TestMethod()]
        public void MakeDocxFileTest() //можно было бы сделать приватным и рефлексия
        {
            try
            {
                Downloader.MakeDocxFile("text\ntext", "Txt.docx");
                Downloader.MakeDocxFile("text\ntext", "txt.txt");
            }
            catch (Exception)
            {
                Assert.Fail();
            }

        }

        [TestMethod()]
        public void MakeTxtFileTest()
        {
            try
            {
                Downloader.MakeTxtFile("text\ntext", "Txt.docx");
                Downloader.MakeTxtFile("text\ntext", "txt.txt");
            }
            catch (Exception)
            {
                Assert.Fail();
            }

        }

        
    }
}