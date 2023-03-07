using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using WMPLib;
namespace SpinGamePlay
{
    public class Music
    {
        //click.wav
        private WindowsMediaPlayer nhacNen = new WindowsMediaPlayer();
        private SoundPlayer nhacHieuUng1 = new SoundPlayer("click.wav");
        private WindowsMediaPlayer nhacHieuUng2 = new WindowsMediaPlayer();
        private SoundPlayer nhacHieuUng3 = new SoundPlayer("projector-button-push-6258.wav");
           
        public WindowsMediaPlayer NhacNen { get => nhacNen; set => nhacNen = value; }
        public SoundPlayer NhacHieuUng1 { get => nhacHieuUng1; set => nhacHieuUng1 = value; }
        public WindowsMediaPlayer NhacHieuUng2 { get => nhacHieuUng2; set => nhacHieuUng2 = value; }
        public SoundPlayer NhacHieuUng3 { get => nhacHieuUng3; set => nhacHieuUng3 = value; }
    }
}
