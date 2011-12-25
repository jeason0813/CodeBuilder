﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeBuilder.WinForm.UI.OptionsPages
{
    using Util;
    using Configuration;

    public partial class TraceOptionsPage : BaseOptionsPage
    {
        public TraceOptionsPage()
        {
            InitializeComponent();
        }

        public TraceOptionsPage(string key)
            : base(key)
        {
            InitializeComponent();
        }

        public override void LoadSettings()
        {
            traceLevelComboBox.SelectedIndex = (int)(InternalTraceLevel)settings.GetSetting("Options.InternalTraceLevel", InternalTraceLevel.Default);
            logDirectoryLabel.Text = System.IO.Path.Combine(Environment.CurrentDirectory, "logs");
        }

        public override void ApplySettings()
        {
           settings.SaveSetting("Options.InternalTraceLevel", (InternalTraceLevel)traceLevelComboBox.SelectedIndex);
        }
    }
}