using System.IO;

namespace KnightsTour
{
    class NonIntel : FileOutput
    {
        public override void CreateFile()
        {
            Path = "../../results/arslanNonIntelligentMethod.txt";

            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
            if (!File.Exists(Path))
            {
                File.Create(Path).Dispose();
            }
        }
    }

}
