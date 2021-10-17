using static System.Console;

namespace CSClassLib
{
    public interface IPlayable
    {
        void Play();
        void Pause();
        void Stop()
        {
            WriteLine("Default implementation of Stop.");
        }

    }
}