using System.IO;

namespace KnightsTour
{
    class Heuristic : FileOutput
    {
        public override void CreateFile()
        {
            Path = "../../results/arslanHeuristicsMethod.txt";
            
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
