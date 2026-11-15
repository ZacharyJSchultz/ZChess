using System;
using System.Collections.Generic;
using NTypewriter.Editor.Config;

namespace ZChess.GenFiles
{
    class NTGlobalConfig : EditorConfig
    {
        public override bool AddGeneratedFilesToVSProject { get => false; }
    }
}
