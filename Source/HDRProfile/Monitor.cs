﻿using CodectoryCore.UI.Wpf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDRProfile
{
    public class Monitor : BaseViewModel
    {
        private bool _autoHDR = true;

        public bool AutoHDR { get => _autoHDR; set { _autoHDR = value; OnPropertyChanged(); } }


        private string _name;
        public string Name { get => _name;  set { _name = value; OnPropertyChanged(); } }


        private UInt32 _uid;
        public UInt32 UID { get => _uid;  set { _uid = value; OnPropertyChanged(); } }

        private bool _hdrState;

        public bool HDRState { get => _hdrState; set { _hdrState = value; OnPropertyChanged(); } }


        private Size _resolution;
        public Size Resolution { get => _resolution; set { _resolution = value; OnPropertyChanged(); } }


        private int _refreshRate;

        public int RefreshRate { get => _refreshRate; set { _refreshRate = value; OnPropertyChanged(); } }

        private Monitor()
        {


        }

        public Monitor(string name, uint uID, Size resolution,  int refreshRate)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            UID = uID;
            Resolution = resolution;
            RefreshRate = refreshRate;
        }

        public void UpdateHDRState()
        {
            HDRState= HDRController.GetHDRState(UID);
        }


    }
}
