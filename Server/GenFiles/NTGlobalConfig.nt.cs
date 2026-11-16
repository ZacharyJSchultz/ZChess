using NTypewriter.Editor.Config;

namespace ZChess.GenFiles
{
    class NTGlobalConfig : EditorConfig
    {
        public override bool AddGeneratedFilesToVSProject { get => false; }

        public override bool RenderWhenProjectBuildIsDone { get => true; }
    }
}
