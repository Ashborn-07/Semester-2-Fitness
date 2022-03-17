using System.IO;

namespace SLFitness
{
    internal class Bitmap
    {
        private MemoryStream ms;

        public Bitmap(MemoryStream ms)
        {
            this.ms = ms;
        }
    }
}